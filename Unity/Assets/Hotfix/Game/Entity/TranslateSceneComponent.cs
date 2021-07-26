using ET;

using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    
    public class TranslateSceneComponentAwakeSystem : AwakeSystem<TranslateSceneComponent>
    {
        public override void Awake(TranslateSceneComponent self)
        {
            self.Awake();
        }
    }
    
    public class TranslateSceneComponentUpdateSsytem : UpdateSystem<TranslateSceneComponent>
    {
        public override void Update(TranslateSceneComponent self)
        {
            self.Update();
        }
    }

    public class TranslateSceneComponent : Entity
    {
        public static TranslateSceneComponent Instance { get; private set; }

        //private FUI_Loading ui;

        //private bool isEnd;
        private bool isShowing;
        private bool isAutoEnd;
        private float progress; 
        //private float progressAddAmount = 0.5f;
        internal void Awake()
        {
            Instance = this;
            isShowing = false;
            //isEnd = false;
            isAutoEnd = true;
        }
        public void Begin(bool isAutoEnd = true)
        {
            if (isShowing)
                return;
            if (!isAutoEnd)
                this.isAutoEnd = isAutoEnd;
            //if (ui == null)
            //{
            //    ui = FUI_Loading.CreateInstance(FUIComponent.Instance);
            //    ui.Name = FUIPackage.Common_Loading;
            //    ui.self.sortingOrder = 9999;
            //    ui.MakeFullScreen();
            //}
            //progressAddAmount = 0.5f;
            //isShowing = true;
            //isEnd = false;
            //progress = 0;
            //ui.m_progress.value = 0;
            //FUIComponent.Instance.Add(ui, true);
        }
        public void AutoEnd()
        {
            if (!isAutoEnd)
                return;
            isShowing = false;
            //isEnd = true;
        }
        public void End()
        {
            isAutoEnd = true;
            isShowing = false;
            //isEnd = true;
        }
        internal void Update()
        {
            //if (isEnd)
            //{
            //    if (progress >= 100)
            //    {
            //        isEnd = false;
            //        ui.RemoveSelfNoDispose();
            //        return;
            //    }
            //    progress += UnityEngine.Random.Range(1.5f, 3f);
            //    if (progress >= 100) progress = 100;
            //    ui.m_progress.value = progress;
            //}
            //if (isShowing)
            //{
            //    if (progress > 99)
            //    {
            //        progress = 99;
            //        return;
            //    }
            //    if (progress <= 70)
            //    {
            //        progressAddAmount = UnityEngine.Random.Range(0.8f, 1.5f);
            //    }
            //    else if (progress >= 70 && progress <= 90)
            //    {
            //        progressAddAmount = UnityEngine.Random.Range(0.1f, 0.15f);
            //    }
            //    else if (progress >= 90)
            //    {
            //        progressAddAmount = UnityEngine.Random.Range(0.2f, 0.8f);
            //    }
            //    progress += progressAddAmount;
            //    ui.m_progress.value = progress;
            //}
        }
    }
}
