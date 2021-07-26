using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UILobbyComponentAwakeSystem : AwakeSystem<UILobbyComponent>
    {
        public override void Awake(UILobbyComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent(typeof(ReferenceCollector)) as ReferenceCollector;
			
            self.enterMap = (GameObject) rc.GetObject("EnterMap");
            Button enterMapButton = (self.enterMap.GetComponent( typeof(Button)) as Button);
            enterMapButton.onClick.AddListener(()=> { self.EnterMap(); });
            self.text = (rc.GetObject("Text") as GameObject).GetComponent(typeof(Text)) as Text;
        }
    }
    
    public static class UILobbyComponentSystem
    {
        public static void EnterMap(this UILobbyComponent self)
        {
            MapHelper.EnterMapAsync(self.ZoneScene(), "Map").Coroutine();
        }
    }
}
