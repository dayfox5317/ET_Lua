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
    public partial class BattlehubUIControlsDockPanelsTabWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.Tab);
			Utils.BeginObjectRegister(type, L, translator, 0, 61, 16, 16);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnClosing", _m_OnClosing);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttemptClose", _m_AttemptClose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerEnter", _m_OnPointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerExit", _m_OnPointerExit);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getClosing", _g_get_Closing);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIcon", _g_get_Icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getText", _g_get_Text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getToggleGroup", _g_get_ToggleGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParentRegion", _g_get_ParentRegion);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIndex", _g_get_Index);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanClose", _g_get_CanClose);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsCloseButtonVisible", _g_get_IsCloseButtonVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPreviewPosition", _g_get_PreviewPosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsContentActive", _g_get_IsContentActive);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsPreviewContentActive", _g_get_IsPreviewContentActive);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRectSize", _g_get_RectSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTabDelegate", _g_get_TabDelegate);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIcon", _s_set_Icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setText", _s_set_Text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setToggleGroup", _s_set_ToggleGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIndex", _s_set_Index);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanClose", _s_set_CanClose);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsCloseButtonVisible", _s_set_IsCloseButtonVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setPreviewPosition", _s_set_PreviewPosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsContentActive", _s_set_IsContentActive);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsPreviewContentActive", _s_set_IsPreviewContentActive);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMaxWidth", _s_set_MaxWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setPreviewContentSize", _s_set_PreviewContentSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSize", _s_set_Size);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTabDelegate", _s_set_TabDelegate);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addToggle", _e_add_Toggle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addPointerDown", _e_add_PointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addPointerUp", _e_add_PointerUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addInitializePotentialDrag", _e_add_InitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addBeginDrag", _e_add_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addDrag", _e_add_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addEndDrag", _e_add_EndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addClosed", _e_add_Closed);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeToggle", _e_remove_Toggle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removePointerDown", _e_remove_PointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removePointerUp", _e_remove_PointerUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeInitializePotentialDrag", _e_remove_InitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeBeginDrag", _e_remove_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeDrag", _e_remove_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeEndDrag", _e_remove_EndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeClosed", _e_remove_Closed);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Toggle", _e_Toggle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PointerDown", _e_PointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PointerUp", _e_PointerUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitializePotentialDrag", _e_InitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginDrag", _e_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Drag", _e_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndDrag", _e_EndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Closed", _e_Closed);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Closing", _g_get_Closing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Icon", _g_get_Icon);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Text", _g_get_Text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ToggleGroup", _g_get_ToggleGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ParentRegion", _g_get_ParentRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Index", _g_get_Index);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanClose", _g_get_CanClose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsCloseButtonVisible", _g_get_IsCloseButtonVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PreviewPosition", _g_get_PreviewPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsContentActive", _g_get_IsContentActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPreviewContentActive", _g_get_IsPreviewContentActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RectSize", _g_get_RectSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TabDelegate", _g_get_TabDelegate);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Icon", _s_set_Icon);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Text", _s_set_Text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ToggleGroup", _s_set_ToggleGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Index", _s_set_Index);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanClose", _s_set_CanClose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsCloseButtonVisible", _s_set_IsCloseButtonVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PreviewPosition", _s_set_PreviewPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsContentActive", _s_set_IsContentActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsPreviewContentActive", _s_set_IsPreviewContentActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MaxWidth", _s_set_MaxWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PreviewContentSize", _s_set_PreviewContentSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Size", _s_set_Size);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "TabDelegate", _s_set_TabDelegate);
            
			
			
			
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
					
					Battlehub.UIControls.DockPanels.Tab gen_ret = new Battlehub.UIControls.DockPanels.Tab();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnClosing(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnClosing(  );
                    
                    
                    
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
            
            
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttemptClose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.AttemptClose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerEnter(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerEnter( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerExit(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerExit( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Closing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Closing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Icon);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ToggleGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ToggleGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ParentRegion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ParentRegion);
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Index(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Index);
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanMaximize);
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanClose);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsCloseButtonVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsCloseButtonVisible);
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PreviewPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.PreviewPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsContentActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsContentActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPreviewContentActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPreviewContentActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RectSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.RectSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TabDelegate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.TabDelegate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ToggleGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ToggleGroup = (UnityEngine.UI.ToggleGroup)translator.GetObject(L, 2, typeof(UnityEngine.UI.ToggleGroup));
            
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOn = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Index(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Index = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanMaximize = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanClose = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsCloseButtonVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsCloseButtonVisible = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrag = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PreviewPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.PreviewPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsContentActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsContentActive = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsPreviewContentActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsPreviewContentActive = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MaxWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PreviewContentSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.PreviewContentSize = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Size(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Size = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TabDelegate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.TabDelegate = (Battlehub.UIControls.DockPanels.ITabDelegate)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.ITabDelegate));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Toggle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<bool>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<bool>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Toggle += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Toggle -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Toggle!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.PointerDown += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.PointerDown -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.PointerDown!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.PointerUp += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.PointerUp -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.PointerUp!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_InitializePotentialDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.InitializePotentialDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.InitializePotentialDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.InitializePotentialDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.BeginDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.BeginDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.BeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Drag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Drag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Drag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.EndDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.EndDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.EndDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Closed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.TabEventArgs gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.TabEventArgs!");
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Closed!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Toggle(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<bool>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<bool>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Toggle += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Toggle!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_PointerDown(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerDown += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.PointerDown!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_PointerUp(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerUp += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.PointerUp!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_InitializePotentialDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.InitializePotentialDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.InitializePotentialDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_BeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.BeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.BeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Drag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Drag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Drag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_EndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.EndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.EndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Closed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Closed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Closed!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Toggle(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<bool>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<bool>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Toggle -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Toggle!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_PointerDown(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerDown -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.PointerDown!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_PointerUp(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerUp -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.PointerUp!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_InitializePotentialDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.InitializePotentialDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.InitializePotentialDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_BeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.BeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.BeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Drag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Drag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Drag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_EndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs<UnityEngine.EventSystems.PointerEventData>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.EndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.EndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Closed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.Tab gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Tab)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.TabEventArgs gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.TabEventArgs>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.TabEventArgs!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Closed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Tab.Closed!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
