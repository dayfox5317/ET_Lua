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
    public partial class BattlehubUIControlsSelectionChangedArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.SelectionChangedArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 4, 0);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOldItems", _g_get_OldItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getNewItems", _g_get_NewItems);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOldItem", _g_get_OldItem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getNewItem", _g_get_NewItem);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "OldItems", _g_get_OldItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NewItems", _g_get_NewItems);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OldItem", _g_get_OldItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NewItem", _g_get_NewItem);
            
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<object[]>(L, 2) && translator.Assignable<object[]>(L, 3))
				{
					object[] _oldItems = (object[])translator.GetObject(L, 2, typeof(object[]));
					object[] _newItems = (object[])translator.GetObject(L, 3, typeof(object[]));
					
					Battlehub.UIControls.SelectionChangedArgs gen_ret = new Battlehub.UIControls.SelectionChangedArgs(_oldItems, _newItems);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<object>(L, 2) && translator.Assignable<object>(L, 3))
				{
					object _oldItem = translator.GetObject(L, 2, typeof(object));
					object _newItem = translator.GetObject(L, 3, typeof(object));
					
					Battlehub.UIControls.SelectionChangedArgs gen_ret = new Battlehub.UIControls.SelectionChangedArgs(_oldItem, _newItem);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.SelectionChangedArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OldItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.SelectionChangedArgs gen_to_be_invoked = (Battlehub.UIControls.SelectionChangedArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OldItems);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NewItems(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.SelectionChangedArgs gen_to_be_invoked = (Battlehub.UIControls.SelectionChangedArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.NewItems);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OldItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.SelectionChangedArgs gen_to_be_invoked = (Battlehub.UIControls.SelectionChangedArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.OldItem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NewItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.SelectionChangedArgs gen_to_be_invoked = (Battlehub.UIControls.SelectionChangedArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.NewItem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
