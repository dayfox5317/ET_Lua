using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using ET;
using ProtoBuf;
using UnityEditor;
using Log = UnityEngine.Debug;

namespace ETEditor
{
    public class ExcelConfigEditor
    {
        [MenuItem("Tools/生成Excel配置")]
        static void Start()
        {
            ProcessHelper.Run("dotnet", "ExcelExporter.dll", "..\\Tools\\ExcelExporter\\Bin\\", false);
            AssetDatabase.Refresh();
        }
    }
}