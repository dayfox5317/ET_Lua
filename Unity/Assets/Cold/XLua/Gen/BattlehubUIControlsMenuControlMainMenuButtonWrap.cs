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
    public partial class BattlehubUIControlsMenuControlMainMenuButtonWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MenuControl.MainMenuButton);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 5, 5);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMenu", _g_get_Menu);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPointerOverColor", _g_get_PointerOverColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getFocusedColor", _g_get_FocusedColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getNormalColor", _g_get_NormalColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getText", _g_get_Text);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMenu", _s_set_Menu);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setPointerOverColor", _s_set_PointerOverColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setFocusedColor", _s_set_FocusedColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setNormalColor", _s_set_NormalColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setText", _s_set_Text);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Menu", _g_get_Menu);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PointerOverColor", _g_get_PointerOverColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FocusedColor", _g_get_FocusedColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NormalColor", _g_get_NormalColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Text", _g_get_Text);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Menu", _s_set_Menu);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PointerOverColor", _s_set_PointerOverColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "FocusedColor", _s_set_FocusedColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "NormalColor", _s_set_NormalColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Text", _s_set_Text);
            
			
			
			
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
					
					Battlehub.UIControls.MenuControl.MainMenuButton gen_ret = new Battlehub.UIControls.MenuControl.MainMenuButton();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.MainMenuButton constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Menu(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Menu);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PointerOverColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.PointerOverColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FocusedColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.FocusedColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NormalColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.NormalColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Menu(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Menu = (Battlehub.UIControls.MenuControl.Menu)translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.Menu));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PointerOverColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.PointerOverColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FocusedColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.FocusedColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NormalColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.NormalColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MainMenuButton gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MainMenuButton)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
