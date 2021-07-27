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
    public partial class BattlehubUIControlsDockPanelsLayoutInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.DockPanels.LayoutInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 28, 14, 14);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanClose", _g_get_CanClose);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTab", _g_get_Tab);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getContent", _g_get_Content);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsVertical", _g_get_IsVertical);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChild0", _g_get_Child0);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getChild1", _g_get_Child1);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRatio", _g_get_Ratio);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsHeaderVisible", _g_get_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTabGroup", _g_get_TabGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHeader", _g_get_Header);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIcon", _g_get_Icon);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanClose", _s_set_CanClose);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTab", _s_set_Tab);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setContent", _s_set_Content);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsVertical", _s_set_IsVertical);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChild0", _s_set_Child0);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setChild1", _s_set_Child1);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRatio", _s_set_Ratio);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsHeaderVisible", _s_set_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTabGroup", _s_set_TabGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setHeader", _s_set_Header);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIcon", _s_set_Icon);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanDrag", _g_get_CanDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanClose", _g_get_CanClose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanMaximize", _g_get_CanMaximize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsOn", _g_get_IsOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Tab", _g_get_Tab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Content", _g_get_Content);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVertical", _g_get_IsVertical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Child0", _g_get_Child0);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Child1", _g_get_Child1);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Ratio", _g_get_Ratio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsHeaderVisible", _g_get_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TabGroup", _g_get_TabGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Header", _g_get_Header);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Icon", _g_get_Icon);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanDrag", _s_set_CanDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanClose", _s_set_CanClose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanMaximize", _s_set_CanMaximize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsOn", _s_set_IsOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Tab", _s_set_Tab);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Content", _s_set_Content);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsVertical", _s_set_IsVertical);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Child0", _s_set_Child0);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Child1", _s_set_Child1);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Ratio", _s_set_Ratio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsHeaderVisible", _s_set_IsHeaderVisible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "TabGroup", _s_set_TabGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Header", _s_set_Header);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Icon", _s_set_Icon);
            
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<UnityEngine.Transform>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.Sprite>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					string _header = LuaAPI.lua_tostring(L, 3);
					UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 4, typeof(UnityEngine.Sprite));
					bool _canDrag = LuaAPI.lua_toboolean(L, 5);
					bool _canClose = LuaAPI.lua_toboolean(L, 6);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _header, _icon, _canDrag, _canClose);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.Transform>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.Sprite>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					string _header = LuaAPI.lua_tostring(L, 3);
					UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 4, typeof(UnityEngine.Sprite));
					bool _canDrag = LuaAPI.lua_toboolean(L, 5);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _header, _icon, _canDrag);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Transform>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.Sprite>(L, 4))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					string _header = LuaAPI.lua_tostring(L, 3);
					UnityEngine.Sprite _icon = (UnityEngine.Sprite)translator.GetObject(L, 4, typeof(UnityEngine.Sprite));
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _header, _icon);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Transform>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					string _header = LuaAPI.lua_tostring(L, 3);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _header);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Transform>(L, 2))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<UnityEngine.Transform>(L, 2) && translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 3, typeof(Battlehub.UIControls.DockPanels.Tab));
					bool _canDrag = LuaAPI.lua_toboolean(L, 4);
					bool _canClose = LuaAPI.lua_toboolean(L, 5);
					bool _canMaximize = LuaAPI.lua_toboolean(L, 6);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _tab, _canDrag, _canClose, _canMaximize);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.Transform>(L, 2) && translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 3, typeof(Battlehub.UIControls.DockPanels.Tab));
					bool _canDrag = LuaAPI.lua_toboolean(L, 4);
					bool _canClose = LuaAPI.lua_toboolean(L, 5);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _tab, _canDrag, _canClose);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Transform>(L, 2) && translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 3, typeof(Battlehub.UIControls.DockPanels.Tab));
					bool _canDrag = LuaAPI.lua_toboolean(L, 4);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _tab, _canDrag);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Transform>(L, 2) && translator.Assignable<Battlehub.UIControls.DockPanels.Tab>(L, 3))
				{
					UnityEngine.Transform _content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
					Battlehub.UIControls.DockPanels.Tab _tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 3, typeof(Battlehub.UIControls.DockPanels.Tab));
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_content, _tab);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2) && translator.Assignable<Battlehub.UIControls.DockPanels.LayoutInfo>(L, 3) && translator.Assignable<Battlehub.UIControls.DockPanels.LayoutInfo>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					bool _isVertical = LuaAPI.lua_toboolean(L, 2);
					Battlehub.UIControls.DockPanels.LayoutInfo _child0 = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 3, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
					Battlehub.UIControls.DockPanels.LayoutInfo _child1 = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 4, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
					float _ratio = (float)LuaAPI.lua_tonumber(L, 5);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_isVertical, _child0, _child1, _ratio);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2) && translator.Assignable<Battlehub.UIControls.DockPanels.LayoutInfo>(L, 3) && translator.Assignable<Battlehub.UIControls.DockPanels.LayoutInfo>(L, 4))
				{
					bool _isVertical = LuaAPI.lua_toboolean(L, 2);
					Battlehub.UIControls.DockPanels.LayoutInfo _child0 = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 3, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
					Battlehub.UIControls.DockPanels.LayoutInfo _child1 = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 4, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_isVertical, _child0, _child1);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 1 && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<Battlehub.UIControls.DockPanels.LayoutInfo>(L, 2)))
				{
					Battlehub.UIControls.DockPanels.LayoutInfo[] _tabGroup = translator.GetParams<Battlehub.UIControls.DockPanels.LayoutInfo>(L, 2);
					
					Battlehub.UIControls.DockPanels.LayoutInfo gen_ret = new Battlehub.UIControls.DockPanels.LayoutInfo(_tabGroup);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.DockPanels.LayoutInfo constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanClose(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanClose);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanMaximize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanMaximize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsOn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Tab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Tab);
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
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Content);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVertical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVertical);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Child0(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Child0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Child1(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Child1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ratio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Ratio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsHeaderVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsHeaderVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TabGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TabGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Header(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Header);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Icon);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanDrag = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanClose(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanClose = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanMaximize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanMaximize = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsOn = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Tab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Tab = (Battlehub.UIControls.DockPanels.Tab)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.Tab));
            
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
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Content = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsVertical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsVertical = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Child0(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Child0 = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Child1(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Child1 = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.LayoutInfo));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Ratio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Ratio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsHeaderVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsHeaderVisible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TabGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.TabGroup = (Battlehub.UIControls.DockPanels.LayoutInfo[])translator.GetObject(L, 2, typeof(Battlehub.UIControls.DockPanels.LayoutInfo[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Header(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Header = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Icon(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.DockPanels.LayoutInfo gen_to_be_invoked = (Battlehub.UIControls.DockPanels.LayoutInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Icon = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
