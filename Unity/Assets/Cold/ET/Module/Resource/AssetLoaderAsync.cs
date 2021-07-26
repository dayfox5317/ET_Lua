using System;
using System.Threading.Tasks;
using UnityEngine;

namespace ETCold
{
	public class AssetLoaderAsync : IDisposable
	{
		private AssetBundle assetBundle;

		private AssetBundleRequest request;

		private TaskCompletionSource<UnityEngine.Object[]> tcs;

		public AssetLoaderAsync(AssetBundle ab)
		{
			this.assetBundle = ab;
		}

		public void Update()
		{
			if (!this.request.isDone)
			{
				return;
			}

			tcs.SetResult(request.allAssets);
		}

		public void Dispose()
		{
			GameLoop.onUpdate -= Update;

			this.assetBundle = null;
			this.request = null;
		}

		public Task<UnityEngine.Object[]> LoadAllAssetsAsync()
		{
			this.tcs = new TaskCompletionSource<UnityEngine.Object[]>();
			this.request = assetBundle.LoadAllAssetsAsync();

			GameLoop.onUpdate += Update;

			return this.tcs.Task;
		}
	}
}