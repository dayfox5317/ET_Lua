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
    public partial class ProtoBufProtoIncludeAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ProtoBuf.ProtoIncludeAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 4, 1);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTag", _g_get_Tag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getKnownTypeName", _g_get_KnownTypeName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getKnownType", _g_get_KnownType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDataFormat", _g_get_DataFormat);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDataFormat", _s_set_DataFormat);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Tag", _g_get_Tag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "KnownTypeName", _g_get_KnownTypeName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "KnownType", _g_get_KnownType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DataFormat", _g_get_DataFormat);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "DataFormat", _s_set_DataFormat);
            
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<System.Type>(L, 3))
				{
					int _tag = LuaAPI.xlua_tointeger(L, 2);
					System.Type _knownType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
					
					ProtoBuf.ProtoIncludeAttribute gen_ret = new ProtoBuf.ProtoIncludeAttribute(_tag, _knownType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					int _tag = LuaAPI.xlua_tointeger(L, 2);
					string _knownTypeName = LuaAPI.lua_tostring(L, 3);
					
					ProtoBuf.ProtoIncludeAttribute gen_ret = new ProtoBuf.ProtoIncludeAttribute(_tag, _knownTypeName);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ProtoBuf.ProtoIncludeAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Tag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoIncludeAttribute gen_to_be_invoked = (ProtoBuf.ProtoIncludeAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Tag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KnownTypeName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoIncludeAttribute gen_to_be_invoked = (ProtoBuf.ProtoIncludeAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.KnownTypeName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KnownType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoIncludeAttribute gen_to_be_invoked = (ProtoBuf.ProtoIncludeAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.KnownType);
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
			
                ProtoBuf.ProtoIncludeAttribute gen_to_be_invoked = (ProtoBuf.ProtoIncludeAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DataFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DataFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ProtoBuf.ProtoIncludeAttribute gen_to_be_invoked = (ProtoBuf.ProtoIncludeAttribute)translator.FastGetCSObj(L, 1);
                ProtoBuf.DataFormat gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DataFormat = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
