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
    public partial class BattlehubUIControlsCommonDragAndDropListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.Common.DragAndDropListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 21, 1, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInitializePotentialDrag", _m_OnInitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDrag", _m_OnBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", _m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrop", _m_OnDrop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEndDrag", _m_OnEndDrag);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getInProgress", _g_get_InProgress);
            
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addInitializePotentialDrag", _e_add_InitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addBeginDrag", _e_add_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addDrag", _e_add_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addDrop", _e_add_Drop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addEndDrag", _e_add_EndDrag);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeInitializePotentialDrag", _e_remove_InitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeBeginDrag", _e_remove_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeDrag", _e_remove_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeDrop", _e_remove_Drop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeEndDrag", _e_remove_EndDrag);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitializePotentialDrag", _e_InitializePotentialDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginDrag", _e_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Drag", _e_Drag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Drop", _e_Drop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndDrag", _e_EndDrag);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "InProgress", _g_get_InProgress);
            
			
			
			
			
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
					
					Battlehub.UIControls.Common.DragAndDropListener gen_ret = new Battlehub.UIControls.Common.DragAndDropListener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnInitializePotentialDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnInitializePotentialDrag( 
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
            
            
                Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnDrop(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnEndDrag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_InProgress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.InProgress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_InitializePotentialDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Common.DragAndDropEvent!");
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.InitializePotentialDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_BeginDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Common.DragAndDropEvent!");
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.BeginDrag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Common.DragAndDropEvent!");
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.Drag!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Drop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Common.DragAndDropEvent!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Drop += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Drop -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.Drop!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EndDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Common.DragAndDropEvent!");
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
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.EndDrag!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_InitializePotentialDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.InitializePotentialDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.InitializePotentialDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_BeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.BeginDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.BeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Drag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Drag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.Drag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Drop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Drop += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.Drop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_EndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.EndDrag += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.EndDrag!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_InitializePotentialDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.InitializePotentialDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.InitializePotentialDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_BeginDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.BeginDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.BeginDrag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Drag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Drag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.Drag!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Drop(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Drop -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.Drop!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_EndDrag(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Common.DragAndDropListener gen_to_be_invoked = (Battlehub.UIControls.Common.DragAndDropListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Common.DragAndDropEvent gen_delegate = translator.GetDelegate<Battlehub.UIControls.Common.DragAndDropEvent>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Common.DragAndDropEvent!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.EndDrag -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Common.DragAndDropListener.EndDrag!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
