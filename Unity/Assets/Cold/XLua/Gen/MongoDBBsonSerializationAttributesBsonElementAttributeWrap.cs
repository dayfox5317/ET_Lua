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
    public partial class MongoDBBsonSerializationAttributesBsonElementAttributeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Attributes.BsonElementAttribute);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 2, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getElementName", _g_get_ElementName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOrder", _g_get_Order);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setOrder", _s_set_Order);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElementName", _g_get_ElementName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Order", _g_get_Order);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Order", _s_set_Order);
            
			
			
			
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
					
					MongoDB.Bson.Serialization.Attributes.BsonElementAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonElementAttribute();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _elementName = LuaAPI.lua_tostring(L, 2);
					
					MongoDB.Bson.Serialization.Attributes.BsonElementAttribute gen_ret = new MongoDB.Bson.Serialization.Attributes.BsonElementAttribute(_elementName);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Attributes.BsonElementAttribute constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Attributes.BsonElementAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonElementAttribute)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_ElementName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonElementAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonElementAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ElementName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Order(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonElementAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonElementAttribute)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Order);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Order(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Attributes.BsonElementAttribute gen_to_be_invoked = (MongoDB.Bson.Serialization.Attributes.BsonElementAttribute)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Order = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
