using System;
using System.Collections.Generic;

namespace ET
{
    public static class ClassHelper
    {
        public static T As<T>(this object obj) where T : class
        {
            if (obj == null)
            {
                Log.Warning($"obj == null");
                return null;
            }
            T t = obj as T;
            if (t == null)
            {
                Log.Error($"the cast of type :{obj.GetType()} to {typeof(T)} is invalid");
            }
            return t;
        }
    }
}
