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
    public partial class FairyGUIITweenListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.ITweenListener);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnTweenStart", _m_OnTweenStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnTweenUpdate", _m_OnTweenUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnTweenComplete", _m_OnTweenComplete);
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "FairyGUI.ITweenListener does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnTweenStart(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ITweenListener gen_to_be_invoked = (FairyGUI.ITweenListener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.GTweener _tweener = (FairyGUI.GTweener)translator.GetObject(L, 2, typeof(FairyGUI.GTweener));
                    
                    gen_to_be_invoked.OnTweenStart( 
                        _tweener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnTweenUpdate(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ITweenListener gen_to_be_invoked = (FairyGUI.ITweenListener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.GTweener _tweener = (FairyGUI.GTweener)translator.GetObject(L, 2, typeof(FairyGUI.GTweener));
                    
                    gen_to_be_invoked.OnTweenUpdate( 
                        _tweener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnTweenComplete(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.ITweenListener gen_to_be_invoked = (FairyGUI.ITweenListener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.GTweener _tweener = (FairyGUI.GTweener)translator.GetObject(L, 2, typeof(FairyGUI.GTweener));
                    
                    gen_to_be_invoked.OnTweenComplete( 
                        _tweener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
