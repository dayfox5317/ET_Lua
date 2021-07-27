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
    public partial class BattlehubUtilsCursorHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.Utils.CursorHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 2, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Map", _m_Map);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDefaultCursor", _m_SetDefaultCursor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCursor", _m_SetCursor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetCursor", _m_ResetCursor);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDefaultCursorTexture", _g_get_DefaultCursorTexture);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDefaultCursorHotspot", _g_get_DefaultCursorHotspot);
            
			
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "DefaultCursorTexture", _g_get_DefaultCursorTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DefaultCursorHotspot", _g_get_DefaultCursorHotspot);
            
			
			
			
			
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
					
					Battlehub.Utils.CursorHelper gen_ret = new Battlehub.Utils.CursorHelper();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.Utils.CursorHelper constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Map(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.Utils.KnownCursor _cursorType;translator.Get(L, 2, out _cursorType);
                    UnityEngine.Texture2D _texture = (UnityEngine.Texture2D)translator.GetObject(L, 3, typeof(UnityEngine.Texture2D));
                    
                    gen_to_be_invoked.Map( 
                        _cursorType, 
                        _texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDefaultCursor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Texture2D _texture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
                    UnityEngine.Vector2 _hotspot;translator.Get(L, 3, out _hotspot);
                    
                    gen_to_be_invoked.SetDefaultCursor( 
                        _texture, 
                        _hotspot );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCursor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<object>(L, 2)&& translator.Assignable<Battlehub.Utils.KnownCursor>(L, 3)) 
                {
                    object _locker = translator.GetObject(L, 2, typeof(object));
                    Battlehub.Utils.KnownCursor _cursorType;translator.Get(L, 3, out _cursorType);
                    
                    gen_to_be_invoked.SetCursor( 
                        _locker, 
                        _cursorType );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<object>(L, 2)&& translator.Assignable<UnityEngine.Texture2D>(L, 3)) 
                {
                    object _locker = translator.GetObject(L, 2, typeof(object));
                    UnityEngine.Texture2D _texture = (UnityEngine.Texture2D)translator.GetObject(L, 3, typeof(UnityEngine.Texture2D));
                    
                    gen_to_be_invoked.SetCursor( 
                        _locker, 
                        _texture );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<object>(L, 2)&& translator.Assignable<Battlehub.Utils.KnownCursor>(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.CursorMode>(L, 5)) 
                {
                    object _locker = translator.GetObject(L, 2, typeof(object));
                    Battlehub.Utils.KnownCursor _cursorType;translator.Get(L, 3, out _cursorType);
                    UnityEngine.Vector2 _hotspot;translator.Get(L, 4, out _hotspot);
                    UnityEngine.CursorMode _mode;translator.Get(L, 5, out _mode);
                    
                    gen_to_be_invoked.SetCursor( 
                        _locker, 
                        _cursorType, 
                        _hotspot, 
                        _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<object>(L, 2)&& translator.Assignable<UnityEngine.Texture2D>(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.CursorMode>(L, 5)) 
                {
                    object _locker = translator.GetObject(L, 2, typeof(object));
                    UnityEngine.Texture2D _texture = (UnityEngine.Texture2D)translator.GetObject(L, 3, typeof(UnityEngine.Texture2D));
                    UnityEngine.Vector2 _hotspot;translator.Get(L, 4, out _hotspot);
                    UnityEngine.CursorMode _mode;translator.Get(L, 5, out _mode);
                    
                    gen_to_be_invoked.SetCursor( 
                        _locker, 
                        _texture, 
                        _hotspot, 
                        _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.Utils.CursorHelper.SetCursor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetCursor(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _locker = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.ResetCursor( 
                        _locker );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DefaultCursorTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DefaultCursorTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DefaultCursorHotspot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.Utils.CursorHelper gen_to_be_invoked = (Battlehub.Utils.CursorHelper)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.DefaultCursorHotspot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
