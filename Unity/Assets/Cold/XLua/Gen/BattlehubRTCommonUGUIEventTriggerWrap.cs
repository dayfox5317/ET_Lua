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
    public partial class BattlehubRTCommonUGUIEventTriggerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.RTCommon.UGUIEventTrigger);
			Utils.BeginObjectRegister(type, L, translator, 0, 44, 1, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnCancel", _m_OnCancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelect", _m_OnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSubmit", _m_OnSubmit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerClick", _m_OnPointerClick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDeselect", _m_OnDeselect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDrag", _m_OnBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", _m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEndDrag", _m_OnEndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrop", _m_OnDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", _m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerUp", _m_OnPointerUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnMove", _m_OnMove);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsPointerOver", _g_get_IsPointerOver);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsPointerOver", _s_set_IsPointerOver);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnPointerEnterEvent", _e_add_OnPointerEnterEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnPointerExitEvent", _e_add_OnPointerExitEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnPointerClickEvent", _e_add_OnPointerClickEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnPointerDownEvent", _e_add_OnPointerDownEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnPointerUpEvent", _e_add_OnPointerUpEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnScrollEvent", _e_add_OnScrollEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnBeginDragEvent", _e_add_OnBeginDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnDragEvent", _e_add_OnDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnEndDragEvent", _e_add_OnEndDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOnDropEvent", _e_add_OnDropEvent);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnPointerEnterEvent", _e_remove_OnPointerEnterEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnPointerExitEvent", _e_remove_OnPointerExitEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnPointerClickEvent", _e_remove_OnPointerClickEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnPointerDownEvent", _e_remove_OnPointerDownEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnPointerUpEvent", _e_remove_OnPointerUpEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnScrollEvent", _e_remove_OnScrollEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnBeginDragEvent", _e_remove_OnBeginDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnDragEvent", _e_remove_OnDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnEndDragEvent", _e_remove_OnEndDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOnDropEvent", _e_remove_OnDropEvent);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerEnterEvent", _e_OnPointerEnterEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerExitEvent", _e_OnPointerExitEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerClickEvent", _e_OnPointerClickEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDownEvent", _e_OnPointerDownEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerUpEvent", _e_OnPointerUpEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnScrollEvent", _e_OnScrollEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDragEvent", _e_OnBeginDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDragEvent", _e_OnDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEndDragEvent", _e_OnEndDragEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDropEvent", _e_OnDropEvent);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPointerOver", _g_get_IsPointerOver);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsPointerOver", _s_set_IsPointerOver);
            
			
			
			
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
					
					Battlehub.RTCommon.UGUIEventTrigger gen_ret = new Battlehub.RTCommon.UGUIEventTrigger();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnCancel(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
                    
                    gen_to_be_invoked.OnCancel( 
                        _eventData );
                    
                    
                    
                    return 0;
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
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnSubmit(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.BaseEventData _eventData = (UnityEngine.EventSystems.BaseEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
                    
                    gen_to_be_invoked.OnSubmit( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerClick(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerClick( 
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
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnBeginDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnBeginDrag( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnDrag( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnEndDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnEndDrag( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDrop(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnDrop( 
                        _eventData );
                    
                    
                    
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
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnPointerUp(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerUp( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnMove(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.AxisEventData _eventData = (UnityEngine.EventSystems.AxisEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
                    
                    gen_to_be_invoked.OnMove( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPointerOver(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPointerOver);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsPointerOver(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsPointerOver = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnPointerEnterEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnPointerEnterEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnPointerEnterEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerEnterEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnPointerExitEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnPointerExitEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnPointerExitEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerExitEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnPointerClickEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnPointerClickEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnPointerClickEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerClickEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnPointerDownEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnPointerDownEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnPointerDownEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerDownEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnPointerUpEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnPointerUpEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnPointerUpEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerUpEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnScrollEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnScrollEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnScrollEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnScrollEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnBeginDragEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnBeginDragEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnBeginDragEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnBeginDragEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnDragEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnDragEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnDragEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnDragEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnEndDragEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnEndDragEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnEndDragEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnEndDragEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnDropEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
                Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.RTCommon.DragDropEventHander!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OnDropEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OnDropEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnDropEvent!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnPointerEnterEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerEnterEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerEnterEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnPointerExitEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerExitEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerExitEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnPointerClickEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerClickEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerClickEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnPointerDownEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerDownEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerDownEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnPointerUpEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerUpEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerUpEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnScrollEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnScrollEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnScrollEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnBeginDragEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnBeginDragEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnBeginDragEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnDragEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnDragEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnDragEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnEndDragEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnEndDragEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnEndDragEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_OnDropEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnDropEvent += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnDropEvent!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnPointerEnterEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerEnterEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerEnterEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnPointerExitEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerExitEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerExitEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnPointerClickEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerClickEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerClickEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnPointerDownEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerDownEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerDownEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnPointerUpEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnPointerUpEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnPointerUpEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnScrollEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnScrollEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnScrollEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnBeginDragEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnBeginDragEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnBeginDragEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnDragEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnDragEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnDragEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnEndDragEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnEndDragEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnEndDragEvent!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_OnDropEvent(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.RTCommon.UGUIEventTrigger gen_to_be_invoked = (Battlehub.RTCommon.UGUIEventTrigger)translator.FastGetCSObj(L, 1);
				Battlehub.RTCommon.DragDropEventHander gen_delegate = translator.GetDelegate<Battlehub.RTCommon.DragDropEventHander>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.RTCommon.DragDropEventHander!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.OnDropEvent -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.RTCommon.UGUIEventTrigger.OnDropEvent!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
