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
    public partial class SystemNetIPAddressWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Net.IPAddress);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 7, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAddressBytes", _m_GetAddressBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapToIPv6", _m_MapToIPv6);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapToIPv4", _m_MapToIPv4);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAddressFamily", _g_get_AddressFamily);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getScopeId", _g_get_ScopeId);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsIPv6Multicast", _g_get_IsIPv6Multicast);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsIPv6LinkLocal", _g_get_IsIPv6LinkLocal);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsIPv6SiteLocal", _g_get_IsIPv6SiteLocal);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsIPv6Teredo", _g_get_IsIPv6Teredo);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsIPv4MappedToIPv6", _g_get_IsIPv4MappedToIPv6);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setScopeId", _s_set_ScopeId);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AddressFamily", _g_get_AddressFamily);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ScopeId", _g_get_ScopeId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsIPv6Multicast", _g_get_IsIPv6Multicast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsIPv6LinkLocal", _g_get_IsIPv6LinkLocal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsIPv6SiteLocal", _g_get_IsIPv6SiteLocal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsIPv6Teredo", _g_get_IsIPv6Teredo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsIPv4MappedToIPv6", _g_get_IsIPv4MappedToIPv6);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ScopeId", _s_set_ScopeId);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 20, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TryParse", _m_TryParse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Parse", _m_Parse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HostToNetworkOrder", _m_HostToNetworkOrder_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NetworkToHostOrder", _m_NetworkToHostOrder_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsLoopback", _m_IsLoopback_xlua_st_);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getAny", System.Net.IPAddress.Any);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getLoopback", System.Net.IPAddress.Loopback);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getBroadcast", System.Net.IPAddress.Broadcast);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getNone", System.Net.IPAddress.None);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getIPv6Any", System.Net.IPAddress.IPv6Any);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getIPv6Loopback", System.Net.IPAddress.IPv6Loopback);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getIPv6None", System.Net.IPAddress.IPv6None);
            
			
			
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Any", System.Net.IPAddress.Any);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loopback", System.Net.IPAddress.Loopback);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Broadcast", System.Net.IPAddress.Broadcast);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", System.Net.IPAddress.None);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6Any", System.Net.IPAddress.IPv6Any);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6Loopback", System.Net.IPAddress.IPv6Loopback);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6None", System.Net.IPAddress.IPv6None);
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2)))
				{
					long _newAddress = LuaAPI.lua_toint64(L, 2);
					
					System.Net.IPAddress gen_ret = new System.Net.IPAddress(_newAddress);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isint64(L, 3)))
				{
					byte[] _address = LuaAPI.lua_tobytes(L, 2);
					long _scopeid = LuaAPI.lua_toint64(L, 3);
					
					System.Net.IPAddress gen_ret = new System.Net.IPAddress(_address, _scopeid);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					byte[] _address = LuaAPI.lua_tobytes(L, 2);
					
					System.Net.IPAddress gen_ret = new System.Net.IPAddress(_address);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.IPAddress constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryParse_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ipString = LuaAPI.lua_tostring(L, 1);
                    System.Net.IPAddress _address;
                    
                        bool gen_ret = System.Net.IPAddress.TryParse( 
                        _ipString, 
                        out _address );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _address);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Parse_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ipString = LuaAPI.lua_tostring(L, 1);
                    
                        System.Net.IPAddress gen_ret = System.Net.IPAddress.Parse( 
                        _ipString );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAddressBytes(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.GetAddressBytes(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HostToNetworkOrder_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _host = LuaAPI.lua_toint64(L, 1);
                    
                        long gen_ret = System.Net.IPAddress.HostToNetworkOrder( 
                        _host );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _host = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = System.Net.IPAddress.HostToNetworkOrder( 
                        _host );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    short _host = (short)LuaAPI.xlua_tointeger(L, 1);
                    
                        short gen_ret = System.Net.IPAddress.HostToNetworkOrder( 
                        _host );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.IPAddress.HostToNetworkOrder!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NetworkToHostOrder_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _network = LuaAPI.lua_toint64(L, 1);
                    
                        long gen_ret = System.Net.IPAddress.NetworkToHostOrder( 
                        _network );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _network = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = System.Net.IPAddress.NetworkToHostOrder( 
                        _network );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    short _network = (short)LuaAPI.xlua_tointeger(L, 1);
                    
                        short gen_ret = System.Net.IPAddress.NetworkToHostOrder( 
                        _network );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.IPAddress.NetworkToHostOrder!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLoopback_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Net.IPAddress _address = (System.Net.IPAddress)translator.GetObject(L, 1, typeof(System.Net.IPAddress));
                    
                        bool gen_ret = System.Net.IPAddress.IsLoopback( 
                        _address );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _comparand = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( 
                        _comparand );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapToIPv6(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Net.IPAddress gen_ret = gen_to_be_invoked.MapToIPv6(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapToIPv4(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Net.IPAddress gen_ret = gen_to_be_invoked.MapToIPv4(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AddressFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsAddressFamily(L, gen_to_be_invoked.AddressFamily);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ScopeId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.ScopeId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsIPv6Multicast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsIPv6Multicast);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsIPv6LinkLocal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsIPv6LinkLocal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsIPv6SiteLocal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsIPv6SiteLocal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsIPv6Teredo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsIPv6Teredo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsIPv4MappedToIPv6(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsIPv4MappedToIPv6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ScopeId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPAddress gen_to_be_invoked = (System.Net.IPAddress)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ScopeId = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
