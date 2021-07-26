using System;
using System.Linq;
public class ConfigBuilder
{
    public const string Config_Proto_Save_Path = "Bundles/Lua/pbc";
    public const string Config_Proto_File_Name = "config.proto.txt";


    [UnityEditor.MenuItem("Tools/Config/Convert Config to Proto")]
    private static void ConvertConfig2Proto()
    {
        var asms = System.AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.StartsWith("Unity."));
        var proto_base_type = typeof(ET.ProtoObject);
        var gen_method = typeof(ProtoBuf.Serializer).GetMethod("GetProto", new Type[] { });
        if (gen_method == null)
        {
            return;
        }
        var path = System.IO.Path.Combine(UnityEngine.Application.dataPath, Config_Proto_Save_Path, Config_Proto_File_Name);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine("package ET;");
        foreach (var item in asms)
        {
            foreach (var item_type in item.GetTypes())
            {
                if (item_type.BaseType == proto_base_type && item_type.FullName.EndsWith("Category"))
                {
                    var pb_method = gen_method.MakeGenericMethod(item_type).Invoke(null, new object[] { }) as string;

                    pb_method = pb_method.Substring(34);

                    sb.Append(pb_method);

                }

            }
        }
        System.IO.File.WriteAllText(path, sb.ToString());

        UnityEditor.AssetDatabase.Refresh();

    }
}
