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
    public partial class BattlehubUIControlsInputProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.InputProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 23, 21, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsMouseButtonDown", _m_IsMouseButtonDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTouch", _m_GetTouch);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHorizontalAxis", _g_get_HorizontalAxis);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getVerticalAxis", _g_get_VerticalAxis);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHorizontalAxis2", _g_get_HorizontalAxis2);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getVerticalAxis2", _g_get_VerticalAxis2);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsHorizontalButtonDown", _g_get_IsHorizontalButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsVerticalButtonDown", _g_get_IsVerticalButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsHorizontal2ButtonDown", _g_get_IsHorizontal2ButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsVertical2ButtonDown", _g_get_IsVertical2ButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsFunctionalButtonPressed", _g_get_IsFunctionalButtonPressed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsFunctional2ButtonPressed", _g_get_IsFunctional2ButtonPressed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSubmitButtonDown", _g_get_IsSubmitButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSubmitButtonUp", _g_get_IsSubmitButtonUp);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsCancelButtonDown", _g_get_IsCancelButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsDeleteButtonDown", _g_get_IsDeleteButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelectAllButtonDown", _g_get_IsSelectAllButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsAnyKeyDown", _g_get_IsAnyKeyDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMousePosition", _g_get_MousePosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsMousePresent", _g_get_IsMousePresent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsKeyboardPresent", _g_get_IsKeyboardPresent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTouchCount", _g_get_TouchCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsTouchSupported", _g_get_IsTouchSupported);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "HorizontalAxis", _g_get_HorizontalAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VerticalAxis", _g_get_VerticalAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HorizontalAxis2", _g_get_HorizontalAxis2);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VerticalAxis2", _g_get_VerticalAxis2);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsHorizontalButtonDown", _g_get_IsHorizontalButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVerticalButtonDown", _g_get_IsVerticalButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsHorizontal2ButtonDown", _g_get_IsHorizontal2ButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVertical2ButtonDown", _g_get_IsVertical2ButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFunctionalButtonPressed", _g_get_IsFunctionalButtonPressed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFunctional2ButtonPressed", _g_get_IsFunctional2ButtonPressed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSubmitButtonDown", _g_get_IsSubmitButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSubmitButtonUp", _g_get_IsSubmitButtonUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsCancelButtonDown", _g_get_IsCancelButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDeleteButtonDown", _g_get_IsDeleteButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelectAllButtonDown", _g_get_IsSelectAllButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsAnyKeyDown", _g_get_IsAnyKeyDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MousePosition", _g_get_MousePosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsMousePresent", _g_get_IsMousePresent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsKeyboardPresent", _g_get_IsKeyboardPresent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TouchCount", _g_get_TouchCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsTouchSupported", _g_get_IsTouchSupported);
            
			
			
			
			
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
					
					Battlehub.UIControls.InputProvider gen_ret = new Battlehub.UIControls.InputProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.InputProvider constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsMouseButtonDown(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _button = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsMouseButtonDown( 
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
            
            
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Touch gen_ret = gen_to_be_invoked.GetTouch( 
                        _i );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HorizontalAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.HorizontalAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VerticalAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.VerticalAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HorizontalAxis2(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.HorizontalAxis2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VerticalAxis2(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.VerticalAxis2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsHorizontalButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsHorizontalButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVerticalButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVerticalButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsHorizontal2ButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsHorizontal2ButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVertical2ButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVertical2ButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFunctionalButtonPressed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFunctionalButtonPressed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFunctional2ButtonPressed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFunctional2ButtonPressed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSubmitButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSubmitButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSubmitButtonUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSubmitButtonUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsCancelButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsCancelButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDeleteButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDeleteButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSelectAllButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSelectAllButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAnyKeyDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsAnyKeyDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MousePosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.MousePosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsMousePresent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsMousePresent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsKeyboardPresent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsKeyboardPresent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TouchCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.TouchCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsTouchSupported(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.InputProvider gen_to_be_invoked = (Battlehub.UIControls.InputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsTouchSupported);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
