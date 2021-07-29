using System.Collections;
using System.Collections.Generic;
using System.IO;
using ET;
using UnityEditor;
using UnityEngine;

namespace ETEditor
{
    public class GenMessage 
    {
        [MenuItem("Tools/生成Proto消息")]
        public static void Gen()
        {
            ETCold.ProcessHelper.Run("dotnet", "Proto2CS.dll", "..\\Tools\\Proto2CS\\Bin\\");
            FileHelper.CleanDirectory("Assets\\Bundles\\Lua\\pbc\\AutoGeneratedCode\\");
            File.Copy("..\\Proto\\OuterMessage.proto","Assets\\Bundles\\Lua\\pbc\\AutoGeneratedCode\\OuterMessage.txt");

            AssetDatabase.Refresh();
        }
    }

}
