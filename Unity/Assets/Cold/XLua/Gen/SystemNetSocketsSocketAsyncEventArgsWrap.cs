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
    public partial class SystemNetSocketsSocketAsyncEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Net.Sockets.SocketAsyncEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 33, 18, 10);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBuffer", _m_SetBuffer);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getConnectByNameError", _g_get_ConnectByNameError);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAcceptSocket", _g_get_AcceptSocket);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBuffer", _g_get_Buffer);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBufferList", _g_get_BufferList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBytesTransferred", _g_get_BytesTransferred);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCount", _g_get_Count);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDisconnectReuseSocket", _g_get_DisconnectReuseSocket);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLastOperation", _g_get_LastOperation);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOffset", _g_get_Offset);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRemoteEndPoint", _g_get_RemoteEndPoint);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getReceiveMessageFromPacketInfo", _g_get_ReceiveMessageFromPacketInfo);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSendPacketsElements", _g_get_SendPacketsElements);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSendPacketsFlags", _g_get_SendPacketsFlags);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSendPacketsSendSize", _g_get_SendPacketsSendSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSocketError", _g_get_SocketError);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSocketFlags", _g_get_SocketFlags);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getUserToken", _g_get_UserToken);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getConnectSocket", _g_get_ConnectSocket);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAcceptSocket", _s_set_AcceptSocket);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setBufferList", _s_set_BufferList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDisconnectReuseSocket", _s_set_DisconnectReuseSocket);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRemoteEndPoint", _s_set_RemoteEndPoint);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSendPacketsElements", _s_set_SendPacketsElements);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSendPacketsFlags", _s_set_SendPacketsFlags);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSendPacketsSendSize", _s_set_SendPacketsSendSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSocketError", _s_set_SocketError);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSocketFlags", _s_set_SocketFlags);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setUserToken", _s_set_UserToken);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addCompleted", _e_add_Completed);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeCompleted", _e_remove_Completed);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Completed", _e_Completed);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ConnectByNameError", _g_get_ConnectByNameError);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AcceptSocket", _g_get_AcceptSocket);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Buffer", _g_get_Buffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BufferList", _g_get_BufferList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BytesTransferred", _g_get_BytesTransferred);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DisconnectReuseSocket", _g_get_DisconnectReuseSocket);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LastOperation", _g_get_LastOperation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Offset", _g_get_Offset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RemoteEndPoint", _g_get_RemoteEndPoint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReceiveMessageFromPacketInfo", _g_get_ReceiveMessageFromPacketInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SendPacketsElements", _g_get_SendPacketsElements);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SendPacketsFlags", _g_get_SendPacketsFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SendPacketsSendSize", _g_get_SendPacketsSendSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SocketError", _g_get_SocketError);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SocketFlags", _g_get_SocketFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UserToken", _g_get_UserToken);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ConnectSocket", _g_get_ConnectSocket);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "AcceptSocket", _s_set_AcceptSocket);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "BufferList", _s_set_BufferList);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DisconnectReuseSocket", _s_set_DisconnectReuseSocket);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RemoteEndPoint", _s_set_RemoteEndPoint);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SendPacketsElements", _s_set_SendPacketsElements);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SendPacketsFlags", _s_set_SendPacketsFlags);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SendPacketsSendSize", _s_set_SendPacketsSendSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SocketError", _s_set_SocketError);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SocketFlags", _s_set_SocketFlags);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UserToken", _s_set_UserToken);
            
			
			
			
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
					
					System.Net.Sockets.SocketAsyncEventArgs gen_ret = new System.Net.Sockets.SocketAsyncEventArgs();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.SocketAsyncEventArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBuffer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _count = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetBuffer( 
                        _offset, 
                        _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetBuffer( 
                        _buffer, 
                        _offset, 
                        _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.SocketAsyncEventArgs.SetBuffer!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConnectByNameError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ConnectByNameError);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AcceptSocket(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AcceptSocket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Buffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Buffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BufferList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.BufferList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BytesTransferred(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.BytesTransferred);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DisconnectReuseSocket(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.DisconnectReuseSocket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LastOperation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsSocketAsyncOperation(L, gen_to_be_invoked.LastOperation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Offset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Offset);
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
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RemoteEndPoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReceiveMessageFromPacketInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ReceiveMessageFromPacketInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SendPacketsElements(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SendPacketsElements);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SendPacketsFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SendPacketsFlags);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SendPacketsSendSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SendPacketsSendSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SocketError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushSystemNetSocketsSocketError(L, gen_to_be_invoked.SocketError);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SocketFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SocketFlags);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UserToken(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.UserToken);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConnectSocket(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ConnectSocket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AcceptSocket(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AcceptSocket = (System.Net.Sockets.Socket)translator.GetObject(L, 2, typeof(System.Net.Sockets.Socket));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BufferList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BufferList = (System.Collections.Generic.IList<System.ArraySegment<byte>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.ArraySegment<byte>>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DisconnectReuseSocket(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DisconnectReuseSocket = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RemoteEndPoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.RemoteEndPoint = (System.Net.EndPoint)translator.GetObject(L, 2, typeof(System.Net.EndPoint));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SendPacketsElements(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SendPacketsElements = (System.Net.Sockets.SendPacketsElement[])translator.GetObject(L, 2, typeof(System.Net.Sockets.SendPacketsElement[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SendPacketsFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                System.Net.Sockets.TransmitFileOptions gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.SendPacketsFlags = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SendPacketsSendSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SendPacketsSendSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SocketError(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                System.Net.Sockets.SocketError gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.SocketError = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SocketFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                System.Net.Sockets.SocketFlags gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.SocketFlags = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UserToken(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UserToken = translator.GetObject(L, 2, typeof(object));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Completed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
                System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Completed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Completed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.SocketAsyncEventArgs.Completed!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Completed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
				System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Completed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.SocketAsyncEventArgs.Completed!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Completed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			System.Net.Sockets.SocketAsyncEventArgs gen_to_be_invoked = (System.Net.Sockets.SocketAsyncEventArgs)translator.FastGetCSObj(L, 1);
				System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Completed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to System.Net.Sockets.SocketAsyncEventArgs.Completed!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
