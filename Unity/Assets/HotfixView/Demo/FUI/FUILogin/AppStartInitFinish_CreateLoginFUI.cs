

namespace ET
{


    public class AppStartInitFinish_CreateLoginFUI : AEvent<EventType.AppStartInitFinish>
    {
        protected override async ETTask Run(EventType.AppStartInitFinish args)
        {

            var fui = await FUILogin.CreateInstanceAsync(args.ZoneScene);
            args.ZoneScene.GetComponent<FUIComponent>().Add(FUILogin.UIResName, fui, true);

            await ETTask.CompletedTask;
        }
    }
}
