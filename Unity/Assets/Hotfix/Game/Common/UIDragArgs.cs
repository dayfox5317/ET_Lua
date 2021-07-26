using System;
using System.Collections.Generic;

namespace ET
{
    public struct UIDragArgs
    {
        public enum UIType { None, Bag, Store, Skill }
        public int index;
        public UIType uiType;

        public static UIDragArgs Create(UIType uiType, int index)
        {
            //var args = ObjectPool.Instance.Fetch<UIDragArgs>();
            var args = new UIDragArgs();
            args.index = index;
            args.uiType = uiType;
            return args;
        }
        public void Release()
        {
            //ObjectPool.Instance.Recycle(this);
        }
    }
}
