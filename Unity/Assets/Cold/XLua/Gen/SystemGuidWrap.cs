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
    public partial class SystemGuidWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Guid);
			Utils.BeginObjectRegister(type, L, translator, 1, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "__clone__", __clone__);
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToByteArray", _m_ToByteArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Parse", _m_Parse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryParse", _m_TryParse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseExact", _m_ParseExact_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryParseExact", _m_TryParseExact_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "op_Equality",__EqMeta);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "op_Inequality", _m_op_Inequality);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewGuid", _m_NewGuid_xlua_st_);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getEmpty", System.Guid.Empty);
            
			
			
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Empty", System.Guid.Empty);
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int __clone__(RealStatePtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				System.Guid gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
				translator.Push(L, gen_to_be_invoked);
				return 1;
			}
			catch (System.Exception e)
			{
				return LuaAPI.luaL_error(L, "c# exception in StructClone:" + e);
			}
		}
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					byte[] _b = LuaAPI.lua_tobytes(L, 2);
					
					System.Guid gen_ret = new System.Guid(_b);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 12 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12))
				{
					uint _a = LuaAPI.xlua_touint(L, 2);
					ushort _b = (ushort)LuaAPI.xlua_tointeger(L, 3);
					ushort _c = (ushort)LuaAPI.xlua_tointeger(L, 4);
					byte _d = (byte)LuaAPI.xlua_tointeger(L, 5);
					byte _e = (byte)LuaAPI.xlua_tointeger(L, 6);
					byte _f = (byte)LuaAPI.xlua_tointeger(L, 7);
					byte _g = (byte)LuaAPI.xlua_tointeger(L, 8);
					byte _h = (byte)LuaAPI.xlua_tointeger(L, 9);
					byte _i = (byte)LuaAPI.xlua_tointeger(L, 10);
					byte _j = (byte)LuaAPI.xlua_tointeger(L, 11);
					byte _k = (byte)LuaAPI.xlua_tointeger(L, 12);
					
					System.Guid gen_ret = new System.Guid(_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING))
				{
					int _a = LuaAPI.xlua_tointeger(L, 2);
					short _b = (short)LuaAPI.xlua_tointeger(L, 3);
					short _c = (short)LuaAPI.xlua_tointeger(L, 4);
					byte[] _d = LuaAPI.lua_tobytes(L, 5);
					
					System.Guid gen_ret = new System.Guid(_a, _b, _c, _d);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 12 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12))
				{
					int _a = LuaAPI.xlua_tointeger(L, 2);
					short _b = (short)LuaAPI.xlua_tointeger(L, 3);
					short _c = (short)LuaAPI.xlua_tointeger(L, 4);
					byte _d = (byte)LuaAPI.xlua_tointeger(L, 5);
					byte _e = (byte)LuaAPI.xlua_tointeger(L, 6);
					byte _f = (byte)LuaAPI.xlua_tointeger(L, 7);
					byte _g = (byte)LuaAPI.xlua_tointeger(L, 8);
					byte _h = (byte)LuaAPI.xlua_tointeger(L, 9);
					byte _i = (byte)LuaAPI.xlua_tointeger(L, 10);
					byte _j = (byte)LuaAPI.xlua_tointeger(L, 11);
					byte _k = (byte)LuaAPI.xlua_tointeger(L, 12);
					
					System.Guid gen_ret = new System.Guid(_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _g = LuaAPI.lua_tostring(L, 2);
					
					System.Guid gen_ret = new System.Guid(_g);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(System.Guid));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Guid constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<System.Guid>(L, 1) && translator.Assignable<System.Guid>(L, 2))
				{
					System.Guid leftside;translator.Get(L, 1, out leftside);
					System.Guid rightside;translator.Get(L, 2, out rightside);
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need System.Guid!");
            
        }
        

		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_op_Inequality(RealStatePtr L)
        {					
			
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<System.Guid>(L, 1) && translator.Assignable<System.Guid>(L, 2))
				{
					System.Guid leftside;translator.Get(L, 1, out leftside);
					System.Guid rightside;translator.Get(L, 2, out rightside);

					LuaAPI.lua_pushboolean(L, leftside != rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of != operator, need System.Guid!");
            
        }
        
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Parse_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _input = LuaAPI.lua_tostring(L, 1);
                    
                        System.Guid gen_ret = System.Guid.Parse( 
                        _input );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryParse_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _input = LuaAPI.lua_tostring(L, 1);
                    System.Guid _result;
                    
                        bool gen_ret = System.Guid.TryParse( 
                        _input, 
                        out _result );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _result);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseExact_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _input = LuaAPI.lua_tostring(L, 1);
                    string _format = LuaAPI.lua_tostring(L, 2);
                    
                        System.Guid gen_ret = System.Guid.ParseExact( 
                        _input, 
                        _format );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryParseExact_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _input = LuaAPI.lua_tostring(L, 1);
                    string _format = LuaAPI.lua_tostring(L, 2);
                    System.Guid _result;
                    
                        bool gen_ret = System.Guid.TryParseExact( 
                        _input, 
                        _format, 
                        out _result );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _result);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToByteArray(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Guid gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.ToByteArray(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Guid gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.ToString( 
                        _format );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.IFormatProvider>(L, 3)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    System.IFormatProvider _provider = (System.IFormatProvider)translator.GetObject(L, 3, typeof(System.IFormatProvider));
                    
                        string gen_ret = gen_to_be_invoked.ToString( 
                        _format, 
                        _provider );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Guid.ToString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Guid gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Guid gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _o = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( 
                        _o );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    System.Guid _g;translator.Get(L, 2, out _g);
                    
                        bool gen_ret = gen_to_be_invoked.Equals( 
                        _g );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Guid.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Guid gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( 
                        _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    System.Guid _value;translator.Get(L, 2, out _value);
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( 
                        _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Guid.CompareTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewGuid_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Guid gen_ret = System.Guid.NewGuid(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
