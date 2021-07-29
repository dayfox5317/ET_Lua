#if NOT_UNITY
using CommandLine;
#endif

namespace ET
{
    public enum AppType
    {
        Server,
        Robot,
        Watcher, // 每台物理机一个守护进程，用来启动该物理机上的所有进程
        GameTool,
    }

    public class Options
    {
#if NOT_UNITY
        [Option("AppType", Required = false, Default = AppType.Server, HelpText = "serverType enum")]
#endif
        public AppType AppType { get; set; }
#if NOT_UNITY
        [Option("Process", Required = false, Default = 1)]
#endif
        public int Process { get; set; } = 1;
#if NOT_UNITY
        [Option("Develop", Required = false, Default = 0, HelpText = "develop mode, 0正式 1开发 2压测")]
#endif
        public int Develop { get; set; } = 0;
#if NOT_UNITY
        [Option("LogLevel", Required = false, Default = 2)]
#endif
        public int LogLevel { get; set; } = 2;
#if NOT_UNITY
        [Option("Console", Required = false, Default = 0)]
#endif
        public int Console { get; set; } = 0;
#if NOT_UNITY
        // 进程启动是否创建该进程的scenes
        [Option("CreateScenes", Required = false, Default = 1)]
#endif
        public int CreateScenes { get; set; } = 1;
    }
}