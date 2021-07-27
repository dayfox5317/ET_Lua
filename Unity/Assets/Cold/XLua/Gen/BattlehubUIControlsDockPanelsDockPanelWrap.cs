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
    public partial class BattlehubUIControlsDockPanelsDockPanelWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.DockPanel);
			Utils.BeginObjectRegister(type, L, translator, 0, 86, 14, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRegion", _m_AddRegion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveRegion", _m_RemoveRegion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddModalRegion", _m_AddModalRegion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForceUpdateLayout", _m_ForceUpdateLayout);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRaycaster", _g_get_Raycaster);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTabPrefab", _g_get_TabPrefab);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRegionPrefab", _g_get_RegionPrefab);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedRegion", _g_get_SelectedRegion);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRootRegion", _g_get_RootRegion);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDocked", _g_get_Docked);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getFree", _g_get_Free);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPreview", _g_get_Preview);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getModal", _g_get_Modal);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCursorHelper", _g_get_CursorHelper);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRegionId", _g_get_RegionId);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAllowDragOutside", _g_get_AllowDragOutside);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMinWidth", _g_get_MinWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMinHeight", _g_get_MinHeight);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCursorHelper", _s_set_CursorHelper);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRegionId", _s_set_RegionId);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addTabActivated", _e_add_TabActivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addTabDeactivated", _e_add_TabDeactivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addTabClosed", _e_add_TabClosed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addTabBeginDrag", _e_add_TabBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addTabEndDrag", _e_add_TabEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionSelected", _e_add_RegionSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionUnselected", _e_add_RegionUnselected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionCreated", _e_add_RegionCreated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionBeforeDepthChanged", _e_add_RegionBeforeDepthChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionDepthChanged", _e_add_RegionDepthChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionDestroyed", _e_add_RegionDestroyed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionEnabled", _e_add_RegionEnabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionDisabled", _e_add_RegionDisabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionMaximized", _e_add_RegionMaximized);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionBeforeBeginDrag", _e_add_RegionBeforeBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionBeginDrag", _e_add_RegionBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionDrag", _e_add_RegionDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionEndDrag", _e_add_RegionEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionTranformChanged", _e_add_RegionTranformChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionBeginResize", _e_add_RegionBeginResize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionResize", _e_add_RegionResize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRegionEndResize", _e_add_RegionEndResize);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeTabActivated", _e_remove_TabActivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeTabDeactivated", _e_remove_TabDeactivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeTabClosed", _e_remove_TabClosed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeTabBeginDrag", _e_remove_TabBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeTabEndDrag", _e_remove_TabEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionSelected", _e_remove_RegionSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionUnselected", _e_remove_RegionUnselected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionCreated", _e_remove_RegionCreated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionBeforeDepthChanged", _e_remove_RegionBeforeDepthChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionDepthChanged", _e_remove_RegionDepthChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionDestroyed", _e_remove_RegionDestroyed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionEnabled", _e_remove_RegionEnabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionDisabled", _e_remove_RegionDisabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionMaximized", _e_remove_RegionMaximized);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionBeforeBeginDrag", _e_remove_RegionBeforeBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionBeginDrag", _e_remove_RegionBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionDrag", _e_remove_RegionDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionEndDrag", _e_remove_RegionEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionTranformChanged", _e_remove_RegionTranformChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionBeginResize", _e_remove_RegionBeginResize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionResize", _e_remove_RegionResize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRegionEndResize", _e_remove_RegionEndResize);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TabActivated", _e_TabActivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TabDeactivated", _e_TabDeactivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TabClosed", _e_TabClosed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TabBeginDrag", _e_TabBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TabEndDrag", _e_TabEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionSelected", _e_RegionSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionUnselected", _e_RegionUnselected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionCreated", _e_RegionCreated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionBeforeDepthChanged", _e_RegionBeforeDepthChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionDepthChanged", _e_RegionDepthChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionDestroyed", _e_RegionDestroyed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionEnabled", _e_RegionEnabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionDisabled", _e_RegionDisabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionMaximized", _e_RegionMaximized);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionBeforeBeginDrag", _e_RegionBeforeBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionBeginDrag", _e_RegionBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionDrag", _e_RegionDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionEndDrag", _e_RegionEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionTranformChanged", _e_RegionTranformChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionBeginResize", _e_RegionBeginResize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionResize", _e_RegionResize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegionEndResize", _e_RegionEndResize);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Raycaster", _g_get_Raycaster);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TabPrefab", _g_get_TabPrefab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RegionPrefab", _g_get_RegionPrefab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedRegion", _g_get_SelectedRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RootRegion", _g_get_RootRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Docked", _g_get_Docked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Free", _g_get_Free);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Preview", _g_get_Preview);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Modal", _g_get_Modal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CursorHelper", _g_get_CursorHelper);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RegionId", _g_get_RegionId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AllowDragOutside", _g_get_AllowDragOutside);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MinWidth", _g_get_MinWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MinHeight", _g_get_MinHeight);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "CursorHelper", _s_set_CursorHelper);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RegionId", _s_set_RegionId);
            
			
			
			
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
					
					Battlehub.UIControls.DockPanels.DockPanel gen_ret = new Battlehub.UIControls.DockPanels.DockPanel();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRegion(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& translator.Assignable<Battlehub.UIControls.DockPanels.RegionSplitType>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    bool _isFree = LuaAPI.lua_toboolean(L, 4);
                    Battlehub.UIControls.DockPanels.RegionSplitType _splitType;translator.Get(L, 5, out _splitType);
                    float _flexibleSize = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    gen_to_be_invoked.AddRegion( 
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
                    
                    gen_to_be_invoked.AddRegion( 
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
                    
                    gen_to_be_invoked.AddRegion( 
                        _tab, 
                        _content, 
                        _isFree );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)) 
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.AddRegion( 
                        _tab, 
                        _content );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.AddRegion!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveRegion(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.RemoveRegion( 
                        _content );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddModalRegion(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _ratio = (float)LuaAPI.lua_tonumber(L, 4);
                    bool _canResize = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _ratio, 
                        _canResize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _ratio = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _ratio );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    bool _canResize = LuaAPI.lua_toboolean(L, 6);
                    float _margin = (float)LuaAPI.lua_tonumber(L, 7);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight, 
                        _canResize, 
                        _margin );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    bool _canResize = LuaAPI.lua_toboolean(L, 6);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight, 
                        _canResize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Rect>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Rect _rect;translator.Get(L, 6, out _rect);
                    bool _center = LuaAPI.lua_toboolean(L, 7);
                    bool _canResize = LuaAPI.lua_toboolean(L, 8);
                    float _margin = (float)LuaAPI.lua_tonumber(L, 9);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight, 
                        _rect, 
                        _center, 
                        _canResize, 
                        _margin );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Rect>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Rect _rect;translator.Get(L, 6, out _rect);
                    bool _center = LuaAPI.lua_toboolean(L, 7);
                    bool _canResize = LuaAPI.lua_toboolean(L, 8);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight, 
                        _rect, 
                        _center, 
                        _canResize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Rect>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Rect _rect;translator.Get(L, 6, out _rect);
                    bool _center = LuaAPI.lua_toboolean(L, 7);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight, 
                        _rect, 
                        _center );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Rect>(L, 6)) 
                {
                    UnityEngine.Transform _headerContent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Rect _rect;translator.Get(L, 6, out _rect);
                    
                    gen_to_be_invoked.AddModalRegion( 
                        _headerContent, 
                        _content, 
                        _minWidth, 
                        _minHeight, 
                        _rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.AddModalRegion!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForceUpdateLayout(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ForceUpdateLayout(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Raycaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Raycaster);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TabPrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TabPrefab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RegionPrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RegionPrefab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectedRegion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SelectedRegion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RootRegion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RootRegion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Docked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Docked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Free(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Free);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Preview(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Preview);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Modal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Modal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CursorHelper(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CursorHelper);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RegionId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.RegionId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AllowDragOutside(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AllowDragOutside);
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
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.MinHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CursorHelper(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CursorHelper = (Battlehub.Utils.CursorHelper)translator.GetObject(L, 2, typeof(Battlehub.Utils.CursorHelper));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RegionId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.RegionId = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabActivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TabActivated += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TabActivated -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabActivated!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabDeactivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TabDeactivated += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TabDeactivated -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabDeactivated!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabClosed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TabClosed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TabClosed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabClosed!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TabBeginDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TabBeginDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabBeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TabEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TabEndDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TabEndDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabEndDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionSelected += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionSelected -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionSelected!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionUnselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionUnselected += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionUnselected -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionUnselected!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionCreated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionCreated += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionCreated -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionCreated!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionBeforeDepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionBeforeDepthChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionBeforeDepthChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeforeDepthChanged!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionDepthChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<int> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<int>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<int>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionDepthChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionDepthChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDepthChanged!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionDestroyed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionDestroyed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionDestroyed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDestroyed!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionEnabled += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionEnabled -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEnabled!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionDisabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionDisabled += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionDisabled -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDisabled!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionMaximized(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<bool>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<bool>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionMaximized += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionMaximized -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionMaximized!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionBeforeBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionBeforeBeginDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionBeforeBeginDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeforeBeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionBeginDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionBeginDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionEndDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionEndDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEndDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionTranformChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionTranformChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionTranformChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionTranformChanged!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionBeginResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionBeginResize += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionBeginResize -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeginResize!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionResize += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionResize -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionResize!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RegionEndResize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RegionEndResize += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RegionEndResize -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEndResize!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_TabActivated(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabActivated += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabActivated!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_TabDeactivated(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabDeactivated += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabDeactivated!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_TabClosed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabClosed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabClosed!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_TabBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabBeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_TabEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabEndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionSelected(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionSelected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionSelected!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionUnselected(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionUnselected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionUnselected!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionCreated(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionCreated += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionCreated!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionBeforeDepthChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeforeDepthChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeforeDepthChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionDepthChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<int> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<int>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<int>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDepthChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDepthChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionDestroyed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDestroyed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDestroyed!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionEnabled(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionEnabled += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEnabled!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionDisabled(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDisabled += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDisabled!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionMaximized(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<bool>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<bool>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionMaximized += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionMaximized!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionBeforeBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeforeBeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeforeBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionEndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionTranformChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionTranformChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionTranformChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionBeginResize(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeginResize += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeginResize!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionResize(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionResize += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionResize!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RegionEndResize(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionEndResize += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEndResize!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_TabActivated(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabActivated -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabActivated!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_TabDeactivated(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabDeactivated -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabDeactivated!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_TabClosed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<UnityEngine.Transform>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabClosed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabClosed!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_TabBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabBeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_TabEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TabEndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.TabEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionSelected(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionSelected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionSelected!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionUnselected(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionUnselected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionUnselected!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionCreated(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionCreated -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionCreated!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionBeforeDepthChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeforeDepthChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeforeDepthChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionDepthChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<int> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<int>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<int>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDepthChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDepthChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionDestroyed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDestroyed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDestroyed!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionEnabled(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionEnabled -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEnabled!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionDisabled(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDisabled -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDisabled!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionMaximized(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<bool> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<bool>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<bool>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionMaximized -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionMaximized!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionBeforeBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler<Battlehub.UIControls.CancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeforeBeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeforeBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionEndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionTranformChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.RegionEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.RegionEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.RegionEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionTranformChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionTranformChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionBeginResize(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionBeginResize -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionBeginResize!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionResize(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionResize -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionResize!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RegionEndResize(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.DockPanels.DockPanel gen_to_be_invoked = (Battlehub.UIControls.DockPanels.DockPanel)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DockPanels.ResizerEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.DockPanels.ResizerEventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DockPanels.ResizerEventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RegionEndResize -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.DockPanel.RegionEndResize!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
