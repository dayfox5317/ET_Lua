using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLua;

namespace ETCold
{
   public static class ArrayHelper
    {
        public static void Test(object array)
        {

      //      Lua.Default.LuaEnv.DoString("",array)
            if(array is XLua.LuaTable table)
            {
                var type = table.Cast<LuaTable[]>()[0];
                var str = type.Cast<Dictionary<object, object>>();
              //  str["A"] = 2012;
             // type.SetMetaTable
                type.Set("A", 2012);
                var pw =(LuaFunction)str["InvokeWrap"];
                pw.Call("a", 1, "c");
                
            //    var t1=(LuaTable)type["c"];
            //   var func = type.Cast<Dictionary<object, object>>();
            //  //  var t2 = t1.Cast<LuaTable[]>()[0];
            //  //  var t3 = t2.Cast<LuaTable[]>()[0];

                //    //   ForEachLuaTable0(array);
            }
        }
        private static void ForEachLuaTable0(object array)
        {


            if (array is XLua.LuaTable table)
            {
                table.ForEach((object x, object y) =>
                {

                    ForEachLuaTable(x, y);

                });
            }
        }
        private static void ForEachLuaTable(object x, object y)
        {
            UnityEngine.Debug.Log($"KEY:{x}({x.GetType()}) VALUE:{y}({y.GetType()})");

            ForEachLuaTable0(y);
        }
        public static int GetLength(Array array)
        {
            return array.Length;
        }
        public static string GetStringItem(string[] array,int index)
        {
            if (index >= array.Length)
                return default;
            return array[index];
        }
        public static UnityEngine.Object GetUnityObjectItem(UnityEngine.Object[] array, int index)
        {
            if (index >= array.Length)
                return default;
            return array[index];
        }
        public static System.Reflection.MemberInfo GetMemberItem(System.Reflection.MemberInfo[] array, int index)
        {
            if (index >= array.Length)
                return default;
            return array[index];
        }
        public static RawMemberInfo GetRawMemberItem(RawMemberInfo[] array, int index)
        {
            if (index >= array.Length)
                return default;
            return array[index];
        }
    }
}
