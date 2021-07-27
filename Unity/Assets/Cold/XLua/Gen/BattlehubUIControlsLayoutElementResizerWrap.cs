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
    public partial class BattlehubUIControlsLayoutElementResizerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.LayoutElementResizer);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 8, 8);
			
            			
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getTarget", _g_get_Target);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getSecondaryTarget", _g_get_SecondaryTarget);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCursorTexture", _g_get_CursorTexture);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getXSign", _g_get_XSign);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getYSign", _g_get_YSign);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getMaxSize", _g_get_MaxSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHasMaxSize", _g_get_HasMaxSize);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setTarget", _s_set_Target);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setParent", _s_set_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setSecondaryTarget", _s_set_SecondaryTarget);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCursorTexture", _s_set_CursorTexture);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setXSign", _s_set_XSign);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setYSign", _s_set_YSign);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setMaxSize", _s_set_MaxSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setHasMaxSize", _s_set_HasMaxSize);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Target", _g_get_Target);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Parent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SecondaryTarget", _g_get_SecondaryTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CursorTexture", _g_get_CursorTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "XSign", _g_get_XSign);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "YSign", _g_get_YSign);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxSize", _g_get_MaxSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasMaxSize", _g_get_HasMaxSize);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Target", _s_set_Target);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Parent", _s_set_Parent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SecondaryTarget", _s_set_SecondaryTarget);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CursorTexture", _s_set_CursorTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "XSign", _s_set_XSign);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "YSign", _s_set_YSign);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MaxSize", _s_set_MaxSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HasMaxSize", _s_set_HasMaxSize);
            
			
			
			
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
					
					Battlehub.UIControls.LayoutElementResizer gen_ret = new Battlehub.UIControls.LayoutElementResizer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.LayoutElementResizer constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Target(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Target);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Parent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SecondaryTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SecondaryTarget);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CursorTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CursorTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_XSign(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.XSign);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_YSign(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.YSign);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.MaxSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasMaxSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasMaxSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Target(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Target = (UnityEngine.UI.LayoutElement)translator.GetObject(L, 2, typeof(UnityEngine.UI.LayoutElement));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Parent = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SecondaryTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SecondaryTarget = (UnityEngine.UI.LayoutElement)translator.GetObject(L, 2, typeof(UnityEngine.UI.LayoutElement));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CursorTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CursorTexture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_XSign(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.XSign = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_YSign(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.YSign = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MaxSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HasMaxSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.LayoutElementResizer gen_to_be_invoked = (Battlehub.UIControls.LayoutElementResizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HasMaxSize = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
