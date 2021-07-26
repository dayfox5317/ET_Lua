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
    public partial class UnityEngineEventSystemsExecuteEventsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.ExecuteEvents);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 35, 17, 0);
			
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getpointerEnterHandler", _g_get_pointerEnterHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getpointerExitHandler", _g_get_pointerExitHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getpointerDownHandler", _g_get_pointerDownHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getpointerUpHandler", _g_get_pointerUpHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getpointerClickHandler", _g_get_pointerClickHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getinitializePotentialDrag", _g_get_initializePotentialDrag);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getbeginDragHandler", _g_get_beginDragHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getdragHandler", _g_get_dragHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getendDragHandler", _g_get_endDragHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getdropHandler", _g_get_dropHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getscrollHandler", _g_get_scrollHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getupdateSelectedHandler", _g_get_updateSelectedHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getselectHandler", _g_get_selectHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getdeselectHandler", _g_get_deselectHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getmoveHandler", _g_get_moveHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getsubmitHandler", _g_get_submitHandler);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getcancelHandler", _g_get_cancelHandler);
            
			
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pointerEnterHandler", _g_get_pointerEnterHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pointerExitHandler", _g_get_pointerExitHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pointerDownHandler", _g_get_pointerDownHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pointerUpHandler", _g_get_pointerUpHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pointerClickHandler", _g_get_pointerClickHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "initializePotentialDrag", _g_get_initializePotentialDrag);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "beginDragHandler", _g_get_beginDragHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dragHandler", _g_get_dragHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "endDragHandler", _g_get_endDragHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dropHandler", _g_get_dropHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "scrollHandler", _g_get_scrollHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "updateSelectedHandler", _g_get_updateSelectedHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "selectHandler", _g_get_selectHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deselectHandler", _g_get_deselectHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "moveHandler", _g_get_moveHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "submitHandler", _g_get_submitHandler);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "cancelHandler", _g_get_cancelHandler);
            
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.EventSystems.ExecuteEvents does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerEnterHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.pointerEnterHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerExitHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.pointerExitHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerDownHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.pointerDownHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerUpHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.pointerUpHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerClickHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.pointerClickHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializePotentialDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.initializePotentialDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_beginDragHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.beginDragHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.dragHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endDragHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.endDragHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dropHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.dropHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.scrollHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updateSelectedHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.updateSelectedHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.selectHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deselectHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.deselectHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_moveHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.moveHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_submitHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.submitHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cancelHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.EventSystems.ExecuteEvents.cancelHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
