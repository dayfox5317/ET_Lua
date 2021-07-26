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