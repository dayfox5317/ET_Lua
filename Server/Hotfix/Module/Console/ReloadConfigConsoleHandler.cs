﻿using System;
using System.Linq;

namespace ET
{
    [ConsoleHandler(ConsoleMode.ReloadConfig)]
    public class ReloadConfigConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ReloadConfig:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console("C must have config name, like: C UnitConfig");
                    break;
                default:
                    string[] ss = content.Split(" ");
                    string configName = ss[1];
                    string category = $"{configName}Category";
                    Type type = typeof(Game).Assembly.GetType($"ET.{category}"); // Game.EventSystem.GetTypes(typeof(ConfigAttribute)).FirstOrDefault((x) => x.FullName == $"ET.{category}");
                    if (type == null)
                    {
                        Log.Console($"reload config but not find {category}");
                        return;
                    }
                    ConfigComponent.Instance.LoadOneConfig(type);
                    Log.Console($"reload config {configName} finish!");
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}