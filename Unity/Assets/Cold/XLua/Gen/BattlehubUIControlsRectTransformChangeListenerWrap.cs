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
    public partial class BattlehubUIControlsRectTransformChangeListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.RectTransformChangeListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 0, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RaiseRectTransformChanged", _m_RaiseRectTransformChanged);
						
            
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addRectTransformChanged", _e_add_RectTransformChanged);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeRectTransformChanged", _e_remove_RectTransformChanged);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RectTransformChanged", _e_RectTransformChanged);
			
			
			
			
			
			
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
					
					Battlehub.UIControls.RectTransformChangeListener gen_ret = new Battlehub.UIControls.RectTransformChangeListener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.RectTransformChangeListener constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaiseRectTransformChanged(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.RectTransformChangeListener gen_to_be_invoked = (Battlehub.UIControls.RectTransformChangeListener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RaiseRectTransformChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RectTransformChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.RectTransformChangeListener gen_to_be_invoked = (Battlehub.UIControls.RectTransformChangeListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.RectTransformChanged gen_delegate = translator.GetDelegate<Battlehub.UIControls.RectTransformChanged>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.RectTransformChanged!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.RectTransformChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.RectTransformChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.RectTransformChangeListener.RectTransformChanged!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_RectTransformChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.RectTransformChangeListener gen_to_be_invoked = (Battlehub.UIControls.RectTransformChangeListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.RectTransformChanged gen_delegate = translator.GetDelegate<Battlehub.UIControls.RectTransformChanged>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.RectTransformChanged!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RectTransformChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.RectTransformChangeListener.RectTransformChanged!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_RectTransformChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.RectTransformChangeListener gen_to_be_invoked = (Battlehub.UIControls.RectTransformChangeListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.RectTransformChanged gen_delegate = translator.GetDelegate<Battlehub.UIControls.RectTransformChanged>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.RectTransformChanged!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.RectTransformChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.RectTransformChangeListener.RectTransformChanged!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
