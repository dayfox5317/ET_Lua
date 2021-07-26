//using System;
//using System.Collections.Generic;

//namespace ET
//{
//    public class HudMgrComponentAwakeSystem : AwakeSystem<HudMgrComponent>
//    {
//    	public override void Awake(HudMgrComponent self)
//    	{
//    		self.Awake();
//    	}
//    }
//    public class HudMgrComponent:Entity
//    {
//        private static HudMgrComponent inst;

//        internal void Awake()
//        {
//            inst = this;
//        }

//        public static HudComponenet Add(Unit unit)
//        {
//            var hud = unit.AddComponent<HudComponenet>();
//            return hud;
//        }
//    }
//}
