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
    public partial class BattlehubUIControlsVirtualizingTreeViewDropMarkerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.VirtualizingTreeViewDropMarker);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 2, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTarget", _m_SetTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPosition", _m_SetPosition);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAction", _g_get_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChildGraphics", _g_get_ChildGraphics);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAction", _s_set_Action);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChildGraphics", _s_set_ChildGraphics);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Action", _g_get_Action);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ChildGraphics", _g_get_ChildGraphics);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Action", _s_set_Action);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ChildGraphics", _s_set_ChildGraphics);
            
			
			
			
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
					
					Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_ret = new Battlehub.UIControls.VirtualizingTreeViewDropMarker();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingTreeViewDropMarker constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTarget(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingTreeViewDropMarker)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingTreeViewDropMarker)translator.FastGetCSObj(L, 1);
            
            
                
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
			
                Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingTreeViewDropMarker)translator.FastGetCSObj(L, 1);
                translator.PushBattlehubUIControlsItemDropAction(L, gen_to_be_invoked.Action);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ChildGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingTreeViewDropMarker)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ChildGraphics);
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
			
                Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingTreeViewDropMarker)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.ItemDropAction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Action = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ChildGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingTreeViewDropMarker gen_to_be_invoked = (Battlehub.UIControls.VirtualizingTreeViewDropMarker)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ChildGraphics = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
