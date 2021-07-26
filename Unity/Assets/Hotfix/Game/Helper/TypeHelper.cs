using System.Reflection;
using ETCold;

namespace ET
{
	public class TypeHelper
	{
		public static void Init()
		{
#if __CSharpLua__
			InitByLua();
#else
			InitByMono();
#endif
		}

#if __CSharpLua__
		private static void InitByLua()
		{
			/*
			[[
			System.try(function()
                for k, v in pairs(ET) do
                    if v.__metadata__ and v.__metadata__.class then
                        ET.Game.getEventSystem():AddType(System.typeof(v))
                    end
                end
            end, function(default)
                local _e = default
                ET.Log.Error1(_e)
            end)
			]]
			*/
		}
#else
		private static void InitByMono()
		{

		//	Game.EventSystem.AddRangeType(ET.Hotfix.Instance.GetHotfixTypes());
			// ET.JsonHelper.LookupTypes(Game.EventSystem.GetAllType());
		}
#endif



		public static string Type_GetFullName(System.Type type)
        {

			return type.FullName;
        }
	}
}