
using System;
using System.Threading;

using UnityEngine;

namespace ETCold
{
    public class GameInit : MonoBehaviour
    {
        public bool isRunLuaMode = true;
        private void Awake()
        {
            SynchronizationContext.SetSynchronizationContext(ThreadSynchronizationContext.Instance);
            DontDestroyOnLoad(gameObject);
            Application.targetFrameRate = Define.FrameRate;
            Define.IsEditorMode = Application.isEditor;
            Define.IsLua = isRunLuaMode;
        }
       
        public void OnHotFixLoaded()
        {
            try
            {
         
                Destroy(UnityEngine.Object.FindObjectOfType<libx.Updater>());
                LuaHelper.StartHotfix();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }


        private void Start()
        {
            try
            {
                GameLoop.onStart?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void OnEnable()
        {
            try
            {
                GameLoop.onEnable?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void OnDisable()
        {
            try
            {
                GameLoop.onDisable?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void Update()
        {
            try
            {
                ThreadSynchronizationContext.Instance.Update();
                GameLoop.onUpdate?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void LateUpdate()
        {
            try
            {
                GameLoop.onLateUpdate?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void FixedUpdate()
        {
            try
            {
                GameLoop.onFixedUpdate?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void OnDestroy()
        {
            try
            {
                GameLoop.onDestroy?.Invoke();

                libx.Assets.RemoveUnusedAssets();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void OnApplicationPause(bool isPause)
        {
            try
            {
                GameLoop.onApplicationPause?.Invoke(isPause);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void OnApplicationFocus(bool isFocus)
        {
            try
            {
                GameLoop.onApplicationFocus?.Invoke(isFocus);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }

        private void OnApplicationQuit()
        {
            try
            {
                GameLoop.onApplicationQuit?.Invoke();

                if (Define.IsLua)
                {
                    Lua.Default.Dispose();
                }
               
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}