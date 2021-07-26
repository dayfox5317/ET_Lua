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
    public partial class ETColdArrayHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.ArrayHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Test", _m_Test_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLength", _m_GetLength_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStringItem", _m_GetStringItem_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUnityObjectItem", _m_GetUnityObjectItem_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMemberItem", _m_GetMemberItem_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRawMemberItem", _m_GetRawMemberItem_xlua_st_);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.ArrayHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Test_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _array = translator.GetObject(L, 1, typeof(object));
                    
                    ETCold.ArrayHelper.Test( 
                        _array );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLength_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    
                        int gen_ret = ETCold.ArrayHelper.GetLength( 
                        _array );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStringItem_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string[] _array = (string[])translator.GetObject(L, 1, typeof(string[]));
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = ETCold.ArrayHelper.GetStringItem( 
                        _array, 
                        _index );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUnityObjectItem_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object[] _array = (UnityEngine.Object[])translator.GetObject(L, 1, typeof(UnityEngine.Object[]));
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Object gen_ret = ETCold.ArrayHelper.GetUnityObjectItem( 
                        _array, 
                        _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMemberItem_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Reflection.MemberInfo[] _array = (System.Reflection.MemberInfo[])translator.GetObject(L, 1, typeof(System.Reflection.MemberInfo[]));
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.Reflection.MemberInfo gen_ret = ETCold.ArrayHelper.GetMemberItem( 
                        _array, 
                        _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRawMemberItem_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ETCold.RawMemberInfo[] _array = (ETCold.RawMemberInfo[])translator.GetObject(L, 1, typeof(ETCold.RawMemberInfo[]));
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        ETCold.RawMemberInfo gen_ret = ETCold.ArrayHelper.GetRawMemberItem( 
                        _array, 
                        _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
