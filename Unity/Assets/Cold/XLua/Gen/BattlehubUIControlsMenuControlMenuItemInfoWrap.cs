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
    public partial class BattlehubUIControlsMenuControlMenuItemInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MenuControl.MenuItemInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 8, 8);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getPath", _g_get_Path);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getText", _g_get_Text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIcon", _g_get_Icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCommand", _g_get_Command);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAction", _g_get_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getValidate", _g_get_Validate);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsVisible", _g_get_IsVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOn", _g_get_IsOn);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setPath", _s_set_Path);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setText", _s_set_Text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIcon", _s_set_Icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCommand", _s_set_Command);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAction", _s_set_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setValidate", _s_set_Validate);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsVisible", _s_set_IsVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOn", _s_set_IsOn);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Path", _g_get_Path);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Text", _g_get_Text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Icon", _g_get_Icon);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Command", _g_get_Command);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Action", _g_get_Action);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Validate", _g_get_Validate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVisible", _g_get_IsVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOn", _g_get_IsOn);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Path", _s_set_Path);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Text", _s_set_Text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Icon", _s_set_Icon);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Command", _s_set_Command);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Action", _s_set_Action);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Validate", _s_set_Validate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsVisible", _s_set_IsVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOn", _s_set_IsOn);
            
			
			
			
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
					
					Battlehub.UIControls.MenuControl.MenuItemInfo gen_ret = new Battlehub.UIControls.MenuControl.MenuItemInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MenuControl.MenuItemInfo constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Path(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Path);
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
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Icon);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Command(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Command);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Action(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Action);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Validate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Validate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVisible);
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
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Path(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Path = LuaAPI.lua_tostring(L, 2);
            
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
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Command(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Command = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Action(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Action = (Battlehub.UIControls.MenuControl.MenuItemEvent)translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItemEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Validate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Validate = (Battlehub.UIControls.MenuControl.MenuItemValidationEvent)translator.GetObject(L, 2, typeof(Battlehub.UIControls.MenuControl.MenuItemValidationEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsVisible = LuaAPI.lua_toboolean(L, 2);
            
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
			
                Battlehub.UIControls.MenuControl.MenuItemInfo gen_to_be_invoked = (Battlehub.UIControls.MenuControl.MenuItemInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOn = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
