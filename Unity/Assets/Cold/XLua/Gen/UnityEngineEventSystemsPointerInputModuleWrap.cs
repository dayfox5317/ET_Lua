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
    public partial class UnityEngineEventSystemsPointerInputModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.PointerInputModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsPointerOverGameObject", _m_IsPointerOverGameObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 0, 0);
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getkMouseLeftId", UnityEngine.EventSystems.PointerInputModule.kMouseLeftId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getkMouseRightId", UnityEngine.EventSystems.PointerInputModule.kMouseRightId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getkMouseMiddleId", UnityEngine.EventSystems.PointerInputModule.kMouseMiddleId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "getkFakeTouchesId", UnityEngine.EventSystems.PointerInputModule.kFakeTouchesId);
            
			
			
			
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kMouseLeftId", UnityEngine.EventSystems.PointerInputModule.kMouseLeftId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kMouseRightId", UnityEngine.EventSystems.PointerInputModule.kMouseRightId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kMouseMiddleId", UnityEngine.EventSystems.PointerInputModule.kMouseMiddleId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kFakeTouchesId", UnityEngine.EventSystems.PointerInputModule.kFakeTouchesId);
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.EventSystems.PointerInputModule does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPointerOverGameObject(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.PointerInputModule gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _pointerId = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsPointerOverGameObject( 
                        _pointerId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.PointerInputModule gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
