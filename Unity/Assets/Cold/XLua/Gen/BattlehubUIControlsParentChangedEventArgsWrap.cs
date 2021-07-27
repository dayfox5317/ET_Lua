﻿#if USE_UNI_LUA
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
    public partial class BattlehubUIControlsParentChangedEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.ParentChangedEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 0);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOldParent", _g_get_OldParent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getNewParent", _g_get_NewParent);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "OldParent", _g_get_OldParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NewParent", _g_get_NewParent);
            
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<Battlehub.UIControls.TreeViewItem>(L, 2) && translator.Assignable<Battlehub.UIControls.TreeViewItem>(L, 3))
				{
					Battlehub.UIControls.TreeViewItem _oldParent = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItem));
					Battlehub.UIControls.TreeViewItem _newParent = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 3, typeof(Battlehub.UIControls.TreeViewItem));
					
					Battlehub.UIControls.ParentChangedEventArgs gen_ret = new Battlehub.UIControls.ParentChangedEventArgs(_oldParent, _newParent);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.ParentChangedEventArgs constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OldParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ParentChangedEventArgs gen_to_be_invoked = (Battlehub.UIControls.ParentChangedEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OldParent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NewParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.ParentChangedEventArgs gen_to_be_invoked = (Battlehub.UIControls.ParentChangedEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.NewParent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
