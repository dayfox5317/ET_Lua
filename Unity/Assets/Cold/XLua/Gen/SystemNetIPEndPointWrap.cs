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
    public partial class SystemNetIPEndPointWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Net.IPEndPoint);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 3, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Serialize", _m_Serialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAddressFamily", _g_get_AddressFamily);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAddress", _g_get_Address);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPort", _g_get_Port);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAddress", _s_set_Address);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setPort", _s_set_Port);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AddressFamily", _g_get_AddressFamily);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Address", _g_get_Address);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Port", _g_get_Port);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Address", _s_set_Address);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Port", _s_set_Port);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getMinPort", System.Net.IPEndPoint.MinPort);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getMaxPort", System.Net.IPEndPoint.MaxPort);
            
			
			
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MinPort", System.Net.IPEndPoint.MinPort);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxPort", System.Net.IPEndPoint.MaxPort);
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2)) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					long _address = LuaAPI.lua_toint64(L, 2);
					int _port = LuaAPI.xlua_tointeger(L, 3);
					
					System.Net.IPEndPoint gen_ret = new System.Net.IPEndPoint(_address, _port);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Net.IPAddress>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					System.Net.IPAddress _address = (System.Net.IPAddress)translator.GetObject(L, 2, typeof(System.Net.IPAddress));
					int _port = LuaAPI.xlua_tointeger(L, 3);
					
					System.Net.IPEndPoint gen_ret = new System.Net.IPEndPoint(_address, _port);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.IPEndPoint constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_Serialize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Net.SocketAddress gen_ret = gen_to_be_invoked.Serialize(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.SocketAddress _socketAddress = (System.Net.SocketAddress)translator.GetObject(L, 2, typeof(System.Net.SocketAddress));
                    
                        System.Net.EndPoint gen_ret = gen_to_be_invoked.Create( 
                        _socketAddress );
                        translator.Push(L, gen_ret);
                    
                    
                    
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
            
            
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_AddressFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsAddressFamily(L, gen_to_be_invoked.AddressFamily);
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
			
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Address);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Port(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Port);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Address(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Address = (System.Net.IPAddress)translator.GetObject(L, 2, typeof(System.Net.IPAddress));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Port(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.IPEndPoint gen_to_be_invoked = (System.Net.IPEndPoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Port = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
