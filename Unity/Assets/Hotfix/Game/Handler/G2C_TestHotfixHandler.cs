using System.Threading.Tasks;

namespace ET
{
	[MessageHandler]
	public class G2C_TestHotfixMessageHandler : AMHandler<G2C_TestHotfixMessage>
	{
		protected override async ETVoid Run(Session session, G2C_TestHotfixMessage message)
		{
			Log.Debug(message.Info);
			await ETTask.CompletedTask;
		}
	}
}