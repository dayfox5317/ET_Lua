using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UILobby)]
    public class UILobbyEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            await ETTask.CompletedTask;

            // ResourcesComponent.Instance.LoadBundle(UIType.UILobby.StringToAB());

            UnityEngine.Object bundleGameObject = ResourcesComponent.Instance.LoadAsset("Assets/Bundles/UI/" + UIType.UILobby + ".prefab", typeof(UnityEngine.GameObject));

            Debug.Log(bundleGameObject.name);

            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject) as GameObject;


            UI ui = EntityFactory.CreateWithParent<UI, string, GameObject>(uiComponent, UIType.UILobby, gameObject);

            ui.AddComponent<UILobbyComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
             ResourcesComponent.Instance.UnLoadAsset("Assets/Bundles/UI/" + UIType.UILobby + ".prefab");
        }
    }
}