using System;
using System.Threading.Tasks;
using UnityEngine;

namespace ETCold
{
	public class AssetBundleLoaderAsync : IDisposable
	{
		private AssetBundleCreateRequest request;

		private TaskCompletionSource<AssetBundle> tcs;

		public void Update()
		{
			if (!this.request.isDone)
			{
				return;
			}

			TaskCompletionSource<AssetBundle> t = tcs;
			t.SetResult(this.request.assetBundle);
		}

		public void Dispose()
		{
			GameLoop.onUpdate -= Update;
			request = null;
			tcs = null;
		}

		public Task<AssetBundle> LoadAsync(string path)
		{
			this.tcs = new TaskCompletionSource<AssetBundle>();
			this.request = AssetBundle.LoadFromFileAsync(path);

			GameLoop.onUpdate -= Update;
			GameLoop.onUpdate += Update;

			return this.tcs.Task;
		}
	}
}