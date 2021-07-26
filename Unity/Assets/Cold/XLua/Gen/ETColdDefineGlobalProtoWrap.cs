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
    public partial class ETColdDefineGlobalProtoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.Define.GlobalProto);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 8, 8);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAddress", _m_GetAddress);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUrl", _m_GetUrl);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAssetBundleServerUrl", _g_get_AssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAddress", _g_get_Address);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLocalAssetBundleServerUrl", _g_get_LocalAssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLocalAddress", _g_get_LocalAddress);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getisLocal", _g_get_isLocal);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getisEditorMode", _g_get_isEditorMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getisLua", _g_get_isLua);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getClientVersion", _g_get_ClientVersion);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAssetBundleServerUrl", _s_set_AssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAddress", _s_set_Address);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setLocalAssetBundleServerUrl", _s_set_LocalAssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setLocalAddress", _s_set_LocalAddress);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setisLocal", _s_set_isLocal);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setisEditorMode", _s_set_isEditorMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setisLua", _s_set_isLua);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setClientVersion", _s_set_ClientVersion);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetBundleServerUrl", _g_get_AssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Address", _g_get_Address);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LocalAssetBundleServerUrl", _g_get_LocalAssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LocalAddress", _g_get_LocalAddress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLocal", _g_get_isLocal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isEditorMode", _g_get_isEditorMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLua", _g_get_isLua);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ClientVersion", _g_get_ClientVersion);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetBundleServerUrl", _s_set_AssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Address", _s_set_Address);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LocalAssetBundleServerUrl", _s_set_LocalAssetBundleServerUrl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LocalAddress", _s_set_LocalAddress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLocal", _s_set_isLocal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isEditorMode", _s_set_isEditorMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLua", _s_set_isLua);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ClientVersion", _s_set_ClientVersion);
            
			
			
			
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
					
					ETCold.Define.GlobalProto gen_ret = new ETCold.Define.GlobalProto();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.Define.GlobalProto constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAddress(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetAddress(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUrl(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetUrl(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetBundleServerUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AssetBundleServerUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Address(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Address);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalAssetBundleServerUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.LocalAssetBundleServerUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalAddress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.LocalAddress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLocal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isLocal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isEditorMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isEditorMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLua(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isLua);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ClientVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ClientVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetBundleServerUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AssetBundleServerUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Address(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Address = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LocalAssetBundleServerUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LocalAssetBundleServerUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LocalAddress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LocalAddress = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLocal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isLocal = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isEditorMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isEditorMode = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLua(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isLua = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ClientVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.Define.GlobalProto gen_to_be_invoked = (ETCold.Define.GlobalProto)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ClientVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
