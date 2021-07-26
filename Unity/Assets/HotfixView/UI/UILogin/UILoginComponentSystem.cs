using System;
using System.Net;

using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	public class UILoginComponentAwakeSystem : AwakeSystem<UILoginComponent>
	{
		public override void Awake(UILoginComponent self)
		{
			Log.Debug("uiloginComponent awake");
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent(typeof(ReferenceCollector)) as ReferenceCollector;
			self.loginBtn = rc.GetObject("LoginBtn") as GameObject;
			(self.loginBtn.GetComponent(typeof(Button)) as Button).onClick.AddListener(()=> { self.OnLogin(); });
			self.account = rc.GetObject("Account") as GameObject;
		}
	}
	
	public static class UILoginComponentSystem
	{
		public static void OnLogin(this UILoginComponent self)
		{
			LoginHelper.Login(self.DomainScene(), "127.0.0.1:10002", (self.account.GetComponent(typeof(InputField)) as InputField).text).Coroutine();
		}
	}
}
