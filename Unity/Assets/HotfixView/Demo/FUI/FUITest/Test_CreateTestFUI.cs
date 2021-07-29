

namespace ET
{
	public class Test_CreateTestFUI : AEvent<EventType.Test_CreateTestFUI>
	{
		protected override async ETTask Run(EventType.Test_CreateTestFUI args)
		{
			var fui = await UI_Button1.CreateInstanceAsync(args.ZoneScene);
			args.ZoneScene.GetComponent<FUIComponent>().Add(fui, true);

		}
	}
}
