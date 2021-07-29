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
    public partial class ETColdFileHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.FileHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllFiles", _m_GetAllFiles_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CleanDirectory", _m_CleanDirectory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyFile", _m_CopyFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyDirectory", _m_CopyDirectory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReplaceExtensionName", _m_ReplaceExtensionName_xlua_st_);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.FileHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllFiles_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.Generic.List<string> _files = (System.Collections.Generic.List<string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<string>));
                    string _dir = LuaAPI.lua_tostring(L, 2);
                    
                    ETCold.FileHelper.GetAllFiles( 
                        _files, 
                        _dir );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CleanDirectory_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _dir = LuaAPI.lua_tostring(L, 1);
                    
                    ETCold.FileHelper.CleanDirectory( 
                        _dir );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _srcDir = LuaAPI.lua_tostring(L, 1);
                    string _extensionName = LuaAPI.lua_tostring(L, 2);
                    
                    ETCold.FileHelper.CleanDirectory( 
                        _srcDir, 
                        _extensionName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.FileHelper.CleanDirectory!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyFile_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _sourcePath = LuaAPI.lua_tostring(L, 1);
                    string _targetPath = LuaAPI.lua_tostring(L, 2);
                    bool _overwrite = LuaAPI.lua_toboolean(L, 3);
                    
                        bool gen_ret = ETCold.FileHelper.CopyFile( 
                        _sourcePath, 
                        _targetPath, 
                        _overwrite );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyDirectory_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _srcDir = LuaAPI.lua_tostring(L, 1);
                    string _tgtDir = LuaAPI.lua_tostring(L, 2);
                    bool _copy_sub = LuaAPI.lua_toboolean(L, 3);
                    
                    ETCold.FileHelper.CopyDirectory( 
                        _srcDir, 
                        _tgtDir, 
                        _copy_sub );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _srcDir = LuaAPI.lua_tostring(L, 1);
                    string _tgtDir = LuaAPI.lua_tostring(L, 2);
                    
                    ETCold.FileHelper.CopyDirectory( 
                        _srcDir, 
                        _tgtDir );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.FileHelper.CopyDirectory!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReplaceExtensionName_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _srcDir = LuaAPI.lua_tostring(L, 1);
                    string _extensionName = LuaAPI.lua_tostring(L, 2);
                    string _newExtensionName = LuaAPI.lua_tostring(L, 3);
                    
                    ETCold.FileHelper.ReplaceExtensionName( 
                        _srcDir, 
                        _extensionName, 
                        _newExtensionName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
