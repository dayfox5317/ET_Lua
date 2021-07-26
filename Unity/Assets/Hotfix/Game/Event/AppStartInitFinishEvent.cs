using System;
using ET.EventType;

namespace ET
{
    public class AppStartInitFinishEvent : AEvent<AppStartInitFinish>
    {
        protected override async ETTask Run(AppStartInitFinish args)
        {
            await ETTask.CompletedTask;
        }
    }
}