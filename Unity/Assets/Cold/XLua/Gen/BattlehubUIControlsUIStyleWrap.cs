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
    public partial class BattlehubUIControlsUIStyleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.UIStyle);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 1, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyImageColor", _m_ApplyImageColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyOutlineColor", _m_ApplyOutlineColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyTextColor", _m_ApplyTextColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyInputFieldColor", _m_ApplyInputFieldColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplySelectableColor", _m_ApplySelectableColor);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getName", _g_get_Name);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setName", _s_set_Name);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Name", _g_get_Name);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Name", _s_set_Name);
            
			
			
			
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
					
					Battlehub.UIControls.UIStyle gen_ret = new Battlehub.UIControls.UIStyle();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.UIStyle constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyImageColor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    gen_to_be_invoked.ApplyImageColor( 
                        _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyOutlineColor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    gen_to_be_invoked.ApplyOutlineColor( 
                        _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyTextColor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    gen_to_be_invoked.ApplyTextColor( 
                        _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyInputFieldColor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color _normalColor;translator.Get(L, 2, out _normalColor);
                    UnityEngine.Color _highlighedColor;translator.Get(L, 3, out _highlighedColor);
                    UnityEngine.Color _pressedColor;translator.Get(L, 4, out _pressedColor);
                    UnityEngine.Color _disabledColor;translator.Get(L, 5, out _disabledColor);
                    UnityEngine.Color _selectedColor;translator.Get(L, 6, out _selectedColor);
                    
                    gen_to_be_invoked.ApplyInputFieldColor( 
                        _normalColor, 
                        _highlighedColor, 
                        _pressedColor, 
                        _disabledColor, 
                        _selectedColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplySelectableColor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color _normalColor;translator.Get(L, 2, out _normalColor);
                    UnityEngine.Color _highlighedColor;translator.Get(L, 3, out _highlighedColor);
                    UnityEngine.Color _pressedColor;translator.Get(L, 4, out _pressedColor);
                    UnityEngine.Color _disabledColor;translator.Get(L, 5, out _disabledColor);
                    UnityEngine.Color _selectedColor;translator.Get(L, 6, out _selectedColor);
                    
                    gen_to_be_invoked.ApplySelectableColor( 
                        _normalColor, 
                        _highlighedColor, 
                        _pressedColor, 
                        _disabledColor, 
                        _selectedColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.UIStyle gen_to_be_invoked = (Battlehub.UIControls.UIStyle)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
