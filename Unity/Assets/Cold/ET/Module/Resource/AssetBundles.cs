using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace ETCold
{
	public class AssetBundles : IDisposable
	{
		public static AssetBundles Default
		{
			get
			{
				if (defaultAssetsBundles == null)
				{
					defaultAssetsBundles = new AssetBundles();
				}

				return defaultAssetsBundles;
			}
		}

		private Dictionary<string, Dictionary<string, Object>> assets = new Dictionary<string, Dictionary<string, Object>>();
		private Dictionary<string, AssetBundle> assetBundles = new Dictionary<string, AssetBundle>();
		private static AssetBundles defaultAssetsBundles = null;

		public async Task<Object> LoadAssetAsync(string assetBundleName, string assetName)
		{
			if (Define.IsEditorMode)
			{
				return LoadEditorAsset(assetBundleName, assetName);
			}

			string p = Path.Combine(PathHelper.AppHotfixResPath, assetBundleName);

			if (!File.Exists(p))
			{
				p = Path.Combine(PathHelper.AppResPath, assetBundleName);
			}

			AssetBundle assetBundle = null;

			if (assetBundles.ContainsKey(assetBundleName))
			{
				if (!assets.ContainsKey(assetBundleName) || !assets[assetBundleName].ContainsKey(assetName))
				{
					assetBundle = assetBundles[assetBundleName];
				}
			}
			else
			{
				using (AssetBundleLoaderAsync assetsBundleLoaderAsync = new AssetBundleLoaderAsync())
				{
					assetBundle = await assetsBundleLoaderAsync.LoadAsync(p);
				}
			}

			if (assetBundle == null)
			{
				Debug.LogError($"assetBundle not found: {assetBundleName}");
				return null;
			}

			assetBundles[assetBundleName] = assetBundle;

			if (!assetBundle.isStreamedSceneAssetBundle)
			{
				using (AssetLoaderAsync assetsLoaderAsync = new AssetLoaderAsync(assetBundle))
				{
					var result = await assetsLoaderAsync.LoadAllAssetsAsync();

					if (!assets.ContainsKey(assetBundleName))
					{
						assets[assetBundleName] = new Dictionary<string, Object>();
					}
					else
					{
						assets[assetBundleName].Clear();
					}

					if (result != null)
					{
						foreach (var asset in result)
						{
							if (asset)
							{
								assets[assetBundleName][asset.name] = asset;
							}
						}
					}
				}
			}

			if (assets.ContainsKey(assetBundleName) && assets[assetBundleName].ContainsKey(assetName))
			{
				return assets[assetBundleName][assetName];
			}

			return null;
		}

		public Object LoadAsset(string assetBundleName, string assetName)
		{
			if (Define.IsEditorMode)
			{
				return LoadEditorAsset(assetBundleName, assetName);
			}

			string p = Path.Combine(PathHelper.AppHotfixResPath, assetBundleName);

			if (!File.Exists(p))
			{
				p = Path.Combine(PathHelper.AppResPath, assetBundleName);
			}

			AssetBundle assetBundle = null;

			if (assetBundles.ContainsKey(assetBundleName))
			{
				assetBundle = assetBundles[assetBundleName];
			}
			else
			{
				assetBundle = AssetBundle.LoadFromFile(p);
			}

			if (assetBundle == null)
			{
				Debug.LogError($"assetBundle not found: {assetBundleName}");
				return null;
			}

			assetBundles[assetBundleName] = assetBundle;

			if (!assetBundle.isStreamedSceneAssetBundle)
			{
				var result = assetBundle.LoadAllAssets();

				if (!assets.ContainsKey(assetBundleName))
				{
					assets[assetBundleName] = new Dictionary<string, Object>();
				}
				else
				{
					assets[assetBundleName].Clear();
				}

				if (result != null)
				{
					foreach (var asset in result)
					{
						if (asset)
						{
							assets[assetBundleName][asset.name] = asset;
						}
					}
				}
			}

			if (assets.ContainsKey(assetBundleName) && assets[assetBundleName].ContainsKey(assetName))
			{
				return assets[assetBundleName][assetName];
			}

			return null;
		}


		private static Object LoadEditorAsset(string assetBundleName, string assetName)
		{
#if UNITY_EDITOR
			var paths = AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);

			if (paths != null)
			{
				foreach (string s in paths)
				{
					var currentAssetName = Path.GetFileNameWithoutExtension(s);
					var currentAsset = AssetDatabase.LoadAssetAtPath<Object>(s);

					if (currentAssetName == assetName)
					{
						return currentAsset;
					}
				}
			}
#endif
			return null;
		}

		public async Task<AssetBundle> LoadAssetBundleAsync(string assetBundleName)
		{
			string p = Path.Combine(PathHelper.AppHotfixResPath, assetBundleName);

			if (!File.Exists(p))
			{
				p = Path.Combine(PathHelper.AppResPath, assetBundleName);
			}

			AssetBundle assetBundle = null;

			if (assetBundles.ContainsKey(assetBundleName))
			{
				assetBundle = assetBundles[assetBundleName];
			}
			else
			{
				using (AssetBundleLoaderAsync assetsBundleLoaderAsync = new AssetBundleLoaderAsync())
				{
					assetBundle = await assetsBundleLoaderAsync.LoadAsync(p);
				}
			}

			if (assetBundle == null)
			{
				Debug.LogError($"assetBundle not found: {assetBundleName}");
				return null;
			}

			return assetBundle;
		}


		public AssetBundle LoadAssetBundle(string assetBundleName)
		{
			string p = Path.Combine(PathHelper.AppHotfixResPath, assetBundleName);

			if (!File.Exists(p))
			{
				p = Path.Combine(PathHelper.AppResPath, assetBundleName);
			}

			AssetBundle assetBundle = null;

			if (assetBundles.ContainsKey(assetBundleName))
			{
				assetBundle = assetBundles[assetBundleName];
			}
			else
			{
				assetBundle = AssetBundle.LoadFromFile(p);
			}

			if (assetBundle == null)
			{
				Debug.LogError($"assetBundle not found: {assetBundleName}");
				return null;
			}

			return assetBundle;
		}

		public void Dispose()
		{
			assets.Clear();

			foreach (var assetBundle in assetBundles)
			{
				assetBundle.Value.Unload(true);
			}

			assetBundles.Clear();
		}
	}
}