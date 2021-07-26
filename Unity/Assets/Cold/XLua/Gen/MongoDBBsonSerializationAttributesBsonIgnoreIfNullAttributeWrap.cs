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
    public partial class MongoDBBsonSerializationAttributesBsonIgnoreIfNullAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getValue", _g_get_Value);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Value", _g_get_Value);
            
			
			
			
			
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
					
					MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2))
				{
					bool _value = LuaAPI.lua_toboolean(L, 2);
					
					MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute(_value);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonMemberMap _memberMap = (MongoDB.Bson.Serialization.BsonMemberMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonMemberMap));
                    
                    gen_to_be_invoked.Apply( 
                        _memberMap );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Value);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
