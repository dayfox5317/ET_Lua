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
    public partial class MongoDBBsonSerializationAttributesBsonDictionaryOptionsAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 1);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRepresentation", _g_get_Representation);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRepresentation", _s_set_Representation);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Representation", _g_get_Representation);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Representation", _s_set_Representation);
            
			
			
			
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
					
					MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<MongoDB.Bson.Serialization.Options.DictionaryRepresentation>(L, 2))
				{
					MongoDB.Bson.Serialization.Options.DictionaryRepresentation _representation;translator.Get(L, 2, out _representation);
					
					MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute(_representation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Representation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Representation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Representation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute)translator.FastGetCSObj(L, 1);
                MongoDB.Bson.Serialization.Options.DictionaryRepresentation gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Representation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
