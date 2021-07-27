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
    public partial class BattlehubUIControlsPointerEnterExitListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.PointerEnterExitListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 0, 0);
			
            			
						
            
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addPointerEnter", _e_add_PointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addPointerExit", _e_add_PointerExit);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removePointerEnter", _e_remove_PointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removePointerExit", _e_remove_PointerExit);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PointerEnter", _e_PointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PointerExit", _e_PointerExit);
			
			
			
			
			
			
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
					
					Battlehub.UIControls.PointerEnterExitListener gen_ret = new Battlehub.UIControls.PointerEnterExitListener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.PointerEnterExitListener gen_to_be_invoked = (Battlehub.UIControls.PointerEnterExitListener)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.PointerEnter += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.PointerEnter -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener.PointerEnter!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_PointerExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.PointerEnterExitListener gen_to_be_invoked = (Battlehub.UIControls.PointerEnterExitListener)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.PointerExit += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.PointerExit -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener.PointerExit!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_PointerEnter(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.PointerEnterExitListener gen_to_be_invoked = (Battlehub.UIControls.PointerEnterExitListener)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerEnter += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener.PointerEnter!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_PointerExit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.PointerEnterExitListener gen_to_be_invoked = (Battlehub.UIControls.PointerEnterExitListener)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerExit += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener.PointerExit!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_PointerEnter(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.PointerEnterExitListener gen_to_be_invoked = (Battlehub.UIControls.PointerEnterExitListener)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerEnter -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener.PointerEnter!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_PointerExit(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.PointerEnterExitListener gen_to_be_invoked = (Battlehub.UIControls.PointerEnterExitListener)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.PointerEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.PointerEventArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.PointerEventArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.PointerExit -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.PointerEnterExitListener.PointerExit!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
