using System;
using System.Collections.Generic;

namespace ET
{
    public static class LuaJsonHelper
    {
        public static T LuaTableToCSType<T>(this System.Object t)
        {
#if __CSharpLua__
            T ret =  default;
            /*
            [[
            ret = setmetatable(t,T)
            ]]
            */
            return ret;
#else
            return (T)t;
#endif
        }
    }
}
