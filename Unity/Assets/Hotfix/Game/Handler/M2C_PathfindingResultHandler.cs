//
//using System.Threading.Tasks;
//using UnityEngine;

//namespace ET
//{
//	[MessageHandler]
//	public class M2C_PathfindingResultHandler : AMHandler<M2C_PathfindingResult>
//	{
//		protected override async Task Run(Session session, M2C_PathfindingResult message)
//		{
//			Unit unit = Game.Scene.GetComponent<UnitComponent>().Get(message.Id);
			
			
//			unit.GetComponent<AnimatorComponent>().SetFloatValue("Speed", 5f);
//			UnitPathComponent unitPathComponent = unit.GetComponent<UnitPathComponent>();

//			unitPathComponent.StartMove(message);

//			GizmosDebug.Instance.Path.Clear();
//			GizmosDebug.Instance.Path.Add(new Vector3(message.X, message.Y, message.Z));
//			for (int i = 0; i < message.Xs.Count; ++i)
//			{
//				GizmosDebug.Instance.Path.Add(new Vector3(message.Xs[i], message.Ys[i], message.Zs[i]));
//			}

//			await Task.CompletedTask;
//		}
//	}
//}
