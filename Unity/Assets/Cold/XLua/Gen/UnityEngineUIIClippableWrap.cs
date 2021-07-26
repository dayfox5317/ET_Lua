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
    public partial class UnityEngineUIIClippableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.IClippable);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 2, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RecalculateClipping", _m_RecalculateClipping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cull", _m_Cull);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetClipRect", _m_SetClipRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetClipSoftness", _m_SetClipSoftness);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getgameObject", _g_get_gameObject);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrectTransform", _g_get_rectTransform);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", _g_get_gameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rectTransform", _g_get_rectTransform);
            
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.IClippable does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecalculateClipping(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.IClippable gen_to_be_invoked = (UnityEngine.UI.IClippable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RecalculateClipping(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cull(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.IClippable gen_to_be_invoked = (UnityEngine.UI.IClippable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect _clipRect;translator.Get(L, 2, out _clipRect);
                    bool _validRect = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Cull( 
                        _clipRect, 
                        _validRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetClipRect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.IClippable gen_to_be_invoked = (UnityEngine.UI.IClippable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect _value;translator.Get(L, 2, out _value);
                    bool _validRect = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetClipRect( 
                        _value, 
                        _validRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetClipSoftness(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.IClippable gen_to_be_invoked = (UnityEngine.UI.IClippable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _clipSoftness;translator.Get(L, 2, out _clipSoftness);
                    
                    gen_to_be_invoked.SetClipSoftness( 
                        _clipSoftness );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gameObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.IClippable gen_to_be_invoked = (UnityEngine.UI.IClippable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gameObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rectTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.IClippable gen_to_be_invoked = (UnityEngine.UI.IClippable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rectTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
