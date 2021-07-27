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
    public partial class BattlehubUIControlsUIMenuStyleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.UIMenuStyle);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ApplyMainButtonColor", _m_ApplyMainButtonColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ApplyMenuItemColor", _m_ApplyMenuItemColor_xlua_st_);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Battlehub.UIControls.UIMenuStyle gen_ret = new Battlehub.UIControls.UIMenuStyle();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.UIMenuStyle constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyMainButtonColor_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Battlehub.UIControls.UIStyle _uiStyle = (Battlehub.UIControls.UIStyle)translator.GetObject(L, 1, typeof(Battlehub.UIControls.UIStyle));
                    UnityEngine.Color _normal;translator.Get(L, 2, out _normal);
                    UnityEngine.Color _pointerOver;translator.Get(L, 3, out _pointerOver);
                    UnityEngine.Color _focused;translator.Get(L, 4, out _focused);
                    
                    Battlehub.UIControls.UIMenuStyle.ApplyMainButtonColor( 
                        _uiStyle, 
                        _normal, 
                        _pointerOver, 
                        _focused );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyMenuItemColor_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Battlehub.UIControls.UIStyle _uiStyle = (Battlehub.UIControls.UIStyle)translator.GetObject(L, 1, typeof(Battlehub.UIControls.UIStyle));
                    UnityEngine.Color _selectionColor;translator.Get(L, 2, out _selectionColor);
                    UnityEngine.Color _textColor;translator.Get(L, 3, out _textColor);
                    UnityEngine.Color _disabledSelectionColor;translator.Get(L, 4, out _disabledSelectionColor);
                    UnityEngine.Color _disabledTextColor;translator.Get(L, 5, out _disabledTextColor);
                    
                    Battlehub.UIControls.UIMenuStyle.ApplyMenuItemColor( 
                        _uiStyle, 
                        _selectionColor, 
                        _textColor, 
                        _disabledSelectionColor, 
                        _disabledTextColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
