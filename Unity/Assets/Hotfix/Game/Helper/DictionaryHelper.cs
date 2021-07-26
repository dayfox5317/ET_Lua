using System;
using System.Collections.Generic;

namespace ET
{
    public static class DictionaryHelper
    {
        public static bool TryAddKV<K,V>(this Dictionary<K,V> self,K k,V v)
        {
            if (self.ContainsKey(k))
                return false;
            self.Add(k, v);
            return true;
        }
    }
}
