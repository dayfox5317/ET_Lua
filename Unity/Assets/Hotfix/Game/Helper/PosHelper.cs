
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class PosHelper
    {
        public static Vector3 WorldToScreen(Vector3 position)
        {
            return new Vector3(position.x, Screen.height - position.y, position.z);
        }

        // internal static Vector2 WorldToUIPos(Vector3 headPoint)
        // { 
        //     // FGUI全局坐标转头顶血条本地坐标
        //     Vector3 screenPos = StageCamera.main.WorldToScreenPoint(headPoint);
        //     //原点位置转换
        //     screenPos.y = Screen.height - screenPos.y;
        //     Vector2 pt = GRoot.inst.GlobalToLocal(screenPos);
        //     return pt;
        // }
    }
}
