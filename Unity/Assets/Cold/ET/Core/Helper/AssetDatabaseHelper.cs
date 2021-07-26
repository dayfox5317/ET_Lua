#if UNITY_EDITOR
using UnityEditor;
#endif

namespace ETCold
{
	public static class AssetDatabaseHelper
	{
		public static string[] GetAssetBundleDependencies(string assetBundleName, bool recursive)
		{
#if UNITY_EDITOR
			return AssetDatabase.GetAssetBundleDependencies(assetBundleName, recursive);
#else
			return null;
#endif
		}

		public static string[] GetAssetPathsFromAssetBundle(string assetBundleName)
		{
#if UNITY_EDITOR
			return AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);
#else
			return null;
#endif
		}

		public static UnityEngine.Object LoadAssetAtPath(string assetName)
		{
#if UNITY_EDITOR
			return AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(assetName);
#else
			return null;
#endif
		}
	}
}
