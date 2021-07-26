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
    public partial class SystemCollectionsConcurrentConcurrentDictionary_2_SystemInt64SystemUInt64_Wrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Collections.Concurrent.ConcurrentDictionary<long, ulong>);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 4, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryAdd", _m_TryAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsKey", _m_ContainsKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryRemove", _m_TryRemove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetValue", _m_TryGetValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryUpdate", _m_TryUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToArray", _m_ToArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOrAdd", _m_GetOrAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddOrUpdate", _m_AddOrUpdate);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCount", _g_get_Count);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsEmpty", _g_get_IsEmpty);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getKeys", _g_get_Keys);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getValues", _g_get_Values);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsEmpty", _g_get_IsEmpty);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Keys", _g_get_Keys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Values", _g_get_Values);
            
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
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
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					int _concurrencyLevel = LuaAPI.xlua_tointeger(L, 2);
					int _capacity = LuaAPI.xlua_tointeger(L, 3);
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>(_concurrencyLevel, _capacity);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>> _collection = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>));
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>(_collection);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEqualityComparer<long>>(L, 2))
				{
					System.Collections.Generic.IEqualityComparer<long> _comparer = (System.Collections.Generic.IEqualityComparer<long>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEqualityComparer<long>));
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>(_comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>>(L, 2) && translator.Assignable<System.Collections.Generic.IEqualityComparer<long>>(L, 3))
				{
					System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>> _collection = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>));
					System.Collections.Generic.IEqualityComparer<long> _comparer = (System.Collections.Generic.IEqualityComparer<long>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEqualityComparer<long>));
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>(_collection, _comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>>(L, 3) && translator.Assignable<System.Collections.Generic.IEqualityComparer<long>>(L, 4))
				{
					int _concurrencyLevel = LuaAPI.xlua_tointeger(L, 2);
					System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>> _collection = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<long, ulong>>));
					System.Collections.Generic.IEqualityComparer<long> _comparer = (System.Collections.Generic.IEqualityComparer<long>)translator.GetObject(L, 4, typeof(System.Collections.Generic.IEqualityComparer<long>));
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>(_concurrencyLevel, _collection, _comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<System.Collections.Generic.IEqualityComparer<long>>(L, 4))
				{
					int _concurrencyLevel = LuaAPI.xlua_tointeger(L, 2);
					int _capacity = LuaAPI.xlua_tointeger(L, 3);
					System.Collections.Generic.IEqualityComparer<long> _comparer = (System.Collections.Generic.IEqualityComparer<long>)translator.GetObject(L, 4, typeof(System.Collections.Generic.IEqualityComparer<long>));
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_ret = new System.Collections.Concurrent.ConcurrentDictionary<long, ulong>(_concurrencyLevel, _capacity, _comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Concurrent.ConcurrentDictionary<long, ulong> constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<System.Collections.Concurrent.ConcurrentDictionary<long, ulong>>(L, 1) && (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2)))
				{
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
					long index = LuaAPI.lua_toint64(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					LuaAPI.lua_pushuint64(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<System.Collections.Concurrent.ConcurrentDictionary<long, ulong>>(L, 1) && (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2)) && (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3)))
				{
					
					System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
					long key = LuaAPI.lua_toint64(L, 2);
					gen_to_be_invoked[key] = LuaAPI.lua_touint64(L, 3);
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryAdd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    ulong _value = LuaAPI.lua_touint64(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.TryAdd( 
                        _key, 
                        _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsKey(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.ContainsKey( 
                        _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryRemove(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    ulong _value;
                    
                        bool gen_ret = gen_to_be_invoked.TryRemove( 
                        _key, 
                        out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushuint64(L, _value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetValue(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    ulong _value;
                    
                        bool gen_ret = gen_to_be_invoked.TryGetValue( 
                        _key, 
                        out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushuint64(L, _value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryUpdate(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    ulong _newValue = LuaAPI.lua_touint64(L, 3);
                    ulong _comparisonValue = LuaAPI.lua_touint64(L, 4);
                    
                        bool gen_ret = gen_to_be_invoked.TryUpdate( 
                        _key, 
                        _newValue, 
                        _comparisonValue );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToArray(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.KeyValuePair<long, ulong>[] gen_ret = gen_to_be_invoked.ToArray(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<long, ulong>> gen_ret = gen_to_be_invoked.GetEnumerator(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOrAdd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))) 
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    ulong _value = LuaAPI.lua_touint64(L, 3);
                    
                        ulong gen_ret = gen_to_be_invoked.GetOrAdd( 
                        _key, 
                        _value );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& translator.Assignable<System.Func<long, ulong>>(L, 3)) 
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    System.Func<long, ulong> _valueFactory = translator.GetDelegate<System.Func<long, ulong>>(L, 3);
                    
                        ulong gen_ret = gen_to_be_invoked.GetOrAdd( 
                        _key, 
                        _valueFactory );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Concurrent.ConcurrentDictionary<long, ulong>.GetOrAdd!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddOrUpdate(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))&& translator.Assignable<System.Func<long, ulong, ulong>>(L, 4)) 
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    ulong _addValue = LuaAPI.lua_touint64(L, 3);
                    System.Func<long, ulong, ulong> _updateValueFactory = translator.GetDelegate<System.Func<long, ulong, ulong>>(L, 4);
                    
                        ulong gen_ret = gen_to_be_invoked.AddOrUpdate( 
                        _key, 
                        _addValue, 
                        _updateValueFactory );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& translator.Assignable<System.Func<long, ulong>>(L, 3)&& translator.Assignable<System.Func<long, ulong, ulong>>(L, 4)) 
                {
                    long _key = LuaAPI.lua_toint64(L, 2);
                    System.Func<long, ulong> _addValueFactory = translator.GetDelegate<System.Func<long, ulong>>(L, 3);
                    System.Func<long, ulong, ulong> _updateValueFactory = translator.GetDelegate<System.Func<long, ulong, ulong>>(L, 4);
                    
                        ulong gen_ret = gen_to_be_invoked.AddOrUpdate( 
                        _key, 
                        _addValueFactory, 
                        _updateValueFactory );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Concurrent.ConcurrentDictionary<long, ulong>.AddOrUpdate!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEmpty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsEmpty);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keys(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Keys);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Values(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Concurrent.ConcurrentDictionary<long, ulong> gen_to_be_invoked = (System.Collections.Concurrent.ConcurrentDictionary<long, ulong>)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Values);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
