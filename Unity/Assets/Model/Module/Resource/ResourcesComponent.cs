using System;
using System.Collections.Generic;

#if UNITY_EDITOR
#endif

namespace ET
{


    [ObjectSystem]
    public class ResourcesComponentAwakeSystem : AwakeSystem<ResourcesComponent>
    {
        public override void Awake(ResourcesComponent self)
        {
            self.Awake();
        }
    }

    public class ResourcesComponent : Entity
    {
        public static ResourcesComponent Instance { get; set; }

        private Dictionary<string, libx.AssetRequest> n2req;
        public void Awake()
        {

            n2req = new Dictionary<string, libx.AssetRequest>();


            Instance = this;



        }

        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            base.Dispose();

            Instance = null;

            //foreach (var item in n2req)
            //{
            //    UnLoadAsset(item.Key);
            //}

        }
        public libx.AssetRequest LoadSceneAsync(string path, bool ad)
        {


            var req = libx.Assets.LoadSceneAsync(path, ad);

            return req;

        }
        public async ETTask<UnityEngine.Object> LoadAssetAsync(string path, Type type)
        {
            if (n2req.ContainsKey(path))
            {
                return n2req[path].asset;
            }
            var req = libx.Assets.LoadAssetAsync(path, type);
            var task = ETTask<UnityEngine.Object>.Create(true);
          
            req.completed = (x) =>
            {
                task.SetResult(x.asset);
            };
            n2req[path] = req;
            return await task;

        }
        public UnityEngine.Object LoadAsset(string path, Type type)
        {
            if (n2req.ContainsKey(path))
            {
                return n2req[path].asset;
            }
            var req = libx.Assets.LoadAsset(path, type);
            n2req[path] = req;
            return req.asset;

        }
        public void UnLoadAsset(string path)
        {
            if (n2req.ContainsKey(path))
            {
                n2req[path].Release();
                n2req.Remove(path);
                ET.Log.Debug("[Unload]" + path);
            }
           

        }


        public string[] GetAllAssetPaths()
        {
            string[] rets = null;
            var files = libx.Assets.GetAllAssetPaths();
#if __CSharpLua__

            
            /*
            [[

                    local ArrayString = System.Array(System.String)
                    rets = ArrayString:new(files.Length)
                    for i = 0, files.Length - 1 do
                     rets[i] = files[i]
                    end
                   
            ]]
            */
            
#endif
            //var len = ETCold.ArrayHelper.GetLength(files);
            //for (int i = 0; i < len; i++)
            //{
            //   var str = ETCold.ArrayHelper.GetStringItem(files, i);

            //}

            return rets;
        }


    }
}