using System;
using System.Net;

using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [ObjectSystem]
    public class FUILoginBindingSystem : UpdateSystem<FUILogin>
    {
        public override void Update(FUILogin self)
        {
            Log.Error("FUILogin awake");
            //ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent(typeof(ReferenceCollector)) as ReferenceCollector;
            //	self.m_n1.self.onClick.Set(()=> { self.OnLogin(); });

        }
    }

    public static class FUILoginComponentSystem
	{
		public static void OnLogin(this FUILogin self)
		{
			LoginHelper.Login(self.DomainScene(), ConstValue.LoginAddress, self.m_Account.text,self.m_Password.text).Coroutine();
		}
	}
}
