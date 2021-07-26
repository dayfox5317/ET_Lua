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
    public partial class MongoDBBsonSerializationBsonSerializerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonSerializer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 24, 3, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Deserialize", _m_Deserialize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsTypeDiscriminated", _m_IsTypeDiscriminated_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookupActualType", _m_LookupActualType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookupDiscriminatorConvention", _m_LookupDiscriminatorConvention_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookupIdGenerator", _m_LookupIdGenerator_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookupSerializer", _m_LookupSerializer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterDiscriminator", _m_RegisterDiscriminator_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterDiscriminatorConvention", _m_RegisterDiscriminatorConvention_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterGenericSerializerDefinition", _m_RegisterGenericSerializerDefinition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterIdGenerator", _m_RegisterIdGenerator_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterSerializationProvider", _m_RegisterSerializationProvider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterSerializer", _m_RegisterSerializer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Serialize", _m_Serialize_xlua_st_);
            
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getSerializerRegistry", _g_get_SerializerRegistry);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getUseNullIdChecker", _g_get_UseNullIdChecker);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getUseZeroIdChecker", _g_get_UseZeroIdChecker);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setUseNullIdChecker", _s_set_UseNullIdChecker);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setUseZeroIdChecker", _s_set_UseZeroIdChecker);
            
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "SerializerRegistry", _g_get_SerializerRegistry);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UseNullIdChecker", _g_get_UseNullIdChecker);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UseZeroIdChecker", _g_get_UseZeroIdChecker);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "UseNullIdChecker", _s_set_UseNullIdChecker);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "UseZeroIdChecker", _s_set_UseZeroIdChecker);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.Serialization.BsonSerializer does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Deserialize_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<MongoDB.Bson.BsonDocument>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3)) 
                {
                    MongoDB.Bson.BsonDocument _document = (MongoDB.Bson.BsonDocument)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonDocument));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3);
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _document, 
                        _nominalType, 
                        _configurator );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonDocument>(L, 1)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    MongoDB.Bson.BsonDocument _document = (MongoDB.Bson.BsonDocument)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonDocument));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _document, 
                        _nominalType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<MongoDB.Bson.IO.IBsonReader>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3)) 
                {
                    MongoDB.Bson.IO.IBsonReader _bsonReader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3);
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _bsonReader, 
                        _nominalType, 
                        _configurator );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.IO.IBsonReader>(L, 1)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    MongoDB.Bson.IO.IBsonReader _bsonReader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _bsonReader, 
                        _nominalType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 1);
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3);
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _bytes, 
                        _nominalType, 
                        _configurator );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 1);
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _bytes, 
                        _nominalType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.IO.Stream>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3)) 
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3);
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _stream, 
                        _nominalType, 
                        _configurator );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.IO.Stream>(L, 1)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _stream, 
                        _nominalType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3)) 
                {
                    string _json = LuaAPI.lua_tostring(L, 1);
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3);
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _json, 
                        _nominalType, 
                        _configurator );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    string _json = LuaAPI.lua_tostring(L, 1);
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _json, 
                        _nominalType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.IO.TextReader>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3)) 
                {
                    System.IO.TextReader _textReader = (System.IO.TextReader)translator.GetObject(L, 1, typeof(System.IO.TextReader));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 3);
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _textReader, 
                        _nominalType, 
                        _configurator );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.IO.TextReader>(L, 1)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.IO.TextReader _textReader = (System.IO.TextReader)translator.GetObject(L, 1, typeof(System.IO.TextReader));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = MongoDB.Bson.Serialization.BsonSerializer.Deserialize( 
                        _textReader, 
                        _nominalType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonSerializer.Deserialize!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTypeDiscriminated_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        bool gen_ret = MongoDB.Bson.Serialization.BsonSerializer.IsTypeDiscriminated( 
                        _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LookupActualType_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    MongoDB.Bson.BsonValue _discriminator = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        System.Type gen_ret = MongoDB.Bson.Serialization.BsonSerializer.LookupActualType( 
                        _nominalType, 
                        _discriminator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LookupDiscriminatorConvention_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        MongoDB.Bson.Serialization.Conventions.IDiscriminatorConvention gen_ret = MongoDB.Bson.Serialization.BsonSerializer.LookupDiscriminatorConvention( 
                        _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LookupIdGenerator_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        MongoDB.Bson.Serialization.IIdGenerator gen_ret = MongoDB.Bson.Serialization.BsonSerializer.LookupIdGenerator( 
                        _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LookupSerializer_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        MongoDB.Bson.Serialization.IBsonSerializer gen_ret = MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer( 
                        _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterDiscriminator_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    MongoDB.Bson.BsonValue _discriminator = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.RegisterDiscriminator( 
                        _type, 
                        _discriminator );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterDiscriminatorConvention_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    MongoDB.Bson.Serialization.Conventions.IDiscriminatorConvention _convention = (MongoDB.Bson.Serialization.Conventions.IDiscriminatorConvention)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.Conventions.IDiscriminatorConvention));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.RegisterDiscriminatorConvention( 
                        _type, 
                        _convention );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterGenericSerializerDefinition_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _genericTypeDefinition = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Type _genericSerializerDefinition = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.RegisterGenericSerializerDefinition( 
                        _genericTypeDefinition, 
                        _genericSerializerDefinition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterIdGenerator_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    MongoDB.Bson.Serialization.IIdGenerator _idGenerator = (MongoDB.Bson.Serialization.IIdGenerator)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IIdGenerator));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.RegisterIdGenerator( 
                        _type, 
                        _idGenerator );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterSerializationProvider_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.Serialization.IBsonSerializationProvider _provider = (MongoDB.Bson.Serialization.IBsonSerializationProvider)translator.GetObject(L, 1, typeof(MongoDB.Bson.Serialization.IBsonSerializationProvider));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.RegisterSerializationProvider( 
                        _provider );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterSerializer_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.RegisterSerializer( 
                        _type, 
                        _serializer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Serialize_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<MongoDB.Bson.IO.IBsonWriter>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4)&& translator.Assignable<MongoDB.Bson.Serialization.BsonSerializationArgs>(L, 5)) 
                {
                    MongoDB.Bson.IO.IBsonWriter _bsonWriter = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    object _value = translator.GetObject(L, 3, typeof(object));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4);
                    MongoDB.Bson.Serialization.BsonSerializationArgs _args;translator.Get(L, 5, out _args);
                    
                    MongoDB.Bson.Serialization.BsonSerializer.Serialize( 
                        _bsonWriter, 
                        _nominalType, 
                        _value, 
                        _configurator, 
                        _args );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<MongoDB.Bson.IO.IBsonWriter>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4)) 
                {
                    MongoDB.Bson.IO.IBsonWriter _bsonWriter = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    object _value = translator.GetObject(L, 3, typeof(object));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4);
                    
                    MongoDB.Bson.Serialization.BsonSerializer.Serialize( 
                        _bsonWriter, 
                        _nominalType, 
                        _value, 
                        _configurator );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<MongoDB.Bson.IO.IBsonWriter>(L, 1)&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    MongoDB.Bson.IO.IBsonWriter _bsonWriter = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                    MongoDB.Bson.Serialization.BsonSerializer.Serialize( 
                        _bsonWriter, 
                        _nominalType, 
                        _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonSerializer.Serialize!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SerializerRegistry(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushAny(L, MongoDB.Bson.Serialization.BsonSerializer.SerializerRegistry);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UseNullIdChecker(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, MongoDB.Bson.Serialization.BsonSerializer.UseNullIdChecker);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UseZeroIdChecker(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, MongoDB.Bson.Serialization.BsonSerializer.UseZeroIdChecker);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UseNullIdChecker(RealStatePtr L)
        {
		    try {
                
			    MongoDB.Bson.Serialization.BsonSerializer.UseNullIdChecker = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UseZeroIdChecker(RealStatePtr L)
        {
		    try {
                
			    MongoDB.Bson.Serialization.BsonSerializer.UseZeroIdChecker = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
