using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
   partial class LuaRuntimeType
    {
        
        private static XLua.LuaFunction getAssemblyQualifiedName_func;
        public static  string getAssemblyQualifiedName_raw(XLua.LuaTable target)
        {
            if (getAssemblyQualifiedName_func == null)
            {
                getAssemblyQualifiedName_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetAssemblyQualifiedName")[0] as XLua.LuaFunction;
            }
          
            var str = getAssemblyQualifiedName_func.Call(target)[0];
            return str as string;          
        }
        private static XLua.LuaFunction getFullName_func;
        public static string getFullName_raw(XLua.LuaTable target)
        {
            if (getFullName_func == null)
            {
                getFullName_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetFullName")[0] as XLua.LuaFunction;
            }

            var str = getFullName_func.Call(target)[0];
            return str as string;
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
        private static XLua.LuaFunction getNamespace_func;
        public static string getNamespace_raw(XLua.LuaTable target)
        {
            if (getNamespace_func == null)
            {
                getNamespace_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetNamespace")[0] as XLua.LuaFunction;
            }

            var str = getNamespace_func.Call(target)[0];
            return str as string;
        }
        private static XLua.LuaFunction getBaseType_func;
        public static Type getBaseType_raw(XLua.LuaTable target)
        {
            if (getBaseType_func == null)
            {
                getBaseType_func = Lua.Default.LuaEnv.DoString("return ET.ReflectHelper.GetBaseType")[0] as XLua.LuaFunction;
            }

            var str = getBaseType_func.Call(target)[0];
            return LuaRuntimeAssembly.CreateFromLuaTable(str as XLua.LuaTable);
        }
    }
}
