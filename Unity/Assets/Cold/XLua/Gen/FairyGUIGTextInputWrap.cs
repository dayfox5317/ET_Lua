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
    public partial class FairyGUIGTextInputWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.GTextInput);
			Utils.BeginObjectRegister(type, L, translator, 0, 38, 19, 16);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSelection", _m_SetSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReplaceSelection", _m_ReplaceSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setup_BeforeAdd", _m_Setup_BeforeAdd);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getinputTextField", _g_get_inputTextField);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonChanged", _g_get_onChanged);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonSubmit", _g_get_onSubmit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geteditable", _g_get_editable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gethideInput", _g_get_hideInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmaxLength", _g_get_maxLength);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrestrict", _g_get_restrict);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getdisplayAsPassword", _g_get_displayAsPassword);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcaretPosition", _g_get_caretPosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpromptText", _g_get_promptText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getkeyboardInput", _g_get_keyboardInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getkeyboardType", _g_get_keyboardType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getdisableIME", _g_get_disableIME);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getemojies", _g_get_emojies);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getborder", _g_get_border);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcorner", _g_get_corner);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getborderColor", _g_get_borderColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getbackgroundColor", _g_get_backgroundColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmouseWheelEnabled", _g_get_mouseWheelEnabled);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "seteditable", _s_set_editable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "sethideInput", _s_set_hideInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmaxLength", _s_set_maxLength);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setrestrict", _s_set_restrict);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setdisplayAsPassword", _s_set_displayAsPassword);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcaretPosition", _s_set_caretPosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setpromptText", _s_set_promptText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setkeyboardInput", _s_set_keyboardInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setkeyboardType", _s_set_keyboardType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setdisableIME", _s_set_disableIME);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setemojies", _s_set_emojies);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setborder", _s_set_border);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcorner", _s_set_corner);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setborderColor", _s_set_borderColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setbackgroundColor", _s_set_backgroundColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmouseWheelEnabled", _s_set_mouseWheelEnabled);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputTextField", _g_get_inputTextField);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onChanged", _g_get_onChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onSubmit", _g_get_onSubmit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "editable", _g_get_editable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideInput", _g_get_hideInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxLength", _g_get_maxLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "restrict", _g_get_restrict);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "displayAsPassword", _g_get_displayAsPassword);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "caretPosition", _g_get_caretPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "promptText", _g_get_promptText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardInput", _g_get_keyboardInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardType", _g_get_keyboardType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disableIME", _g_get_disableIME);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "emojies", _g_get_emojies);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "border", _g_get_border);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "corner", _g_get_corner);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "borderColor", _g_get_borderColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "backgroundColor", _g_get_backgroundColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseWheelEnabled", _g_get_mouseWheelEnabled);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "editable", _s_set_editable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideInput", _s_set_hideInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxLength", _s_set_maxLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "restrict", _s_set_restrict);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "displayAsPassword", _s_set_displayAsPassword);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "caretPosition", _s_set_caretPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "promptText", _s_set_promptText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardInput", _s_set_keyboardInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardType", _s_set_keyboardType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disableIME", _s_set_disableIME);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "emojies", _s_set_emojies);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "border", _s_set_border);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "corner", _s_set_corner);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "borderColor", _s_set_borderColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "backgroundColor", _s_set_backgroundColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseWheelEnabled", _s_set_mouseWheelEnabled);
            
			
			
			
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
					
					FairyGUI.GTextInput gen_ret = new FairyGUI.GTextInput();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GTextInput constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSelection(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _start = LuaAPI.xlua_tointeger(L, 2);
                    int _length = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetSelection( 
                        _start, 
                        _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReplaceSelection(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.ReplaceSelection( 
                        _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Setup_BeforeAdd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Utils.ByteBuffer _buffer = (FairyGUI.Utils.ByteBuffer)translator.GetObject(L, 2, typeof(FairyGUI.Utils.ByteBuffer));
                    int _beginPos = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Setup_BeforeAdd( 
                        _buffer, 
                        _beginPos );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputTextField(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputTextField);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onChanged);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onSubmit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onSubmit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_editable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.editable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hideInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maxLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_restrict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.restrict);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_displayAsPassword(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.displayAsPassword);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_caretPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.caretPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_promptText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.promptText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.keyboardInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.keyboardType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_disableIME(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.disableIME);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_emojies(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.emojies);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_border(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.border);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_corner(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.corner);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_borderColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.borderColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_backgroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.backgroundColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseWheelEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.mouseWheelEnabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_editable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.editable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hideInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hideInput = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxLength = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_restrict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.restrict = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_displayAsPassword(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.displayAsPassword = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_caretPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.caretPosition = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_promptText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.promptText = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardInput = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardType = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_disableIME(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.disableIME = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_emojies(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.emojies = (System.Collections.Generic.Dictionary<uint, FairyGUI.Emoji>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<uint, FairyGUI.Emoji>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_border(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.border = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_corner(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.corner = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_borderColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.borderColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_backgroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.backgroundColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseWheelEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GTextInput gen_to_be_invoked = (FairyGUI.GTextInput)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseWheelEnabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
