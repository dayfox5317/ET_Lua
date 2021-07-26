#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public partial class ETColdGameLoopWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.GameLoop);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 41, 10, 10);
			
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getonStart", _g_get_onStart);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonEnable", _g_get_onEnable);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonDisable", _g_get_onDisable);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonUpdate", _g_get_onUpdate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonFixedUpdate", _g_get_onFixedUpdate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonLateUpdate", _g_get_onLateUpdate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonDestroy", _g_get_onDestroy);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonApplicationFocus", _g_get_onApplicationFocus);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonApplicationPause", _g_get_onApplicationPause);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonApplicationQuit", _g_get_onApplicationQuit);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setonStart", _s_set_onStart);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonEnable", _s_set_onEnable);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonDisable", _s_set_onDisable);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonUpdate", _s_set_onUpdate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonFixedUpdate", _s_set_onFixedUpdate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonLateUpdate", _s_set_onLateUpdate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonDestroy", _s_set_onDestroy);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonApplicationFocus", _s_set_onApplicationFocus);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonApplicationPause", _s_set_onApplicationPause);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonApplicationQuit", _s_set_onApplicationQuit);
            
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onStart", _g_get_onStart);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onEnable", _g_get_onEnable);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDisable", _g_get_onDisable);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onUpdate", _g_get_onUpdate);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onFixedUpdate", _g_get_onFixedUpdate);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onLateUpdate", _g_get_onLateUpdate);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onDestroy", _g_get_onDestroy);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onApplicationFocus", _g_get_onApplicationFocus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onApplicationPause", _g_get_onApplicationPause);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onApplicationQuit", _g_get_onApplicationQuit);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onStart", _s_set_onStart);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onEnable", _s_set_onEnable);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDisable", _s_set_onDisable);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onUpdate", _s_set_onUpdate);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onFixedUpdate", _s_set_onFixedUpdate);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onLateUpdate", _s_set_onLateUpdate);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onDestroy", _s_set_onDestroy);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onApplicationFocus", _s_set_onApplicationFocus);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onApplicationPause", _s_set_onApplicationPause);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onApplicationQuit", _s_set_onApplicationQuit);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.GameLoop does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onStart);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onEnable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onEnable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDisable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onDisable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onUpdate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFixedUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onFixedUpdate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onLateUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onLateUpdate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDestroy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onDestroy);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onApplicationFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onApplicationFocus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onApplicationPause(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onApplicationPause);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onApplicationQuit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.GameLoop.onApplicationQuit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onStart = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onEnable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onEnable = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDisable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onDisable = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onUpdate = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onFixedUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onFixedUpdate = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onLateUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onLateUpdate = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDestroy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onDestroy = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onApplicationFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onApplicationFocus = translator.GetDelegate<System.Action<bool>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onApplicationPause(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onApplicationPause = translator.GetDelegate<System.Action<bool>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onApplicationQuit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.GameLoop.onApplicationQuit = translator.GetDelegate<System.Action>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
