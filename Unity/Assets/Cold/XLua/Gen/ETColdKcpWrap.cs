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
    public partial class ETColdKcpWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.Kcp);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 24, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpCheck", _m_KcpCheck_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpCreate", _m_KcpCreate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpFlush", _m_KcpFlush_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpGetconv", _m_KcpGetconv_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpInput", _m_KcpInput_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpNodelay", _m_KcpNodelay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpPeeksize", _m_KcpPeeksize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpRecv", _m_KcpRecv_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpRelease", _m_KcpRelease_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpSend", _m_KcpSend_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpSetminrto", _m_KcpSetminrto_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpSetmtu", _m_KcpSetmtu_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpSetoutput", _m_KcpSetoutput_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpSetLog", _m_KcpSetLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpUpdate", _m_KcpUpdate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpWaitsnd", _m_KcpWaitsnd_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpWndsize", _m_KcpWndsize_xlua_st_);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getOneM", ETCold.Kcp.OneM);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getInnerMaxWaitSize", ETCold.Kcp.InnerMaxWaitSize);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getOuterMaxWaitSize", ETCold.Kcp.OuterMaxWaitSize);
            
			
			
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OneM", ETCold.Kcp.OneM);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InnerMaxWaitSize", ETCold.Kcp.InnerMaxWaitSize);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OuterMaxWaitSize", ETCold.Kcp.OuterMaxWaitSize);
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.Kcp does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpCheck_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    uint _current = LuaAPI.xlua_touint(L, 2);
                    
                        uint gen_ret = ETCold.Kcp.KcpCheck( 
                        _kcp, 
                        _current );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpCreate_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    uint _conv = LuaAPI.xlua_touint(L, 1);
                    System.IntPtr _user = LuaAPI.lua_touserdata(L, 2);
                    
                        System.IntPtr gen_ret = ETCold.Kcp.KcpCreate( 
                        _conv, 
                        _user );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpFlush_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    
                    ETCold.Kcp.KcpFlush( 
                        _kcp );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpGetconv_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _ptr = LuaAPI.lua_touserdata(L, 1);
                    
                        uint gen_ret = ETCold.Kcp.KcpGetconv( 
                        _ptr );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpInput_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _len = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = ETCold.Kcp.KcpInput( 
                        _kcp, 
                        _buffer, 
                        _offset, 
                        _len );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpNodelay_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    int _nodelay = LuaAPI.xlua_tointeger(L, 2);
                    int _interval = LuaAPI.xlua_tointeger(L, 3);
                    int _resend = LuaAPI.xlua_tointeger(L, 4);
                    int _nc = LuaAPI.xlua_tointeger(L, 5);
                    
                        int gen_ret = ETCold.Kcp.KcpNodelay( 
                        _kcp, 
                        _nodelay, 
                        _interval, 
                        _resend, 
                        _nc );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpPeeksize_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = ETCold.Kcp.KcpPeeksize( 
                        _kcp );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpRecv_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _len = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = ETCold.Kcp.KcpRecv( 
                        _kcp, 
                        _buffer, 
                        _len );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpRelease_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    
                    ETCold.Kcp.KcpRelease( 
                        _kcp );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpSend_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _len = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = ETCold.Kcp.KcpSend( 
                        _kcp, 
                        _buffer, 
                        _offset, 
                        _len );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpSetminrto_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    int _minrto = LuaAPI.xlua_tointeger(L, 2);
                    
                    ETCold.Kcp.KcpSetminrto( 
                        _kcp, 
                        _minrto );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpSetmtu_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    int _mtu = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = ETCold.Kcp.KcpSetmtu( 
                        _kcp, 
                        _mtu );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpSetoutput_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ETCold.KcpOutput _output = translator.GetDelegate<ETCold.KcpOutput>(L, 1);
                    
                    ETCold.Kcp.KcpSetoutput( 
                        _output );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpSetLog_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ETCold.KcpLog _kcpLog = translator.GetDelegate<ETCold.KcpLog>(L, 1);
                    
                    ETCold.Kcp.KcpSetLog( 
                        _kcpLog );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpUpdate_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    uint _current = LuaAPI.xlua_touint(L, 2);
                    
                    ETCold.Kcp.KcpUpdate( 
                        _kcp, 
                        _current );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpWaitsnd_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = ETCold.Kcp.KcpWaitsnd( 
                        _kcp );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpWndsize_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 1);
                    int _sndwnd = LuaAPI.xlua_tointeger(L, 2);
                    int _rcvwnd = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = ETCold.Kcp.KcpWndsize( 
                        _kcp, 
                        _sndwnd, 
                        _rcvwnd );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
