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
    public partial class BattlehubUIControlsItemContainerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemContainer);
			Utils.BeginObjectRegister(type, L, translator, 0, 17, 9, 7);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getLayoutElement", _g_get_LayoutElement);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRectTransform", _g_get_RectTransform);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsEditing", _g_get_IsEditing);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrop", _g_get_CanDrop);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItemPresenter", _g_get_ItemPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEditorPresenter", _g_get_EditorPresenter);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsSelected", _s_set_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsEditing", _s_set_IsEditing);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrop", _s_set_CanDrop);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItemPresenter", _s_set_ItemPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setEditorPresenter", _s_set_EditorPresenter);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LayoutElement", _g_get_LayoutElement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RectTransform", _g_get_RectTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsEditing", _g_get_IsEditing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrop", _g_get_CanDrop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ItemPresenter", _g_get_ItemPresenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EditorPresenter", _g_get_EditorPresenter);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsSelected", _s_set_IsSelected);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsEditing", _s_set_IsEditing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrop", _s_set_CanDrop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ItemPresenter", _s_set_ItemPresenter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EditorPresenter", _s_set_EditorPresenter);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 40, 0, 0);
			
            
			
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addSelected", _e_add_Selected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addUnselected", _e_add_Unselected);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addPointerDown", _e_add_PointerDown);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addPointerUp", _e_add_PointerUp);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addDoubleClick", _e_add_DoubleClick);
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
					
					Battlehub.UIControls.ItemContainer gen_ret = new Battlehub.UIControls.ItemContainer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
            
            
                
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanEdit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrop);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanEdit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrop = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemContainer gen_to_be_invoked = (Battlehub.UIControls.ItemContainer)translator.FastGetCSObj(L, 1);
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
					Battlehub.UIControls.ItemContainer.Selected += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.Selected -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Selected!");
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
					Battlehub.UIControls.ItemContainer.Unselected += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.Unselected -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.PointerDown += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.PointerDown -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerDown!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.PointerUp += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.PointerUp -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerUp!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_DoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.DoubleClick += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.DoubleClick -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.DoubleClick!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.PointerEnter += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.PointerEnter -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerEnter!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.PointerExit += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.PointerExit -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerExit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.BeginDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.BeginDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.Drag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.Drag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.Drop += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.Drop -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Drop!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.ItemContainer.EndDrag += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.EndDrag -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.EndDrag!");
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
					Battlehub.UIControls.ItemContainer.BeginEdit += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.BeginEdit -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.BeginEdit!");
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
					Battlehub.UIControls.ItemContainer.EndEdit += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.ItemContainer.EndEdit -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.EndEdit!");
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
					Battlehub.UIControls.ItemContainer.Selected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Selected!");
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
					Battlehub.UIControls.ItemContainer.Unselected += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerDown += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerDown!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerUp += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerUp!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_DoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.DoubleClick += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.DoubleClick!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerEnter += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerEnter!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerExit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerExit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.BeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.Drag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.Drop += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Drop!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.EndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.EndDrag!");
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
					Battlehub.UIControls.ItemContainer.BeginEdit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.BeginEdit!");
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
					Battlehub.UIControls.ItemContainer.EndEdit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.EndEdit!");
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
					Battlehub.UIControls.ItemContainer.Selected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Selected!");
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
					Battlehub.UIControls.ItemContainer.Unselected -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Unselected!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerDown -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerDown!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerUp -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerUp!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_DoubleClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.DoubleClick -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.DoubleClick!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerEnter -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerEnter!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.PointerExit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.PointerExit!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.BeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.BeginDrag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.Drag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Drag!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.Drop -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.Drop!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                Battlehub.UIControls.ItemEventHandler gen_delegate = translator.GetDelegate<Battlehub.UIControls.ItemEventHandler>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need Battlehub.UIControls.ItemEventHandler!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.ItemContainer.EndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.EndDrag!");
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
					Battlehub.UIControls.ItemContainer.BeginEdit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.BeginEdit!");
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
					Battlehub.UIControls.ItemContainer.EndEdit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemContainer.EndEdit!");
        }
        
    }
}
