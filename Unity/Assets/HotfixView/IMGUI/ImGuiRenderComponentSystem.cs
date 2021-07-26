//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ImGuiNET;
//#if !UIMGUI_REMOVE_IMNODES
//using imnodesNET;
//#endif
//#if !UIMGUI_REMOVE_IMPLOT
//using ImPlotNET;
//using UImGui;

//#endif
//#if !UIMGUI_REMOVE_IMGUIZMO
//using ImGuizmoNET;
//#endif
//using UnityEngine;

//namespace ET
//{
//    [ObjectSystem]
//   public class ImGuiRenderComponentAwakeSystem:AwakeSystem<ImGuiRenderComponent>
//    {
//        public override void Awake(ImGuiRenderComponent self)
//        {
//            UImGuiUtility.Layout += self.OnLayout;
//        }
//    }
//	[ObjectSystem]
//	public class ImGuiRenderComponentDestroySystem : DestroySystem<ImGuiRenderComponent>
//	{
//		public override void Destroy(ImGuiRenderComponent self)
//		{
//			UImGuiUtility.Layout -= self.OnLayout;
//		}
//	}
//	public static class ImGuiRenderComponentMethods
//    {

//		public static string TestString = string.Empty;
//        public static void OnLayout(this  ImGuiRenderComponent component, UImGui.UImGui uImGui)
//        {
               

//#if !UIMGUI_REMOVE_IMNODES
//			if (ImGui.Begin("Nodes Window Sample"))
//			{
//				ImGui.SetNextWindowSize(Vector2.one * 300, ImGuiCond.Once);
//				imnodes.BeginNodeEditor();
//				imnodes.BeginNode(1);

//				imnodes.BeginNodeTitleBar();
//				ImGui.InputText("fyindex", ref TestString, 256);
//				ImGui.TextUnformatted("simple node :)");
//				imnodes.EndNodeTitleBar();

//				imnodes.BeginInputAttribute(2);
//				ImGui.Text("input");
//				imnodes.EndInputAttribute();

//				imnodes.BeginOutputAttribute(3);
//				ImGui.Indent(40);
//				ImGui.Text("output");
//				imnodes.EndOutputAttribute();

//				imnodes.EndNode();
//				imnodes.EndNodeEditor();
//				ImGui.End();
//			}
//#endif

//			ImGui.ShowDemoWindow();
//		}
//    }
//}
