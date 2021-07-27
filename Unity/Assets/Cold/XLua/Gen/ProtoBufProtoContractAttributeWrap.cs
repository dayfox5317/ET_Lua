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
    public partial class ProtoBufProtoContractAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ProtoBuf.ProtoContractAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 24, 12, 12);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getName", _g_get_Name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getImplicitFirstTag", _g_get_ImplicitFirstTag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getUseProtoMembersOnly", _g_get_UseProtoMembersOnly);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIgnoreListHandling", _g_get_IgnoreListHandling);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getImplicitFields", _g_get_ImplicitFields);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getInferTagFromName", _g_get_InferTagFromName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDataMemberOffset", _g_get_DataMemberOffset);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSkipConstructor", _g_get_SkipConstructor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAsReferenceDefault", _g_get_AsReferenceDefault);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsGroup", _g_get_IsGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEnumPassthru", _g_get_EnumPassthru);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSurrogate", _g_get_Surrogate);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setName", _s_set_Name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setImplicitFirstTag", _s_set_ImplicitFirstTag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setUseProtoMembersOnly", _s_set_UseProtoMembersOnly);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIgnoreListHandling", _s_set_IgnoreListHandling);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setImplicitFields", _s_set_ImplicitFields);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setInferTagFromName", _s_set_InferTagFromName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDataMemberOffset", _s_set_DataMemberOffset);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSkipConstructor", _s_set_SkipConstructor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAsReferenceDefault", _s_set_AsReferenceDefault);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsGroup", _s_set_IsGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setEnumPassthru", _s_set_EnumPassthru);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSurrogate", _s_set_Surrogate);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Name", _g_get_Name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ImplicitFirstTag", _g_get_ImplicitFirstTag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UseProtoMembersOnly", _g_get_UseProtoMembersOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IgnoreListHandling", _g_get_IgnoreListHandling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ImplicitFields", _g_get_ImplicitFields);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InferTagFromName", _g_get_InferTagFromName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DataMemberOffset", _g_get_DataMemberOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SkipConstructor", _g_get_SkipConstructor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsReferenceDefault", _g_get_AsReferenceDefault);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsGroup", _g_get_IsGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EnumPassthru", _g_get_EnumPassthru);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Surrogate", _g_get_Surrogate);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Name", _s_set_Name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ImplicitFirstTag", _s_set_ImplicitFirstTag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UseProtoMembersOnly", _s_set_UseProtoMembersOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IgnoreListHandling", _s_set_IgnoreListHandling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ImplicitFields", _s_set_ImplicitFields);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InferTagFromName", _s_set_InferTagFromName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DataMemberOffset", _s_set_DataMemberOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SkipConstructor", _s_set_SkipConstructor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AsReferenceDefault", _s_set_AsReferenceDefault);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsGroup", _s_set_IsGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EnumPassthru", _s_set_EnumPassthru);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Surrogate", _s_set_Surrogate);
            
			
			
			
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
					
					ProtoBuf.ProtoContractAttribute gen_ret = new ProtoBuf.ProtoContractAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ProtoBuf.ProtoContractAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ImplicitFirstTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ImplicitFirstTag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UseProtoMembersOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.UseProtoMembersOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IgnoreListHandling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IgnoreListHandling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ImplicitFields(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ImplicitFields);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InferTagFromName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.InferTagFromName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DataMemberOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.DataMemberOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SkipConstructor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.SkipConstructor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsReferenceDefault(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AsReferenceDefault);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EnumPassthru(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.EnumPassthru);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Surrogate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Surrogate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ImplicitFirstTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ImplicitFirstTag = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UseProtoMembersOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UseProtoMembersOnly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IgnoreListHandling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IgnoreListHandling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ImplicitFields(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                ProtoBuf.ImplicitFields gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ImplicitFields = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InferTagFromName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InferTagFromName = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DataMemberOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DataMemberOffset = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SkipConstructor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SkipConstructor = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AsReferenceDefault(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AsReferenceDefault = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsGroup = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EnumPassthru(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EnumPassthru = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Surrogate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoContractAttribute gen_to_be_invoked = (ProtoBuf.ProtoContractAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Surrogate = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
