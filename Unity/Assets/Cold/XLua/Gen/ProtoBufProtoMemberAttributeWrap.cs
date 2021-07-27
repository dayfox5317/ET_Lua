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
    public partial class ProtoBufProtoMemberAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ProtoBuf.ProtoMemberAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 9, 8);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getName", _g_get_Name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDataFormat", _g_get_DataFormat);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTag", _g_get_Tag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsRequired", _g_get_IsRequired);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsPacked", _g_get_IsPacked);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOverwriteList", _g_get_OverwriteList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAsReference", _g_get_AsReference);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDynamicType", _g_get_DynamicType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOptions", _g_get_Options);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setName", _s_set_Name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDataFormat", _s_set_DataFormat);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsRequired", _s_set_IsRequired);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsPacked", _s_set_IsPacked);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setOverwriteList", _s_set_OverwriteList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAsReference", _s_set_AsReference);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDynamicType", _s_set_DynamicType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setOptions", _s_set_Options);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Name", _g_get_Name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DataFormat", _g_get_DataFormat);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Tag", _g_get_Tag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsRequired", _g_get_IsRequired);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPacked", _g_get_IsPacked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OverwriteList", _g_get_OverwriteList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsReference", _g_get_AsReference);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DynamicType", _g_get_DynamicType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Options", _g_get_Options);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Name", _s_set_Name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DataFormat", _s_set_DataFormat);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsRequired", _s_set_IsRequired);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsPacked", _s_set_IsPacked);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OverwriteList", _s_set_OverwriteList);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AsReference", _s_set_AsReference);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DynamicType", _s_set_DynamicType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Options", _s_set_Options);
            
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _tag = LuaAPI.xlua_tointeger(L, 2);
					
					ProtoBuf.ProtoMemberAttribute gen_ret = new ProtoBuf.ProtoMemberAttribute(_tag);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ProtoBuf.ProtoMemberAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _other = translator.GetObject(L, 2, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( 
                        _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<ProtoBuf.ProtoMemberAttribute>(L, 2)) 
                {
                    ProtoBuf.ProtoMemberAttribute _other = (ProtoBuf.ProtoMemberAttribute)translator.GetObject(L, 2, typeof(ProtoBuf.ProtoMemberAttribute));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( 
                        _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ProtoBuf.ProtoMemberAttribute.CompareTo!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DataFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DataFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Tag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Tag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsRequired(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsRequired);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPacked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPacked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OverwriteList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.OverwriteList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AsReference);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DynamicType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.DynamicType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Options(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Options);
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
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DataFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                ProtoBuf.DataFormat gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DataFormat = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsRequired(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsRequired = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsPacked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsPacked = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OverwriteList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OverwriteList = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AsReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AsReference = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DynamicType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DynamicType = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Options(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoMemberAttribute gen_to_be_invoked = (ProtoBuf.ProtoMemberAttribute)translator.FastGetCSObj(L, 1);
                ProtoBuf.MemberSerializationOptions gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Options = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
