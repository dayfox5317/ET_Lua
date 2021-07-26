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
    public partial class ETColdPathHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.PathHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 5, 0);
			
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getAppHotfixResPath", _g_get_AppHotfixResPath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getAppResPath", _g_get_AppResPath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getAssetPath", _g_get_AssetPath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getLuaAssetPath", _g_get_LuaAssetPath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getAppResPath4Web", _g_get_AppResPath4Web);
            
			
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AppHotfixResPath", _g_get_AppHotfixResPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AppResPath", _g_get_AppResPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AssetPath", _g_get_AssetPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LuaAssetPath", _g_get_LuaAssetPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AppResPath4Web", _g_get_AppResPath4Web);
            
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.PathHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AppHotfixResPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.PathHelper.AppHotfixResPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AppResPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.PathHelper.AppResPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.PathHelper.AssetPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaAssetPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.PathHelper.LuaAssetPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AppResPath4Web(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.PathHelper.AppResPath4Web);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
