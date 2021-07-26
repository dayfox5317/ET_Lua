//using System;
//using System.Collections.Generic;
//using UnityEngine;

//namespace ET
//{
//    public class HudComponenetAwakeSystem : AwakeSystem<HudComponenet>
//    {
//    	public override void Awake(HudComponenet self)
//    	{
//    		self.Awake();
//    	}
//    }
//    public class HudComponenetDestroySystem : DestroySystem<HudComponenet>
//    {
//    	public override void Destroy(HudComponenet self)
//    	{
//    		self.Destroy();
//    	}
//    }
//    public class HudComponenet : Entity
//    {
//        private FUI_Hud hud;

//        private Transform hudTrans;

//        private int hp, maxHp;

//        private Unit unit;


//        private const int sortingOrder = 100;

//        internal void Awake()
//        {
//            if(hud == null)
//            {
//                LoadHud();
//            }
//            unit = GetParent<Unit>();
//            var unitView = unit.GetComponent<UnitView>();
//            hudTrans.SetParent(unitView.transform);
//            hudTrans.position = unitView.HeadPoint.position;
//            hudTrans.gameObject.SetActive(true);
//            FairyGUI.Stage.inst.SortWorldSpacePanelsByZOrder(sortingOrder);
//        }
//        private void LoadHud()
//        {
//            GameObject go = new GameObject("Hud");
//            hudTrans = go.transform;
//            hudTrans.localScale = Vector3.one * 0.01f;
//            var c = go.Add3DUI(FUI_Hud.UIPackageName, FUI_Hud.UIResName, Camera.main, sortingOrder);
//            hud = FUI_Hud.GetFormPool(FUIComponent.Instance, c);
//            hud.Name = hud.Id.ToString();
//        }


//        internal void Init(string name, int level, int _hp, int _maxHp, FairyGUI.ProgressTitleType progressTitleType)
//        {
//            hud.m_txtName.text = name;
//            hud.m_txtLevel.text ="lv."+ level;
//            //hud.m_progress.max =this.maxHp = _maxHp;
//            //hud.m_progress.value =this.hp = _hp;
//            //hud.m_progress.titleType = progressTitleType;
//        }
//        public void ChangeHp()
//        {
//            var num = unit.GetComponent<NumericComponent>();
//            int _hp = num.GetAsInt(NumericType.Hp);
//            if (_hp == hp)
//                return;
//            //hud.m_progress.value = this.hp = _hp;
//        }

//        internal void Destroy()
//        {
//            hudTrans.SetParent(UnityRoot.Instance.ObjPoolParent);
//            hudTrans.gameObject.SetActive(false);
//            unit = null;
//        }
//    }
//}
