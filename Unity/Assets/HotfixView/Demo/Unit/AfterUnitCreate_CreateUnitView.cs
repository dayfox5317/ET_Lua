using UnityEngine;

namespace ET
{
    public class AfterUnitCreate_CreateUnitView : AEvent<EventType.AfterUnitCreate>
    {
        protected override async ETTask Run(EventType.AfterUnitCreate args)
        {
            // Unit View层
            // 这里可以改成异步加载，demo就不搞了
            GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.LoadAsset("Assets/Bundles/Unit/Unit.prefab", typeof(GameObject));// ..GetAsset("Unit.unity3d", "Unit");
            ReferenceCollector referenceCollector = bundleGameObject.GetComponent(typeof(ReferenceCollector)) as ReferenceCollector;
            UnityEngine.Object prefab = referenceCollector.GetObject("Skeleton");

            GameObject go = UnityEngine.Object.Instantiate(prefab) as GameObject;

            go.transform.SetParent(GlobalComponent.Instance.Unit);
            go.transform.position = args.Unit.Position;
            args.Unit.AddComponent<GameObjectComponent>().GameObject = go;
            args.Unit.AddComponent<AnimatorComponent>();
            await ETTask.CompletedTask;
        }
    }
}