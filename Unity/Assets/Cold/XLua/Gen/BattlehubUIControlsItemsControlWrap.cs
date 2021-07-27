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
    public partial class BattlehubUIControlsItemsControlWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemsControl);
			Utils.BeginObjectRegister(type, L, translator, 0, 78, 21, 17);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsItemSelected", _m_IsItemSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IndexOf", _m_IndexOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIndex", _m_SetIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItemContainer", _m_GetItemContainer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastItemContainer", _m_LastItemContainer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExternalBeginDrag", _m_ExternalBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExternalItemDrag", _m_ExternalItemDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExternalItemDrop", _m_ExternalItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", _m_Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNextSibling", _m_SetNextSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPrevSibling", _m_SetPrevSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAt", _m_RemoveAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DataBindItem", _m_DataBindItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveSelectedItems", _m_RemoveSelectedItems);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDropTarget", _g_get_DropTarget);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDropAction", _g_get_DropAction);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItems", _g_get_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItemsCount", _g_get_ItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedItemsCount", _g_get_SelectedItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedItems", _g_get_SelectedItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedItem", _g_get_SelectedItem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectedIndex", _g_get_SelectedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMultiselectKey", _g_get_MultiselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRangeselectKey", _g_get_RangeselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectAllKey", _g_get_SelectAllKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRemoveKey", _g_get_RemoveKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectOnPointerUp", _g_get_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanUnselectAll", _g_get_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanReorder", _g_get_CanReorder);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getExpandChildrenWidth", _g_get_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getExpandChildrenHeight", _g_get_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCamera", _g_get_Camera);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getScrollSpeed", _g_get_ScrollSpeed);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItems", _s_set_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectedItems", _s_set_SelectedItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectedItem", _s_set_SelectedItem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectedIndex", _s_set_SelectedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMultiselectKey", _s_set_MultiselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRangeselectKey", _s_set_RangeselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectAllKey", _s_set_SelectAllKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRemoveKey", _s_set_RemoveKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectOnPointerUp", _s_set_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanUnselectAll", _s_set_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanReorder", _s_set_CanReorder);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setExpandChildrenWidth", _s_set_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setExpandChildrenHeight", _s_set_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCamera", _s_set_Camera);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setScrollSpeed", _s_set_ScrollSpeed);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemBeginDrag", _e_add_ItemBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemBeginDrop", _e_add_ItemBeginDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDrop", _e_add_ItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemEndDrag", _e_add_ItemEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addSelectionChanged", _e_add_SelectionChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDoubleClick", _e_add_ItemDoubleClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemsRemoving", _e_add_ItemsRemoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemsRemoved", _e_add_ItemsRemoved);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemBeginDrag", _e_remove_ItemBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemBeginDrop", _e_remove_ItemBeginDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDrop", _e_remove_ItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemEndDrag", _e_remove_ItemEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeSelectionChanged", _e_remove_SelectionChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDoubleClick", _e_remove_ItemDoubleClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemsRemoving", _e_remove_ItemsRemoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemsRemoved", _e_remove_ItemsRemoved);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemBeginDrag", _e_ItemBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemBeginDrop", _e_ItemBeginDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDrop", _e_ItemDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemEndDrag", _e_ItemEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectionChanged", _e_SelectionChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDoubleClick", _e_ItemDoubleClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemsRemoving", _e_ItemsRemoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemsRemoved", _e_ItemsRemoved);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "DropTarget", _g_get_DropTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DropAction", _g_get_DropAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Items", _g_get_Items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ItemsCount", _g_get_ItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedItemsCount", _g_get_SelectedItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedItems", _g_get_SelectedItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedItem", _g_get_SelectedItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectedIndex", _g_get_SelectedIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MultiselectKey", _g_get_MultiselectKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RangeselectKey", _g_get_RangeselectKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectAllKey", _g_get_SelectAllKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RemoveKey", _g_get_RemoveKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectOnPointerUp", _g_get_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanUnselectAll", _g_get_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanReorder", _g_get_CanReorder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ExpandChildrenWidth", _g_get_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ExpandChildrenHeight", _g_get_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Camera", _g_get_Camera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ScrollSpeed", _g_get_ScrollSpeed);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Items", _s_set_Items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectedItems", _s_set_SelectedItems);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectedItem", _s_set_SelectedItem);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectedIndex", _s_set_SelectedIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MultiselectKey", _s_set_MultiselectKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RangeselectKey", _s_set_RangeselectKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectAllKey", _s_set_SelectAllKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RemoveKey", _s_set_RemoveKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectOnPointerUp", _s_set_SelectOnPointerUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanUnselectAll", _s_set_CanUnselectAll);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanReorder", _s_set_CanReorder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ExpandChildrenWidth", _s_set_ExpandChildrenWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ExpandChildrenHeight", _s_set_ExpandChildrenHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Camera", _s_set_Camera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ScrollSpeed", _s_set_ScrollSpeed);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Battlehub.UIControls.ItemsControl does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsItemSelected(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_IndexOf(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetItemContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _siblingIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        Battlehub.UIControls.ItemContainer gen_ret = gen_to_be_invoked.GetItemContainer( 
                        _siblingIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        Battlehub.UIControls.ItemContainer gen_ret = gen_to_be_invoked.GetItemContainer( 
                        _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.GetItemContainer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LastItemContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        Battlehub.UIControls.ItemContainer gen_ret = gen_to_be_invoked.LastItemContainer(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExternalBeginDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExternalItemDrop(  );
                    
                    
                    
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                        Battlehub.UIControls.ItemContainer gen_ret = gen_to_be_invoked.Add( 
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    object _item = translator.GetObject(L, 3, typeof(object));
                    
                        Battlehub.UIControls.ItemContainer gen_ret = gen_to_be_invoked.Insert( 
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_RemoveAt(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_DataBindItem(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    Battlehub.UIControls.ItemContainer _itemContainer = (Battlehub.UIControls.ItemContainer)translator.GetObject(L, 3, typeof(Battlehub.UIControls.ItemContainer));
                    
                    gen_to_be_invoked.DataBindItem( 
                        _item, 
                        _itemContainer );
                    
                    
                    
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
            
            
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RemoveSelectedItems(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DropTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushBattlehubUIControlsItemDropAction(L, gen_to_be_invoked.DropAction);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Items);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ItemsCount);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SelectedIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MultiselectKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MultiselectKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RangeselectKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RangeselectKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SelectAllKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SelectAllKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RemoveKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RemoveKey);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.SelectOnPointerUp);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanUnselectAll);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanEdit);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.ScrollSpeed);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Items = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
            
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectedIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MultiselectKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.MultiselectKey = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RangeselectKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.RangeselectKey = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SelectAllKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.SelectAllKey = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RemoveKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.RemoveKey = gen_value;
            
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SelectOnPointerUp = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanUnselectAll = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanEdit = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ScrollSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemBeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemBeginDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemBeginDrop!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemDrop!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemEndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemEndDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_SelectionChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.SelectionChanged!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemDoubleClick!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemsRemoving(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemsRemoving!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemsRemoved(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemsRemoved!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemBeginDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemBeginDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_SelectionChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.SelectionChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDoubleClick(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemDoubleClick!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemsRemoving(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemsRemoving!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemsRemoved(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemsRemoved!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemBeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemBeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemBeginDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemBeginDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDrop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemDrop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemEndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemEndDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_SelectionChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.SelectionChanged!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDoubleClick(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemDoubleClick!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemsRemoving(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemsRemoving!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemsRemoved(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.ItemsControl gen_to_be_invoked = (Battlehub.UIControls.ItemsControl)translator.FastGetCSObj(L, 1);
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemsControl.ItemsRemoved!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
