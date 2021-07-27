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
    public partial class BattlehubUIControlsDockPanelsRepeatButtonWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.RepeatButton);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 3, 3);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", _m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerUp", _m_OnPointerUp);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsPressed", _g_get_IsPressed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonPointerDown", _g_get_onPointerDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonPointerUp", _g_get_onPointerUp);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsPressed", _s_set_IsPressed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setonPointerDown", _s_set_onPointerDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setonPointerUp", _s_set_onPointerUp);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPressed", _g_get_IsPressed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPointerDown", _g_get_onPointerDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPointerUp", _g_get_onPointerUp);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsPressed", _s_set_IsPressed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onPointerDown", _s_set_onPointerDown);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onPointerUp", _s_set_onPointerUp);
            
			
			
			
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
					
					Battlehub.UIControls.DockPanels.RepeatButton gen_ret = new Battlehub.UIControls.DockPanels.RepeatButton();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.RepeatButton constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerDown(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerDown( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerUp(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerUp( 
                        _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPressed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPressed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onPointerDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onPointerUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsPressed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsPressed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPointerDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onPointerDown = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPointerUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.RepeatButton gen_to_be_invoked = (Battlehub.UIControls.DockPanels.RepeatButton)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onPointerUp = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
