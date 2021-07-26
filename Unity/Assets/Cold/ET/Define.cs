using System.IO;
using ETCold;

namespace ETCold
{
	public static class Define
    {
        
        public class GlobalProto
        {
            public string AssetBundleServerUrl;
            public string Address;

            public string LocalAssetBundleServerUrl;
            public string LocalAddress;

            public bool isLocal;

            public bool isEditorMode;
            public bool isLua;

            public string ClientVersion;
            public string GetAddress()
            {
                return isLocal ? LocalAddress : Address;
            }
            public string GetUrl()
            {
                string url = isLocal ? LocalAssetBundleServerUrl : this.AssetBundleServerUrl;

                return url;
            }
        }
        public const int FrameRate = 60;

		public static bool IsEditorMode = true;


		public static bool IsLua = false;

        private const string path = "Assets/Res/Config/GlobalProto.txt";
        private static bool _CompileLua;
        public static bool CompileLua
        {
            get
            {
                _CompileLua = false;
                if (File.Exists(path))
                {
                    string str = File.ReadAllText(path);
                    GlobalProto globalProto= JsonHelper.FromJson<GlobalProto>(str);
                    _CompileLua= globalProto.isLua;
                }
                return _CompileLua;
            }
            set { _CompileLua = value; }
        }
    }
}