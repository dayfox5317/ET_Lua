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
    public partial class BattlehubUIControlsItemDropArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemDropArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 5, 0);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDragItems", _g_get_DragItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDropTarget", _g_get_DropTarget);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAction", _g_get_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsExternal", _g_get_IsExternal);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPointerEventData", _g_get_PointerEventData);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "DragItems", _g_get_DragItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DropTarget", _g_get_DropTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Action", _g_get_Action);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsExternal", _g_get_IsExternal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PointerEventData", _g_get_PointerEventData);
            
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<object[]>(L, 2) && translator.Assignable<object>(L, 3) && translator.Assignable<Battlehub.UIControls.ItemDropAction>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && translator.Assignable<UnityEngine.EventSystems.PointerEventData>(L, 6))
				{
					object[] _dragItems = (object[])translator.GetObject(L, 2, typeof(object[]));
					object _dropTarget = translator.GetObject(L, 3, typeof(object));
					Battlehub.UIControls.ItemDropAction _action;translator.Get(L, 4, out _action);
					bool _isExternal = LuaAPI.lua_toboolean(L, 5);
					UnityEngine.EventSystems.PointerEventData _pointerEventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 6, typeof(UnityEngine.EventSystems.PointerEventData));
					
					Battlehub.UIControls.ItemDropArgs gen_ret = new Battlehub.UIControls.ItemDropArgs(_dragItems, _dropTarget, _action, _isExternal, _pointerEventData);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemDropArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DragItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDropArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DragItems);
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
			
                Battlehub.UIControls.ItemDropArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DropTarget);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Action(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDropArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropArgs)translator.FastGetCSObj(L, 1);
                translator.PushBattlehubUIControlsItemDropAction(L, gen_to_be_invoked.Action);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsExternal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDropArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsExternal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PointerEventData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDropArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.PointerEventData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
