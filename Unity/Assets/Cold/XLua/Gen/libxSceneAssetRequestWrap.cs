﻿#if USE_UNI_LUA
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
    public partial class libxSceneAssetRequestWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(libx.SceneAssetRequest);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 3, 1);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getprogress", _g_get_progress);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getloadSceneMode", _g_get_loadSceneMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getassetBundleName", _g_get_assetBundleName);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setassetBundleName", _s_set_assetBundleName);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "progress", _g_get_progress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loadSceneMode", _g_get_loadSceneMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "assetBundleName", _g_get_assetBundleName);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "assetBundleName", _s_set_assetBundleName);
            
			
			
			
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
					string _path = LuaAPI.lua_tostring(L, 2);
					bool _addictive = LuaAPI.lua_toboolean(L, 3);
					
					libx.SceneAssetRequest gen_ret = new libx.SceneAssetRequest(_path, _addictive);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to libx.SceneAssetRequest constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_progress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.SceneAssetRequest gen_to_be_invoked = (libx.SceneAssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.progress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadSceneMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.SceneAssetRequest gen_to_be_invoked = (libx.SceneAssetRequest)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.loadSceneMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_assetBundleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.SceneAssetRequest gen_to_be_invoked = (libx.SceneAssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.assetBundleName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_assetBundleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.SceneAssetRequest gen_to_be_invoked = (libx.SceneAssetRequest)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.assetBundleName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
