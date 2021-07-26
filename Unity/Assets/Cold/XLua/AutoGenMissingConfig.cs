using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLua
{
   
   public class AutoGenMissingConfig
    {
      
        public List<string> types ;
        static string FilePath = UnityEngine.Application.dataPath + "/../Tools/AutoGenMissingConfig.txt";


     
        public AutoGenMissingConfig()
        {
            types = new List<string>();
        }
        //private static AutoGenMissingConfig __inst;
        //public static AutoGenMissingConfig Instance
        //{

        //    get
        //    {
        //        if (__inst == null)
        //        {
        //            __inst = Load();

        //            __inst.types = new List<string>();
        //        }
        //        return __inst;
        //    }
        //}
        public static AutoGenMissingConfig Load()
        {
            AutoGenMissingConfig cfg = null;
            if (System.IO.File.Exists(FilePath))
            {
               cfg = ETCold.JsonHelper.FromJson<AutoGenMissingConfig>(System.IO.File.ReadAllText(FilePath));

            }
            else
            {
                cfg = new AutoGenMissingConfig();
            }

            return cfg;

        }
        public void Save()
        {
           
              var json=  ETCold.JsonHelper.ToJson(this);
              System.IO.File.WriteAllText(FilePath, json);


        }
    
    }
}
