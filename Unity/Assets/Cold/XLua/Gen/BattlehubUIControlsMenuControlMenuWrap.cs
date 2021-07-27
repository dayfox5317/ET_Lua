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
    public partial class BattlehubUIControlsMenuControlMenuWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MenuControl.Menu);
			Utils.BeginObjectRegister(type, L, translator, 0, 23, 8, 6);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMenuItems", _m_SetMenuItems);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Open", _m_Open);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItems", _g_get_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAnchor", _g_get_Anchor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAnchorOffset", _g_get_AnchorOffset);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDepth", _g_get_Depth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChild", _g_get_Child);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getActualItemsCount", _g_get_ActualItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOpened", _g_get_IsOpened);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItems", _s_set_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAnchor", _s_set_Anchor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAnchorOffset", _s_set_AnchorOffset);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDepth", _s_set_Depth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChild", _s_set_Child);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setParent", _s_set_Parent);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOpened", _e_add_Opened);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addClosed", _e_add_Closed);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOpened", _e_remove_Opened);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeClosed", _e_remove_Closed);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Opened", _e_Opened);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Closed", _e_Closed);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Items", _g_get_Items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Anchor", _g_get_Anchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AnchorOffset", _g_get_AnchorOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Depth", _g_get_Depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Child", _g_get_Child);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Parent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ActualItemsCount", _g_get_ActualItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOpened", _g_get_IsOpened);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Items", _s_set_Items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Anchor", _s_set_Anchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AnchorOffset", _s_set_AnchorOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Depth", _s_set_Depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Child", _s_set_Child);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Parent", _s_set_Parent);
            
			
			
			
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
					
					Battlehub.UIControls.MenuControl.Menu gen_ret = new Battlehub.UIControls.MenuControl.Menu();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMenuItems(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<Battlehub.UIControls.MenuControl.MenuItemInfo[]>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    Battlehub.UIControls.MenuControl.MenuItemInfo[] _menuItems = (Battlehub.UIControls.MenuControl.MenuItemInfo[])translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItemInfo[]));
                    bool _databind = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetMenuItems( 
                        _menuItems, 
                        _databind );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<Battlehub.UIControls.MenuControl.MenuItemInfo[]>(L, 2)) 
                {
                    Battlehub.UIControls.MenuControl.MenuItemInfo[] _menuItems = (Battlehub.UIControls.MenuControl.MenuItemInfo[])translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItemInfo[]));
                    
                    gen_to_be_invoked.SetMenuItems( 
                        _menuItems );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.SetMenuItems!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Open(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Open(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Items);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Anchor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Anchor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AnchorOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.AnchorOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Child(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Child);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Parent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ActualItemsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ActualItemsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsOpened(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOpened);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Items = (Battlehub.UIControls.MenuControl.MenuItemInfo[])translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItemInfo[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Anchor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Anchor = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AnchorOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.AnchorOffset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Depth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Child(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Child = (Battlehub.UIControls.MenuControl.MenuItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItem));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Parent = (Battlehub.UIControls.MenuControl.MenuItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItem));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Opened(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Opened += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Opened -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.Opened!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Closed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Closed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Closed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.Closed!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Opened(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Opened += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.Opened!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Closed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Closed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.Closed!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Opened(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Opened -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.Opened!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Closed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.MenuControl.Menu gen_to_be_invoked = (Battlehub.UIControls.MenuControl.Menu)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Closed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.Menu.Closed!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
