using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

namespace ETCold
{
    public class Lua : IDisposable
    {
        public static Lua Default
        {
            get
            {
                if (defaultLua == null)
                {
                    defaultLua = new Lua();
                }

                return defaultLua;
            }
        }

        public const string manifestFileName = "manifest.lua";
        private const string luaExtensionName = ".lua";
        private const string txtExtensionName = ".txt";
        private const string luaTxtExtensionName = ".lua.txt";
        private const string luaDir = "Bundles/Lua/";
        private const string luaSuffixName = "/lua";
        private const char dot = '.';
        private const char backSlash = '/';
        private static Lua defaultLua = null;
        private static readonly Dictionary<string, string> bundleNameToLowerDic = new Dictionary<string, string>();

        public LuaEnv LuaEnv
        {
            get
            {
                if (luaEnv == null)
                {
                    luaEnv = new LuaEnv();
                    luaEnv.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);
                    luaEnv.AddBuildin("lpeg", XLua.LuaDLL.Lua.LoadLpeg);
                    luaEnv.AddBuildin("pb", XLua.LuaDLL.Lua.LoadLuaProfobuf);
                    luaEnv.AddBuildin("ffi", XLua.LuaDLL.Lua.LoadFFI);

                    if (Define.IsEditorMode)
                    {
                        luaEnv.AddLoader(EditorLoader);
                    }
                    else
                    {
                        //替换原来的加载函数
                        luaEnv.AddLoader(ABLuaLoader);
                    }
                }

                return luaEnv;
            }
        }

        private LuaEnv luaEnv;

        private byte[] EditorLoader(ref string filepath)
        {
            if (!string.IsNullOrWhiteSpace(filepath))
            {
                var splits = filepath.Split(dot);

                if (splits != null)
                {
                    if (filepath.EndsWith(luaExtensionName))
                    {
                        filepath = Path.Combine("Assets",luaDir + filepath.Replace(dot, backSlash).Replace(luaSuffixName, luaExtensionName) + txtExtensionName);
                        filepath = filepath.Replace("\\", "/");
                        var txt = libx.Assets.LoadAsset(filepath, typeof(TextAsset)).asset as TextAsset;
                        Debug.Log(filepath);
                        return   txt.bytes;
                  
                    }
                    else
                    {

                        filepath = Path.Combine("Assets", luaDir + filepath.Replace(dot, backSlash) + luaTxtExtensionName);
                        filepath = filepath.Replace("\\", "/");
                        var txt = libx.Assets.LoadAsset(filepath, typeof(TextAsset)).asset as TextAsset;
                        return txt.bytes;
                      
                    }
                }
            }

            return null;
        }

    

        private static byte[] ABLuaLoader(ref string filepath)
        {
            if (!string.IsNullOrWhiteSpace(filepath))
            {
               
                var luaFileName = filepath.Replace(luaExtensionName, "");
                var splits = luaFileName.Split(dot);

                if (splits != null)
                {
                    if (filepath.EndsWith(luaExtensionName))
                    {
                        filepath = Path.Combine("Assets/", luaDir, filepath.Replace(dot, backSlash).Replace(luaSuffixName, luaExtensionName) + txtExtensionName);
                    }
                    else
                    {
                        filepath = Path.Combine("Assets/", luaDir, filepath.Replace(dot, backSlash) + luaTxtExtensionName);
                    }
                }

                var obj = LoadHelper.LoadTextAsset(filepath);
                if (obj is TextAsset textAsset)
                {
#if UNITY_EDITOR
                    if (filepath.EndsWith("manifest.lua.txt"))
                    {
                        UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(obj, out string _, out long id);
                        Debug.Log(id);
                    }
#endif
                    return textAsset.bytes;
                }
            }

            return null;
        }

        public void Dispose()
        {
            luaEnv = null;
        }
    }

    public static class LuaHelper
    {
        public static void StartHotfix()
        {
            Lua.Default.LuaEnv.DoString("require 'Main.lua'(true)");
        }
    }
}
