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
    public partial class BattlehubUIControlsItemExpandingArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ItemExpandingArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 1);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChildren", _g_get_Children);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChildren", _s_set_Children);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Children", _g_get_Children);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Children", _s_set_Children);
            
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<object>(L, 2))
				{
					object _item = translator.GetObject(L, 2, typeof(object));
					
					Battlehub.UIControls.ItemExpandingArgs gen_ret = new Battlehub.UIControls.ItemExpandingArgs(_item);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ItemExpandingArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Children(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemExpandingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemExpandingArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Children);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Children(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ItemExpandingArgs gen_to_be_invoked = (Battlehub.UIControls.ItemExpandingArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Children = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
