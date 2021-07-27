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
    public partial class BattlehubUIControlsMultiselectDropdownWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.MultiselectDropdown);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 5, 3);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectWithoutNotify", _m_SelectWithoutNotify);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getselectedIndexes", _g_get_selectedIndexes);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getdisplayText", _g_get_displayText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getoptions", _g_get_options);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonSelected", _g_get_onSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonUnselected", _g_get_onUnselected);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setoptions", _s_set_options);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setonSelected", _s_set_onSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setonUnselected", _s_set_onUnselected);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectedIndexes", _g_get_selectedIndexes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "displayText", _g_get_displayText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "options", _g_get_options);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onSelected", _g_get_onSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onUnselected", _g_get_onUnselected);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "options", _s_set_options);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onSelected", _s_set_onSelected);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onUnselected", _s_set_onUnselected);
            
			
			
			
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
					
					Battlehub.UIControls.MultiselectDropdown gen_ret = new Battlehub.UIControls.MultiselectDropdown();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.MultiselectDropdown constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectWithoutNotify(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int[] _selectedIndexes = (int[])translator.GetObject(L, 2, typeof(int[]));
                    
                    gen_to_be_invoked.SelectWithoutNotify( 
                        _selectedIndexes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectedIndexes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectedIndexes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_displayText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.displayText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_options(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.options);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onUnselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onUnselected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_options(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.options = (System.Collections.Generic.List<Battlehub.UIControls.MultiselectDropdown.OptionData>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<Battlehub.UIControls.MultiselectDropdown.OptionData>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onSelected = (TMPro.TMP_Dropdown.DropdownEvent)translator.GetObject(L, 2, typeof(TMPro.TMP_Dropdown.DropdownEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onUnselected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.MultiselectDropdown gen_to_be_invoked = (Battlehub.UIControls.MultiselectDropdown)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onUnselected = (TMPro.TMP_Dropdown.DropdownEvent)translator.GetObject(L, 2, typeof(TMPro.TMP_Dropdown.DropdownEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
