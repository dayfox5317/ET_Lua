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
    public partial class BattlehubUIControlsMenuControlMenuItemWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MenuControl.MenuItem);
			Utils.BeginObjectRegister(type, L, translator, 0, 20, 10, 7);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Select", _m_Select);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Unselect", _m_Unselect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", _m_OnPointerDown);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectionColor", _g_get_SelectionColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTextColor", _g_get_TextColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDisabledSelectionColor", _g_get_DisabledSelectionColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDisableTextColor", _g_get_DisableTextColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRoot", _g_get_Root);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDepth", _g_get_Depth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChildren", _g_get_Children);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHasChildren", _g_get_HasChildren);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsPointerOver", _g_get_IsPointerOver);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSubmenu", _g_get_Submenu);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectionColor", _s_set_SelectionColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTextColor", _s_set_TextColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDisabledSelectionColor", _s_set_DisabledSelectionColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDisableTextColor", _s_set_DisableTextColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRoot", _s_set_Root);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDepth", _s_set_Depth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChildren", _s_set_Children);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectionColor", _g_get_SelectionColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TextColor", _g_get_TextColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DisabledSelectionColor", _g_get_DisabledSelectionColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DisableTextColor", _g_get_DisableTextColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Root", _g_get_Root);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Depth", _g_get_Depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Children", _g_get_Children);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasChildren", _g_get_HasChildren);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPointerOver", _g_get_IsPointerOver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Submenu", _g_get_Submenu);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectionColor", _s_set_SelectionColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "TextColor", _s_set_TextColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DisabledSelectionColor", _s_set_DisabledSelectionColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DisableTextColor", _s_set_DisableTextColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Root", _s_set_Root);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Depth", _s_set_Depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Children", _s_set_Children);
            
			
			
			
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
					
					Battlehub.UIControls.MenuControl.MenuItem gen_ret = new Battlehub.UIControls.MenuControl.MenuItem();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.MenuItem constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Select(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _showSelectionOnly = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Select( 
                        _showSelectionOnly );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Unselect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Unselect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerDown(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerDown( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectionColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.SelectionColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TextColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.TextColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DisabledSelectionColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.DisabledSelectionColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DisableTextColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.DisableTextColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Root(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Root);
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
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Children(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Children);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasChildren(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasChildren);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPointerOver(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPointerOver);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Submenu(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Submenu);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectionColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.SelectionColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TextColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.TextColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DisabledSelectionColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DisabledSelectionColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DisableTextColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DisableTextColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Root(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Root = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
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
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Depth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Children(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItem gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Children = (Battlehub.UIControls.MenuControl.MenuItemInfo[])translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItemInfo[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
