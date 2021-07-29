﻿#if USE_UNI_LUA
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
    public partial class FairyGUIGComboBoxWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.GComboBox);
			Utils.BeginObjectRegister(type, L, translator, 0, 42, 20, 16);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyListChange", _m_ApplyListChange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTextField", _m_GetTextField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HandleControllerChanged", _m_HandleControllerChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setup_AfterAdd", _m_Setup_AfterAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDropdownList", _m_UpdateDropdownList);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonChanged", _g_get_onChanged);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geticon", _g_get_icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettitle", _g_get_title);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettext", _g_get_text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettitleColor", _g_get_titleColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettitleFontSize", _g_get_titleFontSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getitems", _g_get_items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geticons", _g_get_icons);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getvalues", _g_get_values);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getitemList", _g_get_itemList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getvalueList", _g_get_valueList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geticonList", _g_get_iconList);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getselectedIndex", _g_get_selectedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getselectionController", _g_get_selectionController);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getvalue", _g_get_value);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpopupDirection", _g_get_popupDirection);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getvisibleItemCount", _g_get_visibleItemCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getdropdown", _g_get_dropdown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getsound", _g_get_sound);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getsoundVolumeScale", _g_get_soundVolumeScale);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "seticon", _s_set_icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settitle", _s_set_title);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settext", _s_set_text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settitleColor", _s_set_titleColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settitleFontSize", _s_set_titleFontSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setitems", _s_set_items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "seticons", _s_set_icons);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setvalues", _s_set_values);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setselectedIndex", _s_set_selectedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setselectionController", _s_set_selectionController);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setvalue", _s_set_value);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setpopupDirection", _s_set_popupDirection);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setvisibleItemCount", _s_set_visibleItemCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setdropdown", _s_set_dropdown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setsound", _s_set_sound);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setsoundVolumeScale", _s_set_soundVolumeScale);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onChanged", _g_get_onChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "icon", _g_get_icon);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "title", _g_get_title);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "titleColor", _g_get_titleColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "titleFontSize", _g_get_titleFontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "items", _g_get_items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "icons", _g_get_icons);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "values", _g_get_values);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "itemList", _g_get_itemList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "valueList", _g_get_valueList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "iconList", _g_get_iconList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectedIndex", _g_get_selectedIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionController", _g_get_selectionController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", _g_get_value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "popupDirection", _g_get_popupDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "visibleItemCount", _g_get_visibleItemCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dropdown", _g_get_dropdown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sound", _g_get_sound);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "soundVolumeScale", _g_get_soundVolumeScale);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "icon", _s_set_icon);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "title", _s_set_title);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", _s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "titleColor", _s_set_titleColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "titleFontSize", _s_set_titleFontSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "items", _s_set_items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "icons", _s_set_icons);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "values", _s_set_values);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectedIndex", _s_set_selectedIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectionController", _s_set_selectionController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", _s_set_value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "popupDirection", _s_set_popupDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "visibleItemCount", _s_set_visibleItemCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dropdown", _s_set_dropdown);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sound", _s_set_sound);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "soundVolumeScale", _s_set_soundVolumeScale);
            
			
			
			
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
					
					FairyGUI.GComboBox gen_ret = new FairyGUI.GComboBox();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GComboBox constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyListChange(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ApplyListChange(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTextField(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        FairyGUI.GTextField gen_ret = gen_to_be_invoked.GetTextField(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HandleControllerChanged(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Controller _c = (FairyGUI.Controller)translator.GetObject(L, 2, typeof(FairyGUI.Controller));
                    
                    gen_to_be_invoked.HandleControllerChanged( 
                        _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Setup_AfterAdd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Utils.ByteBuffer _buffer = (FairyGUI.Utils.ByteBuffer)translator.GetObject(L, 2, typeof(FairyGUI.Utils.ByteBuffer));
                    int _beginPos = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Setup_AfterAdd( 
                        _buffer, 
                        _beginPos );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDropdownList(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpdateDropdownList(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onChanged);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.icon);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_title(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.title);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_titleColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.titleColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_titleFontSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.titleFontSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.items);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_icons(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.icons);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_values(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.values);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_itemList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.itemList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_valueList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.valueList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_iconList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.iconList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.selectedIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectionController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectionController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.value);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_popupDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.PushFairyGUIPopupDirection(L, gen_to_be_invoked.popupDirection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_visibleItemCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.visibleItemCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dropdown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.dropdown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sound);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_soundVolumeScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.soundVolumeScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.icon = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_title(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.title = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_titleColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.titleColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_titleFontSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.titleFontSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.items = (string[])translator.GetObject(L, 2, typeof(string[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_icons(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.icons = (string[])translator.GetObject(L, 2, typeof(string[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_values(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.values = (string[])translator.GetObject(L, 2, typeof(string[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectedIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectionController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectionController = (FairyGUI.Controller)translator.GetObject(L, 2, typeof(FairyGUI.Controller));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.value = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_popupDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                FairyGUI.PopupDirection gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.popupDirection = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_visibleItemCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.visibleItemCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dropdown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.dropdown = (FairyGUI.GComponent)translator.GetObject(L, 2, typeof(FairyGUI.GComponent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sound = (FairyGUI.NAudioClip)translator.GetObject(L, 2, typeof(FairyGUI.NAudioClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_soundVolumeScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GComboBox gen_to_be_invoked = (FairyGUI.GComboBox)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.soundVolumeScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
