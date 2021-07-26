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
    public partial class ETColdDefineWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.Define);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 15, 3, 3);
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getFrameRate", ETCold.Define.FrameRate);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getCompileLua", _g_get_CompileLua);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getIsEditorMode", _g_get_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getIsLua", _g_get_IsLua);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setCompileLua", _s_set_CompileLua);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setIsEditorMode", _s_set_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setIsLua", _s_set_IsLua);
            
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FrameRate", ETCold.Define.FrameRate);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CompileLua", _g_get_CompileLua);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsEditorMode", _g_get_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsLua", _g_get_IsLua);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CompileLua", _s_set_CompileLua);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsEditorMode", _s_set_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsLua", _s_set_IsLua);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.Define does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CompileLua(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, ETCold.Define.CompileLua);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEditorMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, ETCold.Define.IsEditorMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsLua(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, ETCold.Define.IsLua);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CompileLua(RealStatePtr L)
        {
		    try {
                
			    ETCold.Define.CompileLua = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsEditorMode(RealStatePtr L)
        {
		    try {
                
			    ETCold.Define.IsEditorMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsLua(RealStatePtr L)
        {
		    try {
                
			    ETCold.Define.IsLua = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
