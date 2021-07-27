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
    public partial class BattlehubUIControlsDialogsDialogWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.Dialogs.Dialog);
			Utils.BeginObjectRegister(type, L, translator, 0, 36, 9, 15);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Hide", _m_Hide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Show", _m_Show);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParentRegion", _g_get_ParentRegion);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHeaderRoot", _g_get_HeaderRoot);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getContent", _g_get_Content);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsInteractable", _g_get_IsInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOkInteractable", _g_get_IsOkInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsCancelInteractable", _g_get_IsCancelInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsCloseButtonInteractable", _g_get_IsCloseButtonInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getOkAction", _g_get_OkAction);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCancelAction", _g_get_CancelAction);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIcon", _s_set_Icon);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setHeaderText", _s_set_HeaderText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setContentText", _s_set_ContentText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setContent", _s_set_Content);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setOkText", _s_set_OkText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCancelText", _s_set_CancelText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsInteractable", _s_set_IsInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOkInteractable", _s_set_IsOkInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOkVisible", _s_set_IsOkVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsCancelInteractable", _s_set_IsCancelInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsCancelVisible", _s_set_IsCancelVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsCloseButtonInteractable", _s_set_IsCloseButtonInteractable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsCloseButtonVisible", _s_set_IsCloseButtonVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setOkAction", _s_set_OkAction);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCancelAction", _s_set_CancelAction);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addOk", _e_add_Ok);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addCancel", _e_add_Cancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addClosed", _e_add_Closed);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeOk", _e_remove_Ok);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeCancel", _e_remove_Cancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeClosed", _e_remove_Closed);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Ok", _e_Ok);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cancel", _e_Cancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Closed", _e_Closed);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ParentRegion", _g_get_ParentRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HeaderRoot", _g_get_HeaderRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Content", _g_get_Content);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsInteractable", _g_get_IsInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOkInteractable", _g_get_IsOkInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsCancelInteractable", _g_get_IsCancelInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsCloseButtonInteractable", _g_get_IsCloseButtonInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OkAction", _g_get_OkAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CancelAction", _g_get_CancelAction);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Icon", _s_set_Icon);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HeaderText", _s_set_HeaderText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ContentText", _s_set_ContentText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Content", _s_set_Content);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OkText", _s_set_OkText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CancelText", _s_set_CancelText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsInteractable", _s_set_IsInteractable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOkInteractable", _s_set_IsOkInteractable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOkVisible", _s_set_IsOkVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsCancelInteractable", _s_set_IsCancelInteractable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsCancelVisible", _s_set_IsCancelVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsCloseButtonInteractable", _s_set_IsCloseButtonInteractable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsCloseButtonVisible", _s_set_IsCloseButtonVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OkAction", _s_set_OkAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CancelAction", _s_set_CancelAction);
            
			
			
			
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
					
					Battlehub.UIControls.Dialogs.Dialog gen_ret = new Battlehub.UIControls.Dialogs.Dialog();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Hide(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Hide(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Show(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Show(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<System.Nullable<bool>>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    System.Nullable<bool> _result;translator.Get(L, 2, out _result);
                    bool _raiseEvents = LuaAPI.lua_toboolean(L, 3);
                    bool _invokeActions = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.Close( 
                        _result, 
                        _raiseEvents, 
                        _invokeActions );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Nullable<bool>>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Nullable<bool> _result;translator.Get(L, 2, out _result);
                    bool _raiseEvents = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Close( 
                        _result, 
                        _raiseEvents );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Nullable<bool>>(L, 2)) 
                {
                    System.Nullable<bool> _result;translator.Get(L, 2, out _result);
                    
                    gen_to_be_invoked.Close( 
                        _result );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Close!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ParentRegion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ParentRegion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HeaderRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.HeaderRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Content(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Content);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsOkInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOkInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsCancelInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsCancelInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsCloseButtonInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsCloseButtonInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OkAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OkAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CancelAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CancelAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HeaderText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HeaderText = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ContentText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ContentText = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Content(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OkText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OkText = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CancelText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CancelText = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsInteractable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsOkInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOkInteractable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsOkVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOkVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsCancelInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsCancelInteractable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsCancelVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsCancelVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsCloseButtonInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsCloseButtonInteractable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsCloseButtonVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsCloseButtonVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OkAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OkAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CancelAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Ok(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Ok += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Ok -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Ok!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Cancel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Cancel += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Cancel -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Cancel!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Closed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Closed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Closed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Closed!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Ok(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Ok += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Ok!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Cancel(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Cancel += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Cancel!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_Closed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Closed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Closed!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Ok(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Ok -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Ok!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Cancel(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Cancel -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Cancel!");
			return 0;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_Closed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.Dialog gen_to_be_invoked = (Battlehub.UIControls.Dialogs.Dialog)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>> gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction<System.Nullable<bool>>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.Closed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.Dialog.Closed!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
