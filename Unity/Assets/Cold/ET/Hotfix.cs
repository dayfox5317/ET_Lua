//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年4月28日 11:11:32
//------------------------------------------------------------
#define ILRUNTIME
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using ILRuntime.Runtime.Enviorment;
using System.Collections;

namespace ET
{
    public class Hotfix
    {
        static Hotfix __inst;
        public static Hotfix Instance
        {

            get
            {
                if (__inst == null)
                {
                    __inst = new Hotfix();
                }
                return __inst;
            }
        }
#if ILRUNTIME
		private ILRuntime.Runtime.Enviorment.AppDomain s_appDomain;
    //    private ILRuntime.Runtime.Enviorment.AppDomain s_view_appDomain;

        private MemoryStream s_hotfixDllStream;
		private MemoryStream s_hotfixPdbStream;
        private MemoryStream s_hotfixViewDllStream;
        private MemoryStream s_hotfixViewPdbStream;
#else
        private Assembly s_hotfixAssembly;
        private Assembly s_hotfixViewAssembly;
#endif

        public IStaticMethod s_hotfixInit;
        private List<Type> s_hotfixTypes;
        private List<Type> s_hotfixViewTypes;

        public Action HotfixUpdate;
        public Action LateUpdate;

        public IEnumerator GotoHotfix()
        {
#if ILRUNTIME
			ILHelper.InitILRuntime(s_appDomain);
            // ILHelper.InitILRuntime(s_view_appDomain);

#endif
          

            var mb = MessageBox.Show("调试", "是否进入IL_Debug");

            //r.onComplete = (x) =>
            //{
            //    //s_appDomain.DebugService.StartDebugService(56000);
            //  //  s_hotfixInit.Run();

            //};
            s_appDomain.DebugService.StartDebugService(56000);

            //yield return mb;
            //if (mb.isOk)
            //{
            //    s_hotfixInit.Run();
            //}
            //else
            {
            //    s_hotfixInit.Run();
            }

            yield break;


        }

        public List<Type> GetHotfixTypes()
        {
            return s_hotfixTypes;
        }
#if ILRUNTIME
        public ILRuntime.Runtime.Enviorment.AppDomain GetAppDomain()
        {
            return s_appDomain;
        }
#endif
        public List<Type> GetHotfixViewTypes()
        {
            return s_hotfixViewTypes;
        }

        public void LoadHotfixAssembly()
        {


            var hotfix= libx.Assets.LoadAsset("Assets/Bundles/Code/HotfixCombine.dll.bytes", typeof(TextAsset)).asset as TextAsset;
            var hotfix_pdb= libx.Assets.LoadAsset("Assets/Bundles/Code/HotfixCombine.pdb.bytes", typeof(TextAsset)).asset as TextAsset;
            byte[] hotfixAssBytes = hotfix.bytes;// code.GetComponent<ReferenceCollector>().Get<TextAsset>("Hotfix.dll").bytes;
            byte[] hotfixPdbBytes = hotfix_pdb.bytes;// code.GetComponent<ReferenceCollector>().Get<TextAsset>("Hotfix.pdb").bytes;
            // byte[] hotfixViewAssBytes = code.GetComponent<ReferenceCollector>().Get<TextAsset>("HotfixView.dll").bytes;
            // byte[] hotfixViewPdbBytes = code.GetComponent<ReferenceCollector>().Get<TextAsset>("HotfixView.pdb").bytes;


			UnityEngine.Debug.Log($"当前使用的是ILRuntime模式");
			s_appDomain = new ILRuntime.Runtime.Enviorment.AppDomain();
       //     s_view_appDomain = new ILRuntime.Runtime.Enviorment.AppDomain();

            s_hotfixDllStream = new MemoryStream(hotfixAssBytes);
			s_hotfixPdbStream = new MemoryStream(hotfixPdbBytes);
			
			 //s_hotfixViewDllStream = new MemoryStream(hotfixViewAssBytes);
			 //s_hotfixViewPdbStream = new MemoryStream(hotfixViewPdbBytes);
			
			s_appDomain.LoadAssembly(s_hotfixDllStream, s_hotfixPdbStream, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
         //   s_view_appDomain.LoadAssembly(s_hotfixViewDllStream, s_hotfixViewPdbStream, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());

			s_hotfixInit = new ILStaticMethod(s_appDomain, "ET.Init", "Start", 0);
			
		
           // foreach (var item in s_view_appDomain.LoadedTypes)
           // {
           ////     s_appDomain.LoadedTypes[item.Key] = item.Value;
           // }
            s_hotfixTypes = s_appDomain.LoadedTypes.Values.Select(x => x.ReflectionType).ToList();
       //     s_hotfixViewTypes = s_view_appDomain.LoadedTypes.Values.Select(x => x.ReflectionType).ToList();
            


        


       //     Merge();
        }


      
    }
}