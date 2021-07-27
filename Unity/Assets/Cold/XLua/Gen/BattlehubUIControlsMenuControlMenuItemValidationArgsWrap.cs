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
    public partial class BattlehubUIControlsMenuControlMenuItemValidationArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MenuControl.MenuItemValidationArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 4, 3);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsValid", _g_get_IsValid);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHasChildren", _g_get_HasChildren);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsVisible", _g_get_IsVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCommand", _g_get_Command);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsValid", _s_set_IsValid);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setHasChildren", _s_set_HasChildren);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsVisible", _s_set_IsVisible);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsValid", _g_get_IsValid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasChildren", _g_get_HasChildren);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVisible", _g_get_IsVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Command", _g_get_Command);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsValid", _s_set_IsValid);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HasChildren", _s_set_HasChildren);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsVisible", _s_set_IsVisible);
            
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					string _command = LuaAPI.lua_tostring(L, 2);
					bool _hasChildren = LuaAPI.lua_toboolean(L, 3);
					
					Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_ret = new Battlehub.UIControls.MenuControl.MenuItemValidationArgs(_command, _hasChildren);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.MenuItemValidationArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsValid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsValid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasChildren(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasChildren);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Command(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Command);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsValid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsValid = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HasChildren(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HasChildren = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemValidationArgs gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemValidationArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
