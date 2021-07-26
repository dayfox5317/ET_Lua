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
    public partial class ETColdMonoHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.MonoHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 46, 9, 9);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "StartHotfix", _m_StartHotfix_xlua_st_);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getModel", ETCold.MonoHelper.Model);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getModelView", ETCold.MonoHelper.ModelView);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getHotfix", ETCold.MonoHelper.Hotfix);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getHotfixView", ETCold.MonoHelper.HotfixView);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getModelDll", _g_get_ModelDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getModelViewDll", _g_get_ModelViewDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getHotfixDll", _g_get_HotfixDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getHotfixViewDll", _g_get_HotfixViewDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getModelPdb", _g_get_ModelPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getModelViewPdb", _g_get_ModelViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getHotfixPdb", _g_get_HotfixPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getHotfixViewPdb", _g_get_HotfixViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "get_types", _g_get__types);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setModelDll", _s_set_ModelDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setModelViewDll", _s_set_ModelViewDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setHotfixDll", _s_set_HotfixDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setHotfixViewDll", _s_set_HotfixViewDll);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setModelPdb", _s_set_ModelPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setModelViewPdb", _s_set_ModelViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setHotfixPdb", _s_set_HotfixPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setHotfixViewPdb", _s_set_HotfixViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "set_types", _s_set__types);
            
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Model", ETCold.MonoHelper.Model);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ModelView", ETCold.MonoHelper.ModelView);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hotfix", ETCold.MonoHelper.Hotfix);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HotfixView", ETCold.MonoHelper.HotfixView);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ModelDll", _g_get_ModelDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ModelViewDll", _g_get_ModelViewDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixDll", _g_get_HotfixDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixViewDll", _g_get_HotfixViewDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ModelPdb", _g_get_ModelPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ModelViewPdb", _g_get_ModelViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixPdb", _g_get_HotfixPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixViewPdb", _g_get_HotfixViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "_types", _g_get__types);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ModelDll", _s_set_ModelDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ModelViewDll", _s_set_ModelViewDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixDll", _s_set_HotfixDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixViewDll", _s_set_HotfixViewDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ModelPdb", _s_set_ModelPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ModelViewPdb", _s_set_ModelViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixPdb", _s_set_HotfixPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixViewPdb", _s_set_HotfixViewPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "_types", _s_set__types);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.MonoHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartHotfix_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    
                    ETCold.MonoHelper.StartHotfix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModelDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.ModelDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModelViewDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.ModelViewDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.HotfixDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixViewDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.HotfixViewDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModelPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.ModelPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModelViewPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.ModelViewPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.HotfixPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixViewPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, ETCold.MonoHelper.HotfixViewPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__types(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCold.MonoHelper._types);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModelDll(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.ModelDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModelViewDll(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.ModelViewDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixDll(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.HotfixDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixViewDll(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.HotfixViewDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModelPdb(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.ModelPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModelViewPdb(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.ModelViewPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixPdb(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.HotfixPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixViewPdb(RealStatePtr L)
        {
		    try {
                
			    ETCold.MonoHelper.HotfixViewPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__types(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCold.MonoHelper._types = (System.Collections.Generic.List<System.Type>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<System.Type>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
