
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
   public class LuaRuntimeMemberInfo
    {
        private static XLua.LuaFunction getMemberInfoType_func;
        public static int getMemberInfoType_raw(XLua.LuaTable target)
        {
            if (getMemberInfoType_func == null)
            {
                getMemberInfoType_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetMemberInfoType")[0] as XLua.LuaFunction;
            }
            var df = getMemberInfoType_func.Call(target)[0];

            
          
            return Convert.ToInt32(df) ;
        }
        private static XLua.LuaFunction getName_func;
        public static string getName_raw(XLua.LuaTable target)
        {
            if (getName_func == null)
            {
                getName_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetName")[0] as XLua.LuaFunction;
            }

            var str = getName_func.Call(target)[0];
            return str as string;
        }
        private static XLua.LuaFunction getValue_func;
        public static object getValue_raw(object target_fieldinfo, object target)
        {
            if (getValue_func == null)
            {
                getValue_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetValue")[0] as XLua.LuaFunction;
            }

            var str = getValue_func.Call(target_fieldinfo, target)[0];
            return str;
        }
        private static XLua.LuaFunction setValue_func;
        public static void setValue_raw(object target_fieldinfo, object target, object value)
        {
            if (setValue_func == null)
            {
                setValue_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.SetValue")[0] as XLua.LuaFunction;
            }

            setValue_func.Call(target_fieldinfo, target, value);

        }
        private static XLua.LuaFunction getFieldType_func;
        public static Type getFieldType_raw(XLua.LuaTable target)
        {
            if (getFieldType_func == null)
            {
                getFieldType_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetFieldType")[0] as XLua.LuaFunction;
            }

            var str = getFieldType_func.Call(target)[0];
            return LuaRuntimeAssembly.CreateFromLuaTable(str as XLua.LuaTable);
        }
        private static XLua.LuaFunction getDeclaringType_func;
        public static Type getDeclaringType_raw(XLua.LuaTable target)
        {
            if (getDeclaringType_func == null)
            {
                getDeclaringType_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetDeclaringType")[0] as XLua.LuaFunction;
            }

            var str = getFieldType_func.Call(target)[0];
            return LuaRuntimeAssembly.CreateFromLuaTable(str as XLua.LuaTable);
        }

        private static XLua.LuaFunction invoke_func;
        public static object invoke_raw(object info,object target, params object[] args)
        {
            if (invoke_func == null)
            {
                invoke_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.Invoke")[0] as XLua.LuaFunction;
            }

            var vaargs = new object[args.Length + 1];
            vaargs[0] = target;
            for (int i = 0; i < vaargs.Length; i++)
            {
                vaargs[i + 1] = args[i];
            }
          
            var rts = invoke_func.CallSlow(target, vaargs);
            if (rts.Length > 1)
            {
                return rts;
            }
           return rts[0];
        
        }
    }
}
