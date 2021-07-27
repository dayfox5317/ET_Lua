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
    public partial class BattlehubUIControlsVirtualizingItemsControlInputProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.VirtualizingItemsControlInputProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 12, 8, 4);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsFunctionalButtonPressed", _g_get_IsFunctionalButtonPressed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsFunctional2ButtonPressed", _g_get_IsFunctional2ButtonPressed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsDeleteButtonDown", _g_get_IsDeleteButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelectAllButtonDown", _g_get_IsSelectAllButtonDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMultiselectKey", _g_get_MultiselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRangeselectKey", _g_get_RangeselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSelectAllKey", _g_get_SelectAllKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDeleteKey", _g_get_DeleteKey);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMultiselectKey", _s_set_MultiselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRangeselectKey", _s_set_RangeselectKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSelectAllKey", _s_set_SelectAllKey);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDeleteKey", _s_set_DeleteKey);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFunctionalButtonPressed", _g_get_IsFunctionalButtonPressed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFunctional2ButtonPressed", _g_get_IsFunctional2ButtonPressed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDeleteButtonDown", _g_get_IsDeleteButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelectAllButtonDown", _g_get_IsSelectAllButtonDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MultiselectKey", _g_get_MultiselectKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RangeselectKey", _g_get_RangeselectKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SelectAllKey", _g_get_SelectAllKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeleteKey", _g_get_DeleteKey);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "MultiselectKey", _s_set_MultiselectKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RangeselectKey", _s_set_RangeselectKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SelectAllKey", _s_set_SelectAllKey);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DeleteKey", _s_set_DeleteKey);
            
			
			
			
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
					
					Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_ret = new Battlehub.UIControls.VirtualizingItemsControlInputProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemsControlInputProvider constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFunctionalButtonPressed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFunctionalButtonPressed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFunctional2ButtonPressed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFunctional2ButtonPressed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDeleteButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDeleteButtonDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSelectAllButtonDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSelectAllButtonDown);
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
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SelectAllKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeleteKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DeleteKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MultiselectKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.SelectAllKey = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DeleteKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemsControlInputProvider gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemsControlInputProvider)translator.FastGetCSObj(L, 1);
                UnityEngine.KeyCode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DeleteKey = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
