using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_StopTestHandler : AMActorLocationHandler<Unit, C2M_StopTest>
    {
        protected override async ETTask Run(Unit unit, C2M_StopTest message)
        {
            Log.Debug("C2M_StopTest!!!!!!");
            await ETTask.CompletedTask;
        }
    }
}