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
    public partial class ETColdStreamHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCold.StreamHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteToUint", _m_WriteToUint);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteToInt", _m_WriteToInt);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteToByte", _m_WriteToByte);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteToShort", _m_WriteToShort);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteToUshort", _m_WriteToUshort);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToInt32", _m_ToInt32);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToUInt16", _m_ToUInt16);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadBytes", _m_ReadBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteBytes", _m_WriteBytes_xlua_st_);
            
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ETCold.StreamHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToUint(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    uint _num = LuaAPI.xlua_touint(L, 3);
                    
                    ETCold.StreamHelper.WriteToUint( 
                        _stream, 
                        _offset, 
                        _num );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToInt(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _num = LuaAPI.xlua_tointeger(L, 3);
                    
                    ETCold.StreamHelper.WriteToInt( 
                        _stream, 
                        _offset, 
                        _num );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToByte(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _num = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    ETCold.StreamHelper.WriteToByte( 
                        _stream, 
                        _offset, 
                        _num );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToShort(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    short _num = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                    ETCold.StreamHelper.WriteToShort( 
                        _stream, 
                        _offset, 
                        _num );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToUshort(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _stream = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ushort _num = (ushort)LuaAPI.xlua_tointeger(L, 3);
                    
                    ETCold.StreamHelper.WriteToUshort( 
                        _stream, 
                        _offset, 
                        _num );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToInt32(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.MemoryStream _memoryStream = (System.IO.MemoryStream)translator.GetObject(L, 1, typeof(System.IO.MemoryStream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = ETCold.StreamHelper.ToInt32( 
                        _memoryStream, 
                        _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToUInt16(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.MemoryStream _memoryStream = (System.IO.MemoryStream)translator.GetObject(L, 1, typeof(System.IO.MemoryStream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        ushort gen_ret = ETCold.StreamHelper.ToUInt16( 
                        _memoryStream, 
                        _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBytes_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.MemoryStream _memoryStream = (System.IO.MemoryStream)translator.GetObject(L, 1, typeof(System.IO.MemoryStream));
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte[] gen_ret = ETCold.StreamHelper.ReadBytes( 
                        _memoryStream, 
                        _offset );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBytes_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.MemoryStream _memoryStream = (System.IO.MemoryStream)translator.GetObject(L, 1, typeof(System.IO.MemoryStream));
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    
                    ETCold.StreamHelper.WriteBytes( 
                        _memoryStream, 
                        _bytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
