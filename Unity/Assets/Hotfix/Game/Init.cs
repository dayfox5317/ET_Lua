
using System;
using System.Threading;
using System.Threading.Tasks;
using ETCold;
using System.Linq;
namespace ET
{
	public class TestWrap
    {
		public static int[] A;
		public string B;
		public string[] C;
		public System.Collections.Generic.List<string> D;

		public TestWrap(string str,string b)
        {
			Log.Warning(str.GetType().FullName);
			Log.Warning(str + b);
		}

		public static void InvokeWrap(string a,int b,string c)
        {
			Log.Debug(a + b + c+"local A =" + A);
        }
    }
	public static class Init
	{
		public static void Start()
		{
			try
			{
				TypeHelper.Init();
				//	Game.EventSystem.Add(ET.Hotfix.Instance.GetHotfixTypes());
				Game.EventSystem.Init();
				Log.Info("开始热更");
              
				// 注册热更层回调
				GameLoop.onUpdate += Update;
				GameLoop.onLateUpdate += LateUpdate;
				GameLoop.onApplicationQuit += OnApplicationQuit;
				
				ProtobufHelper.Init();

				//var act = typeof(TestWrap);

				//ArrayHelper.Test(act);

				// var go = new UnityEngine.GameObject("te");


				// var  pts = ETCold.TypeHelper.GetMembers(typeof(UnityEngine.GameObject));
                // for (int i = 0; i < ArrayHelper.GetLength(pts); i++)
                // {
					// Log.Info("Field->"+ ArrayHelper.GetMemberItem(pts,i).Name);
                // }
				// var pts2 = (typeof(ET.Game)).GetFields();
				// for (int i = 0; i < pts2.Length; i++)
				// {
					// Log.Info("Field 2 ->" +pts2[i].FieldType);
				// }
				// Log.Error("IsArray->" + pts.GetType().IsArray);
				// Log.Error("Len->" + pts.Length);
				// Log.Error("Len->" + pts[0].Name);

			//	ETCold.TypeHelper.TestT(typeof(Game));
				//ArrayHelper.Test(Game.EventSystem);

				Game.Options = new Options();

				Game.EventSystem.Publish(new EventType.AppStart()).Coroutine();
				
            }
			catch (Exception _e)
			{
				Log.Error(_e);
			}
		}

		public static void Update()
		{
			Game.Update(); 
		}

		public static void LateUpdate()
		{
			Game.LateUpdate();
		}

		public static void OnApplicationQuit()
		{
			GameLoop.onUpdate -= Update;
			GameLoop.onLateUpdate -= LateUpdate;
			GameLoop.onApplicationQuit -= OnApplicationQuit;
			Game.Close();
		}
	}
}