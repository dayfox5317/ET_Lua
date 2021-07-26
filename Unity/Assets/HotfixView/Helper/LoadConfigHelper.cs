using ETCold;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class LoadConfigHelper
    {
        public static void LoadAllConfigBytes(HashSet<Type> types, Dictionary<string, byte[]> output)
        {

            string dirPath = "Assets/Bundles/Config/";
            foreach (var _type in types)
            {
                string name = _type.Name;
                string path = dirPath + name + ".bytes";
                TextAsset asset = LoadHelper.LoadTextAsset(path);
                output[name] = asset.bytes;
            }
        }
    }
}