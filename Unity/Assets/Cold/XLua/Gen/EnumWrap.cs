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
    
    public class SystemNetSocketsAddressFamilyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.AddressFamily), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.AddressFamily), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.AddressFamily), L, null, 32, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", System.Net.Sockets.AddressFamily.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unspecified", System.Net.Sockets.AddressFamily.Unspecified);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unix", System.Net.Sockets.AddressFamily.Unix);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InterNetwork", System.Net.Sockets.AddressFamily.InterNetwork);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ImpLink", System.Net.Sockets.AddressFamily.ImpLink);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pup", System.Net.Sockets.AddressFamily.Pup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Chaos", System.Net.Sockets.AddressFamily.Chaos);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NS", System.Net.Sockets.AddressFamily.NS);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ipx", System.Net.Sockets.AddressFamily.Ipx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Iso", System.Net.Sockets.AddressFamily.Iso);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Osi", System.Net.Sockets.AddressFamily.Osi);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ecma", System.Net.Sockets.AddressFamily.Ecma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DataKit", System.Net.Sockets.AddressFamily.DataKit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ccitt", System.Net.Sockets.AddressFamily.Ccitt);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sna", System.Net.Sockets.AddressFamily.Sna);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecNet", System.Net.Sockets.AddressFamily.DecNet);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DataLink", System.Net.Sockets.AddressFamily.DataLink);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lat", System.Net.Sockets.AddressFamily.Lat);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HyperChannel", System.Net.Sockets.AddressFamily.HyperChannel);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AppleTalk", System.Net.Sockets.AddressFamily.AppleTalk);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetBios", System.Net.Sockets.AddressFamily.NetBios);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VoiceView", System.Net.Sockets.AddressFamily.VoiceView);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FireFox", System.Net.Sockets.AddressFamily.FireFox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Banyan", System.Net.Sockets.AddressFamily.Banyan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Atm", System.Net.Sockets.AddressFamily.Atm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InterNetworkV6", System.Net.Sockets.AddressFamily.InterNetworkV6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cluster", System.Net.Sockets.AddressFamily.Cluster);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ieee12844", System.Net.Sockets.AddressFamily.Ieee12844);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Irda", System.Net.Sockets.AddressFamily.Irda);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetworkDesigners", System.Net.Sockets.AddressFamily.NetworkDesigners);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Max", System.Net.Sockets.AddressFamily.Max);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.AddressFamily), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsAddressFamily(L, (System.Net.Sockets.AddressFamily)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unspecified"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Unspecified);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unix"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Unix);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InterNetwork"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.InterNetwork);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ImpLink"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.ImpLink);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pup"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Pup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Chaos"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Chaos);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NS"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.NS);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ipx"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ipx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Iso"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Iso);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Osi"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Osi);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ecma"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ecma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DataKit"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.DataKit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ccitt"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ccitt);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sna"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Sna);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecNet"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.DecNet);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DataLink"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.DataLink);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lat"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Lat);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HyperChannel"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.HyperChannel);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AppleTalk"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.AppleTalk);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetBios"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.NetBios);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VoiceView"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.VoiceView);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FireFox"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.FireFox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Banyan"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Banyan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Atm"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Atm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InterNetworkV6"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.InterNetworkV6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cluster"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Cluster);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ieee12844"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Ieee12844);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Irda"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Irda);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetworkDesigners"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.NetworkDesigners);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Max"))
                {
                    translator.PushSystemNetSocketsAddressFamily(L, System.Net.Sockets.AddressFamily.Max);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.AddressFamily!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.AddressFamily! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemNetSocketsSocketTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.SocketType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.SocketType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.SocketType), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stream", System.Net.Sockets.SocketType.Stream);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dgram", System.Net.Sockets.SocketType.Dgram);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raw", System.Net.Sockets.SocketType.Raw);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rdm", System.Net.Sockets.SocketType.Rdm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Seqpacket", System.Net.Sockets.SocketType.Seqpacket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", System.Net.Sockets.SocketType.Unknown);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.SocketType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsSocketType(L, (System.Net.Sockets.SocketType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stream"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Stream);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dgram"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Dgram);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raw"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Raw);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rdm"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Rdm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Seqpacket"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Seqpacket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushSystemNetSocketsSocketType(L, System.Net.Sockets.SocketType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.SocketType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.SocketType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemNetSocketsProtocolTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.ProtocolType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.ProtocolType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.ProtocolType), L, null, 26, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IP", System.Net.Sockets.ProtocolType.IP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6HopByHopOptions", System.Net.Sockets.ProtocolType.IPv6HopByHopOptions);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Icmp", System.Net.Sockets.ProtocolType.Icmp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Igmp", System.Net.Sockets.ProtocolType.Igmp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ggp", System.Net.Sockets.ProtocolType.Ggp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv4", System.Net.Sockets.ProtocolType.IPv4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tcp", System.Net.Sockets.ProtocolType.Tcp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pup", System.Net.Sockets.ProtocolType.Pup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Udp", System.Net.Sockets.ProtocolType.Udp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Idp", System.Net.Sockets.ProtocolType.Idp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6", System.Net.Sockets.ProtocolType.IPv6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6RoutingHeader", System.Net.Sockets.ProtocolType.IPv6RoutingHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6FragmentHeader", System.Net.Sockets.ProtocolType.IPv6FragmentHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPSecEncapsulatingSecurityPayload", System.Net.Sockets.ProtocolType.IPSecEncapsulatingSecurityPayload);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPSecAuthenticationHeader", System.Net.Sockets.ProtocolType.IPSecAuthenticationHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IcmpV6", System.Net.Sockets.ProtocolType.IcmpV6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6NoNextHeader", System.Net.Sockets.ProtocolType.IPv6NoNextHeader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IPv6DestinationOptions", System.Net.Sockets.ProtocolType.IPv6DestinationOptions);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ND", System.Net.Sockets.ProtocolType.ND);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raw", System.Net.Sockets.ProtocolType.Raw);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unspecified", System.Net.Sockets.ProtocolType.Unspecified);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ipx", System.Net.Sockets.ProtocolType.Ipx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Spx", System.Net.Sockets.ProtocolType.Spx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpxII", System.Net.Sockets.ProtocolType.SpxII);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", System.Net.Sockets.ProtocolType.Unknown);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.ProtocolType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsProtocolType(L, (System.Net.Sockets.ProtocolType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "IP"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6HopByHopOptions"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6HopByHopOptions);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Icmp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Icmp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Igmp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Igmp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ggp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Ggp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv4"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tcp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Tcp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pup"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Pup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Udp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Udp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Idp"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Idp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6RoutingHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6RoutingHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6FragmentHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6FragmentHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPSecEncapsulatingSecurityPayload"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPSecEncapsulatingSecurityPayload);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPSecAuthenticationHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPSecAuthenticationHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IcmpV6"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IcmpV6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6NoNextHeader"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6NoNextHeader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IPv6DestinationOptions"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.IPv6DestinationOptions);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ND"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.ND);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raw"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Raw);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unspecified"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Unspecified);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ipx"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Ipx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Spx"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Spx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpxII"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.SpxII);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushSystemNetSocketsProtocolType(L, System.Net.Sockets.ProtocolType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.ProtocolType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.ProtocolType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRectTransformAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RectTransform.Axis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RectTransform.Axis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RectTransform.Axis), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.RectTransform.Axis.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.RectTransform.Axis.Vertical);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RectTransform.Axis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRectTransformAxis(L, (UnityEngine.RectTransform.Axis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineRectTransformAxis(L, UnityEngine.RectTransform.Axis.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineRectTransformAxis(L, UnityEngine.RectTransform.Axis.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RectTransform.Axis!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RectTransform.Axis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineRectTransformEdgeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.RectTransform.Edge), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.RectTransform.Edge), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.RectTransform.Edge), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.RectTransform.Edge.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.RectTransform.Edge.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.RectTransform.Edge.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.RectTransform.Edge.Bottom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.RectTransform.Edge), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineRectTransformEdge(L, (UnityEngine.RectTransform.Edge)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineRectTransformEdge(L, UnityEngine.RectTransform.Edge.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.RectTransform.Edge!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.RectTransform.Edge! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISelectableTransitionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Selectable.Transition), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Selectable.Transition.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorTint", UnityEngine.UI.Selectable.Transition.ColorTint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpriteSwap", UnityEngine.UI.Selectable.Transition.SpriteSwap);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Animation", UnityEngine.UI.Selectable.Transition.Animation);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISelectableTransition(L, (UnityEngine.UI.Selectable.Transition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorTint"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.ColorTint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpriteSwap"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.SpriteSwap);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Animation"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.Animation);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Selectable.Transition!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Selectable.Transition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemIOSeekOriginWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.IO.SeekOrigin), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.IO.SeekOrigin), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.IO.SeekOrigin), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Begin", System.IO.SeekOrigin.Begin);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Current", System.IO.SeekOrigin.Current);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "End", System.IO.SeekOrigin.End);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.IO.SeekOrigin), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemIOSeekOrigin(L, (System.IO.SeekOrigin)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Begin"))
                {
                    translator.PushSystemIOSeekOrigin(L, System.IO.SeekOrigin.Begin);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Current"))
                {
                    translator.PushSystemIOSeekOrigin(L, System.IO.SeekOrigin.Current);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "End"))
                {
                    translator.PushSystemIOSeekOrigin(L, System.IO.SeekOrigin.End);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.IO.SeekOrigin!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.IO.SeekOrigin! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTexture2DEXRFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.Texture2D.EXRFlags.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutputAsFloat", UnityEngine.Texture2D.EXRFlags.OutputAsFloat);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressZIP", UnityEngine.Texture2D.EXRFlags.CompressZIP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressRLE", UnityEngine.Texture2D.EXRFlags.CompressRLE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CompressPIZ", UnityEngine.Texture2D.EXRFlags.CompressPIZ);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Texture2D.EXRFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTexture2DEXRFlags(L, (UnityEngine.Texture2D.EXRFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutputAsFloat"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.OutputAsFloat);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressZIP"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.CompressZIP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressRLE"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.CompressRLE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CompressPIZ"))
                {
                    translator.PushUnityEngineTexture2DEXRFlags(L, UnityEngine.Texture2D.EXRFlags.CompressPIZ);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Texture2D.EXRFlags!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Texture2D.EXRFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class libxLoadStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(libx.LoadState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(libx.LoadState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(libx.LoadState), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Init", libx.LoadState.Init);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LoadAssetBundle", libx.LoadState.LoadAssetBundle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LoadAsset", libx.LoadState.LoadAsset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loaded", libx.LoadState.Loaded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unload", libx.LoadState.Unload);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(libx.LoadState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushlibxLoadState(L, (libx.LoadState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Init"))
                {
                    translator.PushlibxLoadState(L, libx.LoadState.Init);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LoadAssetBundle"))
                {
                    translator.PushlibxLoadState(L, libx.LoadState.LoadAssetBundle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LoadAsset"))
                {
                    translator.PushlibxLoadState(L, libx.LoadState.LoadAsset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loaded"))
                {
                    translator.PushlibxLoadState(L, libx.LoadState.Loaded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unload"))
                {
                    translator.PushlibxLoadState(L, libx.LoadState.Unload);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for libx.LoadState!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for libx.LoadState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class libxVerifyByWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(libx.VerifyBy), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(libx.VerifyBy), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(libx.VerifyBy), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", libx.VerifyBy.Size);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hash", libx.VerifyBy.Hash);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(libx.VerifyBy), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushlibxVerifyBy(L, (libx.VerifyBy)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushlibxVerifyBy(L, libx.VerifyBy.Size);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hash"))
                {
                    translator.PushlibxVerifyBy(L, libx.VerifyBy.Hash);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for libx.VerifyBy!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for libx.VerifyBy! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class BattlehubUIControlsItemDropActionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Battlehub.UIControls.ItemDropAction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Battlehub.UIControls.ItemDropAction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Battlehub.UIControls.ItemDropAction), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", Battlehub.UIControls.ItemDropAction.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetLastChild", Battlehub.UIControls.ItemDropAction.SetLastChild);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetPrevSibling", Battlehub.UIControls.ItemDropAction.SetPrevSibling);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetNextSibling", Battlehub.UIControls.ItemDropAction.SetNextSibling);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Battlehub.UIControls.ItemDropAction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushBattlehubUIControlsItemDropAction(L, (Battlehub.UIControls.ItemDropAction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushBattlehubUIControlsItemDropAction(L, Battlehub.UIControls.ItemDropAction.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetLastChild"))
                {
                    translator.PushBattlehubUIControlsItemDropAction(L, Battlehub.UIControls.ItemDropAction.SetLastChild);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetPrevSibling"))
                {
                    translator.PushBattlehubUIControlsItemDropAction(L, Battlehub.UIControls.ItemDropAction.SetPrevSibling);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetNextSibling"))
                {
                    translator.PushBattlehubUIControlsItemDropAction(L, Battlehub.UIControls.ItemDropAction.SetNextSibling);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Battlehub.UIControls.ItemDropAction!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Battlehub.UIControls.ItemDropAction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class BattlehubUIControlsVirtualizingModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Battlehub.UIControls.VirtualizingMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Battlehub.UIControls.VirtualizingMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Battlehub.UIControls.VirtualizingMode), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", Battlehub.UIControls.VirtualizingMode.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", Battlehub.UIControls.VirtualizingMode.Vertical);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Battlehub.UIControls.VirtualizingMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushBattlehubUIControlsVirtualizingMode(L, (Battlehub.UIControls.VirtualizingMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushBattlehubUIControlsVirtualizingMode(L, Battlehub.UIControls.VirtualizingMode.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushBattlehubUIControlsVirtualizingMode(L, Battlehub.UIControls.VirtualizingMode.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Battlehub.UIControls.VirtualizingMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Battlehub.UIControls.VirtualizingMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class BattlehubUIControlsDockPanelsRegionSplitTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Battlehub.UIControls.DockPanels.RegionSplitType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Battlehub.UIControls.DockPanels.RegionSplitType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Battlehub.UIControls.DockPanels.RegionSplitType), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", Battlehub.UIControls.DockPanels.RegionSplitType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", Battlehub.UIControls.DockPanels.RegionSplitType.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", Battlehub.UIControls.DockPanels.RegionSplitType.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", Battlehub.UIControls.DockPanels.RegionSplitType.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", Battlehub.UIControls.DockPanels.RegionSplitType.Bottom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Battlehub.UIControls.DockPanels.RegionSplitType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, (Battlehub.UIControls.DockPanels.RegionSplitType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, Battlehub.UIControls.DockPanels.RegionSplitType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, Battlehub.UIControls.DockPanels.RegionSplitType.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, Battlehub.UIControls.DockPanels.RegionSplitType.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, Battlehub.UIControls.DockPanels.RegionSplitType.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, Battlehub.UIControls.DockPanels.RegionSplitType.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Battlehub.UIControls.DockPanels.RegionSplitType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Battlehub.UIControls.DockPanels.RegionSplitType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class BattlehubUtilsKnownCursorWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Battlehub.Utils.KnownCursor), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Battlehub.Utils.KnownCursor), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Battlehub.Utils.KnownCursor), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VResize", Battlehub.Utils.KnownCursor.VResize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HResize", Battlehub.Utils.KnownCursor.HResize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DropNotAllowed", Battlehub.Utils.KnownCursor.DropNotAllowed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DropAllowed", Battlehub.Utils.KnownCursor.DropAllowed);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Battlehub.Utils.KnownCursor), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushBattlehubUtilsKnownCursor(L, (Battlehub.Utils.KnownCursor)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "VResize"))
                {
                    translator.PushBattlehubUtilsKnownCursor(L, Battlehub.Utils.KnownCursor.VResize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HResize"))
                {
                    translator.PushBattlehubUtilsKnownCursor(L, Battlehub.Utils.KnownCursor.HResize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DropNotAllowed"))
                {
                    translator.PushBattlehubUtilsKnownCursor(L, Battlehub.Utils.KnownCursor.DropNotAllowed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DropAllowed"))
                {
                    translator.PushBattlehubUtilsKnownCursor(L, Battlehub.Utils.KnownCursor.DropAllowed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Battlehub.Utils.KnownCursor!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Battlehub.Utils.KnownCursor! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIBlendModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.BlendMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.BlendMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.BlendMode), L, null, 14, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", FairyGUI.BlendMode.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.BlendMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Add", FairyGUI.BlendMode.Add);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiply", FairyGUI.BlendMode.Multiply);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Screen", FairyGUI.BlendMode.Screen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Erase", FairyGUI.BlendMode.Erase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mask", FairyGUI.BlendMode.Mask);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Below", FairyGUI.BlendMode.Below);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Off", FairyGUI.BlendMode.Off);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "One_OneMinusSrcAlpha", FairyGUI.BlendMode.One_OneMinusSrcAlpha);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom1", FairyGUI.BlendMode.Custom1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom2", FairyGUI.BlendMode.Custom2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom3", FairyGUI.BlendMode.Custom3);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.BlendMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIBlendMode(L, (FairyGUI.BlendMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Add"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Add);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiply"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Multiply);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Screen"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Screen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Erase"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Erase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mask"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Mask);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Below"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Below);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Off"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Off);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "One_OneMinusSrcAlpha"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.One_OneMinusSrcAlpha);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom1"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Custom1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom2"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Custom2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom3"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Custom3);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.BlendMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.BlendMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIHitTestModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.HitTestMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.HitTestMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.HitTestMode), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", FairyGUI.HitTestMode.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raycast", FairyGUI.HitTestMode.Raycast);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.HitTestMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIHitTestMode(L, (FairyGUI.HitTestMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushFairyGUIHitTestMode(L, FairyGUI.HitTestMode.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raycast"))
                {
                    translator.PushFairyGUIHitTestMode(L, FairyGUI.HitTestMode.Raycast);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.HitTestMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.HitTestMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIMaterialFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.MaterialFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.MaterialFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.MaterialFlags), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clipped", FairyGUI.MaterialFlags.Clipped);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoftClipped", FairyGUI.MaterialFlags.SoftClipped);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StencilTest", FairyGUI.MaterialFlags.StencilTest);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AlphaMask", FairyGUI.MaterialFlags.AlphaMask);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Grayed", FairyGUI.MaterialFlags.Grayed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorFilter", FairyGUI.MaterialFlags.ColorFilter);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.MaterialFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIMaterialFlags(L, (FairyGUI.MaterialFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Clipped"))
                {
                    translator.PushFairyGUIMaterialFlags(L, FairyGUI.MaterialFlags.Clipped);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SoftClipped"))
                {
                    translator.PushFairyGUIMaterialFlags(L, FairyGUI.MaterialFlags.SoftClipped);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StencilTest"))
                {
                    translator.PushFairyGUIMaterialFlags(L, FairyGUI.MaterialFlags.StencilTest);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AlphaMask"))
                {
                    translator.PushFairyGUIMaterialFlags(L, FairyGUI.MaterialFlags.AlphaMask);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Grayed"))
                {
                    translator.PushFairyGUIMaterialFlags(L, FairyGUI.MaterialFlags.Grayed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorFilter"))
                {
                    translator.PushFairyGUIMaterialFlags(L, FairyGUI.MaterialFlags.ColorFilter);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.MaterialFlags!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.MaterialFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIDestroyMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.DestroyMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.DestroyMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.DestroyMethod), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Destroy", FairyGUI.DestroyMethod.Destroy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unload", FairyGUI.DestroyMethod.Unload);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.DestroyMethod.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReleaseTemp", FairyGUI.DestroyMethod.ReleaseTemp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", FairyGUI.DestroyMethod.Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.DestroyMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIDestroyMethod(L, (FairyGUI.DestroyMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Destroy"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.Destroy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unload"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.Unload);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ReleaseTemp"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.ReleaseTemp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.DestroyMethod!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.DestroyMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIEaseTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.EaseType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.EaseType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.EaseType), L, null, 33, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", FairyGUI.EaseType.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SineIn", FairyGUI.EaseType.SineIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SineOut", FairyGUI.EaseType.SineOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SineInOut", FairyGUI.EaseType.SineInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuadIn", FairyGUI.EaseType.QuadIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuadOut", FairyGUI.EaseType.QuadOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuadInOut", FairyGUI.EaseType.QuadInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicIn", FairyGUI.EaseType.CubicIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicOut", FairyGUI.EaseType.CubicOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicInOut", FairyGUI.EaseType.CubicInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuartIn", FairyGUI.EaseType.QuartIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuartOut", FairyGUI.EaseType.QuartOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuartInOut", FairyGUI.EaseType.QuartInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuintIn", FairyGUI.EaseType.QuintIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuintOut", FairyGUI.EaseType.QuintOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuintInOut", FairyGUI.EaseType.QuintInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExpoIn", FairyGUI.EaseType.ExpoIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExpoOut", FairyGUI.EaseType.ExpoOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExpoInOut", FairyGUI.EaseType.ExpoInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CircIn", FairyGUI.EaseType.CircIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CircOut", FairyGUI.EaseType.CircOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CircInOut", FairyGUI.EaseType.CircInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ElasticIn", FairyGUI.EaseType.ElasticIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ElasticOut", FairyGUI.EaseType.ElasticOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ElasticInOut", FairyGUI.EaseType.ElasticInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackIn", FairyGUI.EaseType.BackIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackOut", FairyGUI.EaseType.BackOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackInOut", FairyGUI.EaseType.BackInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BounceIn", FairyGUI.EaseType.BounceIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BounceOut", FairyGUI.EaseType.BounceOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BounceInOut", FairyGUI.EaseType.BounceInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", FairyGUI.EaseType.Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.EaseType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIEaseType(L, (FairyGUI.EaseType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SineIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.SineIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SineOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.SineOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SineInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.SineInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuadIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuadIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuadOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuadOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuadInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuadInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CubicIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CubicOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CubicInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuartIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuartIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuartOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuartOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuartInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuartInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuintIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuintIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuintOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuintOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuintInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuintInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExpoIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ExpoIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExpoOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ExpoOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExpoInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ExpoInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CircIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CircIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CircOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CircOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CircInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CircInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ElasticIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ElasticIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ElasticOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ElasticOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ElasticInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ElasticInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BackIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BackOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BackInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BounceIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BounceIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BounceOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BounceOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BounceInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BounceInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.EaseType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.EaseType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUITweenPropTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.TweenPropType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.TweenPropType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.TweenPropType), L, null, 18, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.TweenPropType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", FairyGUI.TweenPropType.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", FairyGUI.TweenPropType.Y);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Z", FairyGUI.TweenPropType.Z);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XY", FairyGUI.TweenPropType.XY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Position", FairyGUI.TweenPropType.Position);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Width", FairyGUI.TweenPropType.Width);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Height", FairyGUI.TweenPropType.Height);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", FairyGUI.TweenPropType.Size);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleX", FairyGUI.TweenPropType.ScaleX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleY", FairyGUI.TweenPropType.ScaleY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scale", FairyGUI.TweenPropType.Scale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rotation", FairyGUI.TweenPropType.Rotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RotationX", FairyGUI.TweenPropType.RotationX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RotationY", FairyGUI.TweenPropType.RotationY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha", FairyGUI.TweenPropType.Alpha);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Progress", FairyGUI.TweenPropType.Progress);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.TweenPropType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUITweenPropType(L, (FairyGUI.TweenPropType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Y);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Z"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Z);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XY"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.XY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Position"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Position);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Width"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Width);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Height"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Height);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Size);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleX"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.ScaleX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleY"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.ScaleY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scale"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Scale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rotation"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Rotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RotationX"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.RotationX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RotationY"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.RotationY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Alpha);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Progress"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Progress);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.TweenPropType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.TweenPropType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIPackageItemTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.PackageItemType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.PackageItemType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.PackageItemType), L, null, 12, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", FairyGUI.PackageItemType.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MovieClip", FairyGUI.PackageItemType.MovieClip);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sound", FairyGUI.PackageItemType.Sound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Component", FairyGUI.PackageItemType.Component);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Atlas", FairyGUI.PackageItemType.Atlas);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Font", FairyGUI.PackageItemType.Font);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Swf", FairyGUI.PackageItemType.Swf);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Misc", FairyGUI.PackageItemType.Misc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", FairyGUI.PackageItemType.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Spine", FairyGUI.PackageItemType.Spine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DragoneBones", FairyGUI.PackageItemType.DragoneBones);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.PackageItemType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIPackageItemType(L, (FairyGUI.PackageItemType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MovieClip"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.MovieClip);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sound"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Sound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Component"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Component);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Atlas"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Atlas);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Font"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Font);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Swf"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Swf);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Misc"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Misc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Spine"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Spine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DragoneBones"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.DragoneBones);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.PackageItemType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.PackageItemType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIObjectTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ObjectType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ObjectType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ObjectType), L, null, 20, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", FairyGUI.ObjectType.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MovieClip", FairyGUI.ObjectType.MovieClip);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Swf", FairyGUI.ObjectType.Swf);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Graph", FairyGUI.ObjectType.Graph);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loader", FairyGUI.ObjectType.Loader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Group", FairyGUI.ObjectType.Group);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", FairyGUI.ObjectType.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RichText", FairyGUI.ObjectType.RichText);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InputText", FairyGUI.ObjectType.InputText);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Component", FairyGUI.ObjectType.Component);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "List", FairyGUI.ObjectType.List);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Label", FairyGUI.ObjectType.Label);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Button", FairyGUI.ObjectType.Button);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ComboBox", FairyGUI.ObjectType.ComboBox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProgressBar", FairyGUI.ObjectType.ProgressBar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Slider", FairyGUI.ObjectType.Slider);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScrollBar", FairyGUI.ObjectType.ScrollBar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tree", FairyGUI.ObjectType.Tree);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loader3D", FairyGUI.ObjectType.Loader3D);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ObjectType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIObjectType(L, (FairyGUI.ObjectType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MovieClip"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.MovieClip);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Swf"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Swf);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Graph"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Graph);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loader"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Loader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Group"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Group);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RichText"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.RichText);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InputText"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.InputText);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Component"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Component);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "List"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.List);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Label"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Label);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Button"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Button);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ComboBox"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.ComboBox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProgressBar"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.ProgressBar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Slider"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Slider);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScrollBar"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.ScrollBar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tree"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Tree);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loader3D"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Loader3D);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ObjectType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ObjectType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIAlignTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.AlignType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.AlignType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.AlignType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.AlignType.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center", FairyGUI.AlignType.Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.AlignType.Right);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.AlignType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIAlignType(L, (FairyGUI.AlignType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIAlignType(L, FairyGUI.AlignType.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Center"))
                {
                    translator.PushFairyGUIAlignType(L, FairyGUI.AlignType.Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIAlignType(L, FairyGUI.AlignType.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.AlignType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.AlignType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIVertAlignTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.VertAlignType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.VertAlignType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.VertAlignType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.VertAlignType.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Middle", FairyGUI.VertAlignType.Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.VertAlignType.Bottom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.VertAlignType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIVertAlignType(L, (FairyGUI.VertAlignType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIVertAlignType(L, FairyGUI.VertAlignType.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Middle"))
                {
                    translator.PushFairyGUIVertAlignType(L, FairyGUI.VertAlignType.Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIVertAlignType(L, FairyGUI.VertAlignType.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.VertAlignType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.VertAlignType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOverflowTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.OverflowType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.OverflowType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.OverflowType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Visible", FairyGUI.OverflowType.Visible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hidden", FairyGUI.OverflowType.Hidden);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scroll", FairyGUI.OverflowType.Scroll);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.OverflowType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOverflowType(L, (FairyGUI.OverflowType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Visible"))
                {
                    translator.PushFairyGUIOverflowType(L, FairyGUI.OverflowType.Visible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hidden"))
                {
                    translator.PushFairyGUIOverflowType(L, FairyGUI.OverflowType.Hidden);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scroll"))
                {
                    translator.PushFairyGUIOverflowType(L, FairyGUI.OverflowType.Scroll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.OverflowType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.OverflowType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFillTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FillType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FillType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FillType), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FillType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scale", FairyGUI.FillType.Scale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleMatchHeight", FairyGUI.FillType.ScaleMatchHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleMatchWidth", FairyGUI.FillType.ScaleMatchWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleFree", FairyGUI.FillType.ScaleFree);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleNoBorder", FairyGUI.FillType.ScaleNoBorder);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FillType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFillType(L, (FairyGUI.FillType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scale"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.Scale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleMatchHeight"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleMatchHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleMatchWidth"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleMatchWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleFree"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleFree);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleNoBorder"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleNoBorder);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FillType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FillType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIAutoSizeTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.AutoSizeType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.AutoSizeType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.AutoSizeType), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.AutoSizeType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", FairyGUI.AutoSizeType.Both);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Height", FairyGUI.AutoSizeType.Height);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", FairyGUI.AutoSizeType.Shrink);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ellipsis", FairyGUI.AutoSizeType.Ellipsis);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.AutoSizeType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIAutoSizeType(L, (FairyGUI.AutoSizeType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Both);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Height"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Height);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Shrink);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ellipsis"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Ellipsis);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.AutoSizeType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.AutoSizeType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIScrollTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ScrollType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ScrollType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ScrollType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.ScrollType.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.ScrollType.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", FairyGUI.ScrollType.Both);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ScrollType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIScrollType(L, (FairyGUI.ScrollType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIScrollType(L, FairyGUI.ScrollType.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIScrollType(L, FairyGUI.ScrollType.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushFairyGUIScrollType(L, FairyGUI.ScrollType.Both);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ScrollType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ScrollType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIScrollBarDisplayTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ScrollBarDisplayType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ScrollBarDisplayType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ScrollBarDisplayType), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", FairyGUI.ScrollBarDisplayType.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Visible", FairyGUI.ScrollBarDisplayType.Visible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", FairyGUI.ScrollBarDisplayType.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hidden", FairyGUI.ScrollBarDisplayType.Hidden);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ScrollBarDisplayType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIScrollBarDisplayType(L, (FairyGUI.ScrollBarDisplayType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Visible"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Visible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hidden"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Hidden);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ScrollBarDisplayType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ScrollBarDisplayType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIRelationTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.RelationType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.RelationType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.RelationType), L, null, 26, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left_Left", FairyGUI.RelationType.Left_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left_Center", FairyGUI.RelationType.Left_Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left_Right", FairyGUI.RelationType.Left_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center_Center", FairyGUI.RelationType.Center_Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right_Left", FairyGUI.RelationType.Right_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right_Center", FairyGUI.RelationType.Right_Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right_Right", FairyGUI.RelationType.Right_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top_Top", FairyGUI.RelationType.Top_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top_Middle", FairyGUI.RelationType.Top_Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top_Bottom", FairyGUI.RelationType.Top_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Middle_Middle", FairyGUI.RelationType.Middle_Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom_Top", FairyGUI.RelationType.Bottom_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom_Middle", FairyGUI.RelationType.Bottom_Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom_Bottom", FairyGUI.RelationType.Bottom_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Width", FairyGUI.RelationType.Width);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Height", FairyGUI.RelationType.Height);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftExt_Left", FairyGUI.RelationType.LeftExt_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftExt_Right", FairyGUI.RelationType.LeftExt_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightExt_Left", FairyGUI.RelationType.RightExt_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightExt_Right", FairyGUI.RelationType.RightExt_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopExt_Top", FairyGUI.RelationType.TopExt_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopExt_Bottom", FairyGUI.RelationType.TopExt_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomExt_Top", FairyGUI.RelationType.BottomExt_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomExt_Bottom", FairyGUI.RelationType.BottomExt_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", FairyGUI.RelationType.Size);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.RelationType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIRelationType(L, (FairyGUI.RelationType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Left_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left_Center"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Left_Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Left_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Center_Center"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Center_Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Right_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right_Center"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Right_Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Right_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Top_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top_Middle"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Top_Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Top_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Middle_Middle"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Middle_Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Bottom_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom_Middle"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Bottom_Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Bottom_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Width"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Width);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Height"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Height);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftExt_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.LeftExt_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftExt_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.LeftExt_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightExt_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.RightExt_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightExt_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.RightExt_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopExt_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.TopExt_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopExt_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.TopExt_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomExt_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.BottomExt_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomExt_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.BottomExt_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Size);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.RelationType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.RelationType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIListLayoutTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ListLayoutType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ListLayoutType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ListLayoutType), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleColumn", FairyGUI.ListLayoutType.SingleColumn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleRow", FairyGUI.ListLayoutType.SingleRow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlowHorizontal", FairyGUI.ListLayoutType.FlowHorizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlowVertical", FairyGUI.ListLayoutType.FlowVertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pagination", FairyGUI.ListLayoutType.Pagination);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ListLayoutType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIListLayoutType(L, (FairyGUI.ListLayoutType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "SingleColumn"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.SingleColumn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SingleRow"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.SingleRow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlowHorizontal"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.FlowHorizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlowVertical"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.FlowVertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pagination"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.Pagination);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ListLayoutType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ListLayoutType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIListSelectionModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ListSelectionMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ListSelectionMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ListSelectionMode), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Single", FairyGUI.ListSelectionMode.Single);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiple", FairyGUI.ListSelectionMode.Multiple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiple_SingleClick", FairyGUI.ListSelectionMode.Multiple_SingleClick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.ListSelectionMode.None);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ListSelectionMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIListSelectionMode(L, (FairyGUI.ListSelectionMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Single"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.Single);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiple"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.Multiple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiple_SingleClick"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.Multiple_SingleClick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ListSelectionMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ListSelectionMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIProgressTitleTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ProgressTitleType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ProgressTitleType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ProgressTitleType), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Percent", FairyGUI.ProgressTitleType.Percent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ValueAndMax", FairyGUI.ProgressTitleType.ValueAndMax);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Value", FairyGUI.ProgressTitleType.Value);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Max", FairyGUI.ProgressTitleType.Max);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ProgressTitleType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIProgressTitleType(L, (FairyGUI.ProgressTitleType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Percent"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.Percent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ValueAndMax"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.ValueAndMax);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Value"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.Value);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Max"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.Max);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ProgressTitleType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ProgressTitleType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIButtonModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ButtonMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ButtonMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ButtonMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Common", FairyGUI.ButtonMode.Common);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Check", FairyGUI.ButtonMode.Check);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radio", FairyGUI.ButtonMode.Radio);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ButtonMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIButtonMode(L, (FairyGUI.ButtonMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Common"))
                {
                    translator.PushFairyGUIButtonMode(L, FairyGUI.ButtonMode.Common);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Check"))
                {
                    translator.PushFairyGUIButtonMode(L, FairyGUI.ButtonMode.Check);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radio"))
                {
                    translator.PushFairyGUIButtonMode(L, FairyGUI.ButtonMode.Radio);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ButtonMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ButtonMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUITransitionActionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.TransitionActionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.TransitionActionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.TransitionActionType), L, null, 18, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XY", FairyGUI.TransitionActionType.XY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", FairyGUI.TransitionActionType.Size);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scale", FairyGUI.TransitionActionType.Scale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pivot", FairyGUI.TransitionActionType.Pivot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha", FairyGUI.TransitionActionType.Alpha);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rotation", FairyGUI.TransitionActionType.Rotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Color", FairyGUI.TransitionActionType.Color);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Animation", FairyGUI.TransitionActionType.Animation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Visible", FairyGUI.TransitionActionType.Visible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sound", FairyGUI.TransitionActionType.Sound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Transition", FairyGUI.TransitionActionType.Transition);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shake", FairyGUI.TransitionActionType.Shake);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorFilter", FairyGUI.TransitionActionType.ColorFilter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Skew", FairyGUI.TransitionActionType.Skew);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", FairyGUI.TransitionActionType.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Icon", FairyGUI.TransitionActionType.Icon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", FairyGUI.TransitionActionType.Unknown);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.TransitionActionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUITransitionActionType(L, (FairyGUI.TransitionActionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "XY"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.XY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Size);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scale"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Scale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pivot"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Pivot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Alpha);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rotation"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Rotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Color"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Color);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Animation"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Animation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Visible"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Visible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sound"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Sound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Transition"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Transition);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shake"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Shake);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorFilter"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.ColorFilter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Skew"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Skew);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Icon"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Icon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.TransitionActionType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.TransitionActionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIGroupLayoutTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.GroupLayoutType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.GroupLayoutType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.GroupLayoutType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.GroupLayoutType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.GroupLayoutType.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.GroupLayoutType.Vertical);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.GroupLayoutType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIGroupLayoutType(L, (FairyGUI.GroupLayoutType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIGroupLayoutType(L, FairyGUI.GroupLayoutType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIGroupLayoutType(L, FairyGUI.GroupLayoutType.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIGroupLayoutType(L, FairyGUI.GroupLayoutType.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.GroupLayoutType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.GroupLayoutType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIChildrenRenderOrderWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ChildrenRenderOrder), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ChildrenRenderOrder), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ChildrenRenderOrder), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ascent", FairyGUI.ChildrenRenderOrder.Ascent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Descent", FairyGUI.ChildrenRenderOrder.Descent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Arch", FairyGUI.ChildrenRenderOrder.Arch);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ChildrenRenderOrder), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIChildrenRenderOrder(L, (FairyGUI.ChildrenRenderOrder)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Ascent"))
                {
                    translator.PushFairyGUIChildrenRenderOrder(L, FairyGUI.ChildrenRenderOrder.Ascent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Descent"))
                {
                    translator.PushFairyGUIChildrenRenderOrder(L, FairyGUI.ChildrenRenderOrder.Descent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Arch"))
                {
                    translator.PushFairyGUIChildrenRenderOrder(L, FairyGUI.ChildrenRenderOrder.Arch);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ChildrenRenderOrder!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ChildrenRenderOrder! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIPopupDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.PopupDirection), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.PopupDirection), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.PopupDirection), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", FairyGUI.PopupDirection.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Up", FairyGUI.PopupDirection.Up);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Down", FairyGUI.PopupDirection.Down);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.PopupDirection), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIPopupDirection(L, (FairyGUI.PopupDirection)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushFairyGUIPopupDirection(L, FairyGUI.PopupDirection.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Up"))
                {
                    translator.PushFairyGUIPopupDirection(L, FairyGUI.PopupDirection.Up);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Down"))
                {
                    translator.PushFairyGUIPopupDirection(L, FairyGUI.PopupDirection.Down);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.PopupDirection!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.PopupDirection! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFlipTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FlipType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FlipType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FlipType), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FlipType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.FlipType.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.FlipType.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", FairyGUI.FlipType.Both);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FlipType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFlipType(L, (FairyGUI.FlipType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.Both);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FlipType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FlipType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFillMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FillMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FillMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FillMethod), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FillMethod.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.FillMethod.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.FillMethod.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial90", FairyGUI.FillMethod.Radial90);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial180", FairyGUI.FillMethod.Radial180);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial360", FairyGUI.FillMethod.Radial360);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FillMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFillMethod(L, (FairyGUI.FillMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial90"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Radial90);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial180"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Radial180);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial360"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Radial360);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FillMethod!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FillMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOriginHorizontalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.OriginHorizontal), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.OriginHorizontal), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.OriginHorizontal), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.OriginHorizontal.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.OriginHorizontal.Right);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.OriginHorizontal), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOriginHorizontal(L, (FairyGUI.OriginHorizontal)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIOriginHorizontal(L, FairyGUI.OriginHorizontal.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIOriginHorizontal(L, FairyGUI.OriginHorizontal.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.OriginHorizontal!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.OriginHorizontal! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOriginVerticalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.OriginVertical), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.OriginVertical), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.OriginVertical), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.OriginVertical.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.OriginVertical.Bottom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.OriginVertical), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOriginVertical(L, (FairyGUI.OriginVertical)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIOriginVertical(L, FairyGUI.OriginVertical.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIOriginVertical(L, FairyGUI.OriginVertical.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.OriginVertical!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.OriginVertical! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOrigin90Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Origin90), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Origin90), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Origin90), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", FairyGUI.Origin90.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", FairyGUI.Origin90.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", FairyGUI.Origin90.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", FairyGUI.Origin90.BottomRight);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Origin90), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOrigin90(L, (FairyGUI.Origin90)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.BottomRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Origin90!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Origin90! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOrigin180Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Origin180), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Origin180), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Origin180), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.Origin180.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.Origin180.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.Origin180.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.Origin180.Right);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Origin180), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOrigin180(L, (FairyGUI.Origin180)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Origin180!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Origin180! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOrigin360Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Origin360), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Origin360), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Origin360), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.Origin360.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.Origin360.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.Origin360.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.Origin360.Right);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Origin360), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOrigin360(L, (FairyGUI.Origin360)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Origin360!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Origin360! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFocusRuleWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FocusRule), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FocusRule), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FocusRule), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotFocusable", FairyGUI.FocusRule.NotFocusable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Focusable", FairyGUI.FocusRule.Focusable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NavigationBase", FairyGUI.FocusRule.NavigationBase);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FocusRule), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFocusRule(L, (FairyGUI.FocusRule)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "NotFocusable"))
                {
                    translator.PushFairyGUIFocusRule(L, FairyGUI.FocusRule.NotFocusable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Focusable"))
                {
                    translator.PushFairyGUIFocusRule(L, FairyGUI.FocusRule.Focusable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NavigationBase"))
                {
                    translator.PushFairyGUIFocusRule(L, FairyGUI.FocusRule.NavigationBase);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FocusRule!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FocusRule! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFitScreenWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FitScreen), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FitScreen), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FitScreen), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FitScreen.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitSize", FairyGUI.FitScreen.FitSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitWidthAndSetMiddle", FairyGUI.FitScreen.FitWidthAndSetMiddle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitHeightAndSetCenter", FairyGUI.FitScreen.FitHeightAndSetCenter);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FitScreen), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFitScreen(L, (FairyGUI.FitScreen)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitSize"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.FitSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitWidthAndSetMiddle"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.FitWidthAndSetMiddle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitHeightAndSetCenter"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.FitHeightAndSetCenter);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FitScreen!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FitScreen! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUtilsHtmlElementTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Utils.HtmlElementType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Utils.HtmlElementType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Utils.HtmlElementType), L, null, 8, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", FairyGUI.Utils.HtmlElementType.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Link", FairyGUI.Utils.HtmlElementType.Link);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", FairyGUI.Utils.HtmlElementType.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Input", FairyGUI.Utils.HtmlElementType.Input);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Select", FairyGUI.Utils.HtmlElementType.Select);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Object", FairyGUI.Utils.HtmlElementType.Object);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LinkEnd", FairyGUI.Utils.HtmlElementType.LinkEnd);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Utils.HtmlElementType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUtilsHtmlElementType(L, (FairyGUI.Utils.HtmlElementType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Link"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Link);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Input"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Input);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Select"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Select);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Object"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Object);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LinkEnd"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.LinkEnd);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Utils.HtmlElementType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Utils.HtmlElementType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUtilsXMLTagTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Utils.XMLTagType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Utils.XMLTagType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Utils.XMLTagType), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Start", FairyGUI.Utils.XMLTagType.Start);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "End", FairyGUI.Utils.XMLTagType.End);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Void", FairyGUI.Utils.XMLTagType.Void);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CDATA", FairyGUI.Utils.XMLTagType.CDATA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Comment", FairyGUI.Utils.XMLTagType.Comment);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Instruction", FairyGUI.Utils.XMLTagType.Instruction);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Utils.XMLTagType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUtilsXMLTagType(L, (FairyGUI.Utils.XMLTagType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Start"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Start);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "End"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.End);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Void"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Void);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CDATA"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.CDATA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Comment"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Comment);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Instruction"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Instruction);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Utils.XMLTagType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Utils.XMLTagType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ETColdDebugTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ETCold.DebugType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ETCold.DebugType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ETCold.DebugType), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Console", ETCold.DebugType.Console);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Memory", ETCold.DebugType.Memory);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "System", ETCold.DebugType.System);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Screen", ETCold.DebugType.Screen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Quality", ETCold.DebugType.Quality);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Environment", ETCold.DebugType.Environment);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ETCold.DebugType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushETColdDebugType(L, (ETCold.DebugType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Console"))
                {
                    translator.PushETColdDebugType(L, ETCold.DebugType.Console);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Memory"))
                {
                    translator.PushETColdDebugType(L, ETCold.DebugType.Memory);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "System"))
                {
                    translator.PushETColdDebugType(L, ETCold.DebugType.System);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Screen"))
                {
                    translator.PushETColdDebugType(L, ETCold.DebugType.Screen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Quality"))
                {
                    translator.PushETColdDebugType(L, ETCold.DebugType.Quality);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Environment"))
                {
                    translator.PushETColdDebugType(L, ETCold.DebugType.Environment);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ETCold.DebugType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ETCold.DebugType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ETColdUILayerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ETCold.UILayer), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ETCold.UILayer), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ETCold.UILayer), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hidden", ETCold.UILayer.Hidden);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Low", ETCold.UILayer.Low);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mid", ETCold.UILayer.Mid);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", ETCold.UILayer.High);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ETCold.UILayer), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushETColdUILayer(L, (ETCold.UILayer)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Hidden"))
                {
                    translator.PushETColdUILayer(L, ETCold.UILayer.Hidden);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Low"))
                {
                    translator.PushETColdUILayer(L, ETCold.UILayer.Low);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mid"))
                {
                    translator.PushETColdUILayer(L, ETCold.UILayer.Mid);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushETColdUILayer(L, ETCold.UILayer.High);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ETCold.UILayer!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ETCold.UILayer! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ETAwaiterStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ET.AwaiterStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ET.AwaiterStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ET.AwaiterStatus), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pending", ET.AwaiterStatus.Pending);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Succeeded", ET.AwaiterStatus.Succeeded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Faulted", ET.AwaiterStatus.Faulted);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ET.AwaiterStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushETAwaiterStatus(L, (ET.AwaiterStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Pending"))
                {
                    translator.PushETAwaiterStatus(L, ET.AwaiterStatus.Pending);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Succeeded"))
                {
                    translator.PushETAwaiterStatus(L, ET.AwaiterStatus.Succeeded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Faulted"))
                {
                    translator.PushETAwaiterStatus(L, ET.AwaiterStatus.Faulted);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ET.AwaiterStatus!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ET.AwaiterStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MessageBoxEventIdWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MessageBox.EventId), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MessageBox.EventId), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MessageBox.EventId), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ok", MessageBox.EventId.Ok);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "No", MessageBox.EventId.No);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MessageBox.EventId), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMessageBoxEventId(L, (MessageBox.EventId)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Ok"))
                {
                    translator.PushMessageBoxEventId(L, MessageBox.EventId.Ok);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "No"))
                {
                    translator.PushMessageBoxEventId(L, MessageBox.EventId.No);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MessageBox.EventId!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MessageBox.EventId! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIRTLSupportDirectionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UNKNOW", FairyGUI.RTLSupport.DirectionType.UNKNOW);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LTR", FairyGUI.RTLSupport.DirectionType.LTR);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RTL", FairyGUI.RTLSupport.DirectionType.RTL);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NEUTRAL", FairyGUI.RTLSupport.DirectionType.NEUTRAL);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIRTLSupportDirectionType(L, (FairyGUI.RTLSupport.DirectionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "UNKNOW"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.UNKNOW);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LTR"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.LTR);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RTL"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.RTL);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NEUTRAL"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.NEUTRAL);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.RTLSupport.DirectionType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.RTLSupport.DirectionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUITextFormatSpecialStyleWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.TextFormat.SpecialStyle.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Superscript", FairyGUI.TextFormat.SpecialStyle.Superscript);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Subscript", FairyGUI.TextFormat.SpecialStyle.Subscript);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUITextFormatSpecialStyle(L, (FairyGUI.TextFormat.SpecialStyle)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUITextFormatSpecialStyle(L, FairyGUI.TextFormat.SpecialStyle.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Superscript"))
                {
                    translator.PushFairyGUITextFormatSpecialStyle(L, FairyGUI.TextFormat.SpecialStyle.Superscript);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Subscript"))
                {
                    translator.PushFairyGUITextFormatSpecialStyle(L, FairyGUI.TextFormat.SpecialStyle.Subscript);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.TextFormat.SpecialStyle!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.TextFormat.SpecialStyle! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIGPathPointCurveTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.GPathPoint.CurveType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.GPathPoint.CurveType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.GPathPoint.CurveType), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CRSpline", FairyGUI.GPathPoint.CurveType.CRSpline);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bezier", FairyGUI.GPathPoint.CurveType.Bezier);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicBezier", FairyGUI.GPathPoint.CurveType.CubicBezier);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Straight", FairyGUI.GPathPoint.CurveType.Straight);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.GPathPoint.CurveType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIGPathPointCurveType(L, (FairyGUI.GPathPoint.CurveType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "CRSpline"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.CRSpline);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bezier"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.Bezier);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicBezier"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.CubicBezier);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Straight"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.Straight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.GPathPoint.CurveType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.GPathPoint.CurveType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIControllerActionActionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ControllerAction.ActionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ControllerAction.ActionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ControllerAction.ActionType), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PlayTransition", FairyGUI.ControllerAction.ActionType.PlayTransition);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChangePage", FairyGUI.ControllerAction.ActionType.ChangePage);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ControllerAction.ActionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIControllerActionActionType(L, (FairyGUI.ControllerAction.ActionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "PlayTransition"))
                {
                    translator.PushFairyGUIControllerActionActionType(L, FairyGUI.ControllerAction.ActionType.PlayTransition);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ChangePage"))
                {
                    translator.PushFairyGUIControllerActionActionType(L, FairyGUI.ControllerAction.ActionType.ChangePage);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ControllerAction.ActionType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ControllerAction.ActionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUIConfigConfigKeyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, null, 30, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultFont", FairyGUI.UIConfig.ConfigKey.DefaultFont);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ButtonSound", FairyGUI.UIConfig.ConfigKey.ButtonSound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ButtonSoundVolumeScale", FairyGUI.UIConfig.ConfigKey.ButtonSoundVolumeScale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HorizontalScrollBar", FairyGUI.UIConfig.ConfigKey.HorizontalScrollBar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VerticalScrollBar", FairyGUI.UIConfig.ConfigKey.VerticalScrollBar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultScrollStep", FairyGUI.UIConfig.ConfigKey.DefaultScrollStep);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultScrollBarDisplay", FairyGUI.UIConfig.ConfigKey.DefaultScrollBarDisplay);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultScrollTouchEffect", FairyGUI.UIConfig.ConfigKey.DefaultScrollTouchEffect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultScrollBounceEffect", FairyGUI.UIConfig.ConfigKey.DefaultScrollBounceEffect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TouchScrollSensitivity", FairyGUI.UIConfig.ConfigKey.TouchScrollSensitivity);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WindowModalWaiting", FairyGUI.UIConfig.ConfigKey.WindowModalWaiting);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GlobalModalWaiting", FairyGUI.UIConfig.ConfigKey.GlobalModalWaiting);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PopupMenu", FairyGUI.UIConfig.ConfigKey.PopupMenu);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PopupMenu_seperator", FairyGUI.UIConfig.ConfigKey.PopupMenu_seperator);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LoaderErrorSign", FairyGUI.UIConfig.ConfigKey.LoaderErrorSign);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TooltipsWin", FairyGUI.UIConfig.ConfigKey.TooltipsWin);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultComboBoxVisibleItemCount", FairyGUI.UIConfig.ConfigKey.DefaultComboBoxVisibleItemCount);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TouchDragSensitivity", FairyGUI.UIConfig.ConfigKey.TouchDragSensitivity);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClickDragSensitivity", FairyGUI.UIConfig.ConfigKey.ClickDragSensitivity);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ModalLayerColor", FairyGUI.UIConfig.ConfigKey.ModalLayerColor);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RenderingTextBrighterOnDesktop", FairyGUI.UIConfig.ConfigKey.RenderingTextBrighterOnDesktop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllowSoftnessOnTopOrLeftSide", FairyGUI.UIConfig.ConfigKey.AllowSoftnessOnTopOrLeftSide);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InputCaretSize", FairyGUI.UIConfig.ConfigKey.InputCaretSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InputHighlightColor", FairyGUI.UIConfig.ConfigKey.InputHighlightColor);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnhancedTextOutlineEffect", FairyGUI.UIConfig.ConfigKey.EnhancedTextOutlineEffect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DepthSupportForPaintingMode", FairyGUI.UIConfig.ConfigKey.DepthSupportForPaintingMode);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RichTextRowVerticalAlign", FairyGUI.UIConfig.ConfigKey.RichTextRowVerticalAlign);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Branch", FairyGUI.UIConfig.ConfigKey.Branch);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PleaseSelect", FairyGUI.UIConfig.ConfigKey.PleaseSelect);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUIConfigConfigKey(L, (FairyGUI.UIConfig.ConfigKey)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "DefaultFont"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DefaultFont);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ButtonSound"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.ButtonSound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ButtonSoundVolumeScale"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.ButtonSoundVolumeScale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HorizontalScrollBar"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.HorizontalScrollBar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VerticalScrollBar"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.VerticalScrollBar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DefaultScrollStep"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DefaultScrollStep);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DefaultScrollBarDisplay"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DefaultScrollBarDisplay);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DefaultScrollTouchEffect"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DefaultScrollTouchEffect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DefaultScrollBounceEffect"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DefaultScrollBounceEffect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TouchScrollSensitivity"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.TouchScrollSensitivity);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WindowModalWaiting"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.WindowModalWaiting);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GlobalModalWaiting"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.GlobalModalWaiting);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PopupMenu"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.PopupMenu);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PopupMenu_seperator"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.PopupMenu_seperator);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LoaderErrorSign"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.LoaderErrorSign);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TooltipsWin"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.TooltipsWin);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DefaultComboBoxVisibleItemCount"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DefaultComboBoxVisibleItemCount);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TouchDragSensitivity"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.TouchDragSensitivity);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClickDragSensitivity"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.ClickDragSensitivity);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ModalLayerColor"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.ModalLayerColor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RenderingTextBrighterOnDesktop"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.RenderingTextBrighterOnDesktop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AllowSoftnessOnTopOrLeftSide"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.AllowSoftnessOnTopOrLeftSide);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InputCaretSize"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.InputCaretSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InputHighlightColor"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.InputHighlightColor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnhancedTextOutlineEffect"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.EnhancedTextOutlineEffect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DepthSupportForPaintingMode"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.DepthSupportForPaintingMode);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RichTextRowVerticalAlign"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.RichTextRowVerticalAlign);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Branch"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.Branch);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PleaseSelect"))
                {
                    translator.PushFairyGUIUIConfigConfigKey(L, FairyGUI.UIConfig.ConfigKey.PleaseSelect);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.UIConfig.ConfigKey!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.UIConfig.ConfigKey! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUIContentScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", FairyGUI.UIContentScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", FairyGUI.UIContentScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", FairyGUI.UIContentScaler.ScaleMode.ConstantPhysicalSize);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUIContentScalerScaleMode(L, (FairyGUI.UIContentScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushFairyGUIUIContentScalerScaleMode(L, FairyGUI.UIContentScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushFairyGUIUIContentScalerScaleMode(L, FairyGUI.UIContentScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushFairyGUIUIContentScalerScaleMode(L, FairyGUI.UIContentScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.UIContentScaler.ScaleMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.UIContentScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUIContentScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidth", FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchHeight", FairyGUI.UIContentScaler.ScreenMatchMode.MatchHeight);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUIContentScalerScreenMatchMode(L, (FairyGUI.UIContentScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidth"))
                {
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MatchHeight"))
                {
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, FairyGUI.UIContentScaler.ScreenMatchMode.MatchHeight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.UIContentScaler.ScreenMatchMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.UIContentScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemNetSocketsSocketAsyncOperationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.SocketAsyncOperation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.SocketAsyncOperation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.SocketAsyncOperation), L, null, 11, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", System.Net.Sockets.SocketAsyncOperation.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Accept", System.Net.Sockets.SocketAsyncOperation.Accept);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Connect", System.Net.Sockets.SocketAsyncOperation.Connect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Disconnect", System.Net.Sockets.SocketAsyncOperation.Disconnect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Receive", System.Net.Sockets.SocketAsyncOperation.Receive);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReceiveFrom", System.Net.Sockets.SocketAsyncOperation.ReceiveFrom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReceiveMessageFrom", System.Net.Sockets.SocketAsyncOperation.ReceiveMessageFrom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Send", System.Net.Sockets.SocketAsyncOperation.Send);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SendPackets", System.Net.Sockets.SocketAsyncOperation.SendPackets);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SendTo", System.Net.Sockets.SocketAsyncOperation.SendTo);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.SocketAsyncOperation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsSocketAsyncOperation(L, (System.Net.Sockets.SocketAsyncOperation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Accept"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.Accept);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Connect"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.Connect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Disconnect"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.Disconnect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Receive"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.Receive);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ReceiveFrom"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.ReceiveFrom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ReceiveMessageFrom"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.ReceiveMessageFrom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Send"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.Send);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SendPackets"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.SendPackets);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SendTo"))
                {
                    translator.PushSystemNetSocketsSocketAsyncOperation(L, System.Net.Sockets.SocketAsyncOperation.SendTo);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.SocketAsyncOperation!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.SocketAsyncOperation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemNetSocketsSocketErrorWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Net.Sockets.SocketError), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Net.Sockets.SocketError), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Net.Sockets.SocketError), L, null, 48, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Success", System.Net.Sockets.SocketError.Success);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SocketError", System.Net.Sockets.SocketError.SocketError);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Interrupted", System.Net.Sockets.SocketError.Interrupted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AccessDenied", System.Net.Sockets.SocketError.AccessDenied);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fault", System.Net.Sockets.SocketError.Fault);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InvalidArgument", System.Net.Sockets.SocketError.InvalidArgument);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TooManyOpenSockets", System.Net.Sockets.SocketError.TooManyOpenSockets);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WouldBlock", System.Net.Sockets.SocketError.WouldBlock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InProgress", System.Net.Sockets.SocketError.InProgress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AlreadyInProgress", System.Net.Sockets.SocketError.AlreadyInProgress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotSocket", System.Net.Sockets.SocketError.NotSocket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DestinationAddressRequired", System.Net.Sockets.SocketError.DestinationAddressRequired);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MessageSize", System.Net.Sockets.SocketError.MessageSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProtocolType", System.Net.Sockets.SocketError.ProtocolType);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProtocolOption", System.Net.Sockets.SocketError.ProtocolOption);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProtocolNotSupported", System.Net.Sockets.SocketError.ProtocolNotSupported);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SocketNotSupported", System.Net.Sockets.SocketError.SocketNotSupported);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OperationNotSupported", System.Net.Sockets.SocketError.OperationNotSupported);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProtocolFamilyNotSupported", System.Net.Sockets.SocketError.ProtocolFamilyNotSupported);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AddressFamilyNotSupported", System.Net.Sockets.SocketError.AddressFamilyNotSupported);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AddressAlreadyInUse", System.Net.Sockets.SocketError.AddressAlreadyInUse);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AddressNotAvailable", System.Net.Sockets.SocketError.AddressNotAvailable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetworkDown", System.Net.Sockets.SocketError.NetworkDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetworkUnreachable", System.Net.Sockets.SocketError.NetworkUnreachable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NetworkReset", System.Net.Sockets.SocketError.NetworkReset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConnectionAborted", System.Net.Sockets.SocketError.ConnectionAborted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConnectionReset", System.Net.Sockets.SocketError.ConnectionReset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoBufferSpaceAvailable", System.Net.Sockets.SocketError.NoBufferSpaceAvailable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IsConnected", System.Net.Sockets.SocketError.IsConnected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotConnected", System.Net.Sockets.SocketError.NotConnected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shutdown", System.Net.Sockets.SocketError.Shutdown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TimedOut", System.Net.Sockets.SocketError.TimedOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConnectionRefused", System.Net.Sockets.SocketError.ConnectionRefused);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HostDown", System.Net.Sockets.SocketError.HostDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HostUnreachable", System.Net.Sockets.SocketError.HostUnreachable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProcessLimit", System.Net.Sockets.SocketError.ProcessLimit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SystemNotReady", System.Net.Sockets.SocketError.SystemNotReady);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VersionNotSupported", System.Net.Sockets.SocketError.VersionNotSupported);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotInitialized", System.Net.Sockets.SocketError.NotInitialized);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Disconnecting", System.Net.Sockets.SocketError.Disconnecting);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TypeNotFound", System.Net.Sockets.SocketError.TypeNotFound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HostNotFound", System.Net.Sockets.SocketError.HostNotFound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TryAgain", System.Net.Sockets.SocketError.TryAgain);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoRecovery", System.Net.Sockets.SocketError.NoRecovery);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoData", System.Net.Sockets.SocketError.NoData);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IOPending", System.Net.Sockets.SocketError.IOPending);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OperationAborted", System.Net.Sockets.SocketError.OperationAborted);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Net.Sockets.SocketError), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemNetSocketsSocketError(L, (System.Net.Sockets.SocketError)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Success"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.Success);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SocketError"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.SocketError);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Interrupted"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.Interrupted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AccessDenied"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.AccessDenied);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fault"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.Fault);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InvalidArgument"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.InvalidArgument);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TooManyOpenSockets"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.TooManyOpenSockets);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WouldBlock"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.WouldBlock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InProgress"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.InProgress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AlreadyInProgress"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.AlreadyInProgress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotSocket"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NotSocket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DestinationAddressRequired"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.DestinationAddressRequired);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MessageSize"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.MessageSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProtocolType"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ProtocolType);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProtocolOption"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ProtocolOption);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProtocolNotSupported"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ProtocolNotSupported);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SocketNotSupported"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.SocketNotSupported);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OperationNotSupported"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.OperationNotSupported);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProtocolFamilyNotSupported"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ProtocolFamilyNotSupported);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AddressFamilyNotSupported"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.AddressFamilyNotSupported);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AddressAlreadyInUse"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.AddressAlreadyInUse);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AddressNotAvailable"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.AddressNotAvailable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetworkDown"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NetworkDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetworkUnreachable"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NetworkUnreachable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NetworkReset"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NetworkReset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConnectionAborted"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ConnectionAborted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConnectionReset"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ConnectionReset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoBufferSpaceAvailable"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NoBufferSpaceAvailable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IsConnected"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.IsConnected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotConnected"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NotConnected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shutdown"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.Shutdown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TimedOut"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.TimedOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConnectionRefused"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ConnectionRefused);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HostDown"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.HostDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HostUnreachable"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.HostUnreachable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProcessLimit"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.ProcessLimit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SystemNotReady"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.SystemNotReady);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "VersionNotSupported"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.VersionNotSupported);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotInitialized"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NotInitialized);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Disconnecting"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.Disconnecting);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TypeNotFound"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.TypeNotFound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HostNotFound"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.HostNotFound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TryAgain"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.TryAgain);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoRecovery"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NoRecovery);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoData"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.NoData);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IOPending"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.IOPending);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OperationAborted"))
                {
                    translator.PushSystemNetSocketsSocketError(L, System.Net.Sockets.SocketError.OperationAborted);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Net.Sockets.SocketError!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Net.Sockets.SocketError! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasUpdateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasUpdate), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Prelayout", UnityEngine.UI.CanvasUpdate.Prelayout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Layout", UnityEngine.UI.CanvasUpdate.Layout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostLayout", UnityEngine.UI.CanvasUpdate.PostLayout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreRender", UnityEngine.UI.CanvasUpdate.PreRender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LatePreRender", UnityEngine.UI.CanvasUpdate.LatePreRender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxUpdateValue", UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasUpdate(L, (UnityEngine.UI.CanvasUpdate)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Prelayout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.Prelayout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Layout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.Layout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PostLayout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.PostLayout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreRender"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.PreRender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LatePreRender"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.LatePreRender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxUpdateValue"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasUpdate!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasUpdate! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsEventHandleWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.EventHandle), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.EventHandle), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.EventHandle), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unused", UnityEngine.EventSystems.EventHandle.Unused);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Used", UnityEngine.EventSystems.EventHandle.Used);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.EventHandle), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsEventHandle(L, (UnityEngine.EventSystems.EventHandle)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unused"))
                {
                    translator.PushUnityEngineEventSystemsEventHandle(L, UnityEngine.EventSystems.EventHandle.Unused);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Used"))
                {
                    translator.PushUnityEngineEventSystemsEventHandle(L, UnityEngine.EventSystems.EventHandle.Used);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.EventHandle!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.EventHandle! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsEventTriggerTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, null, 18, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerEnter", UnityEngine.EventSystems.EventTriggerType.PointerEnter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerExit", UnityEngine.EventSystems.EventTriggerType.PointerExit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerDown", UnityEngine.EventSystems.EventTriggerType.PointerDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerUp", UnityEngine.EventSystems.EventTriggerType.PointerUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerClick", UnityEngine.EventSystems.EventTriggerType.PointerClick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Drag", UnityEngine.EventSystems.EventTriggerType.Drag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Drop", UnityEngine.EventSystems.EventTriggerType.Drop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scroll", UnityEngine.EventSystems.EventTriggerType.Scroll);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpdateSelected", UnityEngine.EventSystems.EventTriggerType.UpdateSelected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Select", UnityEngine.EventSystems.EventTriggerType.Select);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Deselect", UnityEngine.EventSystems.EventTriggerType.Deselect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Move", UnityEngine.EventSystems.EventTriggerType.Move);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InitializePotentialDrag", UnityEngine.EventSystems.EventTriggerType.InitializePotentialDrag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BeginDrag", UnityEngine.EventSystems.EventTriggerType.BeginDrag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndDrag", UnityEngine.EventSystems.EventTriggerType.EndDrag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Submit", UnityEngine.EventSystems.EventTriggerType.Submit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cancel", UnityEngine.EventSystems.EventTriggerType.Cancel);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsEventTriggerType(L, (UnityEngine.EventSystems.EventTriggerType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "PointerEnter"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerEnter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerExit"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerExit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerDown"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerUp"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerClick"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerClick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Drag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Drag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Drop"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Drop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scroll"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Scroll);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpdateSelected"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.UpdateSelected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Select"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Select);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Deselect"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Deselect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Move"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Move);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InitializePotentialDrag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.InitializePotentialDrag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BeginDrag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.BeginDrag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndDrag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.EndDrag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Submit"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Submit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cancel"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Cancel);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.EventTriggerType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.EventTriggerType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsMoveDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.EventSystems.MoveDirection.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Up", UnityEngine.EventSystems.MoveDirection.Up);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.EventSystems.MoveDirection.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Down", UnityEngine.EventSystems.MoveDirection.Down);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.EventSystems.MoveDirection.None);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsMoveDirection(L, (UnityEngine.EventSystems.MoveDirection)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Up"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Up);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Down"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Down);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.MoveDirection!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.MoveDirection! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGraphicRaycasterBlockingObjectsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.GraphicRaycaster.BlockingObjects.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TwoD", UnityEngine.UI.GraphicRaycaster.BlockingObjects.TwoD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ThreeD", UnityEngine.UI.GraphicRaycaster.BlockingObjects.ThreeD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", UnityEngine.UI.GraphicRaycaster.BlockingObjects.All);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, (UnityEngine.UI.GraphicRaycaster.BlockingObjects)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TwoD"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.TwoD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ThreeD"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.ThreeD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.All);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GraphicRaycaster.BlockingObjects!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GraphicRaycaster.BlockingObjects! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Type), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Type), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Type), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Simple", UnityEngine.UI.Image.Type.Simple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sliced", UnityEngine.UI.Image.Type.Sliced);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tiled", UnityEngine.UI.Image.Type.Tiled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Filled", UnityEngine.UI.Image.Type.Filled);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Type), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageType(L, (UnityEngine.UI.Image.Type)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Simple"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Simple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sliced"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Sliced);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tiled"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Tiled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Filled"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Filled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Type!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Type! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageFillMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.FillMethod), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.Image.FillMethod.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.Image.FillMethod.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial90", UnityEngine.UI.Image.FillMethod.Radial90);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial180", UnityEngine.UI.Image.FillMethod.Radial180);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial360", UnityEngine.UI.Image.FillMethod.Radial360);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageFillMethod(L, (UnityEngine.UI.Image.FillMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial90"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial90);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial180"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial180);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial360"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial360);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.FillMethod!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.FillMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOriginHorizontalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.OriginHorizontal.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.OriginHorizontal.Right);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOriginHorizontal(L, (UnityEngine.UI.Image.OriginHorizontal)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOriginHorizontal(L, UnityEngine.UI.Image.OriginHorizontal.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOriginHorizontal(L, UnityEngine.UI.Image.OriginHorizontal.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.OriginHorizontal!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.OriginHorizontal! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOriginVerticalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.OriginVertical.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.OriginVertical.Top);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOriginVertical(L, (UnityEngine.UI.Image.OriginVertical)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOriginVertical(L, UnityEngine.UI.Image.OriginVertical.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOriginVertical(L, UnityEngine.UI.Image.OriginVertical.Top);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.OriginVertical!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.OriginVertical! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin90Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin90), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", UnityEngine.UI.Image.Origin90.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", UnityEngine.UI.Image.Origin90.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", UnityEngine.UI.Image.Origin90.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", UnityEngine.UI.Image.Origin90.BottomRight);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin90(L, (UnityEngine.UI.Image.Origin90)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.BottomRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin90!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin90! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin180Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin180), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.Origin180.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.Origin180.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.Origin180.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.Origin180.Right);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin180(L, (UnityEngine.UI.Image.Origin180)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin180!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin180! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin360Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin360), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.Origin360.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.Origin360.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.Origin360.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.Origin360.Left);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin360(L, (UnityEngine.UI.Image.Origin360)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Left);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin360!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin360! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldContentTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.ContentType), L, null, 11, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", UnityEngine.UI.InputField.ContentType.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Autocorrected", UnityEngine.UI.InputField.ContentType.Autocorrected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IntegerNumber", UnityEngine.UI.InputField.ContentType.IntegerNumber);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecimalNumber", UnityEngine.UI.InputField.ContentType.DecimalNumber);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alphanumeric", UnityEngine.UI.InputField.ContentType.Alphanumeric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", UnityEngine.UI.InputField.ContentType.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.UI.InputField.ContentType.EmailAddress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Password", UnityEngine.UI.InputField.ContentType.Password);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pin", UnityEngine.UI.InputField.ContentType.Pin);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", UnityEngine.UI.InputField.ContentType.Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldContentType(L, (UnityEngine.UI.InputField.ContentType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Autocorrected"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Autocorrected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IntegerNumber"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.IntegerNumber);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecimalNumber"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.DecimalNumber);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alphanumeric"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Alphanumeric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.EmailAddress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Password"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Password);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pin"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Pin);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.ContentType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.ContentType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldInputTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.InputType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", UnityEngine.UI.InputField.InputType.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoCorrect", UnityEngine.UI.InputField.InputType.AutoCorrect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Password", UnityEngine.UI.InputField.InputType.Password);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldInputType(L, (UnityEngine.UI.InputField.InputType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoCorrect"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.AutoCorrect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Password"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.Password);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.InputType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.InputType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldCharacterValidationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.InputField.CharacterValidation.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Integer", UnityEngine.UI.InputField.CharacterValidation.Integer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Decimal", UnityEngine.UI.InputField.CharacterValidation.Decimal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alphanumeric", UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", UnityEngine.UI.InputField.CharacterValidation.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldCharacterValidation(L, (UnityEngine.UI.InputField.CharacterValidation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Integer"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Integer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Decimal"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Decimal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alphanumeric"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.CharacterValidation!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.CharacterValidation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldLineTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.LineType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleLine", UnityEngine.UI.InputField.LineType.SingleLine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MultiLineSubmit", UnityEngine.UI.InputField.LineType.MultiLineSubmit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MultiLineNewline", UnityEngine.UI.InputField.LineType.MultiLineNewline);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldLineType(L, (UnityEngine.UI.InputField.LineType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "SingleLine"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.SingleLine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MultiLineSubmit"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.MultiLineSubmit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MultiLineNewline"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.MultiLineNewline);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.LineType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.LineType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIAspectRatioFitterAspectModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.AspectRatioFitter.AspectMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WidthControlsHeight", UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeightControlsWidth", UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitInParent", UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnvelopeParent", UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, (UnityEngine.UI.AspectRatioFitter.AspectMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WidthControlsHeight"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HeightControlsWidth"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitInParent"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnvelopeParent"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.AspectRatioFitter.AspectMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.AspectRatioFitter.AspectMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScaleMode(L, (UnityEngine.UI.CanvasScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScaleMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Expand", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, (UnityEngine.UI.CanvasScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Expand"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScreenMatchMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerUnitWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Centimeters", UnityEngine.UI.CanvasScaler.Unit.Centimeters);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Millimeters", UnityEngine.UI.CanvasScaler.Unit.Millimeters);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Inches", UnityEngine.UI.CanvasScaler.Unit.Inches);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Points", UnityEngine.UI.CanvasScaler.Unit.Points);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Picas", UnityEngine.UI.CanvasScaler.Unit.Picas);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerUnit(L, (UnityEngine.UI.CanvasScaler.Unit)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Centimeters"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Centimeters);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Millimeters"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Millimeters);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Inches"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Inches);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Points"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Points);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Picas"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Picas);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.Unit!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.Unit! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIContentSizeFitterFitModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unconstrained", UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MinSize", UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreferredSize", UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIContentSizeFitterFitMode(L, (UnityEngine.UI.ContentSizeFitter.FitMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unconstrained"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MinSize"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreferredSize"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ContentSizeFitter.FitMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ContentSizeFitter.FitMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupCornerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLeft", UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperRight", UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLeft", UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerRight", UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupCorner(L, (UnityEngine.UI.GridLayoutGroup.Corner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLeft"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperRight"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLeft"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerRight"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Corner!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Corner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupAxis(L, (UnityEngine.UI.GridLayoutGroup.Axis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupAxis(L, UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupAxis(L, UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Axis!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Axis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupConstraintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flexible", UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedColumnCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedRowCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupConstraint(L, (UnityEngine.UI.GridLayoutGroup.Constraint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Flexible"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedColumnCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedRowCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Constraint!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Constraint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUINavigationModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Navigation.Mode), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Navigation.Mode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.Navigation.Mode.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.Navigation.Mode.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Automatic", UnityEngine.UI.Navigation.Mode.Automatic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Explicit", UnityEngine.UI.Navigation.Mode.Explicit);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUINavigationMode(L, (UnityEngine.UI.Navigation.Mode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Automatic"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Automatic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Explicit"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Explicit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Navigation.Mode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Navigation.Mode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollRectMovementTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unrestricted", UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Elastic", UnityEngine.UI.ScrollRect.MovementType.Elastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clamped", UnityEngine.UI.ScrollRect.MovementType.Clamped);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollRectMovementType(L, (UnityEngine.UI.ScrollRect.MovementType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unrestricted"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Elastic"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Elastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clamped"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Clamped);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ScrollRect.MovementType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ScrollRect.MovementType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollRectScrollbarVisibilityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Permanent", UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoHide", UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoHideAndExpandViewport", UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, (UnityEngine.UI.ScrollRect.ScrollbarVisibility)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Permanent"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoHide"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoHideAndExpandViewport"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ScrollRect.ScrollbarVisibility!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ScrollRect.ScrollbarVisibility! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollbarDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftToRight", UnityEngine.UI.Scrollbar.Direction.LeftToRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightToLeft", UnityEngine.UI.Scrollbar.Direction.RightToLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomToTop", UnityEngine.UI.Scrollbar.Direction.BottomToTop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopToBottom", UnityEngine.UI.Scrollbar.Direction.TopToBottom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollbarDirection(L, (UnityEngine.UI.Scrollbar.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftToRight"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.LeftToRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightToLeft"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.RightToLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomToTop"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.BottomToTop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopToBottom"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.TopToBottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Scrollbar.Direction!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Scrollbar.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISliderDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Slider.Direction), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftToRight", UnityEngine.UI.Slider.Direction.LeftToRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightToLeft", UnityEngine.UI.Slider.Direction.RightToLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomToTop", UnityEngine.UI.Slider.Direction.BottomToTop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopToBottom", UnityEngine.UI.Slider.Direction.TopToBottom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISliderDirection(L, (UnityEngine.UI.Slider.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftToRight"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.LeftToRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightToLeft"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.RightToLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomToTop"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.BottomToTop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopToBottom"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.TopToBottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Slider.Direction!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Slider.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIToggleToggleTransitionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Toggle.ToggleTransition.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fade", UnityEngine.UI.Toggle.ToggleTransition.Fade);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIToggleToggleTransition(L, (UnityEngine.UI.Toggle.ToggleTransition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIToggleToggleTransition(L, UnityEngine.UI.Toggle.ToggleTransition.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fade"))
                {
                    translator.PushUnityEngineUIToggleToggleTransition(L, UnityEngine.UI.Toggle.ToggleTransition.Fade);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Toggle.ToggleTransition!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Toggle.ToggleTransition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsPointerEventDataInputButtonWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.EventSystems.PointerEventData.InputButton.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.EventSystems.PointerEventData.InputButton.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Middle", UnityEngine.EventSystems.PointerEventData.InputButton.Middle);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, (UnityEngine.EventSystems.PointerEventData.InputButton)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, UnityEngine.EventSystems.PointerEventData.InputButton.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, UnityEngine.EventSystems.PointerEventData.InputButton.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Middle"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, UnityEngine.EventSystems.PointerEventData.InputButton.Middle);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.PointerEventData.InputButton!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.PointerEventData.InputButton! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsPointerEventDataFramePressStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pressed", UnityEngine.EventSystems.PointerEventData.FramePressState.Pressed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Released", UnityEngine.EventSystems.PointerEventData.FramePressState.Released);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PressedAndReleased", UnityEngine.EventSystems.PointerEventData.FramePressState.PressedAndReleased);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotChanged", UnityEngine.EventSystems.PointerEventData.FramePressState.NotChanged);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, (UnityEngine.EventSystems.PointerEventData.FramePressState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Pressed"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.Pressed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Released"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.Released);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PressedAndReleased"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.PressedAndReleased);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotChanged"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.NotChanged);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.PointerEventData.FramePressState!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.PointerEventData.FramePressState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}