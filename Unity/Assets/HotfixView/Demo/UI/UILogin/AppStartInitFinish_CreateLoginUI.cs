﻿

namespace ET
{
    public class AppStartInitFinish_CreateLoginUI : AEvent<EventType.AppStartInitFinish>
    {
        protected override async ETTask Run(EventType.AppStartInitFinish args)
        {

            await ETTask.CompletedTask;
          //  await UIHelper.Create(args.ZoneScene, UIType.UILogin);


        }
    }
}
