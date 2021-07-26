using System;
using System.Collections.Generic;
using System.IO;

namespace ET
{
    public static class LoadConfigHelper
    {
        public static void LoadAllConfigBytes(HashSet<Type> types, Dictionary<string, byte[]> output)
        {
            foreach (string file in Directory.GetFiles($"../Config", "*.bytes"))
            {
                string key = Path.GetFileNameWithoutExtension(file);
                output[key] = File.ReadAllBytes(file);
            }
        }
    }
}