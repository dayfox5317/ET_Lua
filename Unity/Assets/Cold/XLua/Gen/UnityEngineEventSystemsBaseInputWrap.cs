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
    public partial class UnityEngineEventSystemsBaseInputWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.BaseInput);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 8, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMouseButtonDown", _m_GetMouseButtonDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMouseButtonUp", _m_GetMouseButtonUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMouseButton", _m_GetMouseButton);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTouch", _m_GetTouch);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAxisRaw", _m_GetAxisRaw);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetButtonDown", _m_GetButtonDown);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcompositionString", _g_get_compositionString);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getimeCompositionMode", _g_get_imeCompositionMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcompositionCursorPos", _g_get_compositionCursorPos);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmousePresent", _g_get_mousePresent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmousePosition", _g_get_mousePosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmouseScrollDelta", _g_get_mouseScrollDelta);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettouchSupported", _g_get_touchSupported);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettouchCount", _g_get_touchCount);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setimeCompositionMode", _s_set_imeCompositionMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcompositionCursorPos", _s_set_compositionCursorPos);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "compositionString", _g_get_compositionString);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "imeCompositionMode", _g_get_imeCompositionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "compositionCursorPos", _g_get_compositionCursorPos);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mousePresent", _g_get_mousePresent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mousePosition", _g_get_mousePosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseScrollDelta", _g_get_mouseScrollDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchSupported", _g_get_touchSupported);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchCount", _g_get_touchCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "imeCompositionMode", _s_set_imeCompositionMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "compositionCursorPos", _s_set_compositionCursorPos);
            
			
			
			
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
					
					UnityEngine.EventSystems.BaseInput gen_ret = new UnityEngine.EventSystems.BaseInput();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.BaseInput constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMouseButtonDown(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _button = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.GetMouseButtonDown( 
                        _button );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMouseButtonUp(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _button = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.GetMouseButtonUp( 
                        _button );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMouseButton(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _button = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.GetMouseButton( 
                        _button );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTouch(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Touch gen_ret = gen_to_be_invoked.GetTouch( 
                        _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisRaw(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 2);
                    
                        float gen_ret = gen_to_be_invoked.GetAxisRaw( 
                        _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButtonDown(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _buttonName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.GetButtonDown( 
                        _buttonName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_compositionString(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.compositionString);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_imeCompositionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.imeCompositionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_compositionCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.compositionCursorPos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mousePresent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.mousePresent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mousePosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.mousePosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseScrollDelta(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.mouseScrollDelta);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchSupported(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.touchSupported);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.touchCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_imeCompositionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                UnityEngine.IMECompositionMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.imeCompositionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_compositionCursorPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInput gen_to_be_invoked = (UnityEngine.EventSystems.BaseInput)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.compositionCursorPos = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
