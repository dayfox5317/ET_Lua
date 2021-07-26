using System;
using System.Collections.Generic;

namespace ET
{
    public class GameKeyComponentAwakeSystem : AwakeSystem<GameKeyComponent>
    {
        public override void Awake(GameKeyComponent self)
        {
            GameKeyComponent.Instance = self;
        }
    }

    public class GameKeyComponent:Entity
    {
        public static GameKeyComponent Instance;

        public byte[] xorKey;
        public string key;
        public string keyIV;
    }
}
