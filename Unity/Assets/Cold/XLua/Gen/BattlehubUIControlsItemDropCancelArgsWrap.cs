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
    public partial class BattlehubUIControlsItemDropCancelArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemDropCancelArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 1);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCancel", _g_get_Cancel);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCancel", _s_set_Cancel);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Cancel", _g_get_Cancel);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Cancel", _s_set_Cancel);
            
			
			
			
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
					
					Battlehub.UIControls.ItemDropCancelArgs gen_ret = new Battlehub.UIControls.ItemDropCancelArgs(_dragItems, _dropTarget, _action, _isExternal, _pointerEventData);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemDropCancelArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Cancel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDropCancelArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropCancelArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Cancel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Cancel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDropCancelArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDropCancelArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Cancel = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
