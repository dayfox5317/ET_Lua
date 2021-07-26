using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace ET
{
    
    public class ResourceEntityAwakeSystem : AwakeSystem<ResourceEntity>
    {
        public override void Awake(ResourceEntity self)
        {
            self.Awake();
        }
    }
    public class ResourceEntityDestroySystem : DestroySystem<ResourceEntity>
    {
        public override void Destroy(ResourceEntity self)
        {
            self.ResourceName = null;
            self.Target = null;
        }
    }

    public class ResourceEntity : Entity
    {
        public string ResourceName;

        public bool IsAssetBundle;
        /// <summary>
        /// 关联目标
        /// </summary>
        public UnityEngine.Object Target;

        public float LastUseTime;

        public int ReferenceCount;


        /// <summary>
        /// 依赖资源实体
        /// </summary>
        public LinkedList<ResourceEntity> DependsResourceList { get; private set; }
        public void Awake()
        {
            DependsResourceList = new LinkedList<ResourceEntity>();
            IsAssetBundle = false;
            LastUseTime = 0;
            ReferenceCount = 0;
        }
        public void Spawn()
        {
            LastUseTime = Time.time;
            if (!IsAssetBundle)
            {
                ReferenceCount++;
            }
            else
            {
                //if (Game.Scene.GetComponent<Pool>().CheckAssetBundleIsLocked(ResourceName))
                //    ReferenceCount = 1;
            }
        }

        public void Despawn()
        {
            LastUseTime = Time.time;
            ReferenceCount--;
            if (ReferenceCount < 0)
                ReferenceCount = 0;
        }

        public void Release()
        {

            if (IsAssetBundle)
            {
                AssetBundle bundle = Target as AssetBundle;
                bundle.Unload(false);
                Log.Debug("释放了资源包:" + ResourceName);
            }
            else
            {
                Log.Debug("释放了资源:" + ResourceName);
            }

            ResourceName = null;
            ReferenceCount = 0;
            Target = null;
            DependsResourceList?.Clear();

            this.Dispose();
        }



    }
}