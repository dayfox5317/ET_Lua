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
    public partial class UnityEngineEventSystemsPointerInputModuleMouseButtonEventDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 2, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PressedThisFrame", _m_PressedThisFrame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReleasedThisFrame", _m_ReleasedThisFrame);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getbuttonState", _g_get_buttonState);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getbuttonData", _g_get_buttonData);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setbuttonState", _s_set_buttonState);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setbuttonData", _s_set_buttonData);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "buttonState", _g_get_buttonState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "buttonData", _g_get_buttonData);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "buttonState", _s_set_buttonState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "buttonData", _s_set_buttonData);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_ret = new UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PressedThisFrame(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.PressedThisFrame(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleasedThisFrame(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.ReleasedThisFrame(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, gen_to_be_invoked.buttonState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.buttonData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.EventSystems.PointerEventData.FramePressState gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.buttonState = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.buttonData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
