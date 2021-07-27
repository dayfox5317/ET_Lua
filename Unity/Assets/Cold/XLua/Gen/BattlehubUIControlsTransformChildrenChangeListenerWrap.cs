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
    public partial class BattlehubUIControlsTransformChildrenChangeListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.TransformChildrenChangeListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
            			
						
            
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addTransformChildrenChanged", _e_add_TransformChildrenChanged);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeTransformChildrenChanged", _e_remove_TransformChildrenChanged);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformChildrenChanged", _e_TransformChildrenChanged);
			
			
			
			
			
			
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
					
					Battlehub.UIControls.TransformChildrenChangeListener gen_ret = new Battlehub.UIControls.TransformChildrenChangeListener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TransformChildrenChangeListener constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TransformChildrenChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.TransformChildrenChangeListener gen_to_be_invoked = (Battlehub.UIControls.TransformChildrenChangeListener)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.RectTransformChanged gen_delegate = translator.GetDelegate<Battlehub.UIControls.RectTransformChanged>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.RectTransformChanged!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TransformChildrenChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TransformChildrenChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TransformChildrenChangeListener.TransformChildrenChanged!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_TransformChildrenChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.TransformChildrenChangeListener gen_to_be_invoked = (Battlehub.UIControls.TransformChildrenChangeListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.RectTransformChanged gen_delegate = translator.GetDelegate<Battlehub.UIControls.RectTransformChanged>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.RectTransformChanged!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TransformChildrenChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TransformChildrenChangeListener.TransformChildrenChanged!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_TransformChildrenChanged(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.TransformChildrenChangeListener gen_to_be_invoked = (Battlehub.UIControls.TransformChildrenChangeListener)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.RectTransformChanged gen_delegate = translator.GetDelegate<Battlehub.UIControls.RectTransformChanged>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.RectTransformChanged!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.TransformChildrenChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TransformChildrenChangeListener.TransformChildrenChanged!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
