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
    public partial class BattlehubUIControlsDockPanelsPersistentLayoutInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.PersistentLayoutInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 22, 11, 11);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getWindowType", _g_get_WindowType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsVertical", _g_get_IsVertical);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChild0", _g_get_Child0);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChild1", _g_get_Child1);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRatio", _g_get_Ratio);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanClose", _g_get_CanClose);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsHeaderVisible", _g_get_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTabGroup", _g_get_TabGroup);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setWindowType", _s_set_WindowType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsVertical", _s_set_IsVertical);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChild0", _s_set_Child0);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChild1", _s_set_Child1);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRatio", _s_set_Ratio);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanClose", _s_set_CanClose);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsHeaderVisible", _s_set_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTabGroup", _s_set_TabGroup);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "WindowType", _g_get_WindowType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVertical", _g_get_IsVertical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Child0", _g_get_Child0);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Child1", _g_get_Child1);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Ratio", _g_get_Ratio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanClose", _g_get_CanClose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsHeaderVisible", _g_get_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TabGroup", _g_get_TabGroup);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "WindowType", _s_set_WindowType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsVertical", _s_set_IsVertical);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Child0", _s_set_Child0);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Child1", _s_set_Child1);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Ratio", _s_set_Ratio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanClose", _s_set_CanClose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsHeaderVisible", _s_set_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "TabGroup", _s_set_TabGroup);
            
			
			
			
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
					
					Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.PersistentLayoutInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.PersistentLayoutInfo constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.WindowType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVertical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVertical);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Child0(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Child0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Child1(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Child1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ratio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Ratio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanClose(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanClose);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanMaximize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanMaximize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsHeaderVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsHeaderVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TabGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TabGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.WindowType = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsVertical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsVertical = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Child0(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Child0 = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.PersistentLayoutInfo));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Child1(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Child1 = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.PersistentLayoutInfo));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Ratio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Ratio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrag = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanClose(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanClose = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanMaximize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanMaximize = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsHeaderVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsHeaderVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOn = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TabGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.PersistentLayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.TabGroup = (Battlehub.UIControls.DockPanels.PersistentLayoutInfo[])translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.PersistentLayoutInfo[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
