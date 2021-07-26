
#if SERVER
using CommandLine;
#endif
using System;
using System.Collections.Generic;

namespace ET
{
    public enum ServerType
    {
        Game,
        Watcher,
    }

    public class Options
    {
#if SERVER
        [Option("ServerType", Required = false, Default = ServerType.Game, HelpText = "serverType enum")]
#endif
        public ServerType ServerType { get; set; }

#if SERVER
        [Option("Process", Required = false, Default = 1)]
#endif
        public int Process { get; set; } = 1;

#if SERVER
        [Option("Develop", Required = false, Default = 0, HelpText = "develop mode, 0正式 1开发 2压测")]
#endif
        public int Develop { get; set; } = 0;

#if SERVER
        [Option("LogLevel", Required = false, Default = 0)]
#endif
        public int LogLevel { get; set; } = 2;
    }
}