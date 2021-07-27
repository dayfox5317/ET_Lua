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
    public partial class BattlehubUIControlsItemArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 0);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItems", _g_get_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPointerEventData", _g_get_PointerEventData);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Items", _g_get_Items);
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<object[]>(L, 2) && translator.Assignable<UnityEngine.EventSystems.PointerEventData>(L, 3))
				{
					object[] _item = (object[])translator.GetObject(L, 2, typeof(object[]));
					UnityEngine.EventSystems.PointerEventData _pointerEventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 3, typeof(UnityEngine.EventSystems.PointerEventData));
					
					Battlehub.UIControls.ItemArgs gen_ret = new Battlehub.UIControls.ItemArgs(_item, _pointerEventData);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemArgs gen_to_be_invoked = (Battlehub.UIControls.ItemArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Items);
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
			
                Battlehub.UIControls.ItemArgs gen_to_be_invoked = (Battlehub.UIControls.ItemArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.PointerEventData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
