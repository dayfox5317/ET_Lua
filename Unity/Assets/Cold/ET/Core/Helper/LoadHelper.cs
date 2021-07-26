using System.IO;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace ETCold
{
    public static class LoadHelper
    {

        public static string[] PreGetLuaScripts()
        {
#if UNITY_EDITOR
            return System.IO.Directory.GetFiles(Application.dataPath+"/Bundles/Lua/","*.txt", SearchOption.AllDirectories).Select(x=>x.Replace(Application.dataPath,"Assets")).ToArray();
#else
            return libx.Assets.GetAllAssetPaths().Where(x => x.StartsWith("Assets/Bundles/Lua")).ToArray();
#endif


        }
        public static UnityEngine.TextAsset[] LoadConfigs()
        {
            var files = libx.Assets.GetAllAssetPaths().Where(x => x.StartsWith("Assets/Bundles/Config/")).ToArray();
            TextAsset[] objects = new TextAsset[files.Length];
            for (int i = 0; i < objects.Length; i++)
            {
                TextAsset v = (TextAsset)libx.Assets.LoadAsset(files[i], typeof(TextAsset)).asset;
                v.name = files[i].Replace("Assets/Bundles/Config/", "");
                objects[i] = v;
            }
            return objects;
        }
        public static TextAsset LoadTextAsset(string path)
        {
#if UNITY_EDITOR
            if (Application.isEditor)
            {
                TextAsset resource = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path) as TextAsset;
                return resource;
            }
#endif
           
            var asd = libx.Assets.LoadAsset(path, typeof(TextAsset));

            if (!asd.asset)
            {

                string p = Path.Combine(PathHelper.LuaAssetPath, path);
                asd = libx.Assets.LoadAsset(p, typeof(TextAsset));
            }
          
            return asd.asset as TextAsset;
          
        }


        public static UnityEngine.Object LoadAssetAtPath(string assetPath)
        {
#if UNITY_EDITOR
            return AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(assetPath);
#else
            return default;
#endif
        }

        public static int GetAssetPathsFromAssetBundleCount(string assetBundleName)
        {
#if UNITY_EDITOR
            string[] resultArr = AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);
            return resultArr.Length;
#else
            return 0;
#endif
        }

        public static string[] GetAssetPathsFromAssetBundle(string assetBundleName)
        {
#if UNITY_EDITOR
            return AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);
#else
            return null;
#endif
        }


        public static int GetAssetBundleDependenciesCount(string assetBundleName, bool recursive)
        {
#if UNITY_EDITOR
            string[] result = AssetDatabase.GetAssetBundleDependencies(assetBundleName, recursive);
            return result.Length;
#else
            return 0;
#endif
        }


        public static string[] GetAssetBundleDependencies(string assetBundleName, bool recursive)
        {
#if UNITY_EDITOR
            return AssetDatabase.GetAssetBundleDependencies(assetBundleName, recursive);
#else

            return  null;

#endif

        }


        public static int GetanimationClipsLength(this Animator self)
        {
            return self.runtimeAnimatorController.animationClips.Length;
        }

        public static int GetAnimatorControllerParameterLength(this Animator self)
        {
            return self.parameters.Length;
        }


    }
}