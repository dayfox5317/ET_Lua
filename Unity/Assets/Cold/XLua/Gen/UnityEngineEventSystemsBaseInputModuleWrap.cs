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
    public partial class UnityEngineEventSystemsBaseInputModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.BaseInputModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 2, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsPointerOverGameObject", _m_IsPointerOverGameObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShouldActivateModule", _m_ShouldActivateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeactivateModule", _m_DeactivateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ActivateModule", _m_ActivateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateModule", _m_UpdateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsModuleSupported", _m_IsModuleSupported);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getinput", _g_get_input);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getinputOverride", _g_get_inputOverride);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setinputOverride", _s_set_inputOverride);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "input", _g_get_input);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputOverride", _g_get_inputOverride);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputOverride", _s_set_inputOverride);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.EventSystems.BaseInputModule does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Process(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPointerOverGameObject(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _pointerId = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsPointerOverGameObject( 
                        _pointerId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShouldActivateModule(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.ShouldActivateModule(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeactivateModule(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DeactivateModule(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ActivateModule(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ActivateModule(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateModule(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpdateModule(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsModuleSupported(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsModuleSupported(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_input(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.input);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputOverride);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.BaseInputModule gen_to_be_invoked = (UnityEngine.EventSystems.BaseInputModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputOverride = (UnityEngine.EventSystems.BaseInput)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseInput));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
