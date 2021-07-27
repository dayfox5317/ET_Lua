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
    public partial class BattlehubUIControlsTreeViewExpanderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.TreeViewExpander);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 3, 3);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanExpand", _g_get_CanExpand);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOffGraphic", _g_get_OffGraphic);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanExpand", _s_set_CanExpand);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setOffGraphic", _s_set_OffGraphic);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanExpand", _g_get_CanExpand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OffGraphic", _g_get_OffGraphic);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanExpand", _s_set_CanExpand);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OffGraphic", _s_set_OffGraphic);
            
			
			
			
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
					
					Battlehub.UIControls.TreeViewExpander gen_ret = new Battlehub.UIControls.TreeViewExpander();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewExpander constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanExpand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewExpander gen_to_be_invoked = (Battlehub.UIControls.TreeViewExpander)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanExpand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewExpander gen_to_be_invoked = (Battlehub.UIControls.TreeViewExpander)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OffGraphic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewExpander gen_to_be_invoked = (Battlehub.UIControls.TreeViewExpander)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OffGraphic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanExpand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewExpander gen_to_be_invoked = (Battlehub.UIControls.TreeViewExpander)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanExpand = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewExpander gen_to_be_invoked = (Battlehub.UIControls.TreeViewExpander)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOn = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OffGraphic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewExpander gen_to_be_invoked = (Battlehub.UIControls.TreeViewExpander)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OffGraphic = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
