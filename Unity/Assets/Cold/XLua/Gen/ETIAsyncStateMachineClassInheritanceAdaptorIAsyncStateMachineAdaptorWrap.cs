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
    public partial class ETIAsyncStateMachineClassInheritanceAdaptorIAsyncStateMachineAdaptorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 1, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveNext", _m_MoveNext);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStateMachine", _m_SetStateMachine);
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
					
					ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor gen_ret = new ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<ILRuntime.Runtime.Enviorment.AppDomain>(L, 2) && translator.Assignable<ILRuntime.Runtime.Intepreter.ILTypeInstance>(L, 3))
				{
					ILRuntime.Runtime.Enviorment.AppDomain _appDomain = (ILRuntime.Runtime.Enviorment.AppDomain)translator.GetObject(L, 2, typeof(ILRuntime.Runtime.Enviorment.AppDomain));
					ILRuntime.Runtime.Intepreter.ILTypeInstance _instance = (ILRuntime.Runtime.Intepreter.ILTypeInstance)translator.GetObject(L, 3, typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance));
					
					ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor gen_ret = new ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor(_appDomain, _instance);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveNext(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor gen_to_be_invoked = (ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveNext(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStateMachine(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor gen_to_be_invoked = (ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Runtime.CompilerServices.IAsyncStateMachine _stateMachine = (System.Runtime.CompilerServices.IAsyncStateMachine)translator.GetObject(L, 2, typeof(System.Runtime.CompilerServices.IAsyncStateMachine));
                    
                    gen_to_be_invoked.SetStateMachine( 
                        _stateMachine );
                    
                    
                    
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
            
            
                ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor gen_to_be_invoked = (ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor)translator.FastGetCSObj(L, 1);
            
            
                
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
			
                ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor gen_to_be_invoked = (ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ILInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
