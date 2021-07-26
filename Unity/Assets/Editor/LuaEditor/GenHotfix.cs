using System.Collections.Generic;
using System.Threading.Tasks;
using ET;
using UnityEditor;
using UnityEngine;
using Define = ETCold.Define;
using FileHelper = ETCold.FileHelper;

namespace ETEditor
{
    public static class GenLuaTool
    {
        [MenuItem("Tools/Gen Lua Scripts #S"),]
        public  static void Geanerate()
        {
            Log.Debug("=========开始转换C#为lua，请耐心等待=========");

            FileHelper.CleanDirectory("Assets/Bundles/Lua/Hotfix");
            FileHelper.CleanDirectory("Assets/Bundles/Lua/HotfixView");
            FileHelper.CleanDirectory("Assets/Bundles/Lua/Model");
            FileHelper.CleanDirectory("Assets/Bundles/Lua/ModelView");
            FileHelper.CleanDirectory("Assets/Res/Code");
            GenModel.Gen();
            GenHotfixView.Gen();
            GenModelView.Gen();
            GenHotfix.Gen();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            Log.Debug("===============转换完成===============");
        }
    }
    
    
    public static class GenHotfixView
    {
        public const string DllName = "Unity.HotfixView";
        private const string DllDir = "./Assets/HotfixView";
        private const string OutDirName = "HotfixView";

        private static List<string> ReferencedLuaAssemblies = new List<string>()
        {
            GenModel.DllName,
            GenHotfix.DllName,
            GenModelView.DllName
        };

        public static void Gen()
        {
            if (GenModel.CopyDll(DllName) && Define.CompileLua)
            {
                GenModel.CompileLua(DllName, DllDir, OutDirName, ReferencedLuaAssemblies, false);
                Debug.Log("生成lua完毕");
            }
        }
    }

   // [InitializeOnLoad]
    public class GenHotfix
    {
        public const string DllName = "Unity.Hotfix";
        private const string DllDir = "./Assets/Hotfix";
        private const string OutDirName = "Hotfix";
        private static List<string> ReferencedLuaAssemblies = new List<string>() {GenModel.DllName};

        static GenHotfix()
        {
           
        }

        public static void Gen()
        {
            if (GenModel.CopyDll(DllName) && Define.CompileLua)
            {
                GenModel.CompileLua(DllName, DllDir, OutDirName, ReferencedLuaAssemblies, true);
            }
        }
        
        
    }

   // [InitializeOnLoad]
    public class GenModelView
    {
        public const string DllName = "Unity.ModelView";
        private const string DllDir = "./Assets/ModelView";
        private const string OutDirName = "ModelView";
        private static List<string> ReferencedLuaAssemblies = new List<string>() {GenModel.DllName};

        static GenModelView()
        {
          
        }
        
        public static void Gen()
        {
            if (GenModel.CopyDll(DllName) && Define.CompileLua)
            {
                GenModel.CompileLua(DllName, DllDir, OutDirName, ReferencedLuaAssemblies, true);
            }
        }
    }

}