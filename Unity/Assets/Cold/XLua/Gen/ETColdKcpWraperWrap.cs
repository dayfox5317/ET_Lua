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
    public partial class ETColdKcpWraperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.KcpWraper);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 1, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Check", _m_Check);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WndSize", _m_WndSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Recv", _m_Recv);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Peeksize", _m_Peeksize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Waitsnd", _m_Waitsnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Input", _m_Input);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Nodelay", _m_Nodelay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Send", _m_Send);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setminrto", _m_Setminrto);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setmtu", _m_Setmtu);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEnable", _m_IsEnable);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getInstance", _g_get_Instance);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setInstance", _s_set_Instance);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Instance", _g_get_Instance);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Instance", _s_set_Instance);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetOutput", _m_SetOutput_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Log", _m_Log_xlua_st_);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					uint _conn = LuaAPI.xlua_touint(L, 2);
					uint _usr = LuaAPI.xlua_touint(L, 3);
					
					ETCold.KcpWraper gen_ret = new ETCold.KcpWraper(_conn, _usr);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.KcpWraper constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Check(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _c = LuaAPI.xlua_touint(L, 2);
                    
                        uint gen_ret = gen_to_be_invoked.Check( 
                        _c );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WndSize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _a = LuaAPI.xlua_tointeger(L, 2);
                    int _b = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = gen_to_be_invoked.WndSize( 
                        _a, 
                        _b );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _c = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.Update( 
                        _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOutput_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Func<byte[], uint, int> _c = translator.GetDelegate<System.Func<byte[], uint, int>>(L, 1);
                    
                    ETCold.KcpWraper.SetOutput( 
                        _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Recv(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _data = LuaAPI.lua_tobytes(L, 2);
                    int _len = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = gen_to_be_invoked.Recv( 
                        _data, 
                        _len );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Peeksize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.Peeksize(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Waitsnd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.Waitsnd(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Input(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _data = LuaAPI.lua_tobytes(L, 2);
                    int _off = LuaAPI.xlua_tointeger(L, 3);
                    int _len = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.Input( 
                        _data, 
                        _off, 
                        _len );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Nodelay(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _a = LuaAPI.xlua_tointeger(L, 2);
                    int _b = LuaAPI.xlua_tointeger(L, 3);
                    int _c = LuaAPI.xlua_tointeger(L, 4);
                    int _d = LuaAPI.xlua_tointeger(L, 5);
                    
                        int gen_ret = gen_to_be_invoked.Nodelay( 
                        _a, 
                        _b, 
                        _c, 
                        _d );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Send(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _data = LuaAPI.lua_tobytes(L, 2);
                    int _off = LuaAPI.xlua_tointeger(L, 3);
                    int _len = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _data, 
                        _off, 
                        _len );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Setminrto(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _c = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Setminrto( 
                        _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Setmtu(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _c = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.Setmtu( 
                        _c );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Log_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Action<string> _action = translator.GetDelegate<System.Action<string>>(L, 1);
                    
                    ETCold.KcpWraper.Log( 
                        _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsEnable(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsEnable(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushlightuserdata(L, gen_to_be_invoked.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.KcpWraper gen_to_be_invoked = (ETCold.KcpWraper)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Instance = LuaAPI.lua_touserdata(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
