using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
  public  class LuaRuntimeActivator
    {

        public static XLua.LuaTable CreateInstance(LuaRuntimeType type, params object[] args)
        {


          return  CreateInstance_raw(type.Target, args);


        }


        private static XLua.LuaFunction CreateInstance_func;
        public static XLua.LuaTable CreateInstance_raw(XLua.LuaTable target,params object[] args)
        {
            if (CreateInstance_func == null)
            {
                CreateInstance_func = Lua.Default.LuaEnv.DoString("return System.Activator.CreateInstance")[0] as XLua.LuaFunction;
            }

            //var vaargs = new object[args.Length + 1];
            //for (int  i = 1;  i < vaargs.Length;  i++)
            //{
            //    vaargs[i] = args[i - 1];
            //}
            var str = CreateInstance_func.CallSlow(target,args)[0];
            return str as XLua.LuaTable;
        }
    }
}
