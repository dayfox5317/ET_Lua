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
    public partial class UnityEngineEventSystemsPhysicsRaycasterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.EventSystems.PhysicsRaycaster);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 5, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geteventCamera", _g_get_eventCamera);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getdepth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getfinalEventMask", _g_get_finalEventMask);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geteventMask", _g_get_eventMask);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmaxRayIntersections", _g_get_maxRayIntersections);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "seteventMask", _s_set_eventMask);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmaxRayIntersections", _s_set_maxRayIntersections);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventCamera", _g_get_eventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalEventMask", _g_get_finalEventMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventMask", _g_get_eventMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxRayIntersections", _g_get_maxRayIntersections);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventMask", _s_set_eventMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxRayIntersections", _s_set_maxRayIntersections);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.EventSystems.PhysicsRaycaster does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> _resultAppendList = (System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>));
                    
                    gen_to_be_invoked.Raycast( 
                        _eventData, 
                        _resultAppendList );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.eventCamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalEventMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.finalEventMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.eventMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxRayIntersections(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maxRayIntersections);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.eventMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxRayIntersections(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.EventSystems.PhysicsRaycaster gen_to_be_invoked = (UnityEngine.EventSystems.PhysicsRaycaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxRayIntersections = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
