using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class TowerPointViewComponentAwakeSystem : AwakeSystem<TowerPointViewComponent>
    {
        public override void Awake(TowerPointViewComponent self)
        {
            self.Awake();
        }
    }
    public class TowerPointViewComponentUpdateSystem : UpdateSystem<TowerPointViewComponent>
    {
        public override void Update(TowerPointViewComponent self)
        {
            self.Update();
        }
    }
    public class TowerPointViewComponent : Entity
    {
        private int towerPointLayer;
        internal void Awake()
        {
            towerPointLayer = 1 << LayerMask.NameToLayer("TowerPoint");
        }

        internal void Update()
        {
            //if (Input.GetMouseButtonUp(0))
            //{
            //    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //    var hit = Physics2D.Raycast(mousePos, Vector3.zero, 100, towerPointLayer);
            //    if (hit.collider == null)
            //        return;
            //    TowerPointMono towerPointMono = hit.collider.gameObject.GetComponent<TowerPointMono>();
            //    long id = towerPointMono.Id;
            //    //TowerHelper.GenerateTower(id);
            //}
        }
    }
}
