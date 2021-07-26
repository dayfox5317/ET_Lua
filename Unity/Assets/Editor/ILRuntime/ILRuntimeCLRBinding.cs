#if UNITY_EDITOR
using System.IO;
using ET;
using ILRuntime.Runtime.CLRBinding;
using UnityEditor;

public class ILRuntimeCLRBinding
{
    [MenuItem("Tools/ILRuntime/Generate CLR Binding")]
    static void GenerateCLRBindingByAnalysis()
    {
        //分析热更dll调用引用来生成绑定代码
        ILRuntime.Runtime.Enviorment.AppDomain domain = new ILRuntime.Runtime.Enviorment.AppDomain();
        using (FileStream fsHotfix = new FileStream("Library/ScriptAssemblies/Unity.ModelView.dll", FileMode.Open, FileAccess.Read))
        {
        //    domain.LoadAssemblyFile("Library/ScriptAssemblies/Unity.Cold.dll");
            domain.LoadAssembly(fsHotfix);
            ILHelper.InitILRuntime(domain);
            BindingCodeGenerator.GenerateBindingCode(domain, "Assets/Cold/ILRuntime/Generated");
        }

        AssetDatabase.Refresh();
    }
}
#endif