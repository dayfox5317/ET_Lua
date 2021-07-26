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
    public partial class SystemNetSocketsSocketWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Net.Sockets.Socket);
			Utils.BeginObjectRegister(type, L, translator, 0, 84, 23, 14);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Connect", _m_Connect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Send", _m_Send);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendFile", _m_SendFile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendTo", _m_SendTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Receive", _m_Receive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReceiveFrom", _m_ReceiveFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IOControl", _m_IOControl);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIPProtectionLevel", _m_SetIPProtectionLevel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginSendFile", _m_BeginSendFile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginConnect", _m_BeginConnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginSend", _m_BeginSend);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndSend", _m_EndSend);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginReceive", _m_BeginReceive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndReceive", _m_EndReceive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginAccept", _m_BeginAccept);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndAccept", _m_EndAccept);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Poll", _m_Poll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Accept", _m_Accept);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AcceptAsync", _m_AcceptAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Bind", _m_Bind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Listen", _m_Listen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConnectAsync", _m_ConnectAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndConnect", _m_EndConnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Disconnect", _m_Disconnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisconnectAsync", _m_DisconnectAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginDisconnect", _m_BeginDisconnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndDisconnect", _m_EndDisconnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReceiveAsync", _m_ReceiveAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReceiveFromAsync", _m_ReceiveFromAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginReceiveFrom", _m_BeginReceiveFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndReceiveFrom", _m_EndReceiveFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReceiveMessageFrom", _m_ReceiveMessageFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReceiveMessageFromAsync", _m_ReceiveMessageFromAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginReceiveMessageFrom", _m_BeginReceiveMessageFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndReceiveMessageFrom", _m_EndReceiveMessageFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendAsync", _m_SendAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendToAsync", _m_SendToAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginSendTo", _m_BeginSendTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndSendTo", _m_EndSendTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndSendFile", _m_EndSendFile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendPacketsAsync", _m_SendPacketsAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DuplicateAndClose", _m_DuplicateAndClose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSocketOption", _m_GetSocketOption);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSocketOption", _m_SetSocketOption);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Shutdown", _m_Shutdown);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHandle", _g_get_Handle);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getUseOnlyOverlappedIO", _g_get_UseOnlyOverlappedIO);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAddressFamily", _g_get_AddressFamily);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSocketType", _g_get_SocketType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getProtocolType", _g_get_ProtocolType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getExclusiveAddressUse", _g_get_ExclusiveAddressUse);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getReceiveBufferSize", _g_get_ReceiveBufferSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSendBufferSize", _g_get_SendBufferSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getReceiveTimeout", _g_get_ReceiveTimeout);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSendTimeout", _g_get_SendTimeout);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLingerState", _g_get_LingerState);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTtl", _g_get_Ttl);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDontFragment", _g_get_DontFragment);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDualMode", _g_get_DualMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAvailable", _g_get_Available);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEnableBroadcast", _g_get_EnableBroadcast);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsBound", _g_get_IsBound);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMulticastLoopback", _g_get_MulticastLoopback);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLocalEndPoint", _g_get_LocalEndPoint);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBlocking", _g_get_Blocking);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getConnected", _g_get_Connected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getNoDelay", _g_get_NoDelay);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRemoteEndPoint", _g_get_RemoteEndPoint);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setUseOnlyOverlappedIO", _s_set_UseOnlyOverlappedIO);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setExclusiveAddressUse", _s_set_ExclusiveAddressUse);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setReceiveBufferSize", _s_set_ReceiveBufferSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSendBufferSize", _s_set_SendBufferSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setReceiveTimeout", _s_set_ReceiveTimeout);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSendTimeout", _s_set_SendTimeout);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setLingerState", _s_set_LingerState);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTtl", _s_set_Ttl);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDontFragment", _s_set_DontFragment);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDualMode", _s_set_DualMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setEnableBroadcast", _s_set_EnableBroadcast);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMulticastLoopback", _s_set_MulticastLoopback);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setBlocking", _s_set_Blocking);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setNoDelay", _s_set_NoDelay);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Handle", _g_get_Handle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UseOnlyOverlappedIO", _g_get_UseOnlyOverlappedIO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AddressFamily", _g_get_AddressFamily);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SocketType", _g_get_SocketType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ProtocolType", _g_get_ProtocolType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ExclusiveAddressUse", _g_get_ExclusiveAddressUse);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReceiveBufferSize", _g_get_ReceiveBufferSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SendBufferSize", _g_get_SendBufferSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReceiveTimeout", _g_get_ReceiveTimeout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SendTimeout", _g_get_SendTimeout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LingerState", _g_get_LingerState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Ttl", _g_get_Ttl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DontFragment", _g_get_DontFragment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DualMode", _g_get_DualMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Available", _g_get_Available);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EnableBroadcast", _g_get_EnableBroadcast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBound", _g_get_IsBound);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MulticastLoopback", _g_get_MulticastLoopback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LocalEndPoint", _g_get_LocalEndPoint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Blocking", _g_get_Blocking);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Connected", _g_get_Connected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NoDelay", _g_get_NoDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RemoteEndPoint", _g_get_RemoteEndPoint);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "UseOnlyOverlappedIO", _s_set_UseOnlyOverlappedIO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ExclusiveAddressUse", _s_set_ExclusiveAddressUse);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ReceiveBufferSize", _s_set_ReceiveBufferSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SendBufferSize", _s_set_SendBufferSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ReceiveTimeout", _s_set_ReceiveTimeout);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SendTimeout", _s_set_SendTimeout);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LingerState", _s_set_LingerState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Ttl", _s_set_Ttl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DontFragment", _s_set_DontFragment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DualMode", _s_set_DualMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EnableBroadcast", _s_set_EnableBroadcast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MulticastLoopback", _s_set_MulticastLoopback);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Blocking", _s_set_Blocking);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "NoDelay", _s_set_NoDelay);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 2, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ConnectAsync", _m_ConnectAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Select", _m_Select_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CancelConnectAsync", _m_CancelConnectAsync_xlua_st_);
            
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getOSSupportsIPv4", _g_get_OSSupportsIPv4);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getOSSupportsIPv6", _g_get_OSSupportsIPv6);
            
			
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OSSupportsIPv4", _g_get_OSSupportsIPv4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OSSupportsIPv6", _g_get_OSSupportsIPv6);
            
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Net.Sockets.SocketType>(L, 2) && translator.Assignable<System.Net.Sockets.ProtocolType>(L, 3))
				{
					System.Net.Sockets.SocketType _socketType;translator.Get(L, 2, out _socketType);
					System.Net.Sockets.ProtocolType _protocolType;translator.Get(L, 3, out _protocolType);
					
					System.Net.Sockets.Socket gen_ret = new System.Net.Sockets.Socket(_socketType, _protocolType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<System.Net.Sockets.AddressFamily>(L, 2) && translator.Assignable<System.Net.Sockets.SocketType>(L, 3) && translator.Assignable<System.Net.Sockets.ProtocolType>(L, 4))
				{
					System.Net.Sockets.AddressFamily _addressFamily;translator.Get(L, 2, out _addressFamily);
					System.Net.Sockets.SocketType _socketType;translator.Get(L, 3, out _socketType);
					System.Net.Sockets.ProtocolType _protocolType;translator.Get(L, 4, out _protocolType);
					
					System.Net.Sockets.Socket gen_ret = new System.Net.Sockets.Socket(_addressFamily, _socketType, _protocolType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Net.Sockets.SocketInformation>(L, 2))
				{
					System.Net.Sockets.SocketInformation _socketInformation;translator.Get(L, 2, out _socketInformation);
					
					System.Net.Sockets.Socket gen_ret = new System.Net.Sockets.Socket(_socketInformation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Connect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Net.EndPoint>(L, 2)) 
                {
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 2, typeof(System.Net.EndPoint));
                    
                    gen_to_be_invoked.Connect( 
                        _remoteEP );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Net.IPAddress[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Net.IPAddress[] _addresses = (System.Net.IPAddress[])translator.GetObject(L, 2, typeof(System.Net.IPAddress[]));
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Connect( 
                        _addresses, 
                        _port );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Net.IPAddress>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Net.IPAddress _address = (System.Net.IPAddress)translator.GetObject(L, 2, typeof(System.Net.IPAddress));
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Connect( 
                        _address, 
                        _port );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _host = LuaAPI.lua_tostring(L, 2);
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Connect( 
                        _host, 
                        _port );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.Connect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Send(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffer );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffers );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffer, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffers, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 4)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 4, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffer, 
                        _size, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffers, 
                        _socketFlags, 
                        out _errorCode );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    
                        int gen_ret = gen_to_be_invoked.Send( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        out _errorCode );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.Send!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendFile(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _fileName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SendFile( 
                        _fileName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.Sockets.TransmitFileOptions>(L, 5)) 
                {
                    string _fileName = LuaAPI.lua_tostring(L, 2);
                    byte[] _preBuffer = LuaAPI.lua_tobytes(L, 3);
                    byte[] _postBuffer = LuaAPI.lua_tobytes(L, 4);
                    System.Net.Sockets.TransmitFileOptions _flags;translator.Get(L, 5, out _flags);
                    
                    gen_to_be_invoked.SendFile( 
                        _fileName, 
                        _preBuffer, 
                        _postBuffer, 
                        _flags );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.SendFile!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendTo(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.EndPoint>(L, 3)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 3, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.SendTo( 
                        _buffer, 
                        _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)&& translator.Assignable<System.Net.EndPoint>(L, 4)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 4, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.SendTo( 
                        _buffer, 
                        _socketFlags, 
                        _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 4)&& translator.Assignable<System.Net.EndPoint>(L, 5)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 4, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 5, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.SendTo( 
                        _buffer, 
                        _size, 
                        _socketFlags, 
                        _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)&& translator.Assignable<System.Net.EndPoint>(L, 6)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 6, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.SendTo( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.SendTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Receive(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffer );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffers );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffer, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffers, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 4)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 4, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffer, 
                        _size, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffers, 
                        _socketFlags, 
                        out _errorCode );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    
                        int gen_ret = gen_to_be_invoked.Receive( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        out _errorCode );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.Receive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReceiveFrom(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.EndPoint>(L, 3)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 3, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.ReceiveFrom( 
                        _buffer, 
                        ref _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _remoteEP);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)&& translator.Assignable<System.Net.EndPoint>(L, 4)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 4, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.ReceiveFrom( 
                        _buffer, 
                        _socketFlags, 
                        ref _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _remoteEP);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 4)&& translator.Assignable<System.Net.EndPoint>(L, 5)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 4, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 5, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.ReceiveFrom( 
                        _buffer, 
                        _size, 
                        _socketFlags, 
                        ref _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _remoteEP);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)&& translator.Assignable<System.Net.EndPoint>(L, 6)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 6, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.ReceiveFrom( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        ref _remoteEP );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _remoteEP);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.ReceiveFrom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IOControl(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    int _ioControlCode = LuaAPI.xlua_tointeger(L, 2);
                    byte[] _optionInValue = LuaAPI.lua_tobytes(L, 3);
                    byte[] _optionOutValue = LuaAPI.lua_tobytes(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.IOControl( 
                        _ioControlCode, 
                        _optionInValue, 
                        _optionOutValue );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.IOControlCode>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Net.Sockets.IOControlCode _ioControlCode;translator.Get(L, 2, out _ioControlCode);
                    byte[] _optionInValue = LuaAPI.lua_tobytes(L, 3);
                    byte[] _optionOutValue = LuaAPI.lua_tobytes(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.IOControl( 
                        _ioControlCode, 
                        _optionInValue, 
                        _optionOutValue );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.IOControl!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIPProtectionLevel(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.IPProtectionLevel _level;translator.Get(L, 2, out _level);
                    
                    gen_to_be_invoked.SetIPProtectionLevel( 
                        _level );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSendFile(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.AsyncCallback>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _fileName = LuaAPI.lua_tostring(L, 2);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 3);
                    object _state = translator.GetObject(L, 4, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSendFile( 
                        _fileName, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Net.Sockets.TransmitFileOptions>(L, 5)&& translator.Assignable<System.AsyncCallback>(L, 6)&& translator.Assignable<object>(L, 7)) 
                {
                    string _fileName = LuaAPI.lua_tostring(L, 2);
                    byte[] _preBuffer = LuaAPI.lua_tobytes(L, 3);
                    byte[] _postBuffer = LuaAPI.lua_tobytes(L, 4);
                    System.Net.Sockets.TransmitFileOptions _flags;translator.Get(L, 5, out _flags);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 6);
                    object _state = translator.GetObject(L, 7, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSendFile( 
                        _fileName, 
                        _preBuffer, 
                        _postBuffer, 
                        _flags, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.BeginSendFile!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginConnect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<System.Net.EndPoint>(L, 2)&& translator.Assignable<System.AsyncCallback>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 2, typeof(System.Net.EndPoint));
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 3);
                    object _state = translator.GetObject(L, 4, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginConnect( 
                        _remoteEP, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Net.IPAddress>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    System.Net.IPAddress _address = (System.Net.IPAddress)translator.GetObject(L, 2, typeof(System.Net.IPAddress));
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    System.AsyncCallback _requestCallback = translator.GetDelegate<System.AsyncCallback>(L, 4);
                    object _state = translator.GetObject(L, 5, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginConnect( 
                        _address, 
                        _port, 
                        _requestCallback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _host = LuaAPI.lua_tostring(L, 2);
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    System.AsyncCallback _requestCallback = translator.GetDelegate<System.AsyncCallback>(L, 4);
                    object _state = translator.GetObject(L, 5, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginConnect( 
                        _host, 
                        _port, 
                        _requestCallback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Net.IPAddress[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    System.Net.IPAddress[] _addresses = (System.Net.IPAddress[])translator.GetObject(L, 2, typeof(System.Net.IPAddress[]));
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    System.AsyncCallback _requestCallback = translator.GetDelegate<System.AsyncCallback>(L, 4);
                    object _state = translator.GetObject(L, 5, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginConnect( 
                        _addresses, 
                        _port, 
                        _requestCallback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.BeginConnect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSend(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 4);
                    object _state = translator.GetObject(L, 5, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSend( 
                        _buffers, 
                        _socketFlags, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 5)&& translator.Assignable<object>(L, 6)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 5);
                    object _state = translator.GetObject(L, 6, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSend( 
                        _buffers, 
                        _socketFlags, 
                        out _errorCode, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)&& translator.Assignable<System.AsyncCallback>(L, 6)&& translator.Assignable<object>(L, 7)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 6);
                    object _state = translator.GetObject(L, 7, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSend( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)&& translator.Assignable<System.AsyncCallback>(L, 7)&& translator.Assignable<object>(L, 8)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 7);
                    object _state = translator.GetObject(L, 8, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSend( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        out _errorCode, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.BeginSend!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSend(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.IAsyncResult>(L, 2)) 
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                        int gen_ret = gen_to_be_invoked.EndSend( 
                        _asyncResult );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.IAsyncResult>(L, 2)) 
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    System.Net.Sockets.SocketError _errorCode;
                    
                        int gen_ret = gen_to_be_invoked.EndSend( 
                        _asyncResult, 
                        out _errorCode );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.EndSend!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginReceive(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 4);
                    object _state = translator.GetObject(L, 5, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginReceive( 
                        _buffers, 
                        _socketFlags, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<System.Collections.Generic.IList<System.ArraySegment<byte>>>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 5)&& translator.Assignable<object>(L, 6)) 
                {
                    System.Collections.Generic.IList<System.ArraySegment<byte>> _buffers = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 5);
                    object _state = translator.GetObject(L, 6, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginReceive( 
                        _buffers, 
                        _socketFlags, 
                        out _errorCode, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)&& translator.Assignable<System.AsyncCallback>(L, 6)&& translator.Assignable<object>(L, 7)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 6);
                    object _state = translator.GetObject(L, 7, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginReceive( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Net.Sockets.SocketFlags>(L, 5)&& translator.Assignable<System.AsyncCallback>(L, 7)&& translator.Assignable<object>(L, 8)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.Sockets.SocketError _errorCode;
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 7);
                    object _state = translator.GetObject(L, 8, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginReceive( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        out _errorCode, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.BeginReceive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndReceive(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.IAsyncResult>(L, 2)) 
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                        int gen_ret = gen_to_be_invoked.EndReceive( 
                        _asyncResult );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.IAsyncResult>(L, 2)) 
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    System.Net.Sockets.SocketError _errorCode;
                    
                        int gen_ret = gen_to_be_invoked.EndReceive( 
                        _asyncResult, 
                        out _errorCode );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.PushSystemNetSocketsSocketError(L, _errorCode);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.EndReceive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginAccept(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.AsyncCallback>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 2);
                    object _state = translator.GetObject(L, 3, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginAccept( 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.AsyncCallback>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    int _receiveSize = LuaAPI.xlua_tointeger(L, 2);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 3);
                    object _state = translator.GetObject(L, 4, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginAccept( 
                        _receiveSize, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Net.Sockets.Socket>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.AsyncCallback>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    System.Net.Sockets.Socket _acceptSocket = (System.Net.Sockets.Socket)translator.GetObject(L, 2, typeof(System.Net.Sockets.Socket));
                    int _receiveSize = LuaAPI.xlua_tointeger(L, 3);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 4);
                    object _state = translator.GetObject(L, 5, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginAccept( 
                        _acceptSocket, 
                        _receiveSize, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.BeginAccept!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndAccept(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.IAsyncResult>(L, 2)) 
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                        System.Net.Sockets.Socket gen_ret = gen_to_be_invoked.EndAccept( 
                        _asyncResult );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.IAsyncResult>(L, 3)) 
                {
                    byte[] _buffer;
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 3, typeof(System.IAsyncResult));
                    
                        System.Net.Sockets.Socket gen_ret = gen_to_be_invoked.EndAccept( 
                        out _buffer, 
                        _asyncResult );
                        translator.Push(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _buffer);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& translator.Assignable<System.IAsyncResult>(L, 4)) 
                {
                    byte[] _buffer;
                    int _bytesTransferred;
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 4, typeof(System.IAsyncResult));
                    
                        System.Net.Sockets.Socket gen_ret = gen_to_be_invoked.EndAccept( 
                        out _buffer, 
                        out _bytesTransferred, 
                        _asyncResult );
                        translator.Push(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _buffer);
                        
                    LuaAPI.xlua_pushinteger(L, _bytesTransferred);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.EndAccept!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConnectAsync_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Net.Sockets.SocketType _socketType;translator.Get(L, 1, out _socketType);
                    System.Net.Sockets.ProtocolType _protocolType;translator.Get(L, 2, out _protocolType);
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 3, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = System.Net.Sockets.Socket.ConnectAsync( 
                        _socketType, 
                        _protocolType, 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Select_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.IList _checkRead = (System.Collections.IList)translator.GetObject(L, 1, typeof(System.Collections.IList));
                    System.Collections.IList _checkWrite = (System.Collections.IList)translator.GetObject(L, 2, typeof(System.Collections.IList));
                    System.Collections.IList _checkError = (System.Collections.IList)translator.GetObject(L, 3, typeof(System.Collections.IList));
                    int _microSeconds = LuaAPI.xlua_tointeger(L, 4);
                    
                    System.Net.Sockets.Socket.Select( 
                        _checkRead, 
                        _checkWrite, 
                        _checkError, 
                        _microSeconds );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Poll(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _microSeconds = LuaAPI.xlua_tointeger(L, 2);
                    System.Net.Sockets.SelectMode _mode;translator.Get(L, 3, out _mode);
                    
                        bool gen_ret = gen_to_be_invoked.Poll( 
                        _microSeconds, 
                        _mode );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Accept(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Net.Sockets.Socket gen_ret = gen_to_be_invoked.Accept(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AcceptAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.AcceptAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Bind(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.EndPoint _localEP = (System.Net.EndPoint)translator.GetObject(L, 2, typeof(System.Net.EndPoint));
                    
                    gen_to_be_invoked.Bind( 
                        _localEP );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Listen(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _backlog = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Listen( 
                        _backlog );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConnectAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.ConnectAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelConnectAsync_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 1, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                    System.Net.Sockets.Socket.CancelConnectAsync( 
                        _e );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndConnect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                    gen_to_be_invoked.EndConnect( 
                        _asyncResult );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Disconnect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _reuseSocket = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Disconnect( 
                        _reuseSocket );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisconnectAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.DisconnectAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginDisconnect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _reuseSocket = LuaAPI.lua_toboolean(L, 2);
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 3);
                    object _state = translator.GetObject(L, 4, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginDisconnect( 
                        _reuseSocket, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndDisconnect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                    gen_to_be_invoked.EndDisconnect( 
                        _asyncResult );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReceiveAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.ReceiveAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReceiveFromAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.ReceiveFromAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginReceiveFrom(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 6, typeof(System.Net.EndPoint));
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 7);
                    object _state = translator.GetObject(L, 8, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginReceiveFrom( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        ref _remoteEP, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    translator.Push(L, _remoteEP);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndReceiveFrom(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    System.Net.EndPoint _endPoint = (System.Net.EndPoint)translator.GetObject(L, 3, typeof(System.Net.EndPoint));
                    
                        int gen_ret = gen_to_be_invoked.EndReceiveFrom( 
                        _asyncResult, 
                        ref _endPoint );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _endPoint);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReceiveMessageFrom(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 6, typeof(System.Net.EndPoint));
                    System.Net.Sockets.IPPacketInformation _ipPacketInformation;
                    
                        int gen_ret = gen_to_be_invoked.ReceiveMessageFrom( 
                        _buffer, 
                        _offset, 
                        _size, 
                        ref _socketFlags, 
                        ref _remoteEP, 
                        out _ipPacketInformation );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _socketFlags);
                        
                    translator.Push(L, _remoteEP);
                        
                    translator.Push(L, _ipPacketInformation);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReceiveMessageFromAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.ReceiveMessageFromAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginReceiveMessageFrom(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 6, typeof(System.Net.EndPoint));
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 7);
                    object _state = translator.GetObject(L, 8, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginReceiveMessageFrom( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        ref _remoteEP, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    translator.Push(L, _remoteEP);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndReceiveMessageFrom(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 3, out _socketFlags);
                    System.Net.EndPoint _endPoint = (System.Net.EndPoint)translator.GetObject(L, 4, typeof(System.Net.EndPoint));
                    System.Net.Sockets.IPPacketInformation _ipPacketInformation;
                    
                        int gen_ret = gen_to_be_invoked.EndReceiveMessageFrom( 
                        _asyncResult, 
                        ref _socketFlags, 
                        ref _endPoint, 
                        out _ipPacketInformation );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _socketFlags);
                        
                    translator.Push(L, _endPoint);
                        
                    translator.Push(L, _ipPacketInformation);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.SendAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendToAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.SendToAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSendTo(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    System.Net.Sockets.SocketFlags _socketFlags;translator.Get(L, 5, out _socketFlags);
                    System.Net.EndPoint _remoteEP = (System.Net.EndPoint)translator.GetObject(L, 6, typeof(System.Net.EndPoint));
                    System.AsyncCallback _callback = translator.GetDelegate<System.AsyncCallback>(L, 7);
                    object _state = translator.GetObject(L, 8, typeof(object));
                    
                        System.IAsyncResult gen_ret = gen_to_be_invoked.BeginSendTo( 
                        _buffer, 
                        _offset, 
                        _size, 
                        _socketFlags, 
                        _remoteEP, 
                        _callback, 
                        _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSendTo(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                        int gen_ret = gen_to_be_invoked.EndSendTo( 
                        _asyncResult );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSendFile(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IAsyncResult _asyncResult = (System.IAsyncResult)translator.GetObject(L, 2, typeof(System.IAsyncResult));
                    
                    gen_to_be_invoked.EndSendFile( 
                        _asyncResult );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendPacketsAsync(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketAsyncEventArgs _e = (System.Net.Sockets.SocketAsyncEventArgs)translator.GetObject(L, 2, typeof(System.Net.Sockets.SocketAsyncEventArgs));
                    
                        bool gen_ret = gen_to_be_invoked.SendPacketsAsync( 
                        _e );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DuplicateAndClose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _targetProcessId = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.Net.Sockets.SocketInformation gen_ret = gen_to_be_invoked.DuplicateAndClose( 
                        _targetProcessId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSocketOption(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    
                        object gen_ret = gen_to_be_invoked.GetSocketOption( 
                        _optionLevel, 
                        _optionName );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    int _optionLength = LuaAPI.xlua_tointeger(L, 4);
                    
                        byte[] gen_ret = gen_to_be_invoked.GetSocketOption( 
                        _optionLevel, 
                        _optionName, 
                        _optionLength );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    byte[] _optionValue = LuaAPI.lua_tobytes(L, 4);
                    
                    gen_to_be_invoked.GetSocketOption( 
                        _optionLevel, 
                        _optionName, 
                        _optionValue );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.GetSocketOption!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSocketOption(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    bool _optionValue = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.SetSocketOption( 
                        _optionLevel, 
                        _optionName, 
                        _optionValue );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    int _optionValue = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetSocketOption( 
                        _optionLevel, 
                        _optionName, 
                        _optionValue );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    byte[] _optionValue = LuaAPI.lua_tobytes(L, 4);
                    
                    gen_to_be_invoked.SetSocketOption( 
                        _optionLevel, 
                        _optionName, 
                        _optionValue );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Net.Sockets.SocketOptionLevel>(L, 2)&& translator.Assignable<System.Net.Sockets.SocketOptionName>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    System.Net.Sockets.SocketOptionLevel _optionLevel;translator.Get(L, 2, out _optionLevel);
                    System.Net.Sockets.SocketOptionName _optionName;translator.Get(L, 3, out _optionName);
                    object _optionValue = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.SetSocketOption( 
                        _optionLevel, 
                        _optionName, 
                        _optionValue );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.SetSocketOption!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _timeout = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Close( 
                        _timeout );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.Socket.Close!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Shutdown(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Net.Sockets.SocketShutdown _how;translator.Get(L, 2, out _how);
                    
                    gen_to_be_invoked.Shutdown( 
                        _how );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OSSupportsIPv4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Net.Sockets.Socket.OSSupportsIPv4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OSSupportsIPv6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Net.Sockets.Socket.OSSupportsIPv6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Handle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushlightuserdata(L, gen_to_be_invoked.Handle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UseOnlyOverlappedIO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.UseOnlyOverlappedIO);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AddressFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsAddressFamily(L, gen_to_be_invoked.AddressFamily);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SocketType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsSocketType(L, gen_to_be_invoked.SocketType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ProtocolType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsProtocolType(L, gen_to_be_invoked.ProtocolType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ExclusiveAddressUse(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ExclusiveAddressUse);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReceiveBufferSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ReceiveBufferSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SendBufferSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SendBufferSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReceiveTimeout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ReceiveTimeout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SendTimeout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SendTimeout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LingerState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LingerState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ttl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Ttl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DontFragment(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.DontFragment);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DualMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.DualMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Available(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Available);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EnableBroadcast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.EnableBroadcast);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBound);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MulticastLoopback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.MulticastLoopback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalEndPoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LocalEndPoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Blocking(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Blocking);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Connected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Connected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NoDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.NoDelay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RemoteEndPoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RemoteEndPoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UseOnlyOverlappedIO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UseOnlyOverlappedIO = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ExclusiveAddressUse(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ExclusiveAddressUse = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ReceiveBufferSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ReceiveBufferSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SendBufferSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SendBufferSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ReceiveTimeout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ReceiveTimeout = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SendTimeout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SendTimeout = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LingerState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LingerState = (System.Net.Sockets.LingerOption)translator.GetObject(L, 2, typeof(System.Net.Sockets.LingerOption));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Ttl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Ttl = (short)LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DontFragment(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DontFragment = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DualMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DualMode = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EnableBroadcast(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EnableBroadcast = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MulticastLoopback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MulticastLoopback = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Blocking(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Blocking = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NoDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.Socket gen_to_be_invoked = (System.Net.Sockets.Socket)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.NoDelay = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
