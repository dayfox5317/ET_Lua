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
    public partial class libxVersionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(libx.Versions);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 15, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAssetBundleFromFile", _m_LoadAssetBundleFromFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAssetBundleFromFileAsync", _m_LoadAssetBundleFromFileAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BuildVersions", _m_BuildVersions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadVersion", _m_LoadVersion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadVersions", _m_LoadVersions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateDisk", _m_UpdateDisk_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadDisk", _m_LoadDisk_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsNew", _m_IsNew_xlua_st_);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getDataname", libx.Versions.Dataname);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getFilename", libx.Versions.Filename);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getverifyBy", libx.Versions.verifyBy);
            
			
			
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dataname", libx.Versions.Dataname);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Filename", libx.Versions.Filename);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "verifyBy", libx.Versions.verifyBy);
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "libx.Versions does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetBundleFromFile_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AssetBundle gen_ret = libx.Versions.LoadAssetBundleFromFile( 
                        _url );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetBundleFromFileAsync_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AssetBundleCreateRequest gen_ret = libx.Versions.LoadAssetBundleFromFileAsync( 
                        _url );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BuildVersions_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _outputPath = LuaAPI.lua_tostring(L, 1);
                    string[] _bundles = (string[])translator.GetObject(L, 2, typeof(string[]));
                    int _version = LuaAPI.xlua_tointeger(L, 3);
                    
                    libx.Versions.BuildVersions( 
                        _outputPath, 
                        _bundles, 
                        _version );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadVersion_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    
                        int gen_ret = libx.Versions.LoadVersion( 
                        _filename );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadVersions_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    bool _update = LuaAPI.lua_toboolean(L, 2);
                    
                        System.Collections.Generic.List<libx.VFile> gen_ret = libx.Versions.LoadVersions( 
                        _filename, 
                        _update );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    
                        System.Collections.Generic.List<libx.VFile> gen_ret = libx.Versions.LoadVersions( 
                        _filename );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to libx.Versions.LoadVersions!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDisk_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _savePath = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<libx.VFile> _newFiles = (System.Collections.Generic.List<libx.VFile>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<libx.VFile>));
                    
                    libx.Versions.UpdateDisk( 
                        _savePath, 
                        _newFiles );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadDisk_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = libx.Versions.LoadDisk( 
                        _filename );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsNew_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    long _len = LuaAPI.lua_toint64(L, 2);
                    string _hash = LuaAPI.lua_tostring(L, 3);
                    
                        bool gen_ret = libx.Versions.IsNew( 
                        _path, 
                        _len, 
                        _hash );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
