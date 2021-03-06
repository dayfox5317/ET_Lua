using System.Collections.Generic;
using System.Diagnostics;

namespace ET
{
    public class WatcherComponent : Entity
    {
        public static WatcherComponent Instance { get; set; }

        public readonly Dictionary<int, Process> Processes = new Dictionary<int, Process>();
    }
}