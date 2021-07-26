using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace ETCold
{
    public static class MonoHelper
    {
        private const string codeAssetName = "Assets/Bundles/Independent/Code.prefab";
        private const string codePrefabName = "Code";

        public const string Model = "Unity.Model";
        public const string ModelView = "Unity.ModelView";
        public const string Hotfix = "Unity.Hotfix";
        public const string HotfixView = "Unity.HotfixView";

        public static string ModelDll = $"Assets/Res/Code/{Model}.dll.bytes";
        public static string ModelViewDll = $"Assets/Res/Code/{ModelView}.dll.bytes";
        public static string HotfixDll = $"Assets/Res/Code/{Hotfix}.dll.bytes";
        public static string HotfixViewDll = $"Assets/Res/Code/{HotfixView}.dll.bytes";
        public static string ModelPdb = $"Assets/Res/Code/{Model}.pdb.bytes";
        public static string ModelViewPdb = $"Assets/Res/Code/{ModelView}.pdb.bytes";
        public static string HotfixPdb = $"Assets/Res/Code/{Hotfix}.pdb.bytes";
        public static string HotfixViewPdb = $"Assets/Res/Code/{HotfixView}.pdb.bytes";

        public static List<Type> _types = new List<Type>();

        public static async void StartHotfix()
        {
            Debug.Log($"当前使用的是Mono模式");

            var assembly = Assembly.Load(Load(ModelDll), Load(ModelPdb));
            _types.AddRange(assembly.GetTypes());
            assembly = Assembly.Load(Load(ModelViewDll), Load(ModelViewPdb));
            _types.AddRange(assembly.GetTypes());
            assembly = Assembly.Load(Load(HotfixViewDll), Load(HotfixViewPdb));
            _types.AddRange(assembly.GetTypes());

            var mainAssembly = Assembly.Load(Load(HotfixDll), Load(HotfixPdb));
            _types.AddRange(mainAssembly.GetTypes());
            var start = new MonoStaticMethod(mainAssembly.GetType("ET.Init"), "Start");
            start.Run();
        }

        private static byte[] Load(string path)
        {
            return  LoadHelper.LoadTextAsset(path).bytes;
        }
    }
}