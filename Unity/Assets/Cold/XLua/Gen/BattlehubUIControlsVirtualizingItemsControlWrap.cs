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
    public partial class BattlehubUIControlsVirtualizingItemsControlWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.VirtualizingItemsControl);
			Utils.BeginObjectRegister(type, L, translator, 0, 131, 30, 21);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearTarget", _m_ClearTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsItemSelected", _m_IsItemSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItems", _m_SetItems);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateContainerSize", _m_UpdateContainerSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", _m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DataBindItem", _m_DataBindItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DataBindVisible", _m_DataBindVisible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IndexOf", _m_IndexOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIndex", _m_SetIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastItemContainerData", _m_LastItemContainerData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemContainer", _m_GetItemContainer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemContainerData", _m_GetItemContainerData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExternalBeginDrag", _m_ExternalBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExternalItemDrag", _m_ExternalItemDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExternalItemDrop", _m_ExternalItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveSelectedItems", _m_RemoveSelectedItems);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", _m_Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNextSibling", _m_SetNextSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPrevSibling", _m_SetPrevSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemAt", _m_GetItemAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelect", _m_OnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDeselect", _m_OnDeselect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdateSelected", _m_OnUpdateSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdateFocused", _m_OnUpdateFocused);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsDropInProgress", _g_get_IsDropInProgress);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsFocused", _g_get_IsFocused);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDropTarget", _g_get_DropTarget);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDropAction", _g_get_DropAction);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDragItems", _g_get_DragItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedItemsCount", _g_get_SelectedItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedItems", _g_get_SelectedItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedItem", _g_get_SelectedItem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedIndex", _g_get_SelectedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItemsCount", _g_get_ItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItems", _g_get_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getVisibleItemIndex", _g_get_VisibleItemIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getVisibleItemsCount", _g_get_VisibleItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getm_eventSystem", _g_get_m_eventSystem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getInputProvider", _g_get_InputProvider);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectOnPointerUp", _g_get_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectUsingLeftButtonOnly", _g_get_SelectUsingLeftButtonOnly);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanUnselectAll", _g_get_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanSelectAll", _g_get_CanSelectAll);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanMultiSelect", _g_get_CanMultiSelect);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanRemove", _g_get_CanRemove);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanReorder", _g_get_CanReorder);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getExpandChildrenWidth", _g_get_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getExpandChildrenHeight", _g_get_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCamera", _g_get_Camera);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getScrollSpeed", _g_get_ScrollSpeed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getScrollMargin", _g_get_ScrollMargin);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsFocused", _s_set_IsFocused);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectedItems", _s_set_SelectedItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectedItem", _s_set_SelectedItem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectedIndex", _s_set_SelectedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItems", _s_set_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setm_eventSystem", _s_set_m_eventSystem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setInputProvider", _s_set_InputProvider);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectOnPointerUp", _s_set_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectUsingLeftButtonOnly", _s_set_SelectUsingLeftButtonOnly);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanUnselectAll", _s_set_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanSelectAll", _s_set_CanSelectAll);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanMultiSelect", _s_set_CanMultiSelect);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanRemove", _s_set_CanRemove);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanReorder", _s_set_CanReorder);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setExpandChildrenWidth", _s_set_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setExpandChildrenHeight", _s_set_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCamera", _s_set_Camera);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setScrollSpeed", _s_set_ScrollSpeed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setScrollMargin", _s_set_ScrollMargin);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemBeginDrag", _e_add_ItemBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemBeginDrop", _e_add_ItemBeginDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDragEnter", _e_add_ItemDragEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDragExit", _e_add_ItemDragExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDrag", _e_add_ItemDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDrop", _e_add_ItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemEndDrag", _e_add_ItemEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addSelectionChanged", _e_add_SelectionChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDoubleClick", _e_add_ItemDoubleClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemClick", _e_add_ItemClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemsRemoving", _e_add_ItemsRemoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemsRemoved", _e_add_ItemsRemoved);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addIsFocusedChanged", _e_add_IsFocusedChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addSubmit", _e_add_Submit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addCancel", _e_add_Cancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addClick", _e_add_Click);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addPointerEnter", _e_add_PointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addPointerExit", _e_add_PointerExit);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemBeginDrag", _e_remove_ItemBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemBeginDrop", _e_remove_ItemBeginDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDragEnter", _e_remove_ItemDragEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDragExit", _e_remove_ItemDragExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDrag", _e_remove_ItemDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDrop", _e_remove_ItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemEndDrag", _e_remove_ItemEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeSelectionChanged", _e_remove_SelectionChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDoubleClick", _e_remove_ItemDoubleClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemClick", _e_remove_ItemClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemsRemoving", _e_remove_ItemsRemoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemsRemoved", _e_remove_ItemsRemoved);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeIsFocusedChanged", _e_remove_IsFocusedChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeSubmit", _e_remove_Submit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeCancel", _e_remove_Cancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeClick", _e_remove_Click);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removePointerEnter", _e_remove_PointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removePointerExit", _e_remove_PointerExit);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemBeginDrag", _e_ItemBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemBeginDrop", _e_ItemBeginDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDragEnter", _e_ItemDragEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDragExit", _e_ItemDragExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDrag", _e_ItemDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDrop", _e_ItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemEndDrag", _e_ItemEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectionChanged", _e_SelectionChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDoubleClick", _e_ItemDoubleClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemClick", _e_ItemClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemsRemoving", _e_ItemsRemoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemsRemoved", _e_ItemsRemoved);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsFocusedChanged", _e_IsFocusedChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Submit", _e_Submit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cancel", _e_Cancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Click", _e_Click);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PointerEnter", _e_PointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PointerExit", _e_PointerExit);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDropInProgress", _g_get_IsDropInProgress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFocused", _g_get_IsFocused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DropTarget", _g_get_DropTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DropAction", _g_get_DropAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DragItems", _g_get_DragItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedItemsCount", _g_get_SelectedItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedItems", _g_get_SelectedItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedItem", _g_get_SelectedItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedIndex", _g_get_SelectedIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ItemsCount", _g_get_ItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Items", _g_get_Items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VisibleItemIndex", _g_get_VisibleItemIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VisibleItemsCount", _g_get_VisibleItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "m_eventSystem", _g_get_m_eventSystem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InputProvider", _g_get_InputProvider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectOnPointerUp", _g_get_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectUsingLeftButtonOnly", _g_get_SelectUsingLeftButtonOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanUnselectAll", _g_get_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanSelectAll", _g_get_CanSelectAll);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanMultiSelect", _g_get_CanMultiSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanRemove", _g_get_CanRemove);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanReorder", _g_get_CanReorder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ExpandChildrenWidth", _g_get_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ExpandChildrenHeight", _g_get_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Camera", _g_get_Camera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ScrollSpeed", _g_get_ScrollSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ScrollMargin", _g_get_ScrollMargin);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsFocused", _s_set_IsFocused);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectedItems", _s_set_SelectedItems);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectedItem", _s_set_SelectedItem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectedIndex", _s_set_SelectedIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Items", _s_set_Items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "m_eventSystem", _s_set_m_eventSystem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InputProvider", _s_set_InputProvider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectOnPointerUp", _s_set_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectUsingLeftButtonOnly", _s_set_SelectUsingLeftButtonOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanUnselectAll", _s_set_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanSelectAll", _s_set_CanSelectAll);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanMultiSelect", _s_set_CanMultiSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanRemove", _s_set_CanRemove);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanReorder", _s_set_CanReorder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ExpandChildrenWidth", _s_set_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ExpandChildrenHeight", _s_set_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Camera", _s_set_Camera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ScrollSpeed", _s_set_ScrollSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ScrollMargin", _s_set_ScrollMargin);
            
			
			
			
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
					
					Battlehub.UIControls.VirtualizingItemsControl gen_ret = new Battlehub.UIControls.VirtualizingItemsControl();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearTarget(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearTarget(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsItemSelected(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.IsItemSelected( 
                        _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItems(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.IEnumerable _value = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
                    bool _updateSelection = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetItems( 
                        _value, 
                        _updateSelection );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateContainerSize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingItemContainer _container = (Battlehub.UIControls.VirtualizingItemContainer)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingItemContainer));
                    
                    gen_to_be_invoked.UpdateContainerSize( 
                        _container );
                    
                    
                    
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
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_DataBindItem(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.DataBindItem( 
                        _item );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<object>(L, 2)&& translator.Assignable<Battlehub.UIControls.VirtualizingItemContainer>(L, 3)) 
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    Battlehub.UIControls.VirtualizingItemContainer _itemContainer = (Battlehub.UIControls.VirtualizingItemContainer)translator.GetObject(L, 3, typeof(Battlehub.UIControls.VirtualizingItemContainer));
                    
                    gen_to_be_invoked.DataBindItem( 
                        _item, 
                        _itemContainer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.DataBindItem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DataBindVisible(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DataBindVisible(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IndexOf(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        int gen_ret = gen_to_be_invoked.IndexOf( 
                        _obj );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIndex(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    int _newIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetIndex( 
                        _obj, 
                        _newIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LastItemContainerData(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        Battlehub.UIControls.ItemContainerData gen_ret = gen_to_be_invoked.LastItemContainerData(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                        Battlehub.UIControls.VirtualizingItemContainer gen_ret = gen_to_be_invoked.GetItemContainer( 
                        _item );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemContainerData(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _siblingIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        Battlehub.UIControls.ItemContainerData gen_ret = gen_to_be_invoked.GetItemContainerData( 
                        _siblingIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                        Battlehub.UIControls.ItemContainerData gen_ret = gen_to_be_invoked.GetItemContainerData( 
                        _item );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.GetItemContainerData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExternalBeginDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                    gen_to_be_invoked.ExternalBeginDrag( 
                        _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExternalItemDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                    gen_to_be_invoked.ExternalItemDrag( 
                        _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExternalItemDrop(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExternalItemDrop(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveSelectedItems(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RemoveSelectedItems(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                        Battlehub.UIControls.ItemContainerData gen_ret = gen_to_be_invoked.Add( 
                        _item );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Insert(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    object _item = translator.GetObject(L, 3, typeof(object));
                    
                        Battlehub.UIControls.ItemContainerData gen_ret = gen_to_be_invoked.Insert( 
                        _index, 
                        _item );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNextSibling(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sibling = translator.GetObject(L, 2, typeof(object));
                    object _nextSibling = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SetNextSibling( 
                        _sibling, 
                        _nextSibling );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPrevSibling(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sibling = translator.GetObject(L, 2, typeof(object));
                    object _prevSibling = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SetPrevSibling( 
                        _sibling, 
                        _prevSibling );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.Remove( 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItemAt(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        object gen_ret = gen_to_be_invoked.GetItemAt( 
                        _index );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSelect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
                    
                    gen_to_be_invoked.OnSelect( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDeselect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
                    
                    gen_to_be_invoked.OnDeselect( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUpdateSelected(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
                    
                    gen_to_be_invoked.OnUpdateSelected( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUpdateFocused(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
                    
                    gen_to_be_invoked.OnUpdateFocused( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDropInProgress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDropInProgress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFocused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFocused);
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
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DropTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DropTarget);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DropAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushBattlehubUIControlsItemDropAction(L, gen_to_be_invoked.DropAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DragItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DragItems);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectedItemsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SelectedItemsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectedItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.SelectedItems);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectedItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.SelectedItem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SelectedIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ItemsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ItemsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Items);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VisibleItemIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VisibleItemIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VisibleItemsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VisibleItemsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m_eventSystem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.m_eventSystem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InputProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.InputProvider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectOnPointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.SelectOnPointerUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectUsingLeftButtonOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.SelectUsingLeftButtonOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanUnselectAll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanUnselectAll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanSelectAll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanSelectAll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanMultiSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanMultiSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanEdit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanRemove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanRemove);
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
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanReorder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanReorder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ExpandChildrenWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ExpandChildrenWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ExpandChildrenHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ExpandChildrenHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Camera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Camera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ScrollSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.ScrollSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ScrollMargin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, gen_to_be_invoked.ScrollMargin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsFocused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsFocused = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectedItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectedItems = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectedItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectedItem = translator.GetObject(L, 2, typeof(object));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectedIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Items = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m_eventSystem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.m_eventSystem = (UnityEngine.EventSystems.EventSystem)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.EventSystem));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InputProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InputProvider = (Battlehub.UIControls.InputProvider)translator.GetObject(L, 2, typeof(Battlehub.UIControls.InputProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectOnPointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectOnPointerUp = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectUsingLeftButtonOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectUsingLeftButtonOnly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanUnselectAll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanUnselectAll = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanSelectAll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanSelectAll = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanMultiSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanMultiSelect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanEdit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanRemove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanRemove = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrag = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanReorder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanReorder = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ExpandChildrenWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ExpandChildrenWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ExpandChildrenHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ExpandChildrenHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Camera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Camera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ScrollSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ScrollSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ScrollMargin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ScrollMargin = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemBeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemBeginDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemBeginDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemBeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemBeginDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemBeginDrop += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemBeginDrop -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemBeginDrop!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDragEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemDragEnter += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemDragEnter -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDragEnter!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDragExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemDragExit += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemDragExit -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDragExit!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemDropArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemDropArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemDrop += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemDrop -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDrop!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemEndDrag += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemEndDrag -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemEndDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_SelectionChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.SelectionChangedArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.SelectionChangedArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.SelectionChangedArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.SelectionChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.SelectionChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.SelectionChanged!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemDoubleClick += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemDoubleClick -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDoubleClick!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemClick += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemClick -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemClick!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemsRemoving(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemsCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemsCancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemsCancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemsRemoving += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemsRemoving -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemsRemoving!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemsRemoved(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemsRemoved += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemsRemoved -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemsRemoved!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_IsFocusedChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.IsFocusedChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.IsFocusedChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.IsFocusedChanged!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Submit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Submit += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Submit -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Submit!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Cancel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Cancel += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Cancel -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Cancel!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Click(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Click += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Click -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Click!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.PointerEnter += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.PointerEnter -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.PointerEnter!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.PointerExit += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.PointerExit -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.PointerExit!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemBeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemBeginDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemBeginDrop += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemBeginDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDragEnter(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDragEnter += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDragEnter!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDragExit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDragExit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDragExit!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemDropArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemDropArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDrop += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemEndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_SelectionChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.SelectionChangedArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.SelectionChangedArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.SelectionChangedArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.SelectionChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.SelectionChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDoubleClick(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDoubleClick += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDoubleClick!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemClick(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemClick += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemClick!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemsRemoving(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemsCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemsCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemsCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemsRemoving += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemsRemoving!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemsRemoved(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemsRemoved += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemsRemoved!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_IsFocusedChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.IsFocusedChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.IsFocusedChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Submit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Submit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Submit!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Cancel(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Cancel += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Cancel!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Click(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Click += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Click!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_PointerEnter(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerEnter += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.PointerEnter!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_PointerExit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerExit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.PointerExit!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemBeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemBeginDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemBeginDrop -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemBeginDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDragEnter(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemDropCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDragEnter -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDragEnter!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDragExit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDragExit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDragExit!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemDropArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemDropArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemDropArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDrop -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemEndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_SelectionChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.SelectionChangedArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.SelectionChangedArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.SelectionChangedArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.SelectionChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.SelectionChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDoubleClick(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDoubleClick -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemDoubleClick!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemClick(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemClick -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemClick!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemsRemoving(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemsCancelArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemsCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemsCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemsRemoving -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemsRemoving!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemsRemoved(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemsRemovedArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemsRemoved -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.ItemsRemoved!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_IsFocusedChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.IsFocusedChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.IsFocusedChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Submit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Submit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Submit!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Cancel(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Cancel -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Cancel!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Click(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Click -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.Click!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_PointerEnter(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerEnter -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.PointerEnter!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_PointerExit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingItemsControl gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControl)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerExit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControl.PointerExit!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
