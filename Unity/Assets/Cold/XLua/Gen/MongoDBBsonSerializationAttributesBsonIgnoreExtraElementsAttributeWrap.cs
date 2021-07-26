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
    public partial class MongoDBBsonSerializationAttributesBsonIgnoreExtraElementsAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 2, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIgnoreExtraElements", _g_get_IgnoreExtraElements);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getInherited", _g_get_Inherited);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setInherited", _s_set_Inherited);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IgnoreExtraElements", _g_get_IgnoreExtraElements);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Inherited", _g_get_Inherited);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Inherited", _s_set_Inherited);
            
			
			
			
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
					
					MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2))
				{
					bool _ignoreExtraElements = LuaAPI.lua_toboolean(L, 2);
					
					MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute(_ignoreExtraElements);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonClassMap _classMap = (MongoDB.Bson.Serialization.BsonClassMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonClassMap));
                    
                    gen_to_be_invoked.Apply( 
                        _classMap );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IgnoreExtraElements(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IgnoreExtraElements);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Inherited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Inherited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Inherited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Inherited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
