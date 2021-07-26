using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
    public class LuaRuntimeModule : System.Reflection.Module
    {
        private static LuaRuntimeModule m_LuaRuntimeModule;

        public static LuaRuntimeModule GetRuntimeModule()
        {
            if (m_LuaRuntimeModule == null)
            {
                m_LuaRuntimeModule = new LuaRuntimeModule();
            }
            return m_LuaRuntimeModule;
        }
    }
   public class LuaRuntimeAssembly
    {


        private static LuaRuntimeAssembly luaRuntimeAssembly;

        public static LuaRuntimeAssembly GetRuntimeAssembly()
        {
            if (luaRuntimeAssembly == null)
            {
                luaRuntimeAssembly = new LuaRuntimeAssembly();
            }
            return luaRuntimeAssembly;
        }

      

        private static  Dictionary<XLua.LuaTable,LuaRuntimeType> types = new Dictionary<XLua.LuaTable, LuaRuntimeType>();
        public static LuaRuntimeType CreateFromLuaTable(XLua.LuaTable table)
        {
            if (table == null) return null;
            if (types.TryGetValue(table,out LuaRuntimeType type))
            {
                return type;
            }
            return types[table] = new LuaRuntimeType(table);
        }
        public static LuaRuntimeType CreateFromFullName(string fullName)
        {
            var table = Lua.Default.LuaEnv.DoString($"return System.typeof({fullName})")[0] as XLua.LuaTable;

         //   var table = Lua.Default.LuaEnv.Global.Get<XLua.LuaTable>("ET.Game");
            return CreateFromLuaTable(table);
        }

    }
}
