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
    public partial class ETColdRawFieldInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.RawFieldInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 2, 2);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getGetValue", _g_get_GetValue);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSetValue", _g_get_SetValue);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setGetValue", _s_set_GetValue);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSetValue", _s_set_SetValue);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "GetValue", _g_get_GetValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SetValue", _g_get_SetValue);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "GetValue", _s_set_GetValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SetValue", _s_set_SetValue);
            
			
			
			
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
					
					ETCold.RawFieldInfo gen_ret = new ETCold.RawFieldInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.RawFieldInfo constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawFieldInfo gen_to_be_invoked = (ETCold.RawFieldInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.GetValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SetValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawFieldInfo gen_to_be_invoked = (ETCold.RawFieldInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SetValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GetValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawFieldInfo gen_to_be_invoked = (ETCold.RawFieldInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.GetValue = translator.GetDelegate<System.Func<object, object>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SetValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawFieldInfo gen_to_be_invoked = (ETCold.RawFieldInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SetValue = translator.GetDelegate<System.Action<object, object>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
