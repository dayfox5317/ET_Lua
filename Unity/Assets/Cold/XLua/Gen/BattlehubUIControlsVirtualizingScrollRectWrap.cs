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
    public partial class BattlehubUIControlsVirtualizingScrollRectWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Battlehub.UIControls.VirtualizingScrollRect);
			Utils.BeginObjectRegister(type, L, translator, 0, 25, 8, 5);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsParentOf", _m_IsParentOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InsertItem", _m_InsertItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveItems", _m_RemoveItems);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetNextSibling", _m_SetNextSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPrevSibling", _m_SetPrevSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetContainer", _m_GetContainer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FirstContainer", _m_FirstContainer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForEachContainer", _m_ForEachContainer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastContainer", _m_LastContainer);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getUseGrid", _g_get_UseGrid);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getContainersPerGroup", _g_get_ContainersPerGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItems", _g_get_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getItemsCount", _g_get_ItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIndex", _g_get_Index);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getRoundedIndex", _g_get_RoundedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getVisibleItemsCount", _g_get_VisibleItemsCount);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getContainerPrefab", _g_get_ContainerPrefab);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setContainersPerGroup", _s_set_ContainersPerGroup);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setItems", _s_set_Items);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setIndex", _s_set_Index);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setRoundedIndex", _s_set_RoundedIndex);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setContainerPrefab", _s_set_ContainerPrefab);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addItemDataBinding", _e_add_ItemDataBinding);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeItemDataBinding", _e_remove_ItemDataBinding);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ItemDataBinding", _e_ItemDataBinding);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "UseGrid", _g_get_UseGrid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ContainersPerGroup", _g_get_ContainersPerGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Items", _g_get_Items);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ItemsCount", _g_get_ItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Index", _g_get_Index);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RoundedIndex", _g_get_RoundedIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VisibleItemsCount", _g_get_VisibleItemsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ContainerPrefab", _g_get_ContainerPrefab);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ContainersPerGroup", _s_set_ContainersPerGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Items", _s_set_Items);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Index", _s_set_Index);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RoundedIndex", _s_set_RoundedIndex);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ContainerPrefab", _s_set_ContainerPrefab);
            
			
			
			
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
					
					Battlehub.UIControls.VirtualizingScrollRect gen_ret = new Battlehub.UIControls.VirtualizingScrollRect();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingScrollRect constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsParentOf(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Transform _child = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        bool gen_ret = gen_to_be_invoked.IsParentOf( 
                        _child );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InsertItem(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    object _item = translator.GetObject(L, 3, typeof(object));
                    bool _raiseItemDataBindingEvent = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.InsertItem( 
                        _index, 
                        _item, 
                        _raiseItemDataBindingEvent );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    object _item = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.InsertItem( 
                        _index, 
                        _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingScrollRect.InsertItem!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveItems(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<int[]>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int[] _indices = (int[])translator.GetObject(L, 2, typeof(int[]));
                    bool _raiseItemDataBindingEvent = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.RemoveItems( 
                        _indices, 
                        _raiseItemDataBindingEvent );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<int[]>(L, 2)) 
                {
                    int[] _indices = (int[])translator.GetObject(L, 2, typeof(int[]));
                    
                    gen_to_be_invoked.RemoveItems( 
                        _indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingScrollRect.RemoveItems!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNextSibling(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sibling = translator.GetObject(L, 2, typeof(object));
                    object _nextSibling = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SetNextSibling( 
                        _sibling, 
                        _nextSibling );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPrevSibling(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sibling = translator.GetObject(L, 2, typeof(object));
                    object _prevSibling = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SetPrevSibling( 
                        _sibling, 
                        _prevSibling );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        UnityEngine.RectTransform gen_ret = gen_to_be_invoked.GetContainer( 
                        _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FirstContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.RectTransform gen_ret = gen_to_be_invoked.FirstContainer(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForEachContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action<UnityEngine.RectTransform> _action = translator.GetDelegate<System.Action<UnityEngine.RectTransform>>(L, 2);
                    
                    gen_to_be_invoked.ForEachContainer( 
                        _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LastContainer(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.RectTransform gen_ret = gen_to_be_invoked.LastContainer(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UseGrid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.UseGrid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ContainersPerGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ContainersPerGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Items);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ItemsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ItemsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Index(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Index);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RoundedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.RoundedIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VisibleItemsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VisibleItemsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ContainerPrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ContainerPrefab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ContainersPerGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ContainersPerGroup = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Items(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Items = (System.Collections.IList)translator.GetObject(L, 2, typeof(System.Collections.IList));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Index(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Index = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RoundedIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.RoundedIndex = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ContainerPrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ContainerPrefab = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ItemDataBinding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
                Battlehub.UIControls.DataBindAction gen_delegate = translator.GetDelegate<Battlehub.UIControls.DataBindAction>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Battlehub.UIControls.DataBindAction!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.ItemDataBinding += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.ItemDataBinding -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingScrollRect.ItemDataBinding!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_ItemDataBinding(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DataBindAction gen_delegate = translator.GetDelegate<Battlehub.UIControls.DataBindAction>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DataBindAction!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDataBinding += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingScrollRect.ItemDataBinding!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_ItemDataBinding(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			Battlehub.UIControls.VirtualizingScrollRect gen_to_be_invoked = (Battlehub.UIControls.VirtualizingScrollRect)translator.FastGetCSObj(L, 1);
				Battlehub.UIControls.DataBindAction gen_delegate = translator.GetDelegate<Battlehub.UIControls.DataBindAction>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need Battlehub.UIControls.DataBindAction!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.ItemDataBinding -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to Battlehub.UIControls.VirtualizingScrollRect.ItemDataBinding!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
