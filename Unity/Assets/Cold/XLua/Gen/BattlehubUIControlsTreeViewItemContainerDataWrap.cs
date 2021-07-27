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
    public partial class BattlehubUIControlsTreeViewItemContainerDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.TreeViewItemContainerData);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 5, 4);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsDescendantOf", _m_IsDescendantOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasChildren", _m_HasChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FirstChild", _m_FirstChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NextChild", _m_NextChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastChild", _m_LastChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastDescendant", _m_LastDescendant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getParentItem", _g_get_ParentItem);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIndent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanExpand", _g_get_CanExpand);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsExpanded", _g_get_IsExpanded);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setParent", _s_set_Parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIndent", _s_set_Indent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanExpand", _s_set_CanExpand);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIsExpanded", _s_set_IsExpanded);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Parent", _g_get_Parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ParentItem", _g_get_ParentItem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Indent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanExpand", _g_get_CanExpand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsExpanded", _g_get_IsExpanded);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Parent", _s_set_Parent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Indent", _s_set_Indent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanExpand", _s_set_CanExpand);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsExpanded", _s_set_IsExpanded);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 1, 1);
			
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getInternal_RaiseEvents", _g_get_Internal_RaiseEvents);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setInternal_RaiseEvents", _s_set_Internal_RaiseEvents);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addParentChanging", _e_add_ParentChanging);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "addParentChanged", _e_add_ParentChanged);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeParentChanging", _e_remove_ParentChanging);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "removeParentChanged", _e_remove_ParentChanged);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ParentChanging", _e_ParentChanging);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ParentChanged", _e_ParentChanged);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Internal_RaiseEvents", _g_get_Internal_RaiseEvents);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Internal_RaiseEvents", _s_set_Internal_RaiseEvents);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Battlehub.UIControls.TreeViewItemContainerData gen_ret = new Battlehub.UIControls.TreeViewItemContainerData();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsDescendantOf(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.TreeViewItemContainerData _ancestor = (Battlehub.UIControls.TreeViewItemContainerData)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItemContainerData));
                    
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
        static int _m_HasChildren(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingTreeView _treeView = (Battlehub.UIControls.VirtualizingTreeView)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingTreeView));
                    
                        bool gen_ret = gen_to_be_invoked.HasChildren( 
                        _treeView );
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
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingTreeView _treeView = (Battlehub.UIControls.VirtualizingTreeView)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingTreeView));
                    
                        Battlehub.UIControls.TreeViewItemContainerData gen_ret = gen_to_be_invoked.FirstChild( 
                        _treeView );
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
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingTreeView _treeView = (Battlehub.UIControls.VirtualizingTreeView)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingTreeView));
                    Battlehub.UIControls.TreeViewItemContainerData _currentChild = (Battlehub.UIControls.TreeViewItemContainerData)translator.GetObject(L, 3, typeof(Battlehub.UIControls.TreeViewItemContainerData));
                    
                        Battlehub.UIControls.TreeViewItemContainerData gen_ret = gen_to_be_invoked.NextChild( 
                        _treeView, 
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
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingTreeView _treeView = (Battlehub.UIControls.VirtualizingTreeView)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingTreeView));
                    
                        Battlehub.UIControls.TreeViewItemContainerData gen_ret = gen_to_be_invoked.LastChild( 
                        _treeView );
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
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.VirtualizingTreeView _treeView = (Battlehub.UIControls.VirtualizingTreeView)translator.GetObject(L, 2, typeof(Battlehub.UIControls.VirtualizingTreeView));
                    
                        Battlehub.UIControls.TreeViewItemContainerData gen_ret = gen_to_be_invoked.LastDescendant( 
                        _treeView );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Parent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ParentItem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.ParentItem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Indent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Indent);
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
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsExpanded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Internal_RaiseEvents(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, Battlehub.UIControls.TreeViewItemContainerData.Internal_RaiseEvents);
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
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Parent = (Battlehub.UIControls.TreeViewItemContainerData)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItemContainerData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Indent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Indent = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
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
			
                Battlehub.UIControls.TreeViewItemContainerData gen_to_be_invoked = (Battlehub.UIControls.TreeViewItemContainerData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsExpanded = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Internal_RaiseEvents(RealStatePtr L)
        {
		    try {
                
			    Battlehub.UIControls.TreeViewItemContainerData.Internal_RaiseEvents = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ParentChanging(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanging += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanging -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData.ParentChanging!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ParentChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData.ParentChanged!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_ParentChanging(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanging += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData.ParentChanging!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_add_ParentChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanged += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData.ParentChanged!");
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_ParentChanging(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanging -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData.ParentChanging!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_remove_ParentChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>>(L, 1);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#1 need System.EventHandler<Battlehub.UIControls.VirtualizingParentChangedEventArgs>!");
                }
                
				if (gen_param_count == 1) {
					Battlehub.UIControls.TreeViewItemContainerData.ParentChanged -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeViewItemContainerData.ParentChanged!");
        }
        
    }
}
