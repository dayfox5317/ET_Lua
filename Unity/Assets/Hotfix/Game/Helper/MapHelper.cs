//using System;

//namespace ET
//{
//	public static class MapHelper
//    {
//        public static async void EnterMapAsync(string sceneName)
//        {
//            try
//            {
//                // 加载Unit资源
//                ResourcesComponent resourcesComponent = Game.Scene.GetComponent<ResourcesComponent>();
//                await resourcesComponent.LoadBundleAsync($"unit.unity3d");

//                // 加载场景资源
//                await Game.Scene.GetComponent<ResourcesComponent>().LoadBundleAsync("map.unity3d");
//                // 切换到map场景
//                using (SceneChangeComponent sceneChangeComponent = Game.Scene.AddComponent<SceneChangeComponent>())
//                {
//                    await sceneChangeComponent.ChangeSceneAsync(sceneName);
//                }
				
//                G2C_EnterMap g2CEnterMap = await SessionComponent.Instance.Session.Call(new C2G_EnterMap()) as G2C_EnterMap;
//                PlayerComponent.Instance.MyPlayer.UnitId = g2CEnterMap.UnitId;
				
//                Game.Scene.AddComponent<OperaComponent>();
				
//            }
//                Game.EventSystem.Run(EventIdType.EnterMapFinish);
//            catch (Exception e)
//            {
//                Log.Exception(e);
//            }	
//        }
//    }
//}