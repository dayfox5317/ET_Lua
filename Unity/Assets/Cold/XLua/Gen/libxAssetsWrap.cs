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
    public partial class libxAssetsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(libx.Assets);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 35, 5, 5);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllAssetPaths", _m_GetAllAssetPaths_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddSearchPath", _m_AddSearchPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Initialize", _m_Initialize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clear", _m_Clear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadSceneAsync", _m_LoadSceneAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnloadScene", _m_UnloadScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAssetAsync", _m_LoadAssetAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAsset", _m_LoadAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnloadAsset", _m_UnloadAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveUnusedAssets", _m_RemoveUnusedAssets_xlua_st_);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getManifestAsset", libx.Assets.ManifestAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getExtension", libx.Assets.Extension);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getbasePath", _g_get_basePath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getupdatePath", _g_get_updatePath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getruntimeMode", _g_get_runtimeMode);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getloadDelegate", _g_get_loadDelegate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "get_searchPaths", _g_get__searchPaths);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setbasePath", _s_set_basePath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setupdatePath", _s_set_updatePath);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setruntimeMode", _s_set_runtimeMode);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setloadDelegate", _s_set_loadDelegate);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "set_searchPaths", _s_set__searchPaths);
            
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ManifestAsset", libx.Assets.ManifestAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Extension", libx.Assets.Extension);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "basePath", _g_get_basePath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "updatePath", _g_get_updatePath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "runtimeMode", _g_get_runtimeMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "loadDelegate", _g_get_loadDelegate);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "_searchPaths", _g_get__searchPaths);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "basePath", _s_set_basePath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "updatePath", _s_set_updatePath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "runtimeMode", _s_set_runtimeMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "loadDelegate", _s_set_loadDelegate);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "_searchPaths", _s_set__searchPaths);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					libx.Assets gen_ret = new libx.Assets();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to libx.Assets constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetPaths_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        string[] gen_ret = libx.Assets.GetAllAssetPaths(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSearchPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                    libx.Assets.AddSearchPath( 
                        _path );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialize_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        libx.ManifestRequest gen_ret = libx.Assets.Initialize(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    
                    libx.Assets.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadSceneAsync_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    bool _additive = LuaAPI.lua_toboolean(L, 2);
                    
                        libx.SceneAssetRequest gen_ret = libx.Assets.LoadSceneAsync( 
                        _path, 
                        _additive );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadScene_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    libx.SceneAssetRequest _scene = (libx.SceneAssetRequest)translator.GetObject(L, 1, typeof(libx.SceneAssetRequest));
                    
                    libx.Assets.UnloadScene( 
                        _scene );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAsync_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        libx.AssetRequest gen_ret = libx.Assets.LoadAssetAsync( 
                        _path, 
                        _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        libx.AssetRequest gen_ret = libx.Assets.LoadAsset( 
                        _path, 
                        _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadAsset_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    libx.AssetRequest _asset = (libx.AssetRequest)translator.GetObject(L, 1, typeof(libx.AssetRequest));
                    
                    libx.Assets.UnloadAsset( 
                        _asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveUnusedAssets_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    
                    libx.Assets.RemoveUnusedAssets(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_basePath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, libx.Assets.basePath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updatePath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, libx.Assets.updatePath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_runtimeMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, libx.Assets.runtimeMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadDelegate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, libx.Assets.loadDelegate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__searchPaths(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, libx.Assets._searchPaths);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_basePath(RealStatePtr L)
        {
		    try {
                
			    libx.Assets.basePath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updatePath(RealStatePtr L)
        {
		    try {
                
			    libx.Assets.updatePath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_runtimeMode(RealStatePtr L)
        {
		    try {
                
			    libx.Assets.runtimeMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_loadDelegate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    libx.Assets.loadDelegate = translator.GetDelegate<System.Func<string, System.Type, UnityEngine.Object>>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__searchPaths(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    libx.Assets._searchPaths = (System.Collections.Generic.List<string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
