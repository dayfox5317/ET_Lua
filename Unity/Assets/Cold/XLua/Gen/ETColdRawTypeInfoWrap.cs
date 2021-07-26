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
    public partial class ETColdRawTypeInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.RawTypeInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 29, 11, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetConstructors", _m_GetConstructors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetElementType", _m_GetElementType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEvent", _m_GetEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEvents", _m_GetEvents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetField", _m_GetField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFields", _m_GetFields);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterface", _m_GetInterface);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterfaces", _m_GetInterfaces);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMembers", _m_GetMembers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMethods", _m_GetMethods);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNestedType", _m_GetNestedType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNestedTypes", _m_GetNestedTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProperties", _m_GetProperties);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvokeMember", _m_InvokeMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCustomAttributes", _m_GetCustomAttributes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsDefined", _m_IsDefined);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getFullName", _g_get_FullName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getName", _g_get_Name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAssembly", _g_get_Assembly);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getAssemblyQualifiedName", _g_get_AssemblyQualifiedName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBaseType", _g_get_BaseType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getGUID", _g_get_GUID);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getModule", _g_get_Module);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getNamespace", _g_get_Namespace);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getUnderlyingSystemType", _g_get_UnderlyingSystemType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getType", _g_get_Type);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmemberInfos", _g_get_memberInfos);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setType", _s_set_Type);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmemberInfos", _s_set_memberInfos);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "FullName", _g_get_FullName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Name", _g_get_Name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Assembly", _g_get_Assembly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssemblyQualifiedName", _g_get_AssemblyQualifiedName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BaseType", _g_get_BaseType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GUID", _g_get_GUID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Module", _g_get_Module);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Namespace", _g_get_Namespace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UnderlyingSystemType", _g_get_UnderlyingSystemType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Type", _g_get_Type);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "memberInfos", _g_get_memberInfos);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Type", _s_set_Type);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "memberInfos", _s_set_memberInfos);
            
			
			
			
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
					
					ETCold.RawTypeInfo gen_ret = new ETCold.RawTypeInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.RawTypeInfo constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConstructors(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.ConstructorInfo[] gen_ret = gen_to_be_invoked.GetConstructors( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetElementType(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetElementType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEvent(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.EventInfo gen_ret = gen_to_be_invoked.GetEvent( 
                        _name, 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEvents(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.EventInfo[] gen_ret = gen_to_be_invoked.GetEvents( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetField(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.FieldInfo gen_ret = gen_to_be_invoked.GetField( 
                        _name, 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFields(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.FieldInfo[] gen_ret = gen_to_be_invoked.GetFields( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterface(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetInterface( 
                        _name, 
                        _ignoreCase );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterfaces(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetInterfaces(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMembers(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetMembers( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethods(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.MethodInfo[] gen_ret = gen_to_be_invoked.GetMethods( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNestedType(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetNestedType( 
                        _name, 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNestedTypes(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetNestedTypes( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProperties(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.PropertyInfo[] gen_ret = gen_to_be_invoked.GetProperties( 
                        _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvokeMember(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _invokeAttr;translator.Get(L, 3, out _invokeAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    object _target = translator.GetObject(L, 5, typeof(object));
                    object[] _args = (object[])translator.GetObject(L, 6, typeof(object[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 7, typeof(System.Reflection.ParameterModifier[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 8, typeof(System.Globalization.CultureInfo));
                    string[] _namedParameters = (string[])translator.GetObject(L, 9, typeof(string[]));
                    
                        object gen_ret = gen_to_be_invoked.InvokeMember( 
                        _name, 
                        _invokeAttr, 
                        _binder, 
                        _target, 
                        _args, 
                        _modifiers, 
                        _culture, 
                        _namedParameters );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCustomAttributes(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _inherit = LuaAPI.lua_toboolean(L, 2);
                    
                        object[] gen_ret = gen_to_be_invoked.GetCustomAttributes( 
                        _inherit );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type _attributeType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool _inherit = LuaAPI.lua_toboolean(L, 3);
                    
                        object[] gen_ret = gen_to_be_invoked.GetCustomAttributes( 
                        _attributeType, 
                        _inherit );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCold.RawTypeInfo.GetCustomAttributes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsDefined(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _attributeType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool _inherit = LuaAPI.lua_toboolean(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.IsDefined( 
                        _attributeType, 
                        _inherit );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FullName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.FullName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Assembly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Assembly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssemblyQualifiedName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AssemblyQualifiedName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BaseType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BaseType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GUID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.GUID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Module);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Namespace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Namespace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UnderlyingSystemType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UnderlyingSystemType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Type(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Type);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_memberInfos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.memberInfos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Type(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_memberInfos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCold.RawTypeInfo gen_to_be_invoked = (ETCold.RawTypeInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.memberInfos = (ETCold.RawMemberInfo[])translator.GetObject(L, 2, typeof(ETCold.RawMemberInfo[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
