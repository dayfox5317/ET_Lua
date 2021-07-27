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
    public partial class BattlehubUIControlsVirtualizingItemDropMarkerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.VirtualizingItemDropMarker);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 3, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTarget", _m_SetTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPosition", _m_SetPosition);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAction", _g_get_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRectTransform", _g_get_RectTransform);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSiblingGraphics", _g_get_SiblingGraphics);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAction", _s_set_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSiblingGraphics", _s_set_SiblingGraphics);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Action", _g_get_Action);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RectTransform", _g_get_RectTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SiblingGraphics", _g_get_SiblingGraphics);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Action", _s_set_Action);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SiblingGraphics", _s_set_SiblingGraphics);
            
			
			
			
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
					
					Battlehub.UIControls.VirtualizingItemDropMarker gen_ret = new Battlehub.UIControls.VirtualizingItemDropMarker();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingItemDropMarker constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTarget(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingItemContainer _item = (Battlehub.UIControls.VirtualizingItemContainer)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingItemContainer));
                    
                    gen_to_be_invoked.SetTarget( 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPosition(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _position;translator.Get(L, 2, out _position);
                    
                    gen_to_be_invoked.SetPosition( 
                        _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Action(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
                translator.PushBattlehubUIControlsItemDropAction(L, gen_to_be_invoked.Action);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RectTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RectTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SiblingGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SiblingGraphics);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Action(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.ItemDropAction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Action = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SiblingGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingItemDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingItemDropMarker)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SiblingGraphics = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
