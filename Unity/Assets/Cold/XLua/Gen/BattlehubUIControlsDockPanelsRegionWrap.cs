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
    public partial class BattlehubUIControlsDockPanelsRegionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.Region);
			Utils.BeginObjectRegister(type, L, translator, 0, 39, 16, 6);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChild", _m_GetChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseAllTabs", _m_CloseAllTabs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Build", _m_Build);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Validate", _m_Validate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDragRegion", _m_GetDragRegion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsModal", _m_IsModal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsFreeOrModal", _m_IsFreeOrModal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Maximize", _m_Maximize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Fit", _m_Fit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollTabHeaderToRight", _m_ScrollTabHeaderToRight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ScrollTabHeaderToLeft", _m_ScrollTabHeaderToLeft);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanAdd", _m_CanAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAt", _m_RemoveAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Move", _m_Move);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveRegionToForeground", _m_MoveRegionToForeground);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RaiseDepthChanged", _m_RaiseDepthChanged);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanResize", _g_get_CanResize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsHeaderVisible", _g_get_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMinWidth", _g_get_MinWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMinHeight", _g_get_MinHeight);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHeaderImage", _g_get_HeaderImage);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getFrameImage", _g_get_FrameImage);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRoot", _g_get_Root);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getActiveTabIndex", _g_get_ActiveTabIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLayoutGroup", _g_get_LayoutGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getActiveContent", _g_get_ActiveContent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getContent", _g_get_Content);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getContentPanel", _g_get_ContentPanel);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChildrenPanel", _g_get_ChildrenPanel);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHasChildren", _g_get_HasChildren);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanResize", _s_set_CanResize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsHeaderVisible", _s_set_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMinWidth", _s_set_MinWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMinHeight", _s_set_MinHeight);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsSelected", _s_set_IsSelected);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanResize", _g_get_CanResize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsHeaderVisible", _g_get_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MinWidth", _g_get_MinWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MinHeight", _g_get_MinHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HeaderImage", _g_get_HeaderImage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FrameImage", _g_get_FrameImage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Root", _g_get_Root);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ActiveTabIndex", _g_get_ActiveTabIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LayoutGroup", _g_get_LayoutGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ActiveContent", _g_get_ActiveContent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Content", _g_get_Content);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ContentPanel", _g_get_ContentPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ChildrenPanel", _g_get_ChildrenPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasChildren", _g_get_HasChildren);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanResize", _s_set_CanResize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsHeaderVisible", _s_set_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MinWidth", _s_set_MinWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MinHeight", _s_set_MinHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsSelected", _s_set_IsSelected);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 59, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FindTab", _m_FindTab_xlua_st_);
            
            
			
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addCreated", _e_add_Created);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDestroyed", _e_add_Destroyed);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addSelected", _e_add_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addUnselected", _e_add_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addBeforeBeginDrag", _e_add_BeforeBeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addBeginDrag", _e_add_BeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addEnabled", _e_add_Enabled);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDisabled", _e_add_Disabled);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDrag", _e_add_Drag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addEndDrag", _e_add_EndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addTransformChanged", _e_add_TransformChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addTabActivated", _e_add_TabActivated);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addTabDeactivated", _e_add_TabDeactivated);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addTabClosed", _e_add_TabClosed);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addTabBeginDrag", _e_add_TabBeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addTabEndDrag", _e_add_TabEndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addBeforeDepthChanged", _e_add_BeforeDepthChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDepthChanged", _e_add_DepthChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addMaximized", _e_add_Maximized);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeCreated", _e_remove_Created);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDestroyed", _e_remove_Destroyed);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeSelected", _e_remove_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeUnselected", _e_remove_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeBeforeBeginDrag", _e_remove_BeforeBeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeBeginDrag", _e_remove_BeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeEnabled", _e_remove_Enabled);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDisabled", _e_remove_Disabled);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDrag", _e_remove_Drag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeEndDrag", _e_remove_EndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeTransformChanged", _e_remove_TransformChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeTabActivated", _e_remove_TabActivated);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeTabDeactivated", _e_remove_TabDeactivated);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeTabClosed", _e_remove_TabClosed);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeTabBeginDrag", _e_remove_TabBeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeTabEndDrag", _e_remove_TabEndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeBeforeDepthChanged", _e_remove_BeforeDepthChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDepthChanged", _e_remove_DepthChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeMaximized", _e_remove_Maximized);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Created", _e_Created);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Destroyed", _e_Destroyed);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Selected", _e_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Unselected", _e_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeforeBeginDrag", _e_BeforeBeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginDrag", _e_BeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Enabled", _e_Enabled);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Disabled", _e_Disabled);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Drag", _e_Drag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "EndDrag", _e_EndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TransformChanged", _e_TransformChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TabActivated", _e_TabActivated);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TabDeactivated", _e_TabDeactivated);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TabClosed", _e_TabClosed);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TabBeginDrag", _e_TabBeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TabEndDrag", _e_TabEndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeforeDepthChanged", _e_BeforeDepthChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DepthChanged", _e_DepthChanged);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Maximized", _e_Maximized);
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Battlehub.UIControls.DockPanels.Region gen_ret = new Battlehub.UIControls.DockPanels.Region();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChild(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        Battlehub.UIControls.DockPanels.Region gen_ret = gen_to_be_invoked.GetChild( 
                        _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseAllTabs(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CloseAllTabs(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Build(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.DockPanels.LayoutInfo _layout = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
                    
                    gen_to_be_invoked.Build( 
                        _layout );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Validate(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.DockPanels.LayoutInfo _layoutInfo = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
                    
                        bool gen_ret = gen_to_be_invoked.Validate( 
                        _layoutInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDragRegion(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Transform gen_ret = gen_to_be_invoked.GetDragRegion(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsModal(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsModal(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsFreeOrModal(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsFreeOrModal(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Maximize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _maximize = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Maximize( 
                        _maximize );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Fit(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Fit(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollTabHeaderToRight(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ScrollTabHeaderToRight(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollTabHeaderToLeft(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ScrollTabHeaderToLeft(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindTab_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        Battlehub.UIControls.DockPanels.Tab gen_ret = Battlehub.UIControls.DockPanels.Region.FindTab( 
                        _content );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanAdd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _isFree = LuaAPI.lua_toboolean(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.CanAdd( 
                        _isFree );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1) 
                {
                    
                        bool gen_ret = gen_to_be_invoked.CanAdd(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.CanAdd!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 4);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 5, out _splitType);
                    float _flexibleSize = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    gen_to_be_invoked.Add( 
                        _tab, 
                        _content, 
                        _isFree, 
                        _splitType, 
                        _flexibleSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 5)) 
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 4);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 5, out _splitType);
                    
                    gen_to_be_invoked.Add( 
                        _tab, 
                        _content, 
                        _isFree, 
                        _splitType );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.Add( 
                        _tab, 
                        _content, 
                        _isFree );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)) 
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.Add( 
                        _tab, 
                        _content );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 5);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 6, out _splitType);
                    float _flexibleSize = (float)LuaAPI.lua_tonumber(L, 7);
                    bool _canDrag = LuaAPI.lua_toboolean(L, 8);
                    bool _canClose = LuaAPI.lua_toboolean(L, 9);
                    bool _canMaximize = LuaAPI.lua_toboolean(L, 10);
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content, 
                        _isFree, 
                        _splitType, 
                        _flexibleSize, 
                        _canDrag, 
                        _canClose, 
                        _canMaximize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 5);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 6, out _splitType);
                    float _flexibleSize = (float)LuaAPI.lua_tonumber(L, 7);
                    bool _canDrag = LuaAPI.lua_toboolean(L, 8);
                    bool _canClose = LuaAPI.lua_toboolean(L, 9);
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content, 
                        _isFree, 
                        _splitType, 
                        _flexibleSize, 
                        _canDrag, 
                        _canClose );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 5);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 6, out _splitType);
                    float _flexibleSize = (float)LuaAPI.lua_tonumber(L, 7);
                    bool _canDrag = LuaAPI.lua_toboolean(L, 8);
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content, 
                        _isFree, 
                        _splitType, 
                        _flexibleSize, 
                        _canDrag );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 5);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 6, out _splitType);
                    float _flexibleSize = (float)LuaAPI.lua_tonumber(L, 7);
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content, 
                        _isFree, 
                        _splitType, 
                        _flexibleSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 6)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 5);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 6, out _splitType);
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content, 
                        _isFree, 
                        _splitType );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content, 
                        _isFree );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.Add( 
                        _icon, 
                        _header, 
                        _content );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAt(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.RemoveAt( 
                        _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Move(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<Battlehub.UIControls.DockPanels.Region>(L, 4)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 5)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    int _targetIndex = LuaAPI.xlua_tointeger(L, 3);
                    Battlehub.UIControls.DockPanels.Region _targetRegion = (Battlehub.UIControls.DockPanels.Region)translator.GetObject(L, 4, typeof(Battlehub.UIControls.DockPanels.Region));
                    Battlehub.UIControls.DockPanels.RegionSplitType _targetSplitType;translator.Get(L, 5, out _targetSplitType);
                    
                    gen_to_be_invoked.Move( 
                        _index, 
                        _targetIndex, 
                        _targetRegion, 
                        _targetSplitType );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<Battlehub.UIControls.DockPanels.Region>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    int _targetIndex = LuaAPI.xlua_tointeger(L, 3);
                    Battlehub.UIControls.DockPanels.Region _targetRegion = (Battlehub.UIControls.DockPanels.Region)translator.GetObject(L, 4, typeof(Battlehub.UIControls.DockPanels.Region));
                    
                    gen_to_be_invoked.Move( 
                        _index, 
                        _targetIndex, 
                        _targetRegion );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Move!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveRegionToForeground(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MoveRegionToForeground(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaiseDepthChanged(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RaiseDepthChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanResize);
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
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsHeaderVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MinWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.MinWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MinHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.MinHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HeaderImage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.HeaderImage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FrameImage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.FrameImage);
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
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Root);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ActiveTabIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ActiveTabIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LayoutGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LayoutGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ActiveContent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ActiveContent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Content(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Content);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ContentPanel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ContentPanel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ChildrenPanel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ChildrenPanel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSelected);
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
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasChildren);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanResize = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsHeaderVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MinWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MinWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MinHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MinHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.Region gen_to_be_invoked = (Battlehub.UIControls.DockPanels.Region)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsSelected = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Created(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Created += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Created -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Created!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Destroyed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Destroyed += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Destroyed -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Destroyed!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Selected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Selected += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Selected -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Selected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Unselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Unselected += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Unselected -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeforeBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.BeginDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.BeginDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Enabled += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Enabled -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Enabled!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Disabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Disabled += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Disabled -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Disabled!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Drag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Drag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.EndDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.EndDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.EndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TransformChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.TransformChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.TransformChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TransformChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabActivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.TabActivated += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.TabActivated -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabActivated!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabDeactivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.TabDeactivated += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.TabDeactivated -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabDeactivated!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabClosed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.TabClosed += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.TabClosed -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabClosed!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.TabBeginDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.TabBeginDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabBeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.TabEndDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.TabEndDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabEndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeforeDepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_DepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<int> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<int>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<int>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.DepthChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.DepthChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.DepthChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Maximized(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<bool>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<bool>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.DockPanels.Region.Maximized += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.DockPanels.Region.Maximized -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Maximized!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Created(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Created += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Created!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Destroyed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Destroyed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Destroyed!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Selected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Selected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Selected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Unselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Unselected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeforeBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.BeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Enabled += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Enabled!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Disabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Disabled += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Disabled!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Drag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.EndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.EndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_TransformChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TransformChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TransformChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_TabActivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabActivated += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabActivated!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_TabDeactivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabDeactivated += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabDeactivated!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_TabClosed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabClosed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabClosed!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_TabBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabBeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabBeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_TabEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabEndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabEndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeforeDepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_DepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<int> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<int>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<int>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.DepthChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.DepthChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Maximized(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<bool>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<bool>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Maximized += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Maximized!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Created(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Created -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Created!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Destroyed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Destroyed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Destroyed!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Selected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Selected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Selected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Unselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Unselected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeforeBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeforeBeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.BeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Enabled -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Enabled!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Disabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Disabled -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Disabled!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Drag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.EndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.EndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_TransformChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TransformChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TransformChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_TabActivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabActivated -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabActivated!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_TabDeactivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabDeactivated -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabDeactivated!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_TabClosed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabClosed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabClosed!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_TabBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabBeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabBeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_TabEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.TabEndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.TabEndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeforeDepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.BeforeDepthChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_DepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<int> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<int>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<int>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.DepthChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.DepthChanged!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Maximized(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.DockPanels.RegionEventHandler<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<bool>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.DockPanels.RegionEventHandler<bool>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.DockPanels.Region.Maximized -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.Region.Maximized!");
        }
        
    }
}
