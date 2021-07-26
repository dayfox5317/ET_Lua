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
    public partial class SystemNetEndPointWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Net.EndPoint);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 1, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Serialize", _m_Serialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAddressFamily", _g_get_AddressFamily);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AddressFamily", _g_get_AddressFamily);
            
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.Net.EndPoint does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Serialize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.EndPoint gen_to_be_invoked = (System.Net.EndPoint)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                System.Net.EndPoint gen_to_be_invoked = (System.Net.EndPoint)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_AddressFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.EndPoint gen_to_be_invoked = (System.Net.EndPoint)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsAddressFamily(L, gen_to_be_invoked.AddressFamily);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
