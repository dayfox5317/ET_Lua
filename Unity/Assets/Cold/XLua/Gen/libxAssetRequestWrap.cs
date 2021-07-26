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
    public partial class libxAssetRequestWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(libx.AssetRequest);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 11, 3);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveNext", _m_MoveNext);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getloadState", _g_get_loadState);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getisDone", _g_get_isDone);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getprogress", _g_get_progress);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geterror", _g_get_error);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettext", _g_get_text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getbytes", _g_get_bytes);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getasset", _g_get_asset);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCurrent", _g_get_Current);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getassetType", _g_get_assetType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcompleted", _g_get_completed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geturl", _g_get_url);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setassetType", _s_set_assetType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcompleted", _s_set_completed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "seturl", _s_set_url);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "loadState", _g_get_loadState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDone", _g_get_isDone);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "progress", _g_get_progress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "error", _g_get_error);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bytes", _g_get_bytes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "asset", _g_get_asset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Current", _g_get_Current);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "assetType", _g_get_assetType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "completed", _g_get_completed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "url", _g_get_url);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "assetType", _s_set_assetType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "completed", _s_set_completed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "url", _s_set_url);
            
			
			
			
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
					
					libx.AssetRequest gen_ret = new libx.AssetRequest();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to libx.AssetRequest constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveNext(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.MoveNext(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                translator.PushlibxLoadState(L, gen_to_be_invoked.loadState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDone(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isDone);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_progress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.progress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_error(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.error);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bytes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.bytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_asset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.asset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Current(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Current);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_assetType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.assetType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_completed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.completed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_url(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.url);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_assetType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.assetType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_completed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.completed = translator.GetDelegate<System.Action<libx.AssetRequest>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_url(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.AssetRequest gen_to_be_invoked = (libx.AssetRequest)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.url = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
