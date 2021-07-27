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
    public partial class BattlehubUIControlsItemDataBindingArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemDataBindingArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 7, 7);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItemPresenter", _g_get_ItemPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEditorPresenter", _g_get_EditorPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanBeParent", _g_get_CanBeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanChangeParent", _g_get_CanChangeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanSelect", _g_get_CanSelect);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItemPresenter", _s_set_ItemPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setEditorPresenter", _s_set_EditorPresenter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanBeParent", _s_set_CanBeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanChangeParent", _s_set_CanChangeParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanSelect", _s_set_CanSelect);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ItemPresenter", _g_get_ItemPresenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EditorPresenter", _g_get_EditorPresenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanEdit", _g_get_CanEdit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanBeParent", _g_get_CanBeParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanChangeParent", _g_get_CanChangeParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanSelect", _g_get_CanSelect);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ItemPresenter", _s_set_ItemPresenter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EditorPresenter", _s_set_EditorPresenter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanEdit", _s_set_CanEdit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanBeParent", _s_set_CanBeParent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanChangeParent", _s_set_CanChangeParent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanSelect", _s_set_CanSelect);
            
			
			
			
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
					
					Battlehub.UIControls.ItemDataBindingArgs gen_ret = new Battlehub.UIControls.ItemDataBindingArgs();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemDataBindingArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ItemPresenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.EditorPresenter);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanEdit);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrag);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanBeParent);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanChangeParent);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ItemPresenter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EditorPresenter = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanEdit = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrag = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanBeParent = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanChangeParent = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.ItemDataBindingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemDataBindingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanSelect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
