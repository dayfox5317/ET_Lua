//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年4月29日 18:22:11
//------------------------------------------------------------

using ET;
using UnityEditor;

public class ILRuntimeCrossAdaptorGenerate
{
    [MenuItem("Tools/ILRuntime/Generate CrossAdaptor")]
    static void CrossAdaptorGenerate()
    {
        //由于跨域继承特殊性太多，自动生成无法实现完全无副作用生成，所以这里提供的代码自动生成主要是给大家生成个初始模版，简化大家的工作
        //大多数情况直接使用自动生成的模版即可，如果遇到问题可以手动去修改生成后的文件，因此这里需要大家自行处理是否覆盖的问题
        //已知问题：
        //不支持Attribute的自动生成
        using (System.IO.StreamWriter sw =
                new System.IO.StreamWriter("Assets/Cold/ILRuntime/AttributeAdaptor.cs"))
        {
            sw.WriteLine(ILRuntime.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(typeof (System.Attribute),
                "ET"));
            
        }

        AssetDatabase.Refresh();
    }
}