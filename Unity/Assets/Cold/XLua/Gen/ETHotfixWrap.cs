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
    public partial class ETHotfixWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ET.Hotfix);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 3, 3);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GotoHotfix", _m_GotoHotfix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHotfixTypes", _m_GetHotfixTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAppDomain", _m_GetAppDomain);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHotfixViewTypes", _m_GetHotfixViewTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadHotfixAssembly", _m_LoadHotfixAssembly);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gets_hotfixInit", _g_get_s_hotfixInit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHotfixUpdate", _g_get_HotfixUpdate);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLateUpdate", _g_get_LateUpdate);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "sets_hotfixInit", _s_set_s_hotfixInit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setHotfixUpdate", _s_set_HotfixUpdate);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setLateUpdate", _s_set_LateUpdate);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "s_hotfixInit", _g_get_s_hotfixInit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HotfixUpdate", _g_get_HotfixUpdate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LateUpdate", _g_get_LateUpdate);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "s_hotfixInit", _s_set_s_hotfixInit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HotfixUpdate", _s_set_HotfixUpdate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LateUpdate", _s_set_LateUpdate);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 1, 0);
			
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getInstance", _g_get_Instance);
            
			
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ET.Hotfix gen_ret = new ET.Hotfix();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ET.Hotfix constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GotoHotfix(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator gen_ret = gen_to_be_invoked.GotoHotfix(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHotfixTypes(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.List<System.Type> gen_ret = gen_to_be_invoked.GetHotfixTypes(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAppDomain(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        ILRuntime.Runtime.Enviorment.AppDomain gen_ret = gen_to_be_invoked.GetAppDomain(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHotfixViewTypes(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.List<System.Type> gen_ret = gen_to_be_invoked.GetHotfixViewTypes(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadHotfixAssembly(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.LoadHotfixAssembly(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ET.Hotfix.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_s_hotfixInit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.s_hotfixInit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.HotfixUpdate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LateUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LateUpdate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_s_hotfixInit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.s_hotfixInit = (ET.IStaticMethod)translator.GetObject(L, 2, typeof(ET.IStaticMethod));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HotfixUpdate = translator.GetDelegate<System.Action>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LateUpdate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ET.Hotfix gen_to_be_invoked = (ET.Hotfix)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LateUpdate = translator.GetDelegate<System.Action>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
