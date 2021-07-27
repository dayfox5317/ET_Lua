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
    public partial class BattlehubUIControlsDockPanelsITabDelegateWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.ITabDelegate);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnTabAttemptClose", _m_OnTabAttemptClose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnTabClosing", _m_OnTabClosing);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnTabVisible", _m_OnTabVisible);
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Battlehub.UIControls.DockPanels.ITabDelegate does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnTabAttemptClose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.ITabDelegate gen_to_be_invoked = (Battlehub.UIControls.DockPanels.ITabDelegate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    
                    gen_to_be_invoked.OnTabAttemptClose( 
                        _tab );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnTabClosing(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.ITabDelegate gen_to_be_invoked = (Battlehub.UIControls.DockPanels.ITabDelegate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    
                    gen_to_be_invoked.OnTabClosing( 
                        _tab );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnTabVisible(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.DockPanels.ITabDelegate gen_to_be_invoked = (Battlehub.UIControls.DockPanels.ITabDelegate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
                    bool _isVisible = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.OnTabVisible( 
                        _tab, 
                        _isVisible );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
