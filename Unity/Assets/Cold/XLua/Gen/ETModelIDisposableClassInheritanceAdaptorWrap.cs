﻿#if USE_UNI_LUA
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
    public partial class ETModelIDisposableClassInheritanceAdaptorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETModel.IDisposableClassInheritanceAdaptor);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 2, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateCLRInstance", _m_CreateCLRInstance);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBaseCLRType", _g_get_BaseCLRType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAdaptorType", _g_get_AdaptorType);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BaseCLRType", _g_get_BaseCLRType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AdaptorType", _g_get_AdaptorType);
            
			
			
			
			
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
					
					ETModel.IDisposableClassInheritanceAdaptor gen_ret = new ETModel.IDisposableClassInheritanceAdaptor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETModel.IDisposableClassInheritanceAdaptor constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateCLRInstance(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETModel.IDisposableClassInheritanceAdaptor gen_to_be_invoked = (ETModel.IDisposableClassInheritanceAdaptor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ILRuntime.Runtime.Enviorment.AppDomain _appdomain = (ILRuntime.Runtime.Enviorment.AppDomain)translator.GetObject(L, 2, typeof(ILRuntime.Runtime.Enviorment.AppDomain));
                    ILRuntime.Runtime.Intepreter.ILTypeInstance _instance = (ILRuntime.Runtime.Intepreter.ILTypeInstance)translator.GetObject(L, 3, typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance));
                    
                        object gen_ret = gen_to_be_invoked.CreateCLRInstance( 
                        _appdomain, 
                        _instance );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BaseCLRType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETModel.IDisposableClassInheritanceAdaptor gen_to_be_invoked = (ETModel.IDisposableClassInheritanceAdaptor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BaseCLRType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AdaptorType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETModel.IDisposableClassInheritanceAdaptor gen_to_be_invoked = (ETModel.IDisposableClassInheritanceAdaptor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AdaptorType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
