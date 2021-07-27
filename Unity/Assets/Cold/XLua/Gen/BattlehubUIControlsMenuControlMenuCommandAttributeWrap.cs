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
    public partial class BattlehubUIControlsMenuControlMenuCommandAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MenuControl.MenuCommandAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 6, 0);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPath", _g_get_Path);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIconPath", _g_get_IconPath);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getValidate", _g_get_Validate);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHide", _g_get_Hide);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPriority", _g_get_Priority);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRequiresInstance", _g_get_RequiresInstance);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Path", _g_get_Path);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IconPath", _g_get_IconPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Validate", _g_get_Validate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Hide", _g_get_Hide);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Priority", _g_get_Priority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RequiresInstance", _g_get_RequiresInstance);
            
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 6 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					bool _validate = LuaAPI.lua_toboolean(L, 3);
					bool _hide = LuaAPI.lua_toboolean(L, 4);
					int _priority = LuaAPI.xlua_tointeger(L, 5);
					bool _requiresInstance = LuaAPI.lua_toboolean(L, 6);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _validate, _hide, _priority, _requiresInstance);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					bool _validate = LuaAPI.lua_toboolean(L, 3);
					bool _hide = LuaAPI.lua_toboolean(L, 4);
					int _priority = LuaAPI.xlua_tointeger(L, 5);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _validate, _hide, _priority);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					bool _validate = LuaAPI.lua_toboolean(L, 3);
					bool _hide = LuaAPI.lua_toboolean(L, 4);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _validate, _hide);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					bool _validate = LuaAPI.lua_toboolean(L, 3);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _validate);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					string _iconPath = LuaAPI.lua_tostring(L, 3);
					bool _requiresInstance = LuaAPI.lua_toboolean(L, 4);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _iconPath, _requiresInstance);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					string _iconPath = LuaAPI.lua_tostring(L, 3);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _iconPath);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					string _iconPath = LuaAPI.lua_tostring(L, 3);
					int _priority = LuaAPI.xlua_tointeger(L, 4);
					bool _requiresInstance = LuaAPI.lua_toboolean(L, 5);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _iconPath, _priority, _requiresInstance);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					string _path = LuaAPI.lua_tostring(L, 2);
					string _iconPath = LuaAPI.lua_tostring(L, 3);
					int _priority = LuaAPI.xlua_tointeger(L, 4);
					
					Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_ret = new Battlehub.UIControls.MenuControl.MenuCommandAttribute(_path, _iconPath, _priority);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.MenuCommandAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Path(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuCommandAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Path);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IconPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuCommandAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.IconPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Validate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuCommandAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Validate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Hide(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuCommandAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Hide);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Priority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuCommandAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Priority);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RequiresInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuCommandAttribute gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuCommandAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.RequiresInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
