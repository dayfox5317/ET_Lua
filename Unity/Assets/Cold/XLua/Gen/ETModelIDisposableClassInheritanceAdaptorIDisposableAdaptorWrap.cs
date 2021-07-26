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
    public partial class ETModelIDisposableClassInheritanceAdaptorIDisposableAdaptorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 1, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getILInstance", _g_get_ILInstance);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ILInstance", _g_get_ILInstance);
            
			
			
			
			
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
					
					ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor gen_ret = new ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<ILRuntime.Runtime.Enviorment.AppDomain>(L, 2) && translator.Assignable<ILRuntime.Runtime.Intepreter.ILTypeInstance>(L, 3))
				{
					ILRuntime.Runtime.Enviorment.AppDomain _appDomain = (ILRuntime.Runtime.Enviorment.AppDomain)translator.GetObject(L, 2, typeof(ILRuntime.Runtime.Enviorment.AppDomain));
					ILRuntime.Runtime.Intepreter.ILTypeInstance _instance = (ILRuntime.Runtime.Intepreter.ILTypeInstance)translator.GetObject(L, 3, typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance));
					
					ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor gen_ret = new ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor(_appDomain, _instance);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor gen_to_be_invoked = (ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
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
            
            
                ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor gen_to_be_invoked = (ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ILInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor gen_to_be_invoked = (ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ILInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
