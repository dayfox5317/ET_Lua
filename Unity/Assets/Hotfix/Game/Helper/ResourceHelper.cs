using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class ResourceViewHelper
    {
        // public static async System.Threading.Tasks.Task<ValueTuple<Transform, bool>> LoadPrefabBoolAsync(int prefabId)
        // {
        //     PrefabConfig prefabConfig = ConfigHelper.Get<PrefabConfig>(prefabId);
        //     var (trans, isNew) = await GameObjectPool.Instanse.GameObjectSpawn((int)prefabConfig.Id, prefabConfig.PoolId, prefabConfig.AssetPath, prefabConfig.CullDespawned, prefabConfig.CullAbove, prefabConfig.CullDelay, prefabConfig.CullMaxPerPass);
        //     return (trans, isNew);
        // }
        // public static async System.Threading.Tasks.Task<Transform> LoadPrefabAsync(int prefabId)
        // {
        //     return (await LoadPrefabBoolAsync(prefabId)).Item1;
        // }
        // public static void DestoryPrefabAsync(GameObject go)
        // {
        //     if (!go) return;
        //     DestoryPrefabAsync(go.transform);
        // }
        // public static void DestoryPrefabAsync(Transform go)
        // {
        //     if (!go) return;
        //     GameObjectPool.Instanse.GameObjectDespawn(go);
        // }

    }
}
