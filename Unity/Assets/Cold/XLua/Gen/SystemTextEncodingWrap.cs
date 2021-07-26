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
    public partial class SystemTextEncodingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Text.Encoding);
			Utils.BeginObjectRegister(type, L, translator, 0, 30, 14, 2);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPreamble", _m_GetPreamble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetByteCount", _m_GetByteCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBytes", _m_GetBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCharCount", _m_GetCharCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChars", _m_GetChars);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAlwaysNormalized", _m_IsAlwaysNormalized);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDecoder", _m_GetDecoder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEncoder", _m_GetEncoder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMaxByteCount", _m_GetMaxByteCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMaxCharCount", _m_GetMaxCharCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetString", _m_GetString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getBodyName", _g_get_BodyName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEncodingName", _g_get_EncodingName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getHeaderName", _g_get_HeaderName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getWebName", _g_get_WebName);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getWindowsCodePage", _g_get_WindowsCodePage);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsBrowserDisplay", _g_get_IsBrowserDisplay);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsBrowserSave", _g_get_IsBrowserSave);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsMailNewsDisplay", _g_get_IsMailNewsDisplay);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsMailNewsSave", _g_get_IsMailNewsSave);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsSingleByte", _g_get_IsSingleByte);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getEncoderFallback", _g_get_EncoderFallback);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getDecoderFallback", _g_get_DecoderFallback);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getIsReadOnly", _g_get_IsReadOnly);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getCodePage", _g_get_CodePage);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setEncoderFallback", _s_set_EncoderFallback);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setDecoderFallback", _s_set_DecoderFallback);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BodyName", _g_get_BodyName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EncodingName", _g_get_EncodingName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HeaderName", _g_get_HeaderName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WebName", _g_get_WebName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WindowsCodePage", _g_get_WindowsCodePage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBrowserDisplay", _g_get_IsBrowserDisplay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBrowserSave", _g_get_IsBrowserSave);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsMailNewsDisplay", _g_get_IsMailNewsDisplay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsMailNewsSave", _g_get_IsMailNewsSave);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSingleByte", _g_get_IsSingleByte);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EncoderFallback", _g_get_EncoderFallback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DecoderFallback", _g_get_DecoderFallback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsReadOnly", _g_get_IsReadOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CodePage", _g_get_CodePage);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "EncoderFallback", _s_set_EncoderFallback);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DecoderFallback", _s_set_DecoderFallback);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 19, 7, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Convert", _m_Convert_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterProvider", _m_RegisterProvider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetEncoding", _m_GetEncoding_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetEncodings", _m_GetEncodings_xlua_st_);
            
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getASCII", _g_get_ASCII);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getDefault", _g_get_Default);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getUnicode", _g_get_Unicode);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getBigEndianUnicode", _g_get_BigEndianUnicode);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getUTF7", _g_get_UTF7);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getUTF8", _g_get_UTF8);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getUTF32", _g_get_UTF32);
            
			
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ASCII", _g_get_ASCII);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Default", _g_get_Default);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Unicode", _g_get_Unicode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BigEndianUnicode", _g_get_BigEndianUnicode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UTF7", _g_get_UTF7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UTF8", _g_get_UTF8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UTF32", _g_get_UTF32);
            
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.Text.Encoding does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Convert_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Text.Encoding>(L, 1)&& translator.Assignable<System.Text.Encoding>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Text.Encoding _srcEncoding = (System.Text.Encoding)translator.GetObject(L, 1, typeof(System.Text.Encoding));
                    System.Text.Encoding _dstEncoding = (System.Text.Encoding)translator.GetObject(L, 2, typeof(System.Text.Encoding));
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 3);
                    
                        byte[] gen_ret = System.Text.Encoding.Convert( 
                        _srcEncoding, 
                        _dstEncoding, 
                        _bytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Text.Encoding>(L, 1)&& translator.Assignable<System.Text.Encoding>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Text.Encoding _srcEncoding = (System.Text.Encoding)translator.GetObject(L, 1, typeof(System.Text.Encoding));
                    System.Text.Encoding _dstEncoding = (System.Text.Encoding)translator.GetObject(L, 2, typeof(System.Text.Encoding));
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 3);
                    int _index = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                        byte[] gen_ret = System.Text.Encoding.Convert( 
                        _srcEncoding, 
                        _dstEncoding, 
                        _bytes, 
                        _index, 
                        _count );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.Convert!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterProvider_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Text.EncodingProvider _provider = (System.Text.EncodingProvider)translator.GetObject(L, 1, typeof(System.Text.EncodingProvider));
                    
                    System.Text.Encoding.RegisterProvider( 
                        _provider );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEncoding_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _codepage = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.Text.Encoding gen_ret = System.Text.Encoding.GetEncoding( 
                        _codepage );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        System.Text.Encoding gen_ret = System.Text.Encoding.GetEncoding( 
                        _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Text.EncoderFallback>(L, 2)&& translator.Assignable<System.Text.DecoderFallback>(L, 3)) 
                {
                    int _codepage = LuaAPI.xlua_tointeger(L, 1);
                    System.Text.EncoderFallback _encoderFallback = (System.Text.EncoderFallback)translator.GetObject(L, 2, typeof(System.Text.EncoderFallback));
                    System.Text.DecoderFallback _decoderFallback = (System.Text.DecoderFallback)translator.GetObject(L, 3, typeof(System.Text.DecoderFallback));
                    
                        System.Text.Encoding gen_ret = System.Text.Encoding.GetEncoding( 
                        _codepage, 
                        _encoderFallback, 
                        _decoderFallback );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Text.EncoderFallback>(L, 2)&& translator.Assignable<System.Text.DecoderFallback>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Text.EncoderFallback _encoderFallback = (System.Text.EncoderFallback)translator.GetObject(L, 2, typeof(System.Text.EncoderFallback));
                    System.Text.DecoderFallback _decoderFallback = (System.Text.DecoderFallback)translator.GetObject(L, 3, typeof(System.Text.DecoderFallback));
                    
                        System.Text.Encoding gen_ret = System.Text.Encoding.GetEncoding( 
                        _name, 
                        _encoderFallback, 
                        _decoderFallback );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.GetEncoding!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEncodings_xlua_st_(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Text.EncodingInfo[] gen_ret = System.Text.Encoding.GetEncodings(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPreamble(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.GetPreamble(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        object gen_ret = gen_to_be_invoked.Clone(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetByteCount(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<char[]>(L, 2)) 
                {
                    char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
                    
                        int gen_ret = gen_to_be_invoked.GetByteCount( 
                        _chars );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _s = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.GetByteCount( 
                        _s );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<char[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.GetByteCount( 
                        _chars, 
                        _index, 
                        _count );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.GetByteCount!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBytes(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<char[]>(L, 2)) 
                {
                    char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
                    
                        byte[] gen_ret = gen_to_be_invoked.GetBytes( 
                        _chars );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _s = LuaAPI.lua_tostring(L, 2);
                    
                        byte[] gen_ret = gen_to_be_invoked.GetBytes( 
                        _s );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<char[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                        byte[] gen_ret = gen_to_be_invoked.GetBytes( 
                        _chars, 
                        _index, 
                        _count );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<char[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
                    int _charIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _charCount = LuaAPI.xlua_tointeger(L, 4);
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 5);
                    int _byteIndex = LuaAPI.xlua_tointeger(L, 6);
                    
                        int gen_ret = gen_to_be_invoked.GetBytes( 
                        _chars, 
                        _charIndex, 
                        _charCount, 
                        _bytes, 
                        _byteIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    string _s = LuaAPI.lua_tostring(L, 2);
                    int _charIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _charCount = LuaAPI.xlua_tointeger(L, 4);
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 5);
                    int _byteIndex = LuaAPI.xlua_tointeger(L, 6);
                    
                        int gen_ret = gen_to_be_invoked.GetBytes( 
                        _s, 
                        _charIndex, 
                        _charCount, 
                        _bytes, 
                        _byteIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.GetBytes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharCount(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.GetCharCount( 
                        _bytes );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.GetCharCount( 
                        _bytes, 
                        _index, 
                        _count );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.GetCharCount!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChars(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    
                        char[] gen_ret = gen_to_be_invoked.GetChars( 
                        _bytes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                        char[] gen_ret = gen_to_be_invoked.GetChars( 
                        _bytes, 
                        _index, 
                        _count );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<char[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    int _byteIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _byteCount = LuaAPI.xlua_tointeger(L, 4);
                    char[] _chars = (char[])translator.GetObject(L, 5, typeof(char[]));
                    int _charIndex = LuaAPI.xlua_tointeger(L, 6);
                    
                        int gen_ret = gen_to_be_invoked.GetChars( 
                        _bytes, 
                        _byteIndex, 
                        _byteCount, 
                        _chars, 
                        _charIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.GetChars!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAlwaysNormalized(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsAlwaysNormalized(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Text.NormalizationForm>(L, 2)) 
                {
                    System.Text.NormalizationForm _form;translator.Get(L, 2, out _form);
                    
                        bool gen_ret = gen_to_be_invoked.IsAlwaysNormalized( 
                        _form );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.IsAlwaysNormalized!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDecoder(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Text.Decoder gen_ret = gen_to_be_invoked.GetDecoder(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEncoder(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Text.Encoder gen_ret = gen_to_be_invoked.GetEncoder(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMaxByteCount(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _charCount = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.GetMaxByteCount( 
                        _charCount );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMaxCharCount(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _byteCount = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.GetMaxCharCount( 
                        _byteCount );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetString(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.GetString( 
                        _bytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                        string gen_ret = gen_to_be_invoked.GetString( 
                        _bytes, 
                        _index, 
                        _count );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Text.Encoding.GetString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( 
                        _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BodyName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.BodyName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EncodingName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.EncodingName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HeaderName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.HeaderName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WebName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.WebName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowsCodePage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.WindowsCodePage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBrowserDisplay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBrowserDisplay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBrowserSave(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBrowserSave);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsMailNewsDisplay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsMailNewsDisplay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsMailNewsSave(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsMailNewsSave);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSingleByte(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSingleByte);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EncoderFallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.EncoderFallback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DecoderFallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DecoderFallback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsReadOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsReadOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ASCII(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.ASCII);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CodePage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.CodePage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Default(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.Default);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Unicode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.Unicode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BigEndianUnicode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.BigEndianUnicode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UTF7(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.UTF7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UTF8(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.UTF8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UTF32(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Text.Encoding.UTF32);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EncoderFallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EncoderFallback = (System.Text.EncoderFallback)translator.GetObject(L, 2, typeof(System.Text.EncoderFallback));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DecoderFallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Text.Encoding gen_to_be_invoked = (System.Text.Encoding)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DecoderFallback = (System.Text.DecoderFallback)translator.GetObject(L, 2, typeof(System.Text.DecoderFallback));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
