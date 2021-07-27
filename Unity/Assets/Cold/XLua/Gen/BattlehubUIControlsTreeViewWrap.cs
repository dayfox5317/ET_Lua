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
    public partial class BattlehubUIControlsTreeViewWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.TreeView);
			Utils.BeginObjectRegister(type, L, translator, 0, 20, 3, 3);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTreeViewItem", _m_GetTreeViewItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddChild", _m_AddChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveChild", _m_RemoveChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ChangeParent", _m_ChangeParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsExpanded", _m_IsExpanded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Expand", _m_Expand);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Collapse", _m_Collapse);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DataBindItem", _m_DataBindItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateIndent", _m_UpdateIndent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FixScrollRect", _m_FixScrollRect);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIndent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCanReparent", _g_get_CanReparent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAutoExpand", _g_get_AutoExpand);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIndent", _s_set_Indent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setCanReparent", _s_set_CanReparent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setAutoExpand", _s_set_AutoExpand);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemExpanding", _e_add_ItemExpanding);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemExpanding", _e_remove_ItemExpanding);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemExpanding", _e_ItemExpanding);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Indent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CanReparent", _g_get_CanReparent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AutoExpand", _g_get_AutoExpand);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Indent", _s_set_Indent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CanReparent", _s_set_CanReparent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AutoExpand", _s_set_AutoExpand);
            
			
			
			
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
					
					Battlehub.UIControls.TreeView gen_ret = new Battlehub.UIControls.TreeView();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeView constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTreeViewItem(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _siblingIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        Battlehub.UIControls.TreeViewItem gen_ret = gen_to_be_invoked.GetTreeViewItem( 
                        _siblingIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        Battlehub.UIControls.TreeViewItem gen_ret = gen_to_be_invoked.GetTreeViewItem( 
                        _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeView.GetTreeViewItem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddChild(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _parent = translator.GetObject(L, 2, typeof(object));
                    object _item = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.AddChild( 
                        _parent, 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.Remove( 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveChild(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _parent = translator.GetObject(L, 2, typeof(object));
                    object _item = translator.GetObject(L, 3, typeof(object));
                    bool _isLastChild = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.RemoveChild( 
                        _parent, 
                        _item, 
                        _isLastChild );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ChangeParent(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _parent = translator.GetObject(L, 2, typeof(object));
                    object _item = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.ChangeParent( 
                        _parent, 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsExpanded(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.IsExpanded( 
                        _item );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Expand(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.TreeViewItem _item = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItem));
                    
                    gen_to_be_invoked.Expand( 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Collapse(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Battlehub.UIControls.TreeViewItem _item = (Battlehub.UIControls.TreeViewItem)translator.GetObject(L, 2, typeof(Battlehub.UIControls.TreeViewItem));
                    
                    gen_to_be_invoked.Collapse( 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DataBindItem(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _item = translator.GetObject(L, 2, typeof(object));
                    Battlehub.UIControls.ItemContainer _itemContainer = (Battlehub.UIControls.ItemContainer)translator.GetObject(L, 3, typeof(Battlehub.UIControls.ItemContainer));
                    
                    gen_to_be_invoked.DataBindItem( 
                        _item, 
                        _itemContainer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateIndent(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.UpdateIndent( 
                        _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FixScrollRect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.FixScrollRect(  );
                    
                    
                    
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
			
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Indent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CanReparent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.CanReparent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AutoExpand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AutoExpand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Indent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Indent = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CanReparent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CanReparent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AutoExpand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AutoExpand = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemExpanding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
                System.EventHandler<Battlehub.UIControls.ItemExpandingArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemExpandingArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.EventHandler<Battlehub.UIControls.ItemExpandingArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemExpanding += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemExpanding -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeView.ItemExpanding!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemExpanding(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemExpandingArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemExpandingArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemExpandingArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemExpanding += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeView.ItemExpanding!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemExpanding(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.TreeView gen_to_be_invoked = (Battlehub.UIControls.TreeView)translator.FastGetCSObj(L, 1);
				System.EventHandler<Battlehub.UIControls.ItemExpandingArgs> gen_delegate = translator.GetDelegate<System.EventHandler<Battlehub.UIControls.ItemExpandingArgs>>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.EventHandler<Battlehub.UIControls.ItemExpandingArgs>!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemExpanding -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.TreeView.ItemExpanding!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
