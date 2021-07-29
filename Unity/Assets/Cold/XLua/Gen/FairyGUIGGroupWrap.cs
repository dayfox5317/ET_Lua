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
    public partial class FairyGUIGGroupWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.GGroup);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 7, 7);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBoundsChangedFlag", _m_SetBoundsChangedFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureBoundsCorrect", _m_EnsureBoundsCorrect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setup_BeforeAdd", _m_Setup_BeforeAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Setup_AfterAdd", _m_Setup_AfterAdd);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getlayout", _g_get_layout);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getlineGap", _g_get_lineGap);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcolumnGap", _g_get_columnGap);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getexcludeInvisibles", _g_get_excludeInvisibles);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getautoSizeDisabled", _g_get_autoSizeDisabled);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmainGridMinSize", _g_get_mainGridMinSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmainGridIndex", _g_get_mainGridIndex);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setlayout", _s_set_layout);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setlineGap", _s_set_lineGap);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcolumnGap", _s_set_columnGap);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setexcludeInvisibles", _s_set_excludeInvisibles);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setautoSizeDisabled", _s_set_autoSizeDisabled);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmainGridMinSize", _s_set_mainGridMinSize);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmainGridIndex", _s_set_mainGridIndex);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "layout", _g_get_layout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineGap", _g_get_lineGap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "columnGap", _g_get_columnGap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "excludeInvisibles", _g_get_excludeInvisibles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoSizeDisabled", _g_get_autoSizeDisabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainGridMinSize", _g_get_mainGridMinSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainGridIndex", _g_get_mainGridIndex);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "layout", _s_set_layout);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineGap", _s_set_lineGap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "columnGap", _s_set_columnGap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "excludeInvisibles", _s_set_excludeInvisibles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoSizeDisabled", _s_set_autoSizeDisabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mainGridMinSize", _s_set_mainGridMinSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mainGridIndex", _s_set_mainGridIndex);
            
			
			
			
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
					
					FairyGUI.GGroup gen_ret = new FairyGUI.GGroup();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GGroup constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBoundsChangedFlag(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _positionChangedOnly = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetBoundsChangedFlag( 
                        _positionChangedOnly );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.SetBoundsChangedFlag(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.GGroup.SetBoundsChangedFlag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureBoundsCorrect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.EnsureBoundsCorrect(  );
                    
                    
                    
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
            
            
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_Setup_AfterAdd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_layout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                translator.PushFairyGUIGroupLayoutType(L, gen_to_be_invoked.layout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lineGap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_columnGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.columnGap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_excludeInvisibles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.excludeInvisibles);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoSizeDisabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoSizeDisabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainGridMinSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.mainGridMinSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainGridIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.mainGridIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                FairyGUI.GroupLayoutType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.layout = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineGap = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_columnGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.columnGap = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_excludeInvisibles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.excludeInvisibles = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoSizeDisabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoSizeDisabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mainGridMinSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mainGridMinSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mainGridIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.GGroup gen_to_be_invoked = (FairyGUI.GGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mainGridIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
