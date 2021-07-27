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
    public partial class ETColdABPathHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.ABPathHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTexturePath", _m_GetTexturePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFGUIDesPath", _m_GetFGUIDesPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFGUIResPath", _m_GetFGUIResPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUGUIPath", _m_GetUGUIPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetConfigPath", _m_GetConfigPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSoundPath", _m_GetSoundPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSkillConfigPath", _m_GetSkillConfigPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUnitPath", _m_GetUnitPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetScenePath", _m_GetScenePath_xlua_st_);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ETCold.ABPathHelper gen_ret = new ETCold.ABPathHelper();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.ABPathHelper constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTexturePath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetTexturePath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFGUIDesPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetFGUIDesPath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFGUIResPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    string _extension = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = ETCold.ABPathHelper.GetFGUIResPath( 
                        _fileName, 
                        _extension );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUGUIPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetUGUIPath( 
                        _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConfigPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetConfigPath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSoundPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetSoundPath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSkillConfigPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetSkillConfigPath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUnitPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetUnitPath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScenePath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _fileName = LuaAPI.lua_tostring(L, 1);
                    
                        string gen_ret = ETCold.ABPathHelper.GetScenePath( 
                        _fileName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
