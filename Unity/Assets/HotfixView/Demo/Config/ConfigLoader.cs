using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class ConfigLoader : IConfigLoader
    {
        public void GetAllConfigBytes(Dictionary<string, byte[]> output)
        {
            var types =  Game.EventSystem.GetTypes(typeof(ConfigAttribute));

            //Dictionary<string, UnityEngine.Object> keys = ResourcesComponent.Instance.get("config.unity3d");

            foreach (var kv in types)
            {
                var data = ResourcesComponent.Instance.LoadAsset(ETCold.ABPathHelper.GetConfigPath(kv.Name), typeof(TextAsset)) as TextAsset;
                output[kv.Name] = data.bytes;
            }
        }

        public byte[] GetOneConfigBytes(string configName)
        {
            var data = ResourcesComponent.Instance.LoadAsset(ETCold.ABPathHelper.GetConfigPath(configName), typeof(TextAsset)) as TextAsset;
           
            return data.bytes;
        }
    }
}