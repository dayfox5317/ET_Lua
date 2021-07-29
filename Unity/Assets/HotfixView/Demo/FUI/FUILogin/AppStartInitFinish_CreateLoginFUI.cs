

namespace ET
{
	public class AppStartInitFinish_CreateLoginFUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(EventType.AppStartInitFinish args)
		{



            var ui = await FUILogin.CreateInstanceAsync(args.ZoneScene);



			//  args.ZoneScene.GetComponent<FUIComponent>().Add(ui, true);
			FairyGUI.GRoot.inst.AddChild(ui.self);

            args.ZoneScene.GetComponent<FUIScalerComponent>().Register(ui.self, AdaptedType.ScaleFullScreen);


            await ETTask.CompletedTask;
		}
	}
}
