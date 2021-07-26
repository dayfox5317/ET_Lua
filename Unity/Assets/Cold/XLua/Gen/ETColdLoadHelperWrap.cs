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
    public partial class ETColdLoadHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.LoadHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PreGetLuaScripts", _m_PreGetLuaScripts_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadConfigs", _m_LoadConfigs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadTextAsset", _m_LoadTextAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAssetAtPath", _m_LoadAssetAtPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAssetPathsFromAssetBundleCount", _m_GetAssetPathsFromAssetBundleCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAssetPathsFromAssetBundle", _m_GetAssetPathsFromAssetBundle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAssetBundleDependenciesCount", _m_GetAssetBundleDependenciesCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAssetBundleDependencies", _m_GetAssetBundleDependencies_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetanimationClipsLength", _m_GetanimationClipsLength);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAnimatorControllerParameterLength", _m_GetAnimatorControllerParameterLength);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.LoadHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreGetLuaScripts_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        string[] gen_ret = ETCold.LoadHelper.PreGetLuaScripts(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadConfigs_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        UnityEngine.TextAsset[] gen_ret = ETCold.LoadHelper.LoadConfigs(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadTextAsset_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.TextAsset gen_ret = ETCold.LoadHelper.LoadTextAsset( 
                        _path );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAtPath_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetPath = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Object gen_ret = ETCold.LoadHelper.LoadAssetAtPath( 
                        _assetPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetPathsFromAssetBundleCount_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    
                        int gen_ret = ETCold.LoadHelper.GetAssetPathsFromAssetBundleCount( 
                        _assetBundleName );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetPathsFromAssetBundle_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    
                        string[] gen_ret = ETCold.LoadHelper.GetAssetPathsFromAssetBundle( 
                        _assetBundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleDependenciesCount_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    bool _recursive = LuaAPI.lua_toboolean(L, 2);
                    
                        int gen_ret = ETCold.LoadHelper.GetAssetBundleDependenciesCount( 
                        _assetBundleName, 
                        _recursive );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleDependencies_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    bool _recursive = LuaAPI.lua_toboolean(L, 2);
                    
                        string[] gen_ret = ETCold.LoadHelper.GetAssetBundleDependencies( 
                        _assetBundleName, 
                        _recursive );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetanimationClipsLength(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Animator _self = (UnityEngine.Animator)translator.GetObject(L, 1, typeof(UnityEngine.Animator));
                    
                        int gen_ret = ETCold.LoadHelper.GetanimationClipsLength( 
                        _self );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAnimatorControllerParameterLength(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Animator _self = (UnityEngine.Animator)translator.GetObject(L, 1, typeof(UnityEngine.Animator));
                    
                        int gen_ret = ETCold.LoadHelper.GetAnimatorControllerParameterLength( 
                        _self );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
