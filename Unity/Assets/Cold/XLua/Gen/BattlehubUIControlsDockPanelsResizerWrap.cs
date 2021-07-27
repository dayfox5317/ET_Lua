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
    public partial class BattlehubUIControlsDockPanelsResizerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.Resizer);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateState", _m_UpdateState);
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			
            
			
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addBeginResize", _e_add_BeginResize);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addResize", _e_add_Resize);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addEndResize", _e_add_EndResize);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeBeginResize", _e_remove_BeginResize);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeResize", _e_remove_Resize);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeEndResize", _e_remove_EndResize);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginResize", _e_BeginResize);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Resize", _e_Resize);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "EndResize", _e_EndResize);
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Battlehub.UIControls.DockPanels.Resizer gen_ret = new Battlehub.UIControls.DockPanels.Resizer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateState(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Resizer gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Resizer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpdateState(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Resizer.BeginResize += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Resizer.BeginResize -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.BeginResize!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Resize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Resizer.Resize += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Resizer.Resize -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.Resize!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Resizer.EndResize += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Resizer.EndResize -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.EndResize!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeginResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Resizer.BeginResize += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.BeginResize!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Resize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Resizer.Resize += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.Resize!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_EndResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Resizer.EndResize += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.EndResize!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeginResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Resizer.BeginResize -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.BeginResize!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Resize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Resizer.Resize -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.Resize!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_EndResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Resizer.EndResize -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Resizer.EndResize!");
        }
        
    }
}
