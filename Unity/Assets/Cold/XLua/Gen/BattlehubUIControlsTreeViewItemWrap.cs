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
    public partial class BattlehubUIControlsTreeViewItemWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.TreeViewItem);
			Utils.BeginObjectRegister(type, L, translator, 0, 17, 6, 4);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateIndent", _m_UpdateIndent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsDescendantOf", _m_IsDescendantOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FirstChild", _m_FirstChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NextChild", _m_NextChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastChild", _m_LastChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastDescendant", _m_LastDescendant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIndent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanExpand", _g_get_CanExpand);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsExpanded", _g_get_IsExpanded);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHasChildren", _g_get_HasChildren);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setParent", _s_set_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsSelected", _s_set_IsSelected);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanExpand", _s_set_CanExpand);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsExpanded", _s_set_IsExpanded);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Indent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Parent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSelected", _g_get_IsSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanExpand", _g_get_CanExpand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsExpanded", _g_get_IsExpanded);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasChildren", _g_get_HasChildren);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Parent", _s_set_Parent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsSelected", _s_set_IsSelected);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanExpand", _s_set_CanExpand);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsExpanded", _s_set_IsExpanded);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			
            
			
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addParentChanged", _e_add_ParentChanged);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeParentChanged", _e_remove_ParentChanged);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ParentChanged", _e_ParentChanged);
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Battlehub.UIControls.TreeViewItem gen_ret = new Battlehub.UIControls.TreeViewItem();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItem constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateIndent(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpdateIndent(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsDescendantOf(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.TreeViewItem _ancestor = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItem));
                    
                        bool gen_ret = gen_to_be_invoked.IsDescendantOf( 
                        _ancestor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FirstChild(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        Battlehub.UIControls.TreeViewItem gen_ret = gen_to_be_invoked.FirstChild(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NextChild(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.TreeViewItem _currentChild = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItem));
                    
                        Battlehub.UIControls.TreeViewItem gen_ret = gen_to_be_invoked.NextChild( 
                        _currentChild );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LastChild(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        Battlehub.UIControls.TreeViewItem gen_ret = gen_to_be_invoked.LastChild(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LastDescendant(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        Battlehub.UIControls.TreeViewItem gen_ret = gen_to_be_invoked.LastDescendant(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Indent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Indent);
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
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Parent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanExpand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanExpand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsExpanded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsExpanded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasChildren(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasChildren);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Parent = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItem));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsSelected = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanExpand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanExpand = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsExpanded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItem gen_to_be_invoked = (Battlehub.UIControls.TreeViewItem)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsExpanded = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ParentChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.TreeViewItem.ParentChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.TreeViewItem.ParentChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItem.ParentChanged!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_ParentChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.TreeViewItem.ParentChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItem.ParentChanged!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_ParentChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler<Battlehub.UIControls.ParentChangedEventArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.TreeViewItem.ParentChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItem.ParentChanged!");
        }
        
    }
}
