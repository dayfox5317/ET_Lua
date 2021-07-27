using System;
using System.Collections.Generic;
using ETCold;

namespace ET
{
    public static class Game
    {
        public static ThreadSynchronizationContext ThreadSynchronizationContext => ThreadSynchronizationContext.Instance;

        public static TimeInfo TimeInfo => TimeInfo.Instance;
        
        public static EventSystem EventSystem => EventSystem.Instance;

        private static Scene scene;
        public static Scene Scene
        {
            get
            {
                if (scene != null)
                {
                    return scene;
                }
                scene = EntitySceneFactory.CreateScene(IdGenerater.Instance.GenerateInstanceId(), 0, SceneType.Process, "Process");

                //InstanceIdStruct instanceIdStruct = new InstanceIdStruct(Options.Process, 0);
                //scene = EntitySceneFactory.CreateScene(instanceIdStruct.ToLong(), 0, SceneType.Process, "Process");
                return scene;
            }
        }

        public static ObjectPool ObjectPool => ObjectPool.Instance;

        public static IdGenerater IdGenerater => IdGenerater.Instance;

        public static Options Options;

        public static ILog ILog;

        public static List<Action> FrameFinishCallback = new List<Action>();

        public static void Update()
        {
#if NOT_UNITY
            ThreadSynchronizationContext.Update();
#endif
            TimeInfo.Update();
            EventSystem.Update();
        }
        
        public static void LateUpdate()
        {
            EventSystem.LateUpdate();
        }

        public static void FrameFinish()
        {
            foreach (Action action in FrameFinishCallback)
            {
                action.Invoke();
            }
            FrameFinishCallback.Clear();
        }

        public static void Close()
        {
            scene?.Dispose();
            scene = null;
            ObjectPool.Instance.Dispose();
            EventSystem.Instance.Dispose();
            IdGenerater.Instance.Dispose();
        }
    }
}