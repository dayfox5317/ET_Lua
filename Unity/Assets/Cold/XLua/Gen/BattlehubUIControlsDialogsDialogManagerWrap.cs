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
    public partial class BattlehubUIControlsDialogsDialogManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.Dialogs.DialogManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 1, 0);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CloseDialog", _m_CloseDialog);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowDialog", _m_ShowDialog);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsDialogOpened", _g_get_IsDialogOpened);
            
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addDialogDestroyed", _e_add_DialogDestroyed);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeDialogDestroyed", _e_remove_DialogDestroyed);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DialogDestroyed", _e_DialogDestroyed);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDialogOpened", _g_get_IsDialogOpened);
            
			
			
			
			
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
					
					Battlehub.UIControls.Dialogs.DialogManager gen_ret = new Battlehub.UIControls.Dialogs.DialogManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.DialogManager constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseDialog(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Dialogs.DialogManager gen_to_be_invoked = (Battlehub.UIControls.Dialogs.DialogManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CloseDialog(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowDialog(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.Dialogs.DialogManager gen_to_be_invoked = (Battlehub.UIControls.Dialogs.DialogManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 13&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 13)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    float _preferredWidth = (float)LuaAPI.lua_tonumber(L, 11);
                    float _preferredHeight = (float)LuaAPI.lua_tonumber(L, 12);
                    bool _canResize = LuaAPI.lua_toboolean(L, 13);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight, 
                        _preferredWidth, 
                        _preferredHeight, 
                        _canResize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    float _preferredWidth = (float)LuaAPI.lua_tonumber(L, 11);
                    float _preferredHeight = (float)LuaAPI.lua_tonumber(L, 12);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight, 
                        _preferredWidth, 
                        _preferredHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    float _preferredWidth = (float)LuaAPI.lua_tonumber(L, 11);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight, 
                        _preferredWidth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 13&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 13)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    float _preferredWidth = (float)LuaAPI.lua_tonumber(L, 11);
                    float _preferredHeight = (float)LuaAPI.lua_tonumber(L, 12);
                    bool _canResize = LuaAPI.lua_toboolean(L, 13);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight, 
                        _preferredWidth, 
                        _preferredHeight, 
                        _canResize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    float _preferredWidth = (float)LuaAPI.lua_tonumber(L, 11);
                    float _preferredHeight = (float)LuaAPI.lua_tonumber(L, 12);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight, 
                        _preferredWidth, 
                        _preferredHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    float _preferredWidth = (float)LuaAPI.lua_tonumber(L, 11);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight, 
                        _preferredWidth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _minHeight = (float)LuaAPI.lua_tonumber(L, 10);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth, 
                        _minHeight );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    float _minWidth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText, 
                        _minWidth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)&& (LuaAPI.lua_isnil(L, 8) || LuaAPI.lua_type(L, 8) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    string _cancelText = LuaAPI.lua_tostring(L, 8);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction, 
                        _cancelText );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _cancelAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 7);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText, 
                        _cancelAction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    string _okText = LuaAPI.lua_tostring(L, 6);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction, 
                        _okText );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs> _okAction = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction<Battlehub.UIControls.Dialogs.DialogCancelArgs>>(L, 5);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content, 
                        _okAction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    string _header = LuaAPI.lua_tostring(L, 3);
                    string _content = LuaAPI.lua_tostring(L, 4);
                    
                        Battlehub.UIControls.Dialogs.Dialog gen_ret = gen_to_be_invoked.ShowDialog( 
                        _icon, 
                        _header, 
                        _content );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.DialogManager.ShowDialog!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDialogOpened(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.Dialogs.DialogManager gen_to_be_invoked = (Battlehub.UIControls.Dialogs.DialogManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDialogOpened);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_DialogDestroyed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.DialogManager gen_to_be_invoked = (Battlehub.UIControls.Dialogs.DialogManager)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.Dialogs.DialogAction gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.Dialogs.DialogAction!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.DialogDestroyed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.DialogDestroyed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.DialogManager.DialogDestroyed!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_DialogDestroyed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.DialogManager gen_to_be_invoked = (Battlehub.UIControls.Dialogs.DialogManager)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.DialogDestroyed += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.DialogManager.DialogDestroyed!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_DialogDestroyed(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.Dialogs.DialogManager gen_to_be_invoked = (Battlehub.UIControls.Dialogs.DialogManager)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.Dialogs.DialogAction gen_delegate = translator.GetDelegate<Battlehub.UIControls.Dialogs.DialogAction>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.Dialogs.DialogAction!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.DialogDestroyed -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.Dialogs.DialogManager.DialogDestroyed!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
