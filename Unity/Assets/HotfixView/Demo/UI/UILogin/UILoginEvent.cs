using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UILogin)]
    public class UILoginEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            await ETTask.CompletedTask;




            //ResourcesComponent.Instance.LoadBundle(UIType.UILogin.StringToAB());

            UnityEngine.Object bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync("Assets/Bundles/UI/UILogin.prefab",typeof(GameObject));
           
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject) as GameObject;
            
            UI ui = EntityFactory.CreateWithParent<UI, string, GameObject>(uiComponent, UIType.UILogin, gameObject);
           
            ui.AddComponent<UILoginComponent>();
           
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            ResourcesComponent.Instance.UnLoadAsset("Assets/Bundles/UI/UILogin.prefab");
        }
    }
}