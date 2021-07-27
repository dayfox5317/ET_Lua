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
    public partial class BattlehubUIControlsVirtualizingItemContainerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.VirtualizingItemContainer);
			Utils.BeginObjectRegister(type, L, translator, 0, 21, 11, 9);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLayoutElement", _g_get_LayoutElement);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRectTransform", _g_get_RectTransform);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsEditing", _g_get_IsEditing);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanBeParent", _g_get_CanBeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanSelect", _g_get_CanSelect);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanChangeParent", _g_get_CanChangeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItemPresenter", _g_get_ItemPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEditorPresenter", _g_get_EditorPresenter);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsSelected", _s_set_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsEditing", _s_set_IsEditing);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanBeParent", _s_set_CanBeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanSelect", _s_set_CanSelect);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanChangeParent", _s_set_CanChangeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItemPresenter", _s_set_ItemPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setEditorPresenter", _s_set_EditorPresenter);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LayoutElement", _g_get_LayoutElement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RectTransform", _g_get_RectTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsEditing", _g_get_IsEditing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanBeParent", _g_get_CanBeParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanSelect", _g_get_CanSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanChangeParent", _g_get_CanChangeParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ItemPresenter", _g_get_ItemPresenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EditorPresenter", _g_get_EditorPresenter);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsSelected", _s_set_IsSelected);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsEditing", _s_set_IsEditing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanBeParent", _s_set_CanBeParent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanSelect", _s_set_CanSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanChangeParent", _s_set_CanChangeParent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ItemPresenter", _s_set_ItemPresenter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EditorPresenter", _s_set_EditorPresenter);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 43, 0, 0);
			
            
			
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addSelected", _e_add_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addUnselected", _e_add_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addPointerDown", _e_add_PointerDown);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addPointerUp", _e_add_PointerUp);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDoubleClick", _e_add_DoubleClick);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addClick", _e_add_Click);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addPointerEnter", _e_add_PointerEnter);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addPointerExit", _e_add_PointerExit);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addBeginDrag", _e_add_BeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDrag", _e_add_Drag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDrop", _e_add_Drop);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addEndDrag", _e_add_EndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addBeginEdit", _e_add_BeginEdit);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addEndEdit", _e_add_EndEdit);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeSelected", _e_remove_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeUnselected", _e_remove_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removePointerDown", _e_remove_PointerDown);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removePointerUp", _e_remove_PointerUp);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDoubleClick", _e_remove_DoubleClick);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeClick", _e_remove_Click);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removePointerEnter", _e_remove_PointerEnter);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removePointerExit", _e_remove_PointerExit);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeBeginDrag", _e_remove_BeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDrag", _e_remove_Drag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeDrop", _e_remove_Drop);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeEndDrag", _e_remove_EndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeBeginEdit", _e_remove_BeginEdit);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeEndEdit", _e_remove_EndEdit);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Selected", _e_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Unselected", _e_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PointerDown", _e_PointerDown);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PointerUp", _e_PointerUp);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DoubleClick", _e_DoubleClick);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Click", _e_Click);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PointerEnter", _e_PointerEnter);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PointerExit", _e_PointerExit);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginDrag", _e_BeginDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Drag", _e_Drag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Drop", _e_Drop);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "EndDrag", _e_EndDrag);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginEdit", _e_BeginEdit);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "EndEdit", _e_EndEdit);
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Battlehub.UIControls.VirtualizingItemContainer gen_ret = new Battlehub.UIControls.VirtualizingItemContainer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LayoutElement(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LayoutElement);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RectTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RectTransform);
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
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEditing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsEditing);
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
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrag);
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
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanEdit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanBeParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanBeParent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanChangeParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanChangeParent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ItemPresenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ItemPresenter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EditorPresenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.EditorPresenter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsSelected = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsEditing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsEditing = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrag = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanEdit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanBeParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanBeParent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanSelect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanChangeParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanChangeParent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ItemPresenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ItemPresenter = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EditorPresenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemContainer gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EditorPresenter = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Selected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.Selected += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.Selected -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Selected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Unselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.Unselected += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.Unselected -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerDown += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerDown -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerDown!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerUp += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerUp -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerUp!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_DoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.DoubleClick += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.DoubleClick -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.DoubleClick!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Click(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.Click += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.Click -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Click!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerEnter += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerEnter -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerEnter!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerExit += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerExit -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerExit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.Drag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.Drag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.Drop += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.Drop -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Drop!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.EndDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.EndDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.EndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginEdit += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginEdit -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.BeginEdit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.VirtualizingItemContainer.EndEdit += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.VirtualizingItemContainer.EndEdit -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.EndEdit!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Selected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Selected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Selected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Unselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Unselected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerDown += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerDown!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerUp += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerUp!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_DoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.DoubleClick += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.DoubleClick!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Click(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Click += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Click!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerEnter += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerEnter!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerExit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerExit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Drag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Drop += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Drop!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.EndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.EndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeginEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginEdit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.BeginEdit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_EndEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.EndEdit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.EndEdit!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Selected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Selected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Selected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Unselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Unselected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerDown -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerDown!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerUp -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerUp!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_DoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.DoubleClick -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.DoubleClick!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Click(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Click -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Click!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerEnter -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerEnter!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.PointerExit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.PointerExit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Drag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.Drop -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.Drop!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.VirtualizingItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.VirtualizingItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.VirtualizingItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.EndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.EndDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeginEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.BeginEdit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.BeginEdit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_EndEdit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler gen_delegate = translator.GetDelegate<System.EventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.VirtualizingItemContainer.EndEdit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemContainer.EndEdit!");
        }
        
    }
}
