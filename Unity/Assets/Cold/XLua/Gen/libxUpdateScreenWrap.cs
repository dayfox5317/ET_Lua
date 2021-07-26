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
    public partial class libxUpdateScreenWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(libx.UpdateScreen);
			Utils.BeginObjectRegister(type, L, translator, 0, 13, 4, 4);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStart", _m_OnStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnMessage", _m_OnMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnProgress", _m_OnProgress);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnVersion", _m_OnVersion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnClear", _m_OnClear);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getbuttonStart", _g_get_buttonStart);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getprogressBar", _g_get_progressBar);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getprogressText", _g_get_progressText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getversion", _g_get_version);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setbuttonStart", _s_set_buttonStart);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setprogressBar", _s_set_progressBar);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setprogressText", _s_set_progressText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setversion", _s_set_version);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "buttonStart", _g_get_buttonStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "progressBar", _g_get_progressBar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "progressText", _g_get_progressText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "version", _g_get_version);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "buttonStart", _s_set_buttonStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "progressBar", _s_set_progressBar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "progressText", _s_set_progressText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "version", _s_set_version);
            
			
			
			
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
					
					libx.UpdateScreen gen_ret = new libx.UpdateScreen();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to libx.UpdateScreen constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStart(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnMessage(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _msg = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.OnMessage( 
                        _msg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnProgress(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _progress = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.OnProgress( 
                        _progress );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnVersion(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _ver = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.OnVersion( 
                        _ver );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnClear(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnClear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.buttonStart);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_progressBar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.progressBar);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_progressText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.progressText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_version(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.version);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.buttonStart = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_progressBar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.progressBar = (UnityEngine.UI.Slider)translator.GetObject(L, 2, typeof(UnityEngine.UI.Slider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_progressText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.progressText = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_version(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                libx.UpdateScreen gen_to_be_invoked = (libx.UpdateScreen)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.version = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
