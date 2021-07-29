#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;


namespace XLua
{
    public partial class ObjectTranslator
    {
        
        class IniterAdderUnityEngineVector2
        {
            static IniterAdderUnityEngineVector2()
            {
                LuaEnv.AddIniter(Init);
            }
			
			static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
			
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector2>(translator.PushUnityEngineVector2, translator.Get, translator.UpdateUnityEngineVector2);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector3>(translator.PushUnityEngineVector3, translator.Get, translator.UpdateUnityEngineVector3);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector4>(translator.PushUnityEngineVector4, translator.Get, translator.UpdateUnityEngineVector4);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Color>(translator.PushUnityEngineColor, translator.Get, translator.UpdateUnityEngineColor);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Quaternion>(translator.PushUnityEngineQuaternion, translator.Get, translator.UpdateUnityEngineQuaternion);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Ray>(translator.PushUnityEngineRay, translator.Get, translator.UpdateUnityEngineRay);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Bounds>(translator.PushUnityEngineBounds, translator.Get, translator.UpdateUnityEngineBounds);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Ray2D>(translator.PushUnityEngineRay2D, translator.Get, translator.UpdateUnityEngineRay2D);
				translator.RegisterPushAndGetAndUpdate<System.Net.Sockets.AddressFamily>(translator.PushSystemNetSocketsAddressFamily, translator.Get, translator.UpdateSystemNetSocketsAddressFamily);
				translator.RegisterPushAndGetAndUpdate<System.Net.Sockets.SocketType>(translator.PushSystemNetSocketsSocketType, translator.Get, translator.UpdateSystemNetSocketsSocketType);
				translator.RegisterPushAndGetAndUpdate<System.Net.Sockets.ProtocolType>(translator.PushSystemNetSocketsProtocolType, translator.Get, translator.UpdateSystemNetSocketsProtocolType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RectTransform.Axis>(translator.PushUnityEngineRectTransformAxis, translator.Get, translator.UpdateUnityEngineRectTransformAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RectTransform.Edge>(translator.PushUnityEngineRectTransformEdge, translator.Get, translator.UpdateUnityEngineRectTransformEdge);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Selectable.Transition>(translator.PushUnityEngineUISelectableTransition, translator.Get, translator.UpdateUnityEngineUISelectableTransition);
				translator.RegisterPushAndGetAndUpdate<System.IO.SeekOrigin>(translator.PushSystemIOSeekOrigin, translator.Get, translator.UpdateSystemIOSeekOrigin);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Texture2D.EXRFlags>(translator.PushUnityEngineTexture2DEXRFlags, translator.Get, translator.UpdateUnityEngineTexture2DEXRFlags);
				translator.RegisterPushAndGetAndUpdate<libx.LoadState>(translator.PushlibxLoadState, translator.Get, translator.UpdatelibxLoadState);
				translator.RegisterPushAndGetAndUpdate<libx.VerifyBy>(translator.PushlibxVerifyBy, translator.Get, translator.UpdatelibxVerifyBy);
				translator.RegisterPushAndGetAndUpdate<Battlehub.UIControls.ItemDropAction>(translator.PushBattlehubUIControlsItemDropAction, translator.Get, translator.UpdateBattlehubUIControlsItemDropAction);
				translator.RegisterPushAndGetAndUpdate<Battlehub.UIControls.VirtualizingMode>(translator.PushBattlehubUIControlsVirtualizingMode, translator.Get, translator.UpdateBattlehubUIControlsVirtualizingMode);
				translator.RegisterPushAndGetAndUpdate<Battlehub.UIControls.DockPanels.RegionSplitType>(translator.PushBattlehubUIControlsDockPanelsRegionSplitType, translator.Get, translator.UpdateBattlehubUIControlsDockPanelsRegionSplitType);
				translator.RegisterPushAndGetAndUpdate<Battlehub.Utils.KnownCursor>(translator.PushBattlehubUtilsKnownCursor, translator.Get, translator.UpdateBattlehubUtilsKnownCursor);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.BlendMode>(translator.PushFairyGUIBlendMode, translator.Get, translator.UpdateFairyGUIBlendMode);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.HitTestMode>(translator.PushFairyGUIHitTestMode, translator.Get, translator.UpdateFairyGUIHitTestMode);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.MaterialFlags>(translator.PushFairyGUIMaterialFlags, translator.Get, translator.UpdateFairyGUIMaterialFlags);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.DestroyMethod>(translator.PushFairyGUIDestroyMethod, translator.Get, translator.UpdateFairyGUIDestroyMethod);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.EaseType>(translator.PushFairyGUIEaseType, translator.Get, translator.UpdateFairyGUIEaseType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.TweenPropType>(translator.PushFairyGUITweenPropType, translator.Get, translator.UpdateFairyGUITweenPropType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.PackageItemType>(translator.PushFairyGUIPackageItemType, translator.Get, translator.UpdateFairyGUIPackageItemType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ObjectType>(translator.PushFairyGUIObjectType, translator.Get, translator.UpdateFairyGUIObjectType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.AlignType>(translator.PushFairyGUIAlignType, translator.Get, translator.UpdateFairyGUIAlignType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.VertAlignType>(translator.PushFairyGUIVertAlignType, translator.Get, translator.UpdateFairyGUIVertAlignType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.OverflowType>(translator.PushFairyGUIOverflowType, translator.Get, translator.UpdateFairyGUIOverflowType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.FillType>(translator.PushFairyGUIFillType, translator.Get, translator.UpdateFairyGUIFillType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.AutoSizeType>(translator.PushFairyGUIAutoSizeType, translator.Get, translator.UpdateFairyGUIAutoSizeType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ScrollType>(translator.PushFairyGUIScrollType, translator.Get, translator.UpdateFairyGUIScrollType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ScrollBarDisplayType>(translator.PushFairyGUIScrollBarDisplayType, translator.Get, translator.UpdateFairyGUIScrollBarDisplayType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.RelationType>(translator.PushFairyGUIRelationType, translator.Get, translator.UpdateFairyGUIRelationType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ListLayoutType>(translator.PushFairyGUIListLayoutType, translator.Get, translator.UpdateFairyGUIListLayoutType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ListSelectionMode>(translator.PushFairyGUIListSelectionMode, translator.Get, translator.UpdateFairyGUIListSelectionMode);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ProgressTitleType>(translator.PushFairyGUIProgressTitleType, translator.Get, translator.UpdateFairyGUIProgressTitleType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ButtonMode>(translator.PushFairyGUIButtonMode, translator.Get, translator.UpdateFairyGUIButtonMode);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.TransitionActionType>(translator.PushFairyGUITransitionActionType, translator.Get, translator.UpdateFairyGUITransitionActionType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.GroupLayoutType>(translator.PushFairyGUIGroupLayoutType, translator.Get, translator.UpdateFairyGUIGroupLayoutType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ChildrenRenderOrder>(translator.PushFairyGUIChildrenRenderOrder, translator.Get, translator.UpdateFairyGUIChildrenRenderOrder);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.PopupDirection>(translator.PushFairyGUIPopupDirection, translator.Get, translator.UpdateFairyGUIPopupDirection);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.FlipType>(translator.PushFairyGUIFlipType, translator.Get, translator.UpdateFairyGUIFlipType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.FillMethod>(translator.PushFairyGUIFillMethod, translator.Get, translator.UpdateFairyGUIFillMethod);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.OriginHorizontal>(translator.PushFairyGUIOriginHorizontal, translator.Get, translator.UpdateFairyGUIOriginHorizontal);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.OriginVertical>(translator.PushFairyGUIOriginVertical, translator.Get, translator.UpdateFairyGUIOriginVertical);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.Origin90>(translator.PushFairyGUIOrigin90, translator.Get, translator.UpdateFairyGUIOrigin90);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.Origin180>(translator.PushFairyGUIOrigin180, translator.Get, translator.UpdateFairyGUIOrigin180);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.Origin360>(translator.PushFairyGUIOrigin360, translator.Get, translator.UpdateFairyGUIOrigin360);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.FocusRule>(translator.PushFairyGUIFocusRule, translator.Get, translator.UpdateFairyGUIFocusRule);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.FitScreen>(translator.PushFairyGUIFitScreen, translator.Get, translator.UpdateFairyGUIFitScreen);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.Utils.HtmlElementType>(translator.PushFairyGUIUtilsHtmlElementType, translator.Get, translator.UpdateFairyGUIUtilsHtmlElementType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.Utils.XMLTagType>(translator.PushFairyGUIUtilsXMLTagType, translator.Get, translator.UpdateFairyGUIUtilsXMLTagType);
				translator.RegisterPushAndGetAndUpdate<ETCold.DebugType>(translator.PushETColdDebugType, translator.Get, translator.UpdateETColdDebugType);
				translator.RegisterPushAndGetAndUpdate<ETCold.UILayer>(translator.PushETColdUILayer, translator.Get, translator.UpdateETColdUILayer);
				translator.RegisterPushAndGetAndUpdate<ET.AwaiterStatus>(translator.PushETAwaiterStatus, translator.Get, translator.UpdateETAwaiterStatus);
				translator.RegisterPushAndGetAndUpdate<MessageBox.EventId>(translator.PushMessageBoxEventId, translator.Get, translator.UpdateMessageBoxEventId);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.RTLSupport.DirectionType>(translator.PushFairyGUIRTLSupportDirectionType, translator.Get, translator.UpdateFairyGUIRTLSupportDirectionType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.TextFormat.SpecialStyle>(translator.PushFairyGUITextFormatSpecialStyle, translator.Get, translator.UpdateFairyGUITextFormatSpecialStyle);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.GPathPoint.CurveType>(translator.PushFairyGUIGPathPointCurveType, translator.Get, translator.UpdateFairyGUIGPathPointCurveType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.ControllerAction.ActionType>(translator.PushFairyGUIControllerActionActionType, translator.Get, translator.UpdateFairyGUIControllerActionActionType);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.UIConfig.ConfigKey>(translator.PushFairyGUIUIConfigConfigKey, translator.Get, translator.UpdateFairyGUIUIConfigConfigKey);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.UIContentScaler.ScaleMode>(translator.PushFairyGUIUIContentScalerScaleMode, translator.Get, translator.UpdateFairyGUIUIContentScalerScaleMode);
				translator.RegisterPushAndGetAndUpdate<FairyGUI.UIContentScaler.ScreenMatchMode>(translator.PushFairyGUIUIContentScalerScreenMatchMode, translator.Get, translator.UpdateFairyGUIUIContentScalerScreenMatchMode);
				translator.RegisterPushAndGetAndUpdate<System.Net.Sockets.SocketAsyncOperation>(translator.PushSystemNetSocketsSocketAsyncOperation, translator.Get, translator.UpdateSystemNetSocketsSocketAsyncOperation);
				translator.RegisterPushAndGetAndUpdate<System.Net.Sockets.SocketError>(translator.PushSystemNetSocketsSocketError, translator.Get, translator.UpdateSystemNetSocketsSocketError);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasUpdate>(translator.PushUnityEngineUICanvasUpdate, translator.Get, translator.UpdateUnityEngineUICanvasUpdate);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EventSystems.EventHandle>(translator.PushUnityEngineEventSystemsEventHandle, translator.Get, translator.UpdateUnityEngineEventSystemsEventHandle);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EventSystems.EventTriggerType>(translator.PushUnityEngineEventSystemsEventTriggerType, translator.Get, translator.UpdateUnityEngineEventSystemsEventTriggerType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EventSystems.MoveDirection>(translator.PushUnityEngineEventSystemsMoveDirection, translator.Get, translator.UpdateUnityEngineEventSystemsMoveDirection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GraphicRaycaster.BlockingObjects>(translator.PushUnityEngineUIGraphicRaycasterBlockingObjects, translator.Get, translator.UpdateUnityEngineUIGraphicRaycasterBlockingObjects);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Type>(translator.PushUnityEngineUIImageType, translator.Get, translator.UpdateUnityEngineUIImageType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.FillMethod>(translator.PushUnityEngineUIImageFillMethod, translator.Get, translator.UpdateUnityEngineUIImageFillMethod);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.OriginHorizontal>(translator.PushUnityEngineUIImageOriginHorizontal, translator.Get, translator.UpdateUnityEngineUIImageOriginHorizontal);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.OriginVertical>(translator.PushUnityEngineUIImageOriginVertical, translator.Get, translator.UpdateUnityEngineUIImageOriginVertical);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin90>(translator.PushUnityEngineUIImageOrigin90, translator.Get, translator.UpdateUnityEngineUIImageOrigin90);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin180>(translator.PushUnityEngineUIImageOrigin180, translator.Get, translator.UpdateUnityEngineUIImageOrigin180);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin360>(translator.PushUnityEngineUIImageOrigin360, translator.Get, translator.UpdateUnityEngineUIImageOrigin360);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.ContentType>(translator.PushUnityEngineUIInputFieldContentType, translator.Get, translator.UpdateUnityEngineUIInputFieldContentType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.InputType>(translator.PushUnityEngineUIInputFieldInputType, translator.Get, translator.UpdateUnityEngineUIInputFieldInputType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.CharacterValidation>(translator.PushUnityEngineUIInputFieldCharacterValidation, translator.Get, translator.UpdateUnityEngineUIInputFieldCharacterValidation);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.InputField.LineType>(translator.PushUnityEngineUIInputFieldLineType, translator.Get, translator.UpdateUnityEngineUIInputFieldLineType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.AspectRatioFitter.AspectMode>(translator.PushUnityEngineUIAspectRatioFitterAspectMode, translator.Get, translator.UpdateUnityEngineUIAspectRatioFitterAspectMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasScaler.ScaleMode>(translator.PushUnityEngineUICanvasScalerScaleMode, translator.Get, translator.UpdateUnityEngineUICanvasScalerScaleMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasScaler.ScreenMatchMode>(translator.PushUnityEngineUICanvasScalerScreenMatchMode, translator.Get, translator.UpdateUnityEngineUICanvasScalerScreenMatchMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.CanvasScaler.Unit>(translator.PushUnityEngineUICanvasScalerUnit, translator.Get, translator.UpdateUnityEngineUICanvasScalerUnit);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.ContentSizeFitter.FitMode>(translator.PushUnityEngineUIContentSizeFitterFitMode, translator.Get, translator.UpdateUnityEngineUIContentSizeFitterFitMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GridLayoutGroup.Corner>(translator.PushUnityEngineUIGridLayoutGroupCorner, translator.Get, translator.UpdateUnityEngineUIGridLayoutGroupCorner);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GridLayoutGroup.Axis>(translator.PushUnityEngineUIGridLayoutGroupAxis, translator.Get, translator.UpdateUnityEngineUIGridLayoutGroupAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.GridLayoutGroup.Constraint>(translator.PushUnityEngineUIGridLayoutGroupConstraint, translator.Get, translator.UpdateUnityEngineUIGridLayoutGroupConstraint);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Navigation.Mode>(translator.PushUnityEngineUINavigationMode, translator.Get, translator.UpdateUnityEngineUINavigationMode);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.ScrollRect.MovementType>(translator.PushUnityEngineUIScrollRectMovementType, translator.Get, translator.UpdateUnityEngineUIScrollRectMovementType);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.ScrollRect.ScrollbarVisibility>(translator.PushUnityEngineUIScrollRectScrollbarVisibility, translator.Get, translator.UpdateUnityEngineUIScrollRectScrollbarVisibility);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Scrollbar.Direction>(translator.PushUnityEngineUIScrollbarDirection, translator.Get, translator.UpdateUnityEngineUIScrollbarDirection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Slider.Direction>(translator.PushUnityEngineUISliderDirection, translator.Get, translator.UpdateUnityEngineUISliderDirection);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Toggle.ToggleTransition>(translator.PushUnityEngineUIToggleToggleTransition, translator.Get, translator.UpdateUnityEngineUIToggleToggleTransition);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EventSystems.PointerEventData.InputButton>(translator.PushUnityEngineEventSystemsPointerEventDataInputButton, translator.Get, translator.UpdateUnityEngineEventSystemsPointerEventDataInputButton);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.EventSystems.PointerEventData.FramePressState>(translator.PushUnityEngineEventSystemsPointerEventDataFramePressState, translator.Get, translator.UpdateUnityEngineEventSystemsPointerEventDataFramePressState);
			
			}
        }
        
        static IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj = new IniterAdderUnityEngineVector2();
        static IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj {get{return s_IniterAdderUnityEngineVector2_dumb_obj;}}
        
        
        int UnityEngineVector2_TypeID = -1;
        public void PushUnityEngineVector2(RealStatePtr L, UnityEngine.Vector2 val)
        {
            if (UnityEngineVector2_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector2_TypeID = getTypeId(L, typeof(UnityEngine.Vector2), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 8, UnityEngineVector2_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector2 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector2 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector2_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector2");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector2)objectCasters.GetCaster(typeof(UnityEngine.Vector2))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector2(RealStatePtr L, int index, UnityEngine.Vector2 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector2_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector2 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector3_TypeID = -1;
        public void PushUnityEngineVector3(RealStatePtr L, UnityEngine.Vector3 val)
        {
            if (UnityEngineVector3_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector3_TypeID = getTypeId(L, typeof(UnityEngine.Vector3), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 12, UnityEngineVector3_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector3 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector3 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector3_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector3");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector3)objectCasters.GetCaster(typeof(UnityEngine.Vector3))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector3(RealStatePtr L, int index, UnityEngine.Vector3 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector3_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector3 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector4_TypeID = -1;
        public void PushUnityEngineVector4(RealStatePtr L, UnityEngine.Vector4 val)
        {
            if (UnityEngineVector4_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector4_TypeID = getTypeId(L, typeof(UnityEngine.Vector4), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineVector4_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector4 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector4 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector4_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector4");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector4)objectCasters.GetCaster(typeof(UnityEngine.Vector4))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector4(RealStatePtr L, int index, UnityEngine.Vector4 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector4_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector4 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineColor_TypeID = -1;
        public void PushUnityEngineColor(RealStatePtr L, UnityEngine.Color val)
        {
            if (UnityEngineColor_TypeID == -1)
            {
			    bool is_first;
                UnityEngineColor_TypeID = getTypeId(L, typeof(UnityEngine.Color), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineColor_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Color ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Color val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Color");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Color");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Color)objectCasters.GetCaster(typeof(UnityEngine.Color))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineColor(RealStatePtr L, int index, UnityEngine.Color val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Color");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Color ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineQuaternion_TypeID = -1;
        public void PushUnityEngineQuaternion(RealStatePtr L, UnityEngine.Quaternion val)
        {
            if (UnityEngineQuaternion_TypeID == -1)
            {
			    bool is_first;
                UnityEngineQuaternion_TypeID = getTypeId(L, typeof(UnityEngine.Quaternion), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineQuaternion_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Quaternion ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Quaternion val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQuaternion_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Quaternion");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Quaternion)objectCasters.GetCaster(typeof(UnityEngine.Quaternion))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineQuaternion(RealStatePtr L, int index, UnityEngine.Quaternion val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQuaternion_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Quaternion ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRay_TypeID = -1;
        public void PushUnityEngineRay(RealStatePtr L, UnityEngine.Ray val)
        {
            if (UnityEngineRay_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRay_TypeID = getTypeId(L, typeof(UnityEngine.Ray), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 24, UnityEngineRay_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Ray ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Ray val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Ray");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Ray)objectCasters.GetCaster(typeof(UnityEngine.Ray))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRay(RealStatePtr L, int index, UnityEngine.Ray val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Ray ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineBounds_TypeID = -1;
        public void PushUnityEngineBounds(RealStatePtr L, UnityEngine.Bounds val)
        {
            if (UnityEngineBounds_TypeID == -1)
            {
			    bool is_first;
                UnityEngineBounds_TypeID = getTypeId(L, typeof(UnityEngine.Bounds), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 24, UnityEngineBounds_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Bounds ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Bounds val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBounds_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Bounds");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Bounds)objectCasters.GetCaster(typeof(UnityEngine.Bounds))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineBounds(RealStatePtr L, int index, UnityEngine.Bounds val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBounds_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Bounds ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRay2D_TypeID = -1;
        public void PushUnityEngineRay2D(RealStatePtr L, UnityEngine.Ray2D val)
        {
            if (UnityEngineRay2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRay2D_TypeID = getTypeId(L, typeof(UnityEngine.Ray2D), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineRay2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Ray2D ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Ray2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Ray2D");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Ray2D)objectCasters.GetCaster(typeof(UnityEngine.Ray2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRay2D(RealStatePtr L, int index, UnityEngine.Ray2D val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Ray2D ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int SystemNetSocketsAddressFamily_TypeID = -1;
		int SystemNetSocketsAddressFamily_EnumRef = -1;
        
        public void PushSystemNetSocketsAddressFamily(RealStatePtr L, System.Net.Sockets.AddressFamily val)
        {
            if (SystemNetSocketsAddressFamily_TypeID == -1)
            {
			    bool is_first;
                SystemNetSocketsAddressFamily_TypeID = getTypeId(L, typeof(System.Net.Sockets.AddressFamily), out is_first);
				
				if (SystemNetSocketsAddressFamily_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(System.Net.Sockets.AddressFamily));
				    SystemNetSocketsAddressFamily_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, SystemNetSocketsAddressFamily_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, SystemNetSocketsAddressFamily_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for System.Net.Sockets.AddressFamily ,value="+val);
            }
			
			LuaAPI.lua_getref(L, SystemNetSocketsAddressFamily_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out System.Net.Sockets.AddressFamily val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsAddressFamily_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.AddressFamily");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for System.Net.Sockets.AddressFamily");
                }
				val = (System.Net.Sockets.AddressFamily)e;
                
            }
            else
            {
                val = (System.Net.Sockets.AddressFamily)objectCasters.GetCaster(typeof(System.Net.Sockets.AddressFamily))(L, index, null);
            }
        }
		
        public void UpdateSystemNetSocketsAddressFamily(RealStatePtr L, int index, System.Net.Sockets.AddressFamily val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsAddressFamily_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.AddressFamily");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for System.Net.Sockets.AddressFamily ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int SystemNetSocketsSocketType_TypeID = -1;
		int SystemNetSocketsSocketType_EnumRef = -1;
        
        public void PushSystemNetSocketsSocketType(RealStatePtr L, System.Net.Sockets.SocketType val)
        {
            if (SystemNetSocketsSocketType_TypeID == -1)
            {
			    bool is_first;
                SystemNetSocketsSocketType_TypeID = getTypeId(L, typeof(System.Net.Sockets.SocketType), out is_first);
				
				if (SystemNetSocketsSocketType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(System.Net.Sockets.SocketType));
				    SystemNetSocketsSocketType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, SystemNetSocketsSocketType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, SystemNetSocketsSocketType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for System.Net.Sockets.SocketType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, SystemNetSocketsSocketType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out System.Net.Sockets.SocketType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsSocketType_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.SocketType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for System.Net.Sockets.SocketType");
                }
				val = (System.Net.Sockets.SocketType)e;
                
            }
            else
            {
                val = (System.Net.Sockets.SocketType)objectCasters.GetCaster(typeof(System.Net.Sockets.SocketType))(L, index, null);
            }
        }
		
        public void UpdateSystemNetSocketsSocketType(RealStatePtr L, int index, System.Net.Sockets.SocketType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsSocketType_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.SocketType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for System.Net.Sockets.SocketType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int SystemNetSocketsProtocolType_TypeID = -1;
		int SystemNetSocketsProtocolType_EnumRef = -1;
        
        public void PushSystemNetSocketsProtocolType(RealStatePtr L, System.Net.Sockets.ProtocolType val)
        {
            if (SystemNetSocketsProtocolType_TypeID == -1)
            {
			    bool is_first;
                SystemNetSocketsProtocolType_TypeID = getTypeId(L, typeof(System.Net.Sockets.ProtocolType), out is_first);
				
				if (SystemNetSocketsProtocolType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(System.Net.Sockets.ProtocolType));
				    SystemNetSocketsProtocolType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, SystemNetSocketsProtocolType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, SystemNetSocketsProtocolType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for System.Net.Sockets.ProtocolType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, SystemNetSocketsProtocolType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out System.Net.Sockets.ProtocolType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsProtocolType_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.ProtocolType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for System.Net.Sockets.ProtocolType");
                }
				val = (System.Net.Sockets.ProtocolType)e;
                
            }
            else
            {
                val = (System.Net.Sockets.ProtocolType)objectCasters.GetCaster(typeof(System.Net.Sockets.ProtocolType))(L, index, null);
            }
        }
		
        public void UpdateSystemNetSocketsProtocolType(RealStatePtr L, int index, System.Net.Sockets.ProtocolType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsProtocolType_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.ProtocolType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for System.Net.Sockets.ProtocolType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRectTransformAxis_TypeID = -1;
		int UnityEngineRectTransformAxis_EnumRef = -1;
        
        public void PushUnityEngineRectTransformAxis(RealStatePtr L, UnityEngine.RectTransform.Axis val)
        {
            if (UnityEngineRectTransformAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRectTransformAxis_TypeID = getTypeId(L, typeof(UnityEngine.RectTransform.Axis), out is_first);
				
				if (UnityEngineRectTransformAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RectTransform.Axis));
				    UnityEngineRectTransformAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRectTransformAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRectTransformAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RectTransform.Axis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRectTransformAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RectTransform.Axis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RectTransform.Axis");
                }
				val = (UnityEngine.RectTransform.Axis)e;
                
            }
            else
            {
                val = (UnityEngine.RectTransform.Axis)objectCasters.GetCaster(typeof(UnityEngine.RectTransform.Axis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRectTransformAxis(RealStatePtr L, int index, UnityEngine.RectTransform.Axis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RectTransform.Axis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRectTransformEdge_TypeID = -1;
		int UnityEngineRectTransformEdge_EnumRef = -1;
        
        public void PushUnityEngineRectTransformEdge(RealStatePtr L, UnityEngine.RectTransform.Edge val)
        {
            if (UnityEngineRectTransformEdge_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRectTransformEdge_TypeID = getTypeId(L, typeof(UnityEngine.RectTransform.Edge), out is_first);
				
				if (UnityEngineRectTransformEdge_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RectTransform.Edge));
				    UnityEngineRectTransformEdge_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRectTransformEdge_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRectTransformEdge_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RectTransform.Edge ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRectTransformEdge_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RectTransform.Edge val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformEdge_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Edge");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RectTransform.Edge");
                }
				val = (UnityEngine.RectTransform.Edge)e;
                
            }
            else
            {
                val = (UnityEngine.RectTransform.Edge)objectCasters.GetCaster(typeof(UnityEngine.RectTransform.Edge))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRectTransformEdge(RealStatePtr L, int index, UnityEngine.RectTransform.Edge val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformEdge_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Edge");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RectTransform.Edge ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUISelectableTransition_TypeID = -1;
		int UnityEngineUISelectableTransition_EnumRef = -1;
        
        public void PushUnityEngineUISelectableTransition(RealStatePtr L, UnityEngine.UI.Selectable.Transition val)
        {
            if (UnityEngineUISelectableTransition_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUISelectableTransition_TypeID = getTypeId(L, typeof(UnityEngine.UI.Selectable.Transition), out is_first);
				
				if (UnityEngineUISelectableTransition_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Selectable.Transition));
				    UnityEngineUISelectableTransition_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUISelectableTransition_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUISelectableTransition_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Selectable.Transition ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUISelectableTransition_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Selectable.Transition val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISelectableTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Selectable.Transition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Selectable.Transition");
                }
				val = (UnityEngine.UI.Selectable.Transition)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Selectable.Transition)objectCasters.GetCaster(typeof(UnityEngine.UI.Selectable.Transition))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUISelectableTransition(RealStatePtr L, int index, UnityEngine.UI.Selectable.Transition val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISelectableTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Selectable.Transition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Selectable.Transition ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int SystemIOSeekOrigin_TypeID = -1;
		int SystemIOSeekOrigin_EnumRef = -1;
        
        public void PushSystemIOSeekOrigin(RealStatePtr L, System.IO.SeekOrigin val)
        {
            if (SystemIOSeekOrigin_TypeID == -1)
            {
			    bool is_first;
                SystemIOSeekOrigin_TypeID = getTypeId(L, typeof(System.IO.SeekOrigin), out is_first);
				
				if (SystemIOSeekOrigin_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(System.IO.SeekOrigin));
				    SystemIOSeekOrigin_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, SystemIOSeekOrigin_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, SystemIOSeekOrigin_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for System.IO.SeekOrigin ,value="+val);
            }
			
			LuaAPI.lua_getref(L, SystemIOSeekOrigin_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out System.IO.SeekOrigin val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemIOSeekOrigin_TypeID)
				{
				    throw new Exception("invalid userdata for System.IO.SeekOrigin");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for System.IO.SeekOrigin");
                }
				val = (System.IO.SeekOrigin)e;
                
            }
            else
            {
                val = (System.IO.SeekOrigin)objectCasters.GetCaster(typeof(System.IO.SeekOrigin))(L, index, null);
            }
        }
		
        public void UpdateSystemIOSeekOrigin(RealStatePtr L, int index, System.IO.SeekOrigin val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemIOSeekOrigin_TypeID)
				{
				    throw new Exception("invalid userdata for System.IO.SeekOrigin");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for System.IO.SeekOrigin ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTexture2DEXRFlags_TypeID = -1;
		int UnityEngineTexture2DEXRFlags_EnumRef = -1;
        
        public void PushUnityEngineTexture2DEXRFlags(RealStatePtr L, UnityEngine.Texture2D.EXRFlags val)
        {
            if (UnityEngineTexture2DEXRFlags_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTexture2DEXRFlags_TypeID = getTypeId(L, typeof(UnityEngine.Texture2D.EXRFlags), out is_first);
				
				if (UnityEngineTexture2DEXRFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.Texture2D.EXRFlags));
				    UnityEngineTexture2DEXRFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTexture2DEXRFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTexture2DEXRFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.Texture2D.EXRFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTexture2DEXRFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Texture2D.EXRFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTexture2DEXRFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Texture2D.EXRFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.Texture2D.EXRFlags");
                }
				val = (UnityEngine.Texture2D.EXRFlags)e;
                
            }
            else
            {
                val = (UnityEngine.Texture2D.EXRFlags)objectCasters.GetCaster(typeof(UnityEngine.Texture2D.EXRFlags))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTexture2DEXRFlags(RealStatePtr L, int index, UnityEngine.Texture2D.EXRFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTexture2DEXRFlags_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Texture2D.EXRFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.Texture2D.EXRFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int libxLoadState_TypeID = -1;
		int libxLoadState_EnumRef = -1;
        
        public void PushlibxLoadState(RealStatePtr L, libx.LoadState val)
        {
            if (libxLoadState_TypeID == -1)
            {
			    bool is_first;
                libxLoadState_TypeID = getTypeId(L, typeof(libx.LoadState), out is_first);
				
				if (libxLoadState_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(libx.LoadState));
				    libxLoadState_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, libxLoadState_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, libxLoadState_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for libx.LoadState ,value="+val);
            }
			
			LuaAPI.lua_getref(L, libxLoadState_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out libx.LoadState val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != libxLoadState_TypeID)
				{
				    throw new Exception("invalid userdata for libx.LoadState");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for libx.LoadState");
                }
				val = (libx.LoadState)e;
                
            }
            else
            {
                val = (libx.LoadState)objectCasters.GetCaster(typeof(libx.LoadState))(L, index, null);
            }
        }
		
        public void UpdatelibxLoadState(RealStatePtr L, int index, libx.LoadState val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != libxLoadState_TypeID)
				{
				    throw new Exception("invalid userdata for libx.LoadState");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for libx.LoadState ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int libxVerifyBy_TypeID = -1;
		int libxVerifyBy_EnumRef = -1;
        
        public void PushlibxVerifyBy(RealStatePtr L, libx.VerifyBy val)
        {
            if (libxVerifyBy_TypeID == -1)
            {
			    bool is_first;
                libxVerifyBy_TypeID = getTypeId(L, typeof(libx.VerifyBy), out is_first);
				
				if (libxVerifyBy_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(libx.VerifyBy));
				    libxVerifyBy_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, libxVerifyBy_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, libxVerifyBy_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for libx.VerifyBy ,value="+val);
            }
			
			LuaAPI.lua_getref(L, libxVerifyBy_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out libx.VerifyBy val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != libxVerifyBy_TypeID)
				{
				    throw new Exception("invalid userdata for libx.VerifyBy");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for libx.VerifyBy");
                }
				val = (libx.VerifyBy)e;
                
            }
            else
            {
                val = (libx.VerifyBy)objectCasters.GetCaster(typeof(libx.VerifyBy))(L, index, null);
            }
        }
		
        public void UpdatelibxVerifyBy(RealStatePtr L, int index, libx.VerifyBy val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != libxVerifyBy_TypeID)
				{
				    throw new Exception("invalid userdata for libx.VerifyBy");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for libx.VerifyBy ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int BattlehubUIControlsItemDropAction_TypeID = -1;
		int BattlehubUIControlsItemDropAction_EnumRef = -1;
        
        public void PushBattlehubUIControlsItemDropAction(RealStatePtr L, Battlehub.UIControls.ItemDropAction val)
        {
            if (BattlehubUIControlsItemDropAction_TypeID == -1)
            {
			    bool is_first;
                BattlehubUIControlsItemDropAction_TypeID = getTypeId(L, typeof(Battlehub.UIControls.ItemDropAction), out is_first);
				
				if (BattlehubUIControlsItemDropAction_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(Battlehub.UIControls.ItemDropAction));
				    BattlehubUIControlsItemDropAction_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, BattlehubUIControlsItemDropAction_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, BattlehubUIControlsItemDropAction_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for Battlehub.UIControls.ItemDropAction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, BattlehubUIControlsItemDropAction_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out Battlehub.UIControls.ItemDropAction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUIControlsItemDropAction_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.UIControls.ItemDropAction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for Battlehub.UIControls.ItemDropAction");
                }
				val = (Battlehub.UIControls.ItemDropAction)e;
                
            }
            else
            {
                val = (Battlehub.UIControls.ItemDropAction)objectCasters.GetCaster(typeof(Battlehub.UIControls.ItemDropAction))(L, index, null);
            }
        }
		
        public void UpdateBattlehubUIControlsItemDropAction(RealStatePtr L, int index, Battlehub.UIControls.ItemDropAction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUIControlsItemDropAction_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.UIControls.ItemDropAction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for Battlehub.UIControls.ItemDropAction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int BattlehubUIControlsVirtualizingMode_TypeID = -1;
		int BattlehubUIControlsVirtualizingMode_EnumRef = -1;
        
        public void PushBattlehubUIControlsVirtualizingMode(RealStatePtr L, Battlehub.UIControls.VirtualizingMode val)
        {
            if (BattlehubUIControlsVirtualizingMode_TypeID == -1)
            {
			    bool is_first;
                BattlehubUIControlsVirtualizingMode_TypeID = getTypeId(L, typeof(Battlehub.UIControls.VirtualizingMode), out is_first);
				
				if (BattlehubUIControlsVirtualizingMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(Battlehub.UIControls.VirtualizingMode));
				    BattlehubUIControlsVirtualizingMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, BattlehubUIControlsVirtualizingMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, BattlehubUIControlsVirtualizingMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for Battlehub.UIControls.VirtualizingMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, BattlehubUIControlsVirtualizingMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out Battlehub.UIControls.VirtualizingMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUIControlsVirtualizingMode_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.UIControls.VirtualizingMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for Battlehub.UIControls.VirtualizingMode");
                }
				val = (Battlehub.UIControls.VirtualizingMode)e;
                
            }
            else
            {
                val = (Battlehub.UIControls.VirtualizingMode)objectCasters.GetCaster(typeof(Battlehub.UIControls.VirtualizingMode))(L, index, null);
            }
        }
		
        public void UpdateBattlehubUIControlsVirtualizingMode(RealStatePtr L, int index, Battlehub.UIControls.VirtualizingMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUIControlsVirtualizingMode_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.UIControls.VirtualizingMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for Battlehub.UIControls.VirtualizingMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int BattlehubUIControlsDockPanelsRegionSplitType_TypeID = -1;
		int BattlehubUIControlsDockPanelsRegionSplitType_EnumRef = -1;
        
        public void PushBattlehubUIControlsDockPanelsRegionSplitType(RealStatePtr L, Battlehub.UIControls.DockPanels.RegionSplitType val)
        {
            if (BattlehubUIControlsDockPanelsRegionSplitType_TypeID == -1)
            {
			    bool is_first;
                BattlehubUIControlsDockPanelsRegionSplitType_TypeID = getTypeId(L, typeof(Battlehub.UIControls.DockPanels.RegionSplitType), out is_first);
				
				if (BattlehubUIControlsDockPanelsRegionSplitType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(Battlehub.UIControls.DockPanels.RegionSplitType));
				    BattlehubUIControlsDockPanelsRegionSplitType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, BattlehubUIControlsDockPanelsRegionSplitType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, BattlehubUIControlsDockPanelsRegionSplitType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for Battlehub.UIControls.DockPanels.RegionSplitType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, BattlehubUIControlsDockPanelsRegionSplitType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out Battlehub.UIControls.DockPanels.RegionSplitType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUIControlsDockPanelsRegionSplitType_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.UIControls.DockPanels.RegionSplitType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for Battlehub.UIControls.DockPanels.RegionSplitType");
                }
				val = (Battlehub.UIControls.DockPanels.RegionSplitType)e;
                
            }
            else
            {
                val = (Battlehub.UIControls.DockPanels.RegionSplitType)objectCasters.GetCaster(typeof(Battlehub.UIControls.DockPanels.RegionSplitType))(L, index, null);
            }
        }
		
        public void UpdateBattlehubUIControlsDockPanelsRegionSplitType(RealStatePtr L, int index, Battlehub.UIControls.DockPanels.RegionSplitType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUIControlsDockPanelsRegionSplitType_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.UIControls.DockPanels.RegionSplitType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for Battlehub.UIControls.DockPanels.RegionSplitType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int BattlehubUtilsKnownCursor_TypeID = -1;
		int BattlehubUtilsKnownCursor_EnumRef = -1;
        
        public void PushBattlehubUtilsKnownCursor(RealStatePtr L, Battlehub.Utils.KnownCursor val)
        {
            if (BattlehubUtilsKnownCursor_TypeID == -1)
            {
			    bool is_first;
                BattlehubUtilsKnownCursor_TypeID = getTypeId(L, typeof(Battlehub.Utils.KnownCursor), out is_first);
				
				if (BattlehubUtilsKnownCursor_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(Battlehub.Utils.KnownCursor));
				    BattlehubUtilsKnownCursor_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, BattlehubUtilsKnownCursor_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, BattlehubUtilsKnownCursor_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for Battlehub.Utils.KnownCursor ,value="+val);
            }
			
			LuaAPI.lua_getref(L, BattlehubUtilsKnownCursor_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out Battlehub.Utils.KnownCursor val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUtilsKnownCursor_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.Utils.KnownCursor");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for Battlehub.Utils.KnownCursor");
                }
				val = (Battlehub.Utils.KnownCursor)e;
                
            }
            else
            {
                val = (Battlehub.Utils.KnownCursor)objectCasters.GetCaster(typeof(Battlehub.Utils.KnownCursor))(L, index, null);
            }
        }
		
        public void UpdateBattlehubUtilsKnownCursor(RealStatePtr L, int index, Battlehub.Utils.KnownCursor val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != BattlehubUtilsKnownCursor_TypeID)
				{
				    throw new Exception("invalid userdata for Battlehub.Utils.KnownCursor");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for Battlehub.Utils.KnownCursor ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIBlendMode_TypeID = -1;
		int FairyGUIBlendMode_EnumRef = -1;
        
        public void PushFairyGUIBlendMode(RealStatePtr L, FairyGUI.BlendMode val)
        {
            if (FairyGUIBlendMode_TypeID == -1)
            {
			    bool is_first;
                FairyGUIBlendMode_TypeID = getTypeId(L, typeof(FairyGUI.BlendMode), out is_first);
				
				if (FairyGUIBlendMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.BlendMode));
				    FairyGUIBlendMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIBlendMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIBlendMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.BlendMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIBlendMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.BlendMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIBlendMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.BlendMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.BlendMode");
                }
				val = (FairyGUI.BlendMode)e;
                
            }
            else
            {
                val = (FairyGUI.BlendMode)objectCasters.GetCaster(typeof(FairyGUI.BlendMode))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIBlendMode(RealStatePtr L, int index, FairyGUI.BlendMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIBlendMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.BlendMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.BlendMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIHitTestMode_TypeID = -1;
		int FairyGUIHitTestMode_EnumRef = -1;
        
        public void PushFairyGUIHitTestMode(RealStatePtr L, FairyGUI.HitTestMode val)
        {
            if (FairyGUIHitTestMode_TypeID == -1)
            {
			    bool is_first;
                FairyGUIHitTestMode_TypeID = getTypeId(L, typeof(FairyGUI.HitTestMode), out is_first);
				
				if (FairyGUIHitTestMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.HitTestMode));
				    FairyGUIHitTestMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIHitTestMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIHitTestMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.HitTestMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIHitTestMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.HitTestMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIHitTestMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.HitTestMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.HitTestMode");
                }
				val = (FairyGUI.HitTestMode)e;
                
            }
            else
            {
                val = (FairyGUI.HitTestMode)objectCasters.GetCaster(typeof(FairyGUI.HitTestMode))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIHitTestMode(RealStatePtr L, int index, FairyGUI.HitTestMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIHitTestMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.HitTestMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.HitTestMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIMaterialFlags_TypeID = -1;
		int FairyGUIMaterialFlags_EnumRef = -1;
        
        public void PushFairyGUIMaterialFlags(RealStatePtr L, FairyGUI.MaterialFlags val)
        {
            if (FairyGUIMaterialFlags_TypeID == -1)
            {
			    bool is_first;
                FairyGUIMaterialFlags_TypeID = getTypeId(L, typeof(FairyGUI.MaterialFlags), out is_first);
				
				if (FairyGUIMaterialFlags_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.MaterialFlags));
				    FairyGUIMaterialFlags_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIMaterialFlags_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIMaterialFlags_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.MaterialFlags ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIMaterialFlags_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.MaterialFlags val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIMaterialFlags_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.MaterialFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.MaterialFlags");
                }
				val = (FairyGUI.MaterialFlags)e;
                
            }
            else
            {
                val = (FairyGUI.MaterialFlags)objectCasters.GetCaster(typeof(FairyGUI.MaterialFlags))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIMaterialFlags(RealStatePtr L, int index, FairyGUI.MaterialFlags val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIMaterialFlags_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.MaterialFlags");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.MaterialFlags ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIDestroyMethod_TypeID = -1;
		int FairyGUIDestroyMethod_EnumRef = -1;
        
        public void PushFairyGUIDestroyMethod(RealStatePtr L, FairyGUI.DestroyMethod val)
        {
            if (FairyGUIDestroyMethod_TypeID == -1)
            {
			    bool is_first;
                FairyGUIDestroyMethod_TypeID = getTypeId(L, typeof(FairyGUI.DestroyMethod), out is_first);
				
				if (FairyGUIDestroyMethod_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.DestroyMethod));
				    FairyGUIDestroyMethod_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIDestroyMethod_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIDestroyMethod_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.DestroyMethod ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIDestroyMethod_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.DestroyMethod val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIDestroyMethod_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.DestroyMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.DestroyMethod");
                }
				val = (FairyGUI.DestroyMethod)e;
                
            }
            else
            {
                val = (FairyGUI.DestroyMethod)objectCasters.GetCaster(typeof(FairyGUI.DestroyMethod))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIDestroyMethod(RealStatePtr L, int index, FairyGUI.DestroyMethod val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIDestroyMethod_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.DestroyMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.DestroyMethod ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIEaseType_TypeID = -1;
		int FairyGUIEaseType_EnumRef = -1;
        
        public void PushFairyGUIEaseType(RealStatePtr L, FairyGUI.EaseType val)
        {
            if (FairyGUIEaseType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIEaseType_TypeID = getTypeId(L, typeof(FairyGUI.EaseType), out is_first);
				
				if (FairyGUIEaseType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.EaseType));
				    FairyGUIEaseType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIEaseType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIEaseType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.EaseType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIEaseType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.EaseType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIEaseType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.EaseType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.EaseType");
                }
				val = (FairyGUI.EaseType)e;
                
            }
            else
            {
                val = (FairyGUI.EaseType)objectCasters.GetCaster(typeof(FairyGUI.EaseType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIEaseType(RealStatePtr L, int index, FairyGUI.EaseType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIEaseType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.EaseType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.EaseType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUITweenPropType_TypeID = -1;
		int FairyGUITweenPropType_EnumRef = -1;
        
        public void PushFairyGUITweenPropType(RealStatePtr L, FairyGUI.TweenPropType val)
        {
            if (FairyGUITweenPropType_TypeID == -1)
            {
			    bool is_first;
                FairyGUITweenPropType_TypeID = getTypeId(L, typeof(FairyGUI.TweenPropType), out is_first);
				
				if (FairyGUITweenPropType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.TweenPropType));
				    FairyGUITweenPropType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUITweenPropType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUITweenPropType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.TweenPropType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUITweenPropType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.TweenPropType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUITweenPropType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.TweenPropType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.TweenPropType");
                }
				val = (FairyGUI.TweenPropType)e;
                
            }
            else
            {
                val = (FairyGUI.TweenPropType)objectCasters.GetCaster(typeof(FairyGUI.TweenPropType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUITweenPropType(RealStatePtr L, int index, FairyGUI.TweenPropType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUITweenPropType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.TweenPropType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.TweenPropType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIPackageItemType_TypeID = -1;
		int FairyGUIPackageItemType_EnumRef = -1;
        
        public void PushFairyGUIPackageItemType(RealStatePtr L, FairyGUI.PackageItemType val)
        {
            if (FairyGUIPackageItemType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIPackageItemType_TypeID = getTypeId(L, typeof(FairyGUI.PackageItemType), out is_first);
				
				if (FairyGUIPackageItemType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.PackageItemType));
				    FairyGUIPackageItemType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIPackageItemType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIPackageItemType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.PackageItemType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIPackageItemType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.PackageItemType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIPackageItemType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.PackageItemType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.PackageItemType");
                }
				val = (FairyGUI.PackageItemType)e;
                
            }
            else
            {
                val = (FairyGUI.PackageItemType)objectCasters.GetCaster(typeof(FairyGUI.PackageItemType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIPackageItemType(RealStatePtr L, int index, FairyGUI.PackageItemType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIPackageItemType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.PackageItemType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.PackageItemType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIObjectType_TypeID = -1;
		int FairyGUIObjectType_EnumRef = -1;
        
        public void PushFairyGUIObjectType(RealStatePtr L, FairyGUI.ObjectType val)
        {
            if (FairyGUIObjectType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIObjectType_TypeID = getTypeId(L, typeof(FairyGUI.ObjectType), out is_first);
				
				if (FairyGUIObjectType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ObjectType));
				    FairyGUIObjectType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIObjectType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIObjectType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ObjectType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIObjectType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ObjectType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIObjectType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ObjectType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ObjectType");
                }
				val = (FairyGUI.ObjectType)e;
                
            }
            else
            {
                val = (FairyGUI.ObjectType)objectCasters.GetCaster(typeof(FairyGUI.ObjectType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIObjectType(RealStatePtr L, int index, FairyGUI.ObjectType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIObjectType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ObjectType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ObjectType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIAlignType_TypeID = -1;
		int FairyGUIAlignType_EnumRef = -1;
        
        public void PushFairyGUIAlignType(RealStatePtr L, FairyGUI.AlignType val)
        {
            if (FairyGUIAlignType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIAlignType_TypeID = getTypeId(L, typeof(FairyGUI.AlignType), out is_first);
				
				if (FairyGUIAlignType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.AlignType));
				    FairyGUIAlignType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIAlignType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIAlignType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.AlignType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIAlignType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.AlignType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIAlignType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.AlignType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.AlignType");
                }
				val = (FairyGUI.AlignType)e;
                
            }
            else
            {
                val = (FairyGUI.AlignType)objectCasters.GetCaster(typeof(FairyGUI.AlignType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIAlignType(RealStatePtr L, int index, FairyGUI.AlignType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIAlignType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.AlignType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.AlignType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIVertAlignType_TypeID = -1;
		int FairyGUIVertAlignType_EnumRef = -1;
        
        public void PushFairyGUIVertAlignType(RealStatePtr L, FairyGUI.VertAlignType val)
        {
            if (FairyGUIVertAlignType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIVertAlignType_TypeID = getTypeId(L, typeof(FairyGUI.VertAlignType), out is_first);
				
				if (FairyGUIVertAlignType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.VertAlignType));
				    FairyGUIVertAlignType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIVertAlignType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIVertAlignType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.VertAlignType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIVertAlignType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.VertAlignType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIVertAlignType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.VertAlignType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.VertAlignType");
                }
				val = (FairyGUI.VertAlignType)e;
                
            }
            else
            {
                val = (FairyGUI.VertAlignType)objectCasters.GetCaster(typeof(FairyGUI.VertAlignType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIVertAlignType(RealStatePtr L, int index, FairyGUI.VertAlignType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIVertAlignType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.VertAlignType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.VertAlignType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIOverflowType_TypeID = -1;
		int FairyGUIOverflowType_EnumRef = -1;
        
        public void PushFairyGUIOverflowType(RealStatePtr L, FairyGUI.OverflowType val)
        {
            if (FairyGUIOverflowType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIOverflowType_TypeID = getTypeId(L, typeof(FairyGUI.OverflowType), out is_first);
				
				if (FairyGUIOverflowType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.OverflowType));
				    FairyGUIOverflowType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIOverflowType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIOverflowType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.OverflowType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIOverflowType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.OverflowType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOverflowType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.OverflowType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.OverflowType");
                }
				val = (FairyGUI.OverflowType)e;
                
            }
            else
            {
                val = (FairyGUI.OverflowType)objectCasters.GetCaster(typeof(FairyGUI.OverflowType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIOverflowType(RealStatePtr L, int index, FairyGUI.OverflowType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOverflowType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.OverflowType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.OverflowType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIFillType_TypeID = -1;
		int FairyGUIFillType_EnumRef = -1;
        
        public void PushFairyGUIFillType(RealStatePtr L, FairyGUI.FillType val)
        {
            if (FairyGUIFillType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIFillType_TypeID = getTypeId(L, typeof(FairyGUI.FillType), out is_first);
				
				if (FairyGUIFillType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.FillType));
				    FairyGUIFillType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIFillType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIFillType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.FillType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIFillType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.FillType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFillType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FillType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.FillType");
                }
				val = (FairyGUI.FillType)e;
                
            }
            else
            {
                val = (FairyGUI.FillType)objectCasters.GetCaster(typeof(FairyGUI.FillType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIFillType(RealStatePtr L, int index, FairyGUI.FillType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFillType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FillType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.FillType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIAutoSizeType_TypeID = -1;
		int FairyGUIAutoSizeType_EnumRef = -1;
        
        public void PushFairyGUIAutoSizeType(RealStatePtr L, FairyGUI.AutoSizeType val)
        {
            if (FairyGUIAutoSizeType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIAutoSizeType_TypeID = getTypeId(L, typeof(FairyGUI.AutoSizeType), out is_first);
				
				if (FairyGUIAutoSizeType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.AutoSizeType));
				    FairyGUIAutoSizeType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIAutoSizeType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIAutoSizeType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.AutoSizeType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIAutoSizeType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.AutoSizeType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIAutoSizeType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.AutoSizeType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.AutoSizeType");
                }
				val = (FairyGUI.AutoSizeType)e;
                
            }
            else
            {
                val = (FairyGUI.AutoSizeType)objectCasters.GetCaster(typeof(FairyGUI.AutoSizeType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIAutoSizeType(RealStatePtr L, int index, FairyGUI.AutoSizeType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIAutoSizeType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.AutoSizeType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.AutoSizeType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIScrollType_TypeID = -1;
		int FairyGUIScrollType_EnumRef = -1;
        
        public void PushFairyGUIScrollType(RealStatePtr L, FairyGUI.ScrollType val)
        {
            if (FairyGUIScrollType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIScrollType_TypeID = getTypeId(L, typeof(FairyGUI.ScrollType), out is_first);
				
				if (FairyGUIScrollType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ScrollType));
				    FairyGUIScrollType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIScrollType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIScrollType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ScrollType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIScrollType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ScrollType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIScrollType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ScrollType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ScrollType");
                }
				val = (FairyGUI.ScrollType)e;
                
            }
            else
            {
                val = (FairyGUI.ScrollType)objectCasters.GetCaster(typeof(FairyGUI.ScrollType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIScrollType(RealStatePtr L, int index, FairyGUI.ScrollType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIScrollType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ScrollType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ScrollType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIScrollBarDisplayType_TypeID = -1;
		int FairyGUIScrollBarDisplayType_EnumRef = -1;
        
        public void PushFairyGUIScrollBarDisplayType(RealStatePtr L, FairyGUI.ScrollBarDisplayType val)
        {
            if (FairyGUIScrollBarDisplayType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIScrollBarDisplayType_TypeID = getTypeId(L, typeof(FairyGUI.ScrollBarDisplayType), out is_first);
				
				if (FairyGUIScrollBarDisplayType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ScrollBarDisplayType));
				    FairyGUIScrollBarDisplayType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIScrollBarDisplayType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIScrollBarDisplayType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ScrollBarDisplayType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIScrollBarDisplayType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ScrollBarDisplayType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIScrollBarDisplayType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ScrollBarDisplayType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ScrollBarDisplayType");
                }
				val = (FairyGUI.ScrollBarDisplayType)e;
                
            }
            else
            {
                val = (FairyGUI.ScrollBarDisplayType)objectCasters.GetCaster(typeof(FairyGUI.ScrollBarDisplayType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIScrollBarDisplayType(RealStatePtr L, int index, FairyGUI.ScrollBarDisplayType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIScrollBarDisplayType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ScrollBarDisplayType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ScrollBarDisplayType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIRelationType_TypeID = -1;
		int FairyGUIRelationType_EnumRef = -1;
        
        public void PushFairyGUIRelationType(RealStatePtr L, FairyGUI.RelationType val)
        {
            if (FairyGUIRelationType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIRelationType_TypeID = getTypeId(L, typeof(FairyGUI.RelationType), out is_first);
				
				if (FairyGUIRelationType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.RelationType));
				    FairyGUIRelationType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIRelationType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIRelationType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.RelationType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIRelationType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.RelationType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIRelationType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.RelationType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.RelationType");
                }
				val = (FairyGUI.RelationType)e;
                
            }
            else
            {
                val = (FairyGUI.RelationType)objectCasters.GetCaster(typeof(FairyGUI.RelationType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIRelationType(RealStatePtr L, int index, FairyGUI.RelationType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIRelationType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.RelationType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.RelationType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIListLayoutType_TypeID = -1;
		int FairyGUIListLayoutType_EnumRef = -1;
        
        public void PushFairyGUIListLayoutType(RealStatePtr L, FairyGUI.ListLayoutType val)
        {
            if (FairyGUIListLayoutType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIListLayoutType_TypeID = getTypeId(L, typeof(FairyGUI.ListLayoutType), out is_first);
				
				if (FairyGUIListLayoutType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ListLayoutType));
				    FairyGUIListLayoutType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIListLayoutType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIListLayoutType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ListLayoutType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIListLayoutType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ListLayoutType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIListLayoutType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ListLayoutType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ListLayoutType");
                }
				val = (FairyGUI.ListLayoutType)e;
                
            }
            else
            {
                val = (FairyGUI.ListLayoutType)objectCasters.GetCaster(typeof(FairyGUI.ListLayoutType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIListLayoutType(RealStatePtr L, int index, FairyGUI.ListLayoutType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIListLayoutType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ListLayoutType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ListLayoutType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIListSelectionMode_TypeID = -1;
		int FairyGUIListSelectionMode_EnumRef = -1;
        
        public void PushFairyGUIListSelectionMode(RealStatePtr L, FairyGUI.ListSelectionMode val)
        {
            if (FairyGUIListSelectionMode_TypeID == -1)
            {
			    bool is_first;
                FairyGUIListSelectionMode_TypeID = getTypeId(L, typeof(FairyGUI.ListSelectionMode), out is_first);
				
				if (FairyGUIListSelectionMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ListSelectionMode));
				    FairyGUIListSelectionMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIListSelectionMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIListSelectionMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ListSelectionMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIListSelectionMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ListSelectionMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIListSelectionMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ListSelectionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ListSelectionMode");
                }
				val = (FairyGUI.ListSelectionMode)e;
                
            }
            else
            {
                val = (FairyGUI.ListSelectionMode)objectCasters.GetCaster(typeof(FairyGUI.ListSelectionMode))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIListSelectionMode(RealStatePtr L, int index, FairyGUI.ListSelectionMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIListSelectionMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ListSelectionMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ListSelectionMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIProgressTitleType_TypeID = -1;
		int FairyGUIProgressTitleType_EnumRef = -1;
        
        public void PushFairyGUIProgressTitleType(RealStatePtr L, FairyGUI.ProgressTitleType val)
        {
            if (FairyGUIProgressTitleType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIProgressTitleType_TypeID = getTypeId(L, typeof(FairyGUI.ProgressTitleType), out is_first);
				
				if (FairyGUIProgressTitleType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ProgressTitleType));
				    FairyGUIProgressTitleType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIProgressTitleType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIProgressTitleType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ProgressTitleType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIProgressTitleType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ProgressTitleType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIProgressTitleType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ProgressTitleType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ProgressTitleType");
                }
				val = (FairyGUI.ProgressTitleType)e;
                
            }
            else
            {
                val = (FairyGUI.ProgressTitleType)objectCasters.GetCaster(typeof(FairyGUI.ProgressTitleType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIProgressTitleType(RealStatePtr L, int index, FairyGUI.ProgressTitleType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIProgressTitleType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ProgressTitleType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ProgressTitleType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIButtonMode_TypeID = -1;
		int FairyGUIButtonMode_EnumRef = -1;
        
        public void PushFairyGUIButtonMode(RealStatePtr L, FairyGUI.ButtonMode val)
        {
            if (FairyGUIButtonMode_TypeID == -1)
            {
			    bool is_first;
                FairyGUIButtonMode_TypeID = getTypeId(L, typeof(FairyGUI.ButtonMode), out is_first);
				
				if (FairyGUIButtonMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ButtonMode));
				    FairyGUIButtonMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIButtonMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIButtonMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ButtonMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIButtonMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ButtonMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIButtonMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ButtonMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ButtonMode");
                }
				val = (FairyGUI.ButtonMode)e;
                
            }
            else
            {
                val = (FairyGUI.ButtonMode)objectCasters.GetCaster(typeof(FairyGUI.ButtonMode))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIButtonMode(RealStatePtr L, int index, FairyGUI.ButtonMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIButtonMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ButtonMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ButtonMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUITransitionActionType_TypeID = -1;
		int FairyGUITransitionActionType_EnumRef = -1;
        
        public void PushFairyGUITransitionActionType(RealStatePtr L, FairyGUI.TransitionActionType val)
        {
            if (FairyGUITransitionActionType_TypeID == -1)
            {
			    bool is_first;
                FairyGUITransitionActionType_TypeID = getTypeId(L, typeof(FairyGUI.TransitionActionType), out is_first);
				
				if (FairyGUITransitionActionType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.TransitionActionType));
				    FairyGUITransitionActionType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUITransitionActionType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUITransitionActionType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.TransitionActionType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUITransitionActionType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.TransitionActionType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUITransitionActionType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.TransitionActionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.TransitionActionType");
                }
				val = (FairyGUI.TransitionActionType)e;
                
            }
            else
            {
                val = (FairyGUI.TransitionActionType)objectCasters.GetCaster(typeof(FairyGUI.TransitionActionType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUITransitionActionType(RealStatePtr L, int index, FairyGUI.TransitionActionType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUITransitionActionType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.TransitionActionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.TransitionActionType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIGroupLayoutType_TypeID = -1;
		int FairyGUIGroupLayoutType_EnumRef = -1;
        
        public void PushFairyGUIGroupLayoutType(RealStatePtr L, FairyGUI.GroupLayoutType val)
        {
            if (FairyGUIGroupLayoutType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIGroupLayoutType_TypeID = getTypeId(L, typeof(FairyGUI.GroupLayoutType), out is_first);
				
				if (FairyGUIGroupLayoutType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.GroupLayoutType));
				    FairyGUIGroupLayoutType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIGroupLayoutType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIGroupLayoutType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.GroupLayoutType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIGroupLayoutType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.GroupLayoutType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIGroupLayoutType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.GroupLayoutType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.GroupLayoutType");
                }
				val = (FairyGUI.GroupLayoutType)e;
                
            }
            else
            {
                val = (FairyGUI.GroupLayoutType)objectCasters.GetCaster(typeof(FairyGUI.GroupLayoutType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIGroupLayoutType(RealStatePtr L, int index, FairyGUI.GroupLayoutType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIGroupLayoutType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.GroupLayoutType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.GroupLayoutType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIChildrenRenderOrder_TypeID = -1;
		int FairyGUIChildrenRenderOrder_EnumRef = -1;
        
        public void PushFairyGUIChildrenRenderOrder(RealStatePtr L, FairyGUI.ChildrenRenderOrder val)
        {
            if (FairyGUIChildrenRenderOrder_TypeID == -1)
            {
			    bool is_first;
                FairyGUIChildrenRenderOrder_TypeID = getTypeId(L, typeof(FairyGUI.ChildrenRenderOrder), out is_first);
				
				if (FairyGUIChildrenRenderOrder_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ChildrenRenderOrder));
				    FairyGUIChildrenRenderOrder_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIChildrenRenderOrder_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIChildrenRenderOrder_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ChildrenRenderOrder ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIChildrenRenderOrder_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ChildrenRenderOrder val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIChildrenRenderOrder_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ChildrenRenderOrder");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ChildrenRenderOrder");
                }
				val = (FairyGUI.ChildrenRenderOrder)e;
                
            }
            else
            {
                val = (FairyGUI.ChildrenRenderOrder)objectCasters.GetCaster(typeof(FairyGUI.ChildrenRenderOrder))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIChildrenRenderOrder(RealStatePtr L, int index, FairyGUI.ChildrenRenderOrder val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIChildrenRenderOrder_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ChildrenRenderOrder");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ChildrenRenderOrder ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIPopupDirection_TypeID = -1;
		int FairyGUIPopupDirection_EnumRef = -1;
        
        public void PushFairyGUIPopupDirection(RealStatePtr L, FairyGUI.PopupDirection val)
        {
            if (FairyGUIPopupDirection_TypeID == -1)
            {
			    bool is_first;
                FairyGUIPopupDirection_TypeID = getTypeId(L, typeof(FairyGUI.PopupDirection), out is_first);
				
				if (FairyGUIPopupDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.PopupDirection));
				    FairyGUIPopupDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIPopupDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIPopupDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.PopupDirection ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIPopupDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.PopupDirection val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIPopupDirection_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.PopupDirection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.PopupDirection");
                }
				val = (FairyGUI.PopupDirection)e;
                
            }
            else
            {
                val = (FairyGUI.PopupDirection)objectCasters.GetCaster(typeof(FairyGUI.PopupDirection))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIPopupDirection(RealStatePtr L, int index, FairyGUI.PopupDirection val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIPopupDirection_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.PopupDirection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.PopupDirection ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIFlipType_TypeID = -1;
		int FairyGUIFlipType_EnumRef = -1;
        
        public void PushFairyGUIFlipType(RealStatePtr L, FairyGUI.FlipType val)
        {
            if (FairyGUIFlipType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIFlipType_TypeID = getTypeId(L, typeof(FairyGUI.FlipType), out is_first);
				
				if (FairyGUIFlipType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.FlipType));
				    FairyGUIFlipType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIFlipType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIFlipType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.FlipType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIFlipType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.FlipType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFlipType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FlipType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.FlipType");
                }
				val = (FairyGUI.FlipType)e;
                
            }
            else
            {
                val = (FairyGUI.FlipType)objectCasters.GetCaster(typeof(FairyGUI.FlipType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIFlipType(RealStatePtr L, int index, FairyGUI.FlipType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFlipType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FlipType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.FlipType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIFillMethod_TypeID = -1;
		int FairyGUIFillMethod_EnumRef = -1;
        
        public void PushFairyGUIFillMethod(RealStatePtr L, FairyGUI.FillMethod val)
        {
            if (FairyGUIFillMethod_TypeID == -1)
            {
			    bool is_first;
                FairyGUIFillMethod_TypeID = getTypeId(L, typeof(FairyGUI.FillMethod), out is_first);
				
				if (FairyGUIFillMethod_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.FillMethod));
				    FairyGUIFillMethod_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIFillMethod_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIFillMethod_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.FillMethod ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIFillMethod_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.FillMethod val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.FillMethod");
                }
				val = (FairyGUI.FillMethod)e;
                
            }
            else
            {
                val = (FairyGUI.FillMethod)objectCasters.GetCaster(typeof(FairyGUI.FillMethod))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIFillMethod(RealStatePtr L, int index, FairyGUI.FillMethod val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.FillMethod ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIOriginHorizontal_TypeID = -1;
		int FairyGUIOriginHorizontal_EnumRef = -1;
        
        public void PushFairyGUIOriginHorizontal(RealStatePtr L, FairyGUI.OriginHorizontal val)
        {
            if (FairyGUIOriginHorizontal_TypeID == -1)
            {
			    bool is_first;
                FairyGUIOriginHorizontal_TypeID = getTypeId(L, typeof(FairyGUI.OriginHorizontal), out is_first);
				
				if (FairyGUIOriginHorizontal_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.OriginHorizontal));
				    FairyGUIOriginHorizontal_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIOriginHorizontal_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIOriginHorizontal_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.OriginHorizontal ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIOriginHorizontal_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.OriginHorizontal val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.OriginHorizontal");
                }
				val = (FairyGUI.OriginHorizontal)e;
                
            }
            else
            {
                val = (FairyGUI.OriginHorizontal)objectCasters.GetCaster(typeof(FairyGUI.OriginHorizontal))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIOriginHorizontal(RealStatePtr L, int index, FairyGUI.OriginHorizontal val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.OriginHorizontal ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIOriginVertical_TypeID = -1;
		int FairyGUIOriginVertical_EnumRef = -1;
        
        public void PushFairyGUIOriginVertical(RealStatePtr L, FairyGUI.OriginVertical val)
        {
            if (FairyGUIOriginVertical_TypeID == -1)
            {
			    bool is_first;
                FairyGUIOriginVertical_TypeID = getTypeId(L, typeof(FairyGUI.OriginVertical), out is_first);
				
				if (FairyGUIOriginVertical_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.OriginVertical));
				    FairyGUIOriginVertical_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIOriginVertical_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIOriginVertical_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.OriginVertical ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIOriginVertical_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.OriginVertical val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.OriginVertical");
                }
				val = (FairyGUI.OriginVertical)e;
                
            }
            else
            {
                val = (FairyGUI.OriginVertical)objectCasters.GetCaster(typeof(FairyGUI.OriginVertical))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIOriginVertical(RealStatePtr L, int index, FairyGUI.OriginVertical val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.OriginVertical ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIOrigin90_TypeID = -1;
		int FairyGUIOrigin90_EnumRef = -1;
        
        public void PushFairyGUIOrigin90(RealStatePtr L, FairyGUI.Origin90 val)
        {
            if (FairyGUIOrigin90_TypeID == -1)
            {
			    bool is_first;
                FairyGUIOrigin90_TypeID = getTypeId(L, typeof(FairyGUI.Origin90), out is_first);
				
				if (FairyGUIOrigin90_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.Origin90));
				    FairyGUIOrigin90_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIOrigin90_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIOrigin90_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.Origin90 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIOrigin90_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.Origin90 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.Origin90");
                }
				val = (FairyGUI.Origin90)e;
                
            }
            else
            {
                val = (FairyGUI.Origin90)objectCasters.GetCaster(typeof(FairyGUI.Origin90))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIOrigin90(RealStatePtr L, int index, FairyGUI.Origin90 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.Origin90 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIOrigin180_TypeID = -1;
		int FairyGUIOrigin180_EnumRef = -1;
        
        public void PushFairyGUIOrigin180(RealStatePtr L, FairyGUI.Origin180 val)
        {
            if (FairyGUIOrigin180_TypeID == -1)
            {
			    bool is_first;
                FairyGUIOrigin180_TypeID = getTypeId(L, typeof(FairyGUI.Origin180), out is_first);
				
				if (FairyGUIOrigin180_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.Origin180));
				    FairyGUIOrigin180_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIOrigin180_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIOrigin180_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.Origin180 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIOrigin180_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.Origin180 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.Origin180");
                }
				val = (FairyGUI.Origin180)e;
                
            }
            else
            {
                val = (FairyGUI.Origin180)objectCasters.GetCaster(typeof(FairyGUI.Origin180))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIOrigin180(RealStatePtr L, int index, FairyGUI.Origin180 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.Origin180 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIOrigin360_TypeID = -1;
		int FairyGUIOrigin360_EnumRef = -1;
        
        public void PushFairyGUIOrigin360(RealStatePtr L, FairyGUI.Origin360 val)
        {
            if (FairyGUIOrigin360_TypeID == -1)
            {
			    bool is_first;
                FairyGUIOrigin360_TypeID = getTypeId(L, typeof(FairyGUI.Origin360), out is_first);
				
				if (FairyGUIOrigin360_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.Origin360));
				    FairyGUIOrigin360_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIOrigin360_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIOrigin360_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.Origin360 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIOrigin360_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.Origin360 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.Origin360");
                }
				val = (FairyGUI.Origin360)e;
                
            }
            else
            {
                val = (FairyGUI.Origin360)objectCasters.GetCaster(typeof(FairyGUI.Origin360))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIOrigin360(RealStatePtr L, int index, FairyGUI.Origin360 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.Origin360 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIFocusRule_TypeID = -1;
		int FairyGUIFocusRule_EnumRef = -1;
        
        public void PushFairyGUIFocusRule(RealStatePtr L, FairyGUI.FocusRule val)
        {
            if (FairyGUIFocusRule_TypeID == -1)
            {
			    bool is_first;
                FairyGUIFocusRule_TypeID = getTypeId(L, typeof(FairyGUI.FocusRule), out is_first);
				
				if (FairyGUIFocusRule_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.FocusRule));
				    FairyGUIFocusRule_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIFocusRule_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIFocusRule_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.FocusRule ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIFocusRule_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.FocusRule val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFocusRule_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FocusRule");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.FocusRule");
                }
				val = (FairyGUI.FocusRule)e;
                
            }
            else
            {
                val = (FairyGUI.FocusRule)objectCasters.GetCaster(typeof(FairyGUI.FocusRule))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIFocusRule(RealStatePtr L, int index, FairyGUI.FocusRule val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFocusRule_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FocusRule");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.FocusRule ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIFitScreen_TypeID = -1;
		int FairyGUIFitScreen_EnumRef = -1;
        
        public void PushFairyGUIFitScreen(RealStatePtr L, FairyGUI.FitScreen val)
        {
            if (FairyGUIFitScreen_TypeID == -1)
            {
			    bool is_first;
                FairyGUIFitScreen_TypeID = getTypeId(L, typeof(FairyGUI.FitScreen), out is_first);
				
				if (FairyGUIFitScreen_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.FitScreen));
				    FairyGUIFitScreen_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIFitScreen_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIFitScreen_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.FitScreen ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIFitScreen_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.FitScreen val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFitScreen_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FitScreen");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.FitScreen");
                }
				val = (FairyGUI.FitScreen)e;
                
            }
            else
            {
                val = (FairyGUI.FitScreen)objectCasters.GetCaster(typeof(FairyGUI.FitScreen))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIFitScreen(RealStatePtr L, int index, FairyGUI.FitScreen val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIFitScreen_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.FitScreen");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.FitScreen ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIUtilsHtmlElementType_TypeID = -1;
		int FairyGUIUtilsHtmlElementType_EnumRef = -1;
        
        public void PushFairyGUIUtilsHtmlElementType(RealStatePtr L, FairyGUI.Utils.HtmlElementType val)
        {
            if (FairyGUIUtilsHtmlElementType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIUtilsHtmlElementType_TypeID = getTypeId(L, typeof(FairyGUI.Utils.HtmlElementType), out is_first);
				
				if (FairyGUIUtilsHtmlElementType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.Utils.HtmlElementType));
				    FairyGUIUtilsHtmlElementType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIUtilsHtmlElementType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIUtilsHtmlElementType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.Utils.HtmlElementType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIUtilsHtmlElementType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.Utils.HtmlElementType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUtilsHtmlElementType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Utils.HtmlElementType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.Utils.HtmlElementType");
                }
				val = (FairyGUI.Utils.HtmlElementType)e;
                
            }
            else
            {
                val = (FairyGUI.Utils.HtmlElementType)objectCasters.GetCaster(typeof(FairyGUI.Utils.HtmlElementType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIUtilsHtmlElementType(RealStatePtr L, int index, FairyGUI.Utils.HtmlElementType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUtilsHtmlElementType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Utils.HtmlElementType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.Utils.HtmlElementType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIUtilsXMLTagType_TypeID = -1;
		int FairyGUIUtilsXMLTagType_EnumRef = -1;
        
        public void PushFairyGUIUtilsXMLTagType(RealStatePtr L, FairyGUI.Utils.XMLTagType val)
        {
            if (FairyGUIUtilsXMLTagType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIUtilsXMLTagType_TypeID = getTypeId(L, typeof(FairyGUI.Utils.XMLTagType), out is_first);
				
				if (FairyGUIUtilsXMLTagType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.Utils.XMLTagType));
				    FairyGUIUtilsXMLTagType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIUtilsXMLTagType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIUtilsXMLTagType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.Utils.XMLTagType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIUtilsXMLTagType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.Utils.XMLTagType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUtilsXMLTagType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Utils.XMLTagType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.Utils.XMLTagType");
                }
				val = (FairyGUI.Utils.XMLTagType)e;
                
            }
            else
            {
                val = (FairyGUI.Utils.XMLTagType)objectCasters.GetCaster(typeof(FairyGUI.Utils.XMLTagType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIUtilsXMLTagType(RealStatePtr L, int index, FairyGUI.Utils.XMLTagType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUtilsXMLTagType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.Utils.XMLTagType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.Utils.XMLTagType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int ETColdDebugType_TypeID = -1;
		int ETColdDebugType_EnumRef = -1;
        
        public void PushETColdDebugType(RealStatePtr L, ETCold.DebugType val)
        {
            if (ETColdDebugType_TypeID == -1)
            {
			    bool is_first;
                ETColdDebugType_TypeID = getTypeId(L, typeof(ETCold.DebugType), out is_first);
				
				if (ETColdDebugType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(ETCold.DebugType));
				    ETColdDebugType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, ETColdDebugType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, ETColdDebugType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for ETCold.DebugType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, ETColdDebugType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out ETCold.DebugType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != ETColdDebugType_TypeID)
				{
				    throw new Exception("invalid userdata for ETCold.DebugType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for ETCold.DebugType");
                }
				val = (ETCold.DebugType)e;
                
            }
            else
            {
                val = (ETCold.DebugType)objectCasters.GetCaster(typeof(ETCold.DebugType))(L, index, null);
            }
        }
		
        public void UpdateETColdDebugType(RealStatePtr L, int index, ETCold.DebugType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != ETColdDebugType_TypeID)
				{
				    throw new Exception("invalid userdata for ETCold.DebugType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for ETCold.DebugType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int ETColdUILayer_TypeID = -1;
		int ETColdUILayer_EnumRef = -1;
        
        public void PushETColdUILayer(RealStatePtr L, ETCold.UILayer val)
        {
            if (ETColdUILayer_TypeID == -1)
            {
			    bool is_first;
                ETColdUILayer_TypeID = getTypeId(L, typeof(ETCold.UILayer), out is_first);
				
				if (ETColdUILayer_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(ETCold.UILayer));
				    ETColdUILayer_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, ETColdUILayer_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, ETColdUILayer_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for ETCold.UILayer ,value="+val);
            }
			
			LuaAPI.lua_getref(L, ETColdUILayer_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out ETCold.UILayer val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != ETColdUILayer_TypeID)
				{
				    throw new Exception("invalid userdata for ETCold.UILayer");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for ETCold.UILayer");
                }
				val = (ETCold.UILayer)e;
                
            }
            else
            {
                val = (ETCold.UILayer)objectCasters.GetCaster(typeof(ETCold.UILayer))(L, index, null);
            }
        }
		
        public void UpdateETColdUILayer(RealStatePtr L, int index, ETCold.UILayer val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != ETColdUILayer_TypeID)
				{
				    throw new Exception("invalid userdata for ETCold.UILayer");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for ETCold.UILayer ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int ETAwaiterStatus_TypeID = -1;
		int ETAwaiterStatus_EnumRef = -1;
        
        public void PushETAwaiterStatus(RealStatePtr L, ET.AwaiterStatus val)
        {
            if (ETAwaiterStatus_TypeID == -1)
            {
			    bool is_first;
                ETAwaiterStatus_TypeID = getTypeId(L, typeof(ET.AwaiterStatus), out is_first);
				
				if (ETAwaiterStatus_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(ET.AwaiterStatus));
				    ETAwaiterStatus_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, ETAwaiterStatus_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, ETAwaiterStatus_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for ET.AwaiterStatus ,value="+val);
            }
			
			LuaAPI.lua_getref(L, ETAwaiterStatus_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out ET.AwaiterStatus val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != ETAwaiterStatus_TypeID)
				{
				    throw new Exception("invalid userdata for ET.AwaiterStatus");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for ET.AwaiterStatus");
                }
				val = (ET.AwaiterStatus)e;
                
            }
            else
            {
                val = (ET.AwaiterStatus)objectCasters.GetCaster(typeof(ET.AwaiterStatus))(L, index, null);
            }
        }
		
        public void UpdateETAwaiterStatus(RealStatePtr L, int index, ET.AwaiterStatus val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != ETAwaiterStatus_TypeID)
				{
				    throw new Exception("invalid userdata for ET.AwaiterStatus");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for ET.AwaiterStatus ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int MessageBoxEventId_TypeID = -1;
		int MessageBoxEventId_EnumRef = -1;
        
        public void PushMessageBoxEventId(RealStatePtr L, MessageBox.EventId val)
        {
            if (MessageBoxEventId_TypeID == -1)
            {
			    bool is_first;
                MessageBoxEventId_TypeID = getTypeId(L, typeof(MessageBox.EventId), out is_first);
				
				if (MessageBoxEventId_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(MessageBox.EventId));
				    MessageBoxEventId_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, MessageBoxEventId_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, MessageBoxEventId_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for MessageBox.EventId ,value="+val);
            }
			
			LuaAPI.lua_getref(L, MessageBoxEventId_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out MessageBox.EventId val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != MessageBoxEventId_TypeID)
				{
				    throw new Exception("invalid userdata for MessageBox.EventId");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for MessageBox.EventId");
                }
				val = (MessageBox.EventId)e;
                
            }
            else
            {
                val = (MessageBox.EventId)objectCasters.GetCaster(typeof(MessageBox.EventId))(L, index, null);
            }
        }
		
        public void UpdateMessageBoxEventId(RealStatePtr L, int index, MessageBox.EventId val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != MessageBoxEventId_TypeID)
				{
				    throw new Exception("invalid userdata for MessageBox.EventId");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for MessageBox.EventId ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIRTLSupportDirectionType_TypeID = -1;
		int FairyGUIRTLSupportDirectionType_EnumRef = -1;
        
        public void PushFairyGUIRTLSupportDirectionType(RealStatePtr L, FairyGUI.RTLSupport.DirectionType val)
        {
            if (FairyGUIRTLSupportDirectionType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIRTLSupportDirectionType_TypeID = getTypeId(L, typeof(FairyGUI.RTLSupport.DirectionType), out is_first);
				
				if (FairyGUIRTLSupportDirectionType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.RTLSupport.DirectionType));
				    FairyGUIRTLSupportDirectionType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIRTLSupportDirectionType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIRTLSupportDirectionType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.RTLSupport.DirectionType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIRTLSupportDirectionType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.RTLSupport.DirectionType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIRTLSupportDirectionType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.RTLSupport.DirectionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.RTLSupport.DirectionType");
                }
				val = (FairyGUI.RTLSupport.DirectionType)e;
                
            }
            else
            {
                val = (FairyGUI.RTLSupport.DirectionType)objectCasters.GetCaster(typeof(FairyGUI.RTLSupport.DirectionType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIRTLSupportDirectionType(RealStatePtr L, int index, FairyGUI.RTLSupport.DirectionType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIRTLSupportDirectionType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.RTLSupport.DirectionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.RTLSupport.DirectionType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUITextFormatSpecialStyle_TypeID = -1;
		int FairyGUITextFormatSpecialStyle_EnumRef = -1;
        
        public void PushFairyGUITextFormatSpecialStyle(RealStatePtr L, FairyGUI.TextFormat.SpecialStyle val)
        {
            if (FairyGUITextFormatSpecialStyle_TypeID == -1)
            {
			    bool is_first;
                FairyGUITextFormatSpecialStyle_TypeID = getTypeId(L, typeof(FairyGUI.TextFormat.SpecialStyle), out is_first);
				
				if (FairyGUITextFormatSpecialStyle_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.TextFormat.SpecialStyle));
				    FairyGUITextFormatSpecialStyle_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUITextFormatSpecialStyle_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUITextFormatSpecialStyle_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.TextFormat.SpecialStyle ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUITextFormatSpecialStyle_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.TextFormat.SpecialStyle val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUITextFormatSpecialStyle_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.TextFormat.SpecialStyle");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.TextFormat.SpecialStyle");
                }
				val = (FairyGUI.TextFormat.SpecialStyle)e;
                
            }
            else
            {
                val = (FairyGUI.TextFormat.SpecialStyle)objectCasters.GetCaster(typeof(FairyGUI.TextFormat.SpecialStyle))(L, index, null);
            }
        }
		
        public void UpdateFairyGUITextFormatSpecialStyle(RealStatePtr L, int index, FairyGUI.TextFormat.SpecialStyle val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUITextFormatSpecialStyle_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.TextFormat.SpecialStyle");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.TextFormat.SpecialStyle ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIGPathPointCurveType_TypeID = -1;
		int FairyGUIGPathPointCurveType_EnumRef = -1;
        
        public void PushFairyGUIGPathPointCurveType(RealStatePtr L, FairyGUI.GPathPoint.CurveType val)
        {
            if (FairyGUIGPathPointCurveType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIGPathPointCurveType_TypeID = getTypeId(L, typeof(FairyGUI.GPathPoint.CurveType), out is_first);
				
				if (FairyGUIGPathPointCurveType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.GPathPoint.CurveType));
				    FairyGUIGPathPointCurveType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIGPathPointCurveType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIGPathPointCurveType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.GPathPoint.CurveType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIGPathPointCurveType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.GPathPoint.CurveType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIGPathPointCurveType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.GPathPoint.CurveType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.GPathPoint.CurveType");
                }
				val = (FairyGUI.GPathPoint.CurveType)e;
                
            }
            else
            {
                val = (FairyGUI.GPathPoint.CurveType)objectCasters.GetCaster(typeof(FairyGUI.GPathPoint.CurveType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIGPathPointCurveType(RealStatePtr L, int index, FairyGUI.GPathPoint.CurveType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIGPathPointCurveType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.GPathPoint.CurveType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.GPathPoint.CurveType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIControllerActionActionType_TypeID = -1;
		int FairyGUIControllerActionActionType_EnumRef = -1;
        
        public void PushFairyGUIControllerActionActionType(RealStatePtr L, FairyGUI.ControllerAction.ActionType val)
        {
            if (FairyGUIControllerActionActionType_TypeID == -1)
            {
			    bool is_first;
                FairyGUIControllerActionActionType_TypeID = getTypeId(L, typeof(FairyGUI.ControllerAction.ActionType), out is_first);
				
				if (FairyGUIControllerActionActionType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.ControllerAction.ActionType));
				    FairyGUIControllerActionActionType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIControllerActionActionType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIControllerActionActionType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.ControllerAction.ActionType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIControllerActionActionType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.ControllerAction.ActionType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIControllerActionActionType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ControllerAction.ActionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.ControllerAction.ActionType");
                }
				val = (FairyGUI.ControllerAction.ActionType)e;
                
            }
            else
            {
                val = (FairyGUI.ControllerAction.ActionType)objectCasters.GetCaster(typeof(FairyGUI.ControllerAction.ActionType))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIControllerActionActionType(RealStatePtr L, int index, FairyGUI.ControllerAction.ActionType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIControllerActionActionType_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.ControllerAction.ActionType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.ControllerAction.ActionType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIUIConfigConfigKey_TypeID = -1;
		int FairyGUIUIConfigConfigKey_EnumRef = -1;
        
        public void PushFairyGUIUIConfigConfigKey(RealStatePtr L, FairyGUI.UIConfig.ConfigKey val)
        {
            if (FairyGUIUIConfigConfigKey_TypeID == -1)
            {
			    bool is_first;
                FairyGUIUIConfigConfigKey_TypeID = getTypeId(L, typeof(FairyGUI.UIConfig.ConfigKey), out is_first);
				
				if (FairyGUIUIConfigConfigKey_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.UIConfig.ConfigKey));
				    FairyGUIUIConfigConfigKey_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIUIConfigConfigKey_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIUIConfigConfigKey_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.UIConfig.ConfigKey ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIUIConfigConfigKey_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.UIConfig.ConfigKey val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUIConfigConfigKey_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.UIConfig.ConfigKey");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.UIConfig.ConfigKey");
                }
				val = (FairyGUI.UIConfig.ConfigKey)e;
                
            }
            else
            {
                val = (FairyGUI.UIConfig.ConfigKey)objectCasters.GetCaster(typeof(FairyGUI.UIConfig.ConfigKey))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIUIConfigConfigKey(RealStatePtr L, int index, FairyGUI.UIConfig.ConfigKey val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUIConfigConfigKey_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.UIConfig.ConfigKey");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.UIConfig.ConfigKey ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIUIContentScalerScaleMode_TypeID = -1;
		int FairyGUIUIContentScalerScaleMode_EnumRef = -1;
        
        public void PushFairyGUIUIContentScalerScaleMode(RealStatePtr L, FairyGUI.UIContentScaler.ScaleMode val)
        {
            if (FairyGUIUIContentScalerScaleMode_TypeID == -1)
            {
			    bool is_first;
                FairyGUIUIContentScalerScaleMode_TypeID = getTypeId(L, typeof(FairyGUI.UIContentScaler.ScaleMode), out is_first);
				
				if (FairyGUIUIContentScalerScaleMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.UIContentScaler.ScaleMode));
				    FairyGUIUIContentScalerScaleMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIUIContentScalerScaleMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIUIContentScalerScaleMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.UIContentScaler.ScaleMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIUIContentScalerScaleMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.UIContentScaler.ScaleMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUIContentScalerScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.UIContentScaler.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.UIContentScaler.ScaleMode");
                }
				val = (FairyGUI.UIContentScaler.ScaleMode)e;
                
            }
            else
            {
                val = (FairyGUI.UIContentScaler.ScaleMode)objectCasters.GetCaster(typeof(FairyGUI.UIContentScaler.ScaleMode))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIUIContentScalerScaleMode(RealStatePtr L, int index, FairyGUI.UIContentScaler.ScaleMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUIContentScalerScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.UIContentScaler.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.UIContentScaler.ScaleMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int FairyGUIUIContentScalerScreenMatchMode_TypeID = -1;
		int FairyGUIUIContentScalerScreenMatchMode_EnumRef = -1;
        
        public void PushFairyGUIUIContentScalerScreenMatchMode(RealStatePtr L, FairyGUI.UIContentScaler.ScreenMatchMode val)
        {
            if (FairyGUIUIContentScalerScreenMatchMode_TypeID == -1)
            {
			    bool is_first;
                FairyGUIUIContentScalerScreenMatchMode_TypeID = getTypeId(L, typeof(FairyGUI.UIContentScaler.ScreenMatchMode), out is_first);
				
				if (FairyGUIUIContentScalerScreenMatchMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(FairyGUI.UIContentScaler.ScreenMatchMode));
				    FairyGUIUIContentScalerScreenMatchMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, FairyGUIUIContentScalerScreenMatchMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, FairyGUIUIContentScalerScreenMatchMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for FairyGUI.UIContentScaler.ScreenMatchMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, FairyGUIUIContentScalerScreenMatchMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out FairyGUI.UIContentScaler.ScreenMatchMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUIContentScalerScreenMatchMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.UIContentScaler.ScreenMatchMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for FairyGUI.UIContentScaler.ScreenMatchMode");
                }
				val = (FairyGUI.UIContentScaler.ScreenMatchMode)e;
                
            }
            else
            {
                val = (FairyGUI.UIContentScaler.ScreenMatchMode)objectCasters.GetCaster(typeof(FairyGUI.UIContentScaler.ScreenMatchMode))(L, index, null);
            }
        }
		
        public void UpdateFairyGUIUIContentScalerScreenMatchMode(RealStatePtr L, int index, FairyGUI.UIContentScaler.ScreenMatchMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != FairyGUIUIContentScalerScreenMatchMode_TypeID)
				{
				    throw new Exception("invalid userdata for FairyGUI.UIContentScaler.ScreenMatchMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for FairyGUI.UIContentScaler.ScreenMatchMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int SystemNetSocketsSocketAsyncOperation_TypeID = -1;
		int SystemNetSocketsSocketAsyncOperation_EnumRef = -1;
        
        public void PushSystemNetSocketsSocketAsyncOperation(RealStatePtr L, System.Net.Sockets.SocketAsyncOperation val)
        {
            if (SystemNetSocketsSocketAsyncOperation_TypeID == -1)
            {
			    bool is_first;
                SystemNetSocketsSocketAsyncOperation_TypeID = getTypeId(L, typeof(System.Net.Sockets.SocketAsyncOperation), out is_first);
				
				if (SystemNetSocketsSocketAsyncOperation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(System.Net.Sockets.SocketAsyncOperation));
				    SystemNetSocketsSocketAsyncOperation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, SystemNetSocketsSocketAsyncOperation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, SystemNetSocketsSocketAsyncOperation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for System.Net.Sockets.SocketAsyncOperation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, SystemNetSocketsSocketAsyncOperation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out System.Net.Sockets.SocketAsyncOperation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsSocketAsyncOperation_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.SocketAsyncOperation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for System.Net.Sockets.SocketAsyncOperation");
                }
				val = (System.Net.Sockets.SocketAsyncOperation)e;
                
            }
            else
            {
                val = (System.Net.Sockets.SocketAsyncOperation)objectCasters.GetCaster(typeof(System.Net.Sockets.SocketAsyncOperation))(L, index, null);
            }
        }
		
        public void UpdateSystemNetSocketsSocketAsyncOperation(RealStatePtr L, int index, System.Net.Sockets.SocketAsyncOperation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsSocketAsyncOperation_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.SocketAsyncOperation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for System.Net.Sockets.SocketAsyncOperation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int SystemNetSocketsSocketError_TypeID = -1;
		int SystemNetSocketsSocketError_EnumRef = -1;
        
        public void PushSystemNetSocketsSocketError(RealStatePtr L, System.Net.Sockets.SocketError val)
        {
            if (SystemNetSocketsSocketError_TypeID == -1)
            {
			    bool is_first;
                SystemNetSocketsSocketError_TypeID = getTypeId(L, typeof(System.Net.Sockets.SocketError), out is_first);
				
				if (SystemNetSocketsSocketError_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(System.Net.Sockets.SocketError));
				    SystemNetSocketsSocketError_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, SystemNetSocketsSocketError_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, SystemNetSocketsSocketError_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for System.Net.Sockets.SocketError ,value="+val);
            }
			
			LuaAPI.lua_getref(L, SystemNetSocketsSocketError_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out System.Net.Sockets.SocketError val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsSocketError_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.SocketError");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for System.Net.Sockets.SocketError");
                }
				val = (System.Net.Sockets.SocketError)e;
                
            }
            else
            {
                val = (System.Net.Sockets.SocketError)objectCasters.GetCaster(typeof(System.Net.Sockets.SocketError))(L, index, null);
            }
        }
		
        public void UpdateSystemNetSocketsSocketError(RealStatePtr L, int index, System.Net.Sockets.SocketError val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != SystemNetSocketsSocketError_TypeID)
				{
				    throw new Exception("invalid userdata for System.Net.Sockets.SocketError");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for System.Net.Sockets.SocketError ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasUpdate_TypeID = -1;
		int UnityEngineUICanvasUpdate_EnumRef = -1;
        
        public void PushUnityEngineUICanvasUpdate(RealStatePtr L, UnityEngine.UI.CanvasUpdate val)
        {
            if (UnityEngineUICanvasUpdate_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasUpdate_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasUpdate), out is_first);
				
				if (UnityEngineUICanvasUpdate_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasUpdate));
				    UnityEngineUICanvasUpdate_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasUpdate_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasUpdate_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasUpdate ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasUpdate_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasUpdate val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasUpdate_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasUpdate");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasUpdate");
                }
				val = (UnityEngine.UI.CanvasUpdate)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasUpdate)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasUpdate))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasUpdate(RealStatePtr L, int index, UnityEngine.UI.CanvasUpdate val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasUpdate_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasUpdate");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasUpdate ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEventSystemsEventHandle_TypeID = -1;
		int UnityEngineEventSystemsEventHandle_EnumRef = -1;
        
        public void PushUnityEngineEventSystemsEventHandle(RealStatePtr L, UnityEngine.EventSystems.EventHandle val)
        {
            if (UnityEngineEventSystemsEventHandle_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEventSystemsEventHandle_TypeID = getTypeId(L, typeof(UnityEngine.EventSystems.EventHandle), out is_first);
				
				if (UnityEngineEventSystemsEventHandle_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EventSystems.EventHandle));
				    UnityEngineEventSystemsEventHandle_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEventSystemsEventHandle_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEventSystemsEventHandle_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EventSystems.EventHandle ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEventSystemsEventHandle_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EventSystems.EventHandle val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsEventHandle_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.EventHandle");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EventSystems.EventHandle");
                }
				val = (UnityEngine.EventSystems.EventHandle)e;
                
            }
            else
            {
                val = (UnityEngine.EventSystems.EventHandle)objectCasters.GetCaster(typeof(UnityEngine.EventSystems.EventHandle))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEventSystemsEventHandle(RealStatePtr L, int index, UnityEngine.EventSystems.EventHandle val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsEventHandle_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.EventHandle");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EventSystems.EventHandle ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEventSystemsEventTriggerType_TypeID = -1;
		int UnityEngineEventSystemsEventTriggerType_EnumRef = -1;
        
        public void PushUnityEngineEventSystemsEventTriggerType(RealStatePtr L, UnityEngine.EventSystems.EventTriggerType val)
        {
            if (UnityEngineEventSystemsEventTriggerType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEventSystemsEventTriggerType_TypeID = getTypeId(L, typeof(UnityEngine.EventSystems.EventTriggerType), out is_first);
				
				if (UnityEngineEventSystemsEventTriggerType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EventSystems.EventTriggerType));
				    UnityEngineEventSystemsEventTriggerType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEventSystemsEventTriggerType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEventSystemsEventTriggerType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EventSystems.EventTriggerType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEventSystemsEventTriggerType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EventSystems.EventTriggerType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsEventTriggerType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.EventTriggerType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EventSystems.EventTriggerType");
                }
				val = (UnityEngine.EventSystems.EventTriggerType)e;
                
            }
            else
            {
                val = (UnityEngine.EventSystems.EventTriggerType)objectCasters.GetCaster(typeof(UnityEngine.EventSystems.EventTriggerType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEventSystemsEventTriggerType(RealStatePtr L, int index, UnityEngine.EventSystems.EventTriggerType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsEventTriggerType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.EventTriggerType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EventSystems.EventTriggerType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEventSystemsMoveDirection_TypeID = -1;
		int UnityEngineEventSystemsMoveDirection_EnumRef = -1;
        
        public void PushUnityEngineEventSystemsMoveDirection(RealStatePtr L, UnityEngine.EventSystems.MoveDirection val)
        {
            if (UnityEngineEventSystemsMoveDirection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEventSystemsMoveDirection_TypeID = getTypeId(L, typeof(UnityEngine.EventSystems.MoveDirection), out is_first);
				
				if (UnityEngineEventSystemsMoveDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EventSystems.MoveDirection));
				    UnityEngineEventSystemsMoveDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEventSystemsMoveDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEventSystemsMoveDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EventSystems.MoveDirection ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEventSystemsMoveDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EventSystems.MoveDirection val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsMoveDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.MoveDirection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EventSystems.MoveDirection");
                }
				val = (UnityEngine.EventSystems.MoveDirection)e;
                
            }
            else
            {
                val = (UnityEngine.EventSystems.MoveDirection)objectCasters.GetCaster(typeof(UnityEngine.EventSystems.MoveDirection))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEventSystemsMoveDirection(RealStatePtr L, int index, UnityEngine.EventSystems.MoveDirection val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsMoveDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.MoveDirection");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EventSystems.MoveDirection ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGraphicRaycasterBlockingObjects_TypeID = -1;
		int UnityEngineUIGraphicRaycasterBlockingObjects_EnumRef = -1;
        
        public void PushUnityEngineUIGraphicRaycasterBlockingObjects(RealStatePtr L, UnityEngine.UI.GraphicRaycaster.BlockingObjects val)
        {
            if (UnityEngineUIGraphicRaycasterBlockingObjects_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGraphicRaycasterBlockingObjects_TypeID = getTypeId(L, typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), out is_first);
				
				if (UnityEngineUIGraphicRaycasterBlockingObjects_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects));
				    UnityEngineUIGraphicRaycasterBlockingObjects_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGraphicRaycasterBlockingObjects_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGraphicRaycasterBlockingObjects_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GraphicRaycaster.BlockingObjects ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGraphicRaycasterBlockingObjects_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GraphicRaycaster.BlockingObjects val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGraphicRaycasterBlockingObjects_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GraphicRaycaster.BlockingObjects");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GraphicRaycaster.BlockingObjects");
                }
				val = (UnityEngine.UI.GraphicRaycaster.BlockingObjects)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GraphicRaycaster.BlockingObjects)objectCasters.GetCaster(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGraphicRaycasterBlockingObjects(RealStatePtr L, int index, UnityEngine.UI.GraphicRaycaster.BlockingObjects val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGraphicRaycasterBlockingObjects_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GraphicRaycaster.BlockingObjects");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GraphicRaycaster.BlockingObjects ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageType_TypeID = -1;
		int UnityEngineUIImageType_EnumRef = -1;
        
        public void PushUnityEngineUIImageType(RealStatePtr L, UnityEngine.UI.Image.Type val)
        {
            if (UnityEngineUIImageType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageType_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Type), out is_first);
				
				if (UnityEngineUIImageType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Type));
				    UnityEngineUIImageType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Type ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Type val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Type");
                }
				val = (UnityEngine.UI.Image.Type)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Type)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Type))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageType(RealStatePtr L, int index, UnityEngine.UI.Image.Type val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Type ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageFillMethod_TypeID = -1;
		int UnityEngineUIImageFillMethod_EnumRef = -1;
        
        public void PushUnityEngineUIImageFillMethod(RealStatePtr L, UnityEngine.UI.Image.FillMethod val)
        {
            if (UnityEngineUIImageFillMethod_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageFillMethod_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.FillMethod), out is_first);
				
				if (UnityEngineUIImageFillMethod_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.FillMethod));
				    UnityEngineUIImageFillMethod_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageFillMethod_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageFillMethod_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.FillMethod ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageFillMethod_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.FillMethod val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.FillMethod");
                }
				val = (UnityEngine.UI.Image.FillMethod)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.FillMethod)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.FillMethod))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageFillMethod(RealStatePtr L, int index, UnityEngine.UI.Image.FillMethod val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.FillMethod ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOriginHorizontal_TypeID = -1;
		int UnityEngineUIImageOriginHorizontal_EnumRef = -1;
        
        public void PushUnityEngineUIImageOriginHorizontal(RealStatePtr L, UnityEngine.UI.Image.OriginHorizontal val)
        {
            if (UnityEngineUIImageOriginHorizontal_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOriginHorizontal_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.OriginHorizontal), out is_first);
				
				if (UnityEngineUIImageOriginHorizontal_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.OriginHorizontal));
				    UnityEngineUIImageOriginHorizontal_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOriginHorizontal_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOriginHorizontal_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.OriginHorizontal ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOriginHorizontal_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.OriginHorizontal val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.OriginHorizontal");
                }
				val = (UnityEngine.UI.Image.OriginHorizontal)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.OriginHorizontal)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.OriginHorizontal))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOriginHorizontal(RealStatePtr L, int index, UnityEngine.UI.Image.OriginHorizontal val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.OriginHorizontal ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOriginVertical_TypeID = -1;
		int UnityEngineUIImageOriginVertical_EnumRef = -1;
        
        public void PushUnityEngineUIImageOriginVertical(RealStatePtr L, UnityEngine.UI.Image.OriginVertical val)
        {
            if (UnityEngineUIImageOriginVertical_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOriginVertical_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.OriginVertical), out is_first);
				
				if (UnityEngineUIImageOriginVertical_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.OriginVertical));
				    UnityEngineUIImageOriginVertical_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOriginVertical_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOriginVertical_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.OriginVertical ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOriginVertical_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.OriginVertical val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.OriginVertical");
                }
				val = (UnityEngine.UI.Image.OriginVertical)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.OriginVertical)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.OriginVertical))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOriginVertical(RealStatePtr L, int index, UnityEngine.UI.Image.OriginVertical val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.OriginVertical ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin90_TypeID = -1;
		int UnityEngineUIImageOrigin90_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin90(RealStatePtr L, UnityEngine.UI.Image.Origin90 val)
        {
            if (UnityEngineUIImageOrigin90_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin90_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin90), out is_first);
				
				if (UnityEngineUIImageOrigin90_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin90));
				    UnityEngineUIImageOrigin90_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin90_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin90_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin90 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin90_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin90 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin90");
                }
				val = (UnityEngine.UI.Image.Origin90)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin90)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin90))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin90(RealStatePtr L, int index, UnityEngine.UI.Image.Origin90 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin90 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin180_TypeID = -1;
		int UnityEngineUIImageOrigin180_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin180(RealStatePtr L, UnityEngine.UI.Image.Origin180 val)
        {
            if (UnityEngineUIImageOrigin180_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin180_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin180), out is_first);
				
				if (UnityEngineUIImageOrigin180_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin180));
				    UnityEngineUIImageOrigin180_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin180_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin180_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin180 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin180_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin180 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin180");
                }
				val = (UnityEngine.UI.Image.Origin180)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin180)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin180))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin180(RealStatePtr L, int index, UnityEngine.UI.Image.Origin180 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin180 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin360_TypeID = -1;
		int UnityEngineUIImageOrigin360_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin360(RealStatePtr L, UnityEngine.UI.Image.Origin360 val)
        {
            if (UnityEngineUIImageOrigin360_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin360_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin360), out is_first);
				
				if (UnityEngineUIImageOrigin360_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin360));
				    UnityEngineUIImageOrigin360_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin360_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin360_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin360 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin360_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin360 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin360");
                }
				val = (UnityEngine.UI.Image.Origin360)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin360)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin360))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin360(RealStatePtr L, int index, UnityEngine.UI.Image.Origin360 val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin360 ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldContentType_TypeID = -1;
		int UnityEngineUIInputFieldContentType_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldContentType(RealStatePtr L, UnityEngine.UI.InputField.ContentType val)
        {
            if (UnityEngineUIInputFieldContentType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldContentType_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.ContentType), out is_first);
				
				if (UnityEngineUIInputFieldContentType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.ContentType));
				    UnityEngineUIInputFieldContentType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldContentType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldContentType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.ContentType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldContentType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.ContentType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldContentType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.ContentType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.ContentType");
                }
				val = (UnityEngine.UI.InputField.ContentType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.ContentType)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.ContentType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldContentType(RealStatePtr L, int index, UnityEngine.UI.InputField.ContentType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldContentType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.ContentType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.ContentType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldInputType_TypeID = -1;
		int UnityEngineUIInputFieldInputType_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldInputType(RealStatePtr L, UnityEngine.UI.InputField.InputType val)
        {
            if (UnityEngineUIInputFieldInputType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldInputType_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.InputType), out is_first);
				
				if (UnityEngineUIInputFieldInputType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.InputType));
				    UnityEngineUIInputFieldInputType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldInputType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldInputType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.InputType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldInputType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.InputType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldInputType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.InputType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.InputType");
                }
				val = (UnityEngine.UI.InputField.InputType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.InputType)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.InputType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldInputType(RealStatePtr L, int index, UnityEngine.UI.InputField.InputType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldInputType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.InputType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.InputType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldCharacterValidation_TypeID = -1;
		int UnityEngineUIInputFieldCharacterValidation_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldCharacterValidation(RealStatePtr L, UnityEngine.UI.InputField.CharacterValidation val)
        {
            if (UnityEngineUIInputFieldCharacterValidation_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldCharacterValidation_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.CharacterValidation), out is_first);
				
				if (UnityEngineUIInputFieldCharacterValidation_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.CharacterValidation));
				    UnityEngineUIInputFieldCharacterValidation_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldCharacterValidation_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldCharacterValidation_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.CharacterValidation ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldCharacterValidation_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.CharacterValidation val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldCharacterValidation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.CharacterValidation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.CharacterValidation");
                }
				val = (UnityEngine.UI.InputField.CharacterValidation)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.CharacterValidation)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.CharacterValidation))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldCharacterValidation(RealStatePtr L, int index, UnityEngine.UI.InputField.CharacterValidation val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldCharacterValidation_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.CharacterValidation");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.CharacterValidation ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIInputFieldLineType_TypeID = -1;
		int UnityEngineUIInputFieldLineType_EnumRef = -1;
        
        public void PushUnityEngineUIInputFieldLineType(RealStatePtr L, UnityEngine.UI.InputField.LineType val)
        {
            if (UnityEngineUIInputFieldLineType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIInputFieldLineType_TypeID = getTypeId(L, typeof(UnityEngine.UI.InputField.LineType), out is_first);
				
				if (UnityEngineUIInputFieldLineType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.InputField.LineType));
				    UnityEngineUIInputFieldLineType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIInputFieldLineType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIInputFieldLineType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.InputField.LineType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIInputFieldLineType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.InputField.LineType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldLineType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.LineType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.InputField.LineType");
                }
				val = (UnityEngine.UI.InputField.LineType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.InputField.LineType)objectCasters.GetCaster(typeof(UnityEngine.UI.InputField.LineType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIInputFieldLineType(RealStatePtr L, int index, UnityEngine.UI.InputField.LineType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIInputFieldLineType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.InputField.LineType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.InputField.LineType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIAspectRatioFitterAspectMode_TypeID = -1;
		int UnityEngineUIAspectRatioFitterAspectMode_EnumRef = -1;
        
        public void PushUnityEngineUIAspectRatioFitterAspectMode(RealStatePtr L, UnityEngine.UI.AspectRatioFitter.AspectMode val)
        {
            if (UnityEngineUIAspectRatioFitterAspectMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIAspectRatioFitterAspectMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), out is_first);
				
				if (UnityEngineUIAspectRatioFitterAspectMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.AspectRatioFitter.AspectMode));
				    UnityEngineUIAspectRatioFitterAspectMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIAspectRatioFitterAspectMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIAspectRatioFitterAspectMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.AspectRatioFitter.AspectMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIAspectRatioFitterAspectMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.AspectRatioFitter.AspectMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIAspectRatioFitterAspectMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.AspectRatioFitter.AspectMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.AspectRatioFitter.AspectMode");
                }
				val = (UnityEngine.UI.AspectRatioFitter.AspectMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.AspectRatioFitter.AspectMode)objectCasters.GetCaster(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIAspectRatioFitterAspectMode(RealStatePtr L, int index, UnityEngine.UI.AspectRatioFitter.AspectMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIAspectRatioFitterAspectMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.AspectRatioFitter.AspectMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.AspectRatioFitter.AspectMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasScalerScaleMode_TypeID = -1;
		int UnityEngineUICanvasScalerScaleMode_EnumRef = -1;
        
        public void PushUnityEngineUICanvasScalerScaleMode(RealStatePtr L, UnityEngine.UI.CanvasScaler.ScaleMode val)
        {
            if (UnityEngineUICanvasScalerScaleMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasScalerScaleMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasScaler.ScaleMode), out is_first);
				
				if (UnityEngineUICanvasScalerScaleMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasScaler.ScaleMode));
				    UnityEngineUICanvasScalerScaleMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasScalerScaleMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasScalerScaleMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasScaler.ScaleMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasScalerScaleMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasScaler.ScaleMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasScaler.ScaleMode");
                }
				val = (UnityEngine.UI.CanvasScaler.ScaleMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasScaler.ScaleMode)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasScaler.ScaleMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasScalerScaleMode(RealStatePtr L, int index, UnityEngine.UI.CanvasScaler.ScaleMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScaleMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScaleMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasScaler.ScaleMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasScalerScreenMatchMode_TypeID = -1;
		int UnityEngineUICanvasScalerScreenMatchMode_EnumRef = -1;
        
        public void PushUnityEngineUICanvasScalerScreenMatchMode(RealStatePtr L, UnityEngine.UI.CanvasScaler.ScreenMatchMode val)
        {
            if (UnityEngineUICanvasScalerScreenMatchMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasScalerScreenMatchMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), out is_first);
				
				if (UnityEngineUICanvasScalerScreenMatchMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode));
				    UnityEngineUICanvasScalerScreenMatchMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasScalerScreenMatchMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasScalerScreenMatchMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasScaler.ScreenMatchMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasScalerScreenMatchMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasScaler.ScreenMatchMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScreenMatchMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScreenMatchMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasScaler.ScreenMatchMode");
                }
				val = (UnityEngine.UI.CanvasScaler.ScreenMatchMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasScaler.ScreenMatchMode)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasScalerScreenMatchMode(RealStatePtr L, int index, UnityEngine.UI.CanvasScaler.ScreenMatchMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerScreenMatchMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.ScreenMatchMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasScaler.ScreenMatchMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUICanvasScalerUnit_TypeID = -1;
		int UnityEngineUICanvasScalerUnit_EnumRef = -1;
        
        public void PushUnityEngineUICanvasScalerUnit(RealStatePtr L, UnityEngine.UI.CanvasScaler.Unit val)
        {
            if (UnityEngineUICanvasScalerUnit_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUICanvasScalerUnit_TypeID = getTypeId(L, typeof(UnityEngine.UI.CanvasScaler.Unit), out is_first);
				
				if (UnityEngineUICanvasScalerUnit_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.CanvasScaler.Unit));
				    UnityEngineUICanvasScalerUnit_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUICanvasScalerUnit_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUICanvasScalerUnit_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.CanvasScaler.Unit ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUICanvasScalerUnit_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.CanvasScaler.Unit val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerUnit_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.Unit");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.CanvasScaler.Unit");
                }
				val = (UnityEngine.UI.CanvasScaler.Unit)e;
                
            }
            else
            {
                val = (UnityEngine.UI.CanvasScaler.Unit)objectCasters.GetCaster(typeof(UnityEngine.UI.CanvasScaler.Unit))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUICanvasScalerUnit(RealStatePtr L, int index, UnityEngine.UI.CanvasScaler.Unit val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUICanvasScalerUnit_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.CanvasScaler.Unit");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.CanvasScaler.Unit ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIContentSizeFitterFitMode_TypeID = -1;
		int UnityEngineUIContentSizeFitterFitMode_EnumRef = -1;
        
        public void PushUnityEngineUIContentSizeFitterFitMode(RealStatePtr L, UnityEngine.UI.ContentSizeFitter.FitMode val)
        {
            if (UnityEngineUIContentSizeFitterFitMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIContentSizeFitterFitMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.ContentSizeFitter.FitMode), out is_first);
				
				if (UnityEngineUIContentSizeFitterFitMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.ContentSizeFitter.FitMode));
				    UnityEngineUIContentSizeFitterFitMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIContentSizeFitterFitMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIContentSizeFitterFitMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.ContentSizeFitter.FitMode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIContentSizeFitterFitMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.ContentSizeFitter.FitMode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIContentSizeFitterFitMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ContentSizeFitter.FitMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.ContentSizeFitter.FitMode");
                }
				val = (UnityEngine.UI.ContentSizeFitter.FitMode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.ContentSizeFitter.FitMode)objectCasters.GetCaster(typeof(UnityEngine.UI.ContentSizeFitter.FitMode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIContentSizeFitterFitMode(RealStatePtr L, int index, UnityEngine.UI.ContentSizeFitter.FitMode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIContentSizeFitterFitMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ContentSizeFitter.FitMode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.ContentSizeFitter.FitMode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGridLayoutGroupCorner_TypeID = -1;
		int UnityEngineUIGridLayoutGroupCorner_EnumRef = -1;
        
        public void PushUnityEngineUIGridLayoutGroupCorner(RealStatePtr L, UnityEngine.UI.GridLayoutGroup.Corner val)
        {
            if (UnityEngineUIGridLayoutGroupCorner_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGridLayoutGroupCorner_TypeID = getTypeId(L, typeof(UnityEngine.UI.GridLayoutGroup.Corner), out is_first);
				
				if (UnityEngineUIGridLayoutGroupCorner_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GridLayoutGroup.Corner));
				    UnityEngineUIGridLayoutGroupCorner_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGridLayoutGroupCorner_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGridLayoutGroupCorner_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GridLayoutGroup.Corner ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGridLayoutGroupCorner_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GridLayoutGroup.Corner val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupCorner_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Corner");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GridLayoutGroup.Corner");
                }
				val = (UnityEngine.UI.GridLayoutGroup.Corner)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GridLayoutGroup.Corner)objectCasters.GetCaster(typeof(UnityEngine.UI.GridLayoutGroup.Corner))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGridLayoutGroupCorner(RealStatePtr L, int index, UnityEngine.UI.GridLayoutGroup.Corner val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupCorner_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Corner");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GridLayoutGroup.Corner ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGridLayoutGroupAxis_TypeID = -1;
		int UnityEngineUIGridLayoutGroupAxis_EnumRef = -1;
        
        public void PushUnityEngineUIGridLayoutGroupAxis(RealStatePtr L, UnityEngine.UI.GridLayoutGroup.Axis val)
        {
            if (UnityEngineUIGridLayoutGroupAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGridLayoutGroupAxis_TypeID = getTypeId(L, typeof(UnityEngine.UI.GridLayoutGroup.Axis), out is_first);
				
				if (UnityEngineUIGridLayoutGroupAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GridLayoutGroup.Axis));
				    UnityEngineUIGridLayoutGroupAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGridLayoutGroupAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGridLayoutGroupAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GridLayoutGroup.Axis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGridLayoutGroupAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GridLayoutGroup.Axis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GridLayoutGroup.Axis");
                }
				val = (UnityEngine.UI.GridLayoutGroup.Axis)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GridLayoutGroup.Axis)objectCasters.GetCaster(typeof(UnityEngine.UI.GridLayoutGroup.Axis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGridLayoutGroupAxis(RealStatePtr L, int index, UnityEngine.UI.GridLayoutGroup.Axis val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GridLayoutGroup.Axis ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIGridLayoutGroupConstraint_TypeID = -1;
		int UnityEngineUIGridLayoutGroupConstraint_EnumRef = -1;
        
        public void PushUnityEngineUIGridLayoutGroupConstraint(RealStatePtr L, UnityEngine.UI.GridLayoutGroup.Constraint val)
        {
            if (UnityEngineUIGridLayoutGroupConstraint_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIGridLayoutGroupConstraint_TypeID = getTypeId(L, typeof(UnityEngine.UI.GridLayoutGroup.Constraint), out is_first);
				
				if (UnityEngineUIGridLayoutGroupConstraint_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.GridLayoutGroup.Constraint));
				    UnityEngineUIGridLayoutGroupConstraint_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIGridLayoutGroupConstraint_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIGridLayoutGroupConstraint_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.GridLayoutGroup.Constraint ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIGridLayoutGroupConstraint_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.GridLayoutGroup.Constraint val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupConstraint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Constraint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.GridLayoutGroup.Constraint");
                }
				val = (UnityEngine.UI.GridLayoutGroup.Constraint)e;
                
            }
            else
            {
                val = (UnityEngine.UI.GridLayoutGroup.Constraint)objectCasters.GetCaster(typeof(UnityEngine.UI.GridLayoutGroup.Constraint))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIGridLayoutGroupConstraint(RealStatePtr L, int index, UnityEngine.UI.GridLayoutGroup.Constraint val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIGridLayoutGroupConstraint_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.GridLayoutGroup.Constraint");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.GridLayoutGroup.Constraint ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUINavigationMode_TypeID = -1;
		int UnityEngineUINavigationMode_EnumRef = -1;
        
        public void PushUnityEngineUINavigationMode(RealStatePtr L, UnityEngine.UI.Navigation.Mode val)
        {
            if (UnityEngineUINavigationMode_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUINavigationMode_TypeID = getTypeId(L, typeof(UnityEngine.UI.Navigation.Mode), out is_first);
				
				if (UnityEngineUINavigationMode_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Navigation.Mode));
				    UnityEngineUINavigationMode_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUINavigationMode_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUINavigationMode_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Navigation.Mode ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUINavigationMode_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Navigation.Mode val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUINavigationMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Navigation.Mode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Navigation.Mode");
                }
				val = (UnityEngine.UI.Navigation.Mode)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Navigation.Mode)objectCasters.GetCaster(typeof(UnityEngine.UI.Navigation.Mode))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUINavigationMode(RealStatePtr L, int index, UnityEngine.UI.Navigation.Mode val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUINavigationMode_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Navigation.Mode");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Navigation.Mode ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIScrollRectMovementType_TypeID = -1;
		int UnityEngineUIScrollRectMovementType_EnumRef = -1;
        
        public void PushUnityEngineUIScrollRectMovementType(RealStatePtr L, UnityEngine.UI.ScrollRect.MovementType val)
        {
            if (UnityEngineUIScrollRectMovementType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIScrollRectMovementType_TypeID = getTypeId(L, typeof(UnityEngine.UI.ScrollRect.MovementType), out is_first);
				
				if (UnityEngineUIScrollRectMovementType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.ScrollRect.MovementType));
				    UnityEngineUIScrollRectMovementType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIScrollRectMovementType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIScrollRectMovementType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.ScrollRect.MovementType ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIScrollRectMovementType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.ScrollRect.MovementType val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectMovementType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.MovementType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.ScrollRect.MovementType");
                }
				val = (UnityEngine.UI.ScrollRect.MovementType)e;
                
            }
            else
            {
                val = (UnityEngine.UI.ScrollRect.MovementType)objectCasters.GetCaster(typeof(UnityEngine.UI.ScrollRect.MovementType))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIScrollRectMovementType(RealStatePtr L, int index, UnityEngine.UI.ScrollRect.MovementType val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectMovementType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.MovementType");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.ScrollRect.MovementType ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIScrollRectScrollbarVisibility_TypeID = -1;
		int UnityEngineUIScrollRectScrollbarVisibility_EnumRef = -1;
        
        public void PushUnityEngineUIScrollRectScrollbarVisibility(RealStatePtr L, UnityEngine.UI.ScrollRect.ScrollbarVisibility val)
        {
            if (UnityEngineUIScrollRectScrollbarVisibility_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIScrollRectScrollbarVisibility_TypeID = getTypeId(L, typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), out is_first);
				
				if (UnityEngineUIScrollRectScrollbarVisibility_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility));
				    UnityEngineUIScrollRectScrollbarVisibility_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIScrollRectScrollbarVisibility_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIScrollRectScrollbarVisibility_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.ScrollRect.ScrollbarVisibility ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIScrollRectScrollbarVisibility_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.ScrollRect.ScrollbarVisibility val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectScrollbarVisibility_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.ScrollbarVisibility");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.ScrollRect.ScrollbarVisibility");
                }
				val = (UnityEngine.UI.ScrollRect.ScrollbarVisibility)e;
                
            }
            else
            {
                val = (UnityEngine.UI.ScrollRect.ScrollbarVisibility)objectCasters.GetCaster(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIScrollRectScrollbarVisibility(RealStatePtr L, int index, UnityEngine.UI.ScrollRect.ScrollbarVisibility val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollRectScrollbarVisibility_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.ScrollRect.ScrollbarVisibility");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.ScrollRect.ScrollbarVisibility ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIScrollbarDirection_TypeID = -1;
		int UnityEngineUIScrollbarDirection_EnumRef = -1;
        
        public void PushUnityEngineUIScrollbarDirection(RealStatePtr L, UnityEngine.UI.Scrollbar.Direction val)
        {
            if (UnityEngineUIScrollbarDirection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIScrollbarDirection_TypeID = getTypeId(L, typeof(UnityEngine.UI.Scrollbar.Direction), out is_first);
				
				if (UnityEngineUIScrollbarDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Scrollbar.Direction));
				    UnityEngineUIScrollbarDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIScrollbarDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIScrollbarDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Scrollbar.Direction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIScrollbarDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Scrollbar.Direction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollbarDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Scrollbar.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Scrollbar.Direction");
                }
				val = (UnityEngine.UI.Scrollbar.Direction)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Scrollbar.Direction)objectCasters.GetCaster(typeof(UnityEngine.UI.Scrollbar.Direction))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIScrollbarDirection(RealStatePtr L, int index, UnityEngine.UI.Scrollbar.Direction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIScrollbarDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Scrollbar.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Scrollbar.Direction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUISliderDirection_TypeID = -1;
		int UnityEngineUISliderDirection_EnumRef = -1;
        
        public void PushUnityEngineUISliderDirection(RealStatePtr L, UnityEngine.UI.Slider.Direction val)
        {
            if (UnityEngineUISliderDirection_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUISliderDirection_TypeID = getTypeId(L, typeof(UnityEngine.UI.Slider.Direction), out is_first);
				
				if (UnityEngineUISliderDirection_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Slider.Direction));
				    UnityEngineUISliderDirection_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUISliderDirection_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUISliderDirection_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Slider.Direction ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUISliderDirection_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Slider.Direction val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISliderDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Slider.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Slider.Direction");
                }
				val = (UnityEngine.UI.Slider.Direction)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Slider.Direction)objectCasters.GetCaster(typeof(UnityEngine.UI.Slider.Direction))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUISliderDirection(RealStatePtr L, int index, UnityEngine.UI.Slider.Direction val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUISliderDirection_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Slider.Direction");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Slider.Direction ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIToggleToggleTransition_TypeID = -1;
		int UnityEngineUIToggleToggleTransition_EnumRef = -1;
        
        public void PushUnityEngineUIToggleToggleTransition(RealStatePtr L, UnityEngine.UI.Toggle.ToggleTransition val)
        {
            if (UnityEngineUIToggleToggleTransition_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIToggleToggleTransition_TypeID = getTypeId(L, typeof(UnityEngine.UI.Toggle.ToggleTransition), out is_first);
				
				if (UnityEngineUIToggleToggleTransition_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Toggle.ToggleTransition));
				    UnityEngineUIToggleToggleTransition_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIToggleToggleTransition_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIToggleToggleTransition_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Toggle.ToggleTransition ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIToggleToggleTransition_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Toggle.ToggleTransition val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIToggleToggleTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Toggle.ToggleTransition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Toggle.ToggleTransition");
                }
				val = (UnityEngine.UI.Toggle.ToggleTransition)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Toggle.ToggleTransition)objectCasters.GetCaster(typeof(UnityEngine.UI.Toggle.ToggleTransition))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIToggleToggleTransition(RealStatePtr L, int index, UnityEngine.UI.Toggle.ToggleTransition val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIToggleToggleTransition_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Toggle.ToggleTransition");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Toggle.ToggleTransition ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEventSystemsPointerEventDataInputButton_TypeID = -1;
		int UnityEngineEventSystemsPointerEventDataInputButton_EnumRef = -1;
        
        public void PushUnityEngineEventSystemsPointerEventDataInputButton(RealStatePtr L, UnityEngine.EventSystems.PointerEventData.InputButton val)
        {
            if (UnityEngineEventSystemsPointerEventDataInputButton_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEventSystemsPointerEventDataInputButton_TypeID = getTypeId(L, typeof(UnityEngine.EventSystems.PointerEventData.InputButton), out is_first);
				
				if (UnityEngineEventSystemsPointerEventDataInputButton_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EventSystems.PointerEventData.InputButton));
				    UnityEngineEventSystemsPointerEventDataInputButton_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEventSystemsPointerEventDataInputButton_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEventSystemsPointerEventDataInputButton_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EventSystems.PointerEventData.InputButton ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEventSystemsPointerEventDataInputButton_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EventSystems.PointerEventData.InputButton val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsPointerEventDataInputButton_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.PointerEventData.InputButton");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EventSystems.PointerEventData.InputButton");
                }
				val = (UnityEngine.EventSystems.PointerEventData.InputButton)e;
                
            }
            else
            {
                val = (UnityEngine.EventSystems.PointerEventData.InputButton)objectCasters.GetCaster(typeof(UnityEngine.EventSystems.PointerEventData.InputButton))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEventSystemsPointerEventDataInputButton(RealStatePtr L, int index, UnityEngine.EventSystems.PointerEventData.InputButton val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsPointerEventDataInputButton_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.PointerEventData.InputButton");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EventSystems.PointerEventData.InputButton ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineEventSystemsPointerEventDataFramePressState_TypeID = -1;
		int UnityEngineEventSystemsPointerEventDataFramePressState_EnumRef = -1;
        
        public void PushUnityEngineEventSystemsPointerEventDataFramePressState(RealStatePtr L, UnityEngine.EventSystems.PointerEventData.FramePressState val)
        {
            if (UnityEngineEventSystemsPointerEventDataFramePressState_TypeID == -1)
            {
			    bool is_first;
                UnityEngineEventSystemsPointerEventDataFramePressState_TypeID = getTypeId(L, typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), out is_first);
				
				if (UnityEngineEventSystemsPointerEventDataFramePressState_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.EventSystems.PointerEventData.FramePressState));
				    UnityEngineEventSystemsPointerEventDataFramePressState_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineEventSystemsPointerEventDataFramePressState_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineEventSystemsPointerEventDataFramePressState_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.EventSystems.PointerEventData.FramePressState ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineEventSystemsPointerEventDataFramePressState_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.EventSystems.PointerEventData.FramePressState val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsPointerEventDataFramePressState_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.PointerEventData.FramePressState");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.EventSystems.PointerEventData.FramePressState");
                }
				val = (UnityEngine.EventSystems.PointerEventData.FramePressState)e;
                
            }
            else
            {
                val = (UnityEngine.EventSystems.PointerEventData.FramePressState)objectCasters.GetCaster(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineEventSystemsPointerEventDataFramePressState(RealStatePtr L, int index, UnityEngine.EventSystems.PointerEventData.FramePressState val)
        {
		    
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineEventSystemsPointerEventDataFramePressState_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.EventSystems.PointerEventData.FramePressState");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.EventSystems.PointerEventData.FramePressState ,value="+val);
                }
            }
			
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        
		// table cast optimze
		
        
    }
	
	public partial class StaticLuaCallbacks
    {
	    internal static bool __tryArrayGet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int index)
		{
		
			if (type == typeof(UnityEngine.Vector2[]))
			{
			    UnityEngine.Vector2[] array = obj as UnityEngine.Vector2[];
				translator.PushUnityEngineVector2(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector3[]))
			{
			    UnityEngine.Vector3[] array = obj as UnityEngine.Vector3[];
				translator.PushUnityEngineVector3(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector4[]))
			{
			    UnityEngine.Vector4[] array = obj as UnityEngine.Vector4[];
				translator.PushUnityEngineVector4(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Color[]))
			{
			    UnityEngine.Color[] array = obj as UnityEngine.Color[];
				translator.PushUnityEngineColor(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Quaternion[]))
			{
			    UnityEngine.Quaternion[] array = obj as UnityEngine.Quaternion[];
				translator.PushUnityEngineQuaternion(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray[]))
			{
			    UnityEngine.Ray[] array = obj as UnityEngine.Ray[];
				translator.PushUnityEngineRay(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Bounds[]))
			{
			    UnityEngine.Bounds[] array = obj as UnityEngine.Bounds[];
				translator.PushUnityEngineBounds(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray2D[]))
			{
			    UnityEngine.Ray2D[] array = obj as UnityEngine.Ray2D[];
				translator.PushUnityEngineRay2D(L, array[index]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.AddressFamily[]))
			{
			    System.Net.Sockets.AddressFamily[] array = obj as System.Net.Sockets.AddressFamily[];
				translator.PushSystemNetSocketsAddressFamily(L, array[index]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.SocketType[]))
			{
			    System.Net.Sockets.SocketType[] array = obj as System.Net.Sockets.SocketType[];
				translator.PushSystemNetSocketsSocketType(L, array[index]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.ProtocolType[]))
			{
			    System.Net.Sockets.ProtocolType[] array = obj as System.Net.Sockets.ProtocolType[];
				translator.PushSystemNetSocketsProtocolType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Axis[]))
			{
			    UnityEngine.RectTransform.Axis[] array = obj as UnityEngine.RectTransform.Axis[];
				translator.PushUnityEngineRectTransformAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Edge[]))
			{
			    UnityEngine.RectTransform.Edge[] array = obj as UnityEngine.RectTransform.Edge[];
				translator.PushUnityEngineRectTransformEdge(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Selectable.Transition[]))
			{
			    UnityEngine.UI.Selectable.Transition[] array = obj as UnityEngine.UI.Selectable.Transition[];
				translator.PushUnityEngineUISelectableTransition(L, array[index]);
				return true;
			}
			else if (type == typeof(System.IO.SeekOrigin[]))
			{
			    System.IO.SeekOrigin[] array = obj as System.IO.SeekOrigin[];
				translator.PushSystemIOSeekOrigin(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Texture2D.EXRFlags[]))
			{
			    UnityEngine.Texture2D.EXRFlags[] array = obj as UnityEngine.Texture2D.EXRFlags[];
				translator.PushUnityEngineTexture2DEXRFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(libx.LoadState[]))
			{
			    libx.LoadState[] array = obj as libx.LoadState[];
				translator.PushlibxLoadState(L, array[index]);
				return true;
			}
			else if (type == typeof(libx.VerifyBy[]))
			{
			    libx.VerifyBy[] array = obj as libx.VerifyBy[];
				translator.PushlibxVerifyBy(L, array[index]);
				return true;
			}
			else if (type == typeof(Battlehub.UIControls.ItemDropAction[]))
			{
			    Battlehub.UIControls.ItemDropAction[] array = obj as Battlehub.UIControls.ItemDropAction[];
				translator.PushBattlehubUIControlsItemDropAction(L, array[index]);
				return true;
			}
			else if (type == typeof(Battlehub.UIControls.VirtualizingMode[]))
			{
			    Battlehub.UIControls.VirtualizingMode[] array = obj as Battlehub.UIControls.VirtualizingMode[];
				translator.PushBattlehubUIControlsVirtualizingMode(L, array[index]);
				return true;
			}
			else if (type == typeof(Battlehub.UIControls.DockPanels.RegionSplitType[]))
			{
			    Battlehub.UIControls.DockPanels.RegionSplitType[] array = obj as Battlehub.UIControls.DockPanels.RegionSplitType[];
				translator.PushBattlehubUIControlsDockPanelsRegionSplitType(L, array[index]);
				return true;
			}
			else if (type == typeof(Battlehub.Utils.KnownCursor[]))
			{
			    Battlehub.Utils.KnownCursor[] array = obj as Battlehub.Utils.KnownCursor[];
				translator.PushBattlehubUtilsKnownCursor(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.BlendMode[]))
			{
			    FairyGUI.BlendMode[] array = obj as FairyGUI.BlendMode[];
				translator.PushFairyGUIBlendMode(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.HitTestMode[]))
			{
			    FairyGUI.HitTestMode[] array = obj as FairyGUI.HitTestMode[];
				translator.PushFairyGUIHitTestMode(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.MaterialFlags[]))
			{
			    FairyGUI.MaterialFlags[] array = obj as FairyGUI.MaterialFlags[];
				translator.PushFairyGUIMaterialFlags(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.DestroyMethod[]))
			{
			    FairyGUI.DestroyMethod[] array = obj as FairyGUI.DestroyMethod[];
				translator.PushFairyGUIDestroyMethod(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.EaseType[]))
			{
			    FairyGUI.EaseType[] array = obj as FairyGUI.EaseType[];
				translator.PushFairyGUIEaseType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.TweenPropType[]))
			{
			    FairyGUI.TweenPropType[] array = obj as FairyGUI.TweenPropType[];
				translator.PushFairyGUITweenPropType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.PackageItemType[]))
			{
			    FairyGUI.PackageItemType[] array = obj as FairyGUI.PackageItemType[];
				translator.PushFairyGUIPackageItemType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ObjectType[]))
			{
			    FairyGUI.ObjectType[] array = obj as FairyGUI.ObjectType[];
				translator.PushFairyGUIObjectType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.AlignType[]))
			{
			    FairyGUI.AlignType[] array = obj as FairyGUI.AlignType[];
				translator.PushFairyGUIAlignType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.VertAlignType[]))
			{
			    FairyGUI.VertAlignType[] array = obj as FairyGUI.VertAlignType[];
				translator.PushFairyGUIVertAlignType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.OverflowType[]))
			{
			    FairyGUI.OverflowType[] array = obj as FairyGUI.OverflowType[];
				translator.PushFairyGUIOverflowType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.FillType[]))
			{
			    FairyGUI.FillType[] array = obj as FairyGUI.FillType[];
				translator.PushFairyGUIFillType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.AutoSizeType[]))
			{
			    FairyGUI.AutoSizeType[] array = obj as FairyGUI.AutoSizeType[];
				translator.PushFairyGUIAutoSizeType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ScrollType[]))
			{
			    FairyGUI.ScrollType[] array = obj as FairyGUI.ScrollType[];
				translator.PushFairyGUIScrollType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ScrollBarDisplayType[]))
			{
			    FairyGUI.ScrollBarDisplayType[] array = obj as FairyGUI.ScrollBarDisplayType[];
				translator.PushFairyGUIScrollBarDisplayType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.RelationType[]))
			{
			    FairyGUI.RelationType[] array = obj as FairyGUI.RelationType[];
				translator.PushFairyGUIRelationType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ListLayoutType[]))
			{
			    FairyGUI.ListLayoutType[] array = obj as FairyGUI.ListLayoutType[];
				translator.PushFairyGUIListLayoutType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ListSelectionMode[]))
			{
			    FairyGUI.ListSelectionMode[] array = obj as FairyGUI.ListSelectionMode[];
				translator.PushFairyGUIListSelectionMode(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ProgressTitleType[]))
			{
			    FairyGUI.ProgressTitleType[] array = obj as FairyGUI.ProgressTitleType[];
				translator.PushFairyGUIProgressTitleType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ButtonMode[]))
			{
			    FairyGUI.ButtonMode[] array = obj as FairyGUI.ButtonMode[];
				translator.PushFairyGUIButtonMode(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.TransitionActionType[]))
			{
			    FairyGUI.TransitionActionType[] array = obj as FairyGUI.TransitionActionType[];
				translator.PushFairyGUITransitionActionType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.GroupLayoutType[]))
			{
			    FairyGUI.GroupLayoutType[] array = obj as FairyGUI.GroupLayoutType[];
				translator.PushFairyGUIGroupLayoutType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ChildrenRenderOrder[]))
			{
			    FairyGUI.ChildrenRenderOrder[] array = obj as FairyGUI.ChildrenRenderOrder[];
				translator.PushFairyGUIChildrenRenderOrder(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.PopupDirection[]))
			{
			    FairyGUI.PopupDirection[] array = obj as FairyGUI.PopupDirection[];
				translator.PushFairyGUIPopupDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.FlipType[]))
			{
			    FairyGUI.FlipType[] array = obj as FairyGUI.FlipType[];
				translator.PushFairyGUIFlipType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.FillMethod[]))
			{
			    FairyGUI.FillMethod[] array = obj as FairyGUI.FillMethod[];
				translator.PushFairyGUIFillMethod(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.OriginHorizontal[]))
			{
			    FairyGUI.OriginHorizontal[] array = obj as FairyGUI.OriginHorizontal[];
				translator.PushFairyGUIOriginHorizontal(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.OriginVertical[]))
			{
			    FairyGUI.OriginVertical[] array = obj as FairyGUI.OriginVertical[];
				translator.PushFairyGUIOriginVertical(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.Origin90[]))
			{
			    FairyGUI.Origin90[] array = obj as FairyGUI.Origin90[];
				translator.PushFairyGUIOrigin90(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.Origin180[]))
			{
			    FairyGUI.Origin180[] array = obj as FairyGUI.Origin180[];
				translator.PushFairyGUIOrigin180(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.Origin360[]))
			{
			    FairyGUI.Origin360[] array = obj as FairyGUI.Origin360[];
				translator.PushFairyGUIOrigin360(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.FocusRule[]))
			{
			    FairyGUI.FocusRule[] array = obj as FairyGUI.FocusRule[];
				translator.PushFairyGUIFocusRule(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.FitScreen[]))
			{
			    FairyGUI.FitScreen[] array = obj as FairyGUI.FitScreen[];
				translator.PushFairyGUIFitScreen(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.Utils.HtmlElementType[]))
			{
			    FairyGUI.Utils.HtmlElementType[] array = obj as FairyGUI.Utils.HtmlElementType[];
				translator.PushFairyGUIUtilsHtmlElementType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.Utils.XMLTagType[]))
			{
			    FairyGUI.Utils.XMLTagType[] array = obj as FairyGUI.Utils.XMLTagType[];
				translator.PushFairyGUIUtilsXMLTagType(L, array[index]);
				return true;
			}
			else if (type == typeof(ETCold.DebugType[]))
			{
			    ETCold.DebugType[] array = obj as ETCold.DebugType[];
				translator.PushETColdDebugType(L, array[index]);
				return true;
			}
			else if (type == typeof(ETCold.UILayer[]))
			{
			    ETCold.UILayer[] array = obj as ETCold.UILayer[];
				translator.PushETColdUILayer(L, array[index]);
				return true;
			}
			else if (type == typeof(ET.AwaiterStatus[]))
			{
			    ET.AwaiterStatus[] array = obj as ET.AwaiterStatus[];
				translator.PushETAwaiterStatus(L, array[index]);
				return true;
			}
			else if (type == typeof(MessageBox.EventId[]))
			{
			    MessageBox.EventId[] array = obj as MessageBox.EventId[];
				translator.PushMessageBoxEventId(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.RTLSupport.DirectionType[]))
			{
			    FairyGUI.RTLSupport.DirectionType[] array = obj as FairyGUI.RTLSupport.DirectionType[];
				translator.PushFairyGUIRTLSupportDirectionType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.TextFormat.SpecialStyle[]))
			{
			    FairyGUI.TextFormat.SpecialStyle[] array = obj as FairyGUI.TextFormat.SpecialStyle[];
				translator.PushFairyGUITextFormatSpecialStyle(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.GPathPoint.CurveType[]))
			{
			    FairyGUI.GPathPoint.CurveType[] array = obj as FairyGUI.GPathPoint.CurveType[];
				translator.PushFairyGUIGPathPointCurveType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.ControllerAction.ActionType[]))
			{
			    FairyGUI.ControllerAction.ActionType[] array = obj as FairyGUI.ControllerAction.ActionType[];
				translator.PushFairyGUIControllerActionActionType(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.UIConfig.ConfigKey[]))
			{
			    FairyGUI.UIConfig.ConfigKey[] array = obj as FairyGUI.UIConfig.ConfigKey[];
				translator.PushFairyGUIUIConfigConfigKey(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.UIContentScaler.ScaleMode[]))
			{
			    FairyGUI.UIContentScaler.ScaleMode[] array = obj as FairyGUI.UIContentScaler.ScaleMode[];
				translator.PushFairyGUIUIContentScalerScaleMode(L, array[index]);
				return true;
			}
			else if (type == typeof(FairyGUI.UIContentScaler.ScreenMatchMode[]))
			{
			    FairyGUI.UIContentScaler.ScreenMatchMode[] array = obj as FairyGUI.UIContentScaler.ScreenMatchMode[];
				translator.PushFairyGUIUIContentScalerScreenMatchMode(L, array[index]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.SocketAsyncOperation[]))
			{
			    System.Net.Sockets.SocketAsyncOperation[] array = obj as System.Net.Sockets.SocketAsyncOperation[];
				translator.PushSystemNetSocketsSocketAsyncOperation(L, array[index]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.SocketError[]))
			{
			    System.Net.Sockets.SocketError[] array = obj as System.Net.Sockets.SocketError[];
				translator.PushSystemNetSocketsSocketError(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasUpdate[]))
			{
			    UnityEngine.UI.CanvasUpdate[] array = obj as UnityEngine.UI.CanvasUpdate[];
				translator.PushUnityEngineUICanvasUpdate(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.EventHandle[]))
			{
			    UnityEngine.EventSystems.EventHandle[] array = obj as UnityEngine.EventSystems.EventHandle[];
				translator.PushUnityEngineEventSystemsEventHandle(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.EventTriggerType[]))
			{
			    UnityEngine.EventSystems.EventTriggerType[] array = obj as UnityEngine.EventSystems.EventTriggerType[];
				translator.PushUnityEngineEventSystemsEventTriggerType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.MoveDirection[]))
			{
			    UnityEngine.EventSystems.MoveDirection[] array = obj as UnityEngine.EventSystems.MoveDirection[];
				translator.PushUnityEngineEventSystemsMoveDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects[]))
			{
			    UnityEngine.UI.GraphicRaycaster.BlockingObjects[] array = obj as UnityEngine.UI.GraphicRaycaster.BlockingObjects[];
				translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Type[]))
			{
			    UnityEngine.UI.Image.Type[] array = obj as UnityEngine.UI.Image.Type[];
				translator.PushUnityEngineUIImageType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.FillMethod[]))
			{
			    UnityEngine.UI.Image.FillMethod[] array = obj as UnityEngine.UI.Image.FillMethod[];
				translator.PushUnityEngineUIImageFillMethod(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginHorizontal[]))
			{
			    UnityEngine.UI.Image.OriginHorizontal[] array = obj as UnityEngine.UI.Image.OriginHorizontal[];
				translator.PushUnityEngineUIImageOriginHorizontal(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginVertical[]))
			{
			    UnityEngine.UI.Image.OriginVertical[] array = obj as UnityEngine.UI.Image.OriginVertical[];
				translator.PushUnityEngineUIImageOriginVertical(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin90[]))
			{
			    UnityEngine.UI.Image.Origin90[] array = obj as UnityEngine.UI.Image.Origin90[];
				translator.PushUnityEngineUIImageOrigin90(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin180[]))
			{
			    UnityEngine.UI.Image.Origin180[] array = obj as UnityEngine.UI.Image.Origin180[];
				translator.PushUnityEngineUIImageOrigin180(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin360[]))
			{
			    UnityEngine.UI.Image.Origin360[] array = obj as UnityEngine.UI.Image.Origin360[];
				translator.PushUnityEngineUIImageOrigin360(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.ContentType[]))
			{
			    UnityEngine.UI.InputField.ContentType[] array = obj as UnityEngine.UI.InputField.ContentType[];
				translator.PushUnityEngineUIInputFieldContentType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.InputType[]))
			{
			    UnityEngine.UI.InputField.InputType[] array = obj as UnityEngine.UI.InputField.InputType[];
				translator.PushUnityEngineUIInputFieldInputType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.CharacterValidation[]))
			{
			    UnityEngine.UI.InputField.CharacterValidation[] array = obj as UnityEngine.UI.InputField.CharacterValidation[];
				translator.PushUnityEngineUIInputFieldCharacterValidation(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.LineType[]))
			{
			    UnityEngine.UI.InputField.LineType[] array = obj as UnityEngine.UI.InputField.LineType[];
				translator.PushUnityEngineUIInputFieldLineType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.AspectRatioFitter.AspectMode[]))
			{
			    UnityEngine.UI.AspectRatioFitter.AspectMode[] array = obj as UnityEngine.UI.AspectRatioFitter.AspectMode[];
				translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScaleMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScaleMode[] array = obj as UnityEngine.UI.CanvasScaler.ScaleMode[];
				translator.PushUnityEngineUICanvasScalerScaleMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScreenMatchMode[] array = obj as UnityEngine.UI.CanvasScaler.ScreenMatchMode[];
				translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.Unit[]))
			{
			    UnityEngine.UI.CanvasScaler.Unit[] array = obj as UnityEngine.UI.CanvasScaler.Unit[];
				translator.PushUnityEngineUICanvasScalerUnit(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ContentSizeFitter.FitMode[]))
			{
			    UnityEngine.UI.ContentSizeFitter.FitMode[] array = obj as UnityEngine.UI.ContentSizeFitter.FitMode[];
				translator.PushUnityEngineUIContentSizeFitterFitMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Corner[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Corner[] array = obj as UnityEngine.UI.GridLayoutGroup.Corner[];
				translator.PushUnityEngineUIGridLayoutGroupCorner(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Axis[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Axis[] array = obj as UnityEngine.UI.GridLayoutGroup.Axis[];
				translator.PushUnityEngineUIGridLayoutGroupAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Constraint[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Constraint[] array = obj as UnityEngine.UI.GridLayoutGroup.Constraint[];
				translator.PushUnityEngineUIGridLayoutGroupConstraint(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Navigation.Mode[]))
			{
			    UnityEngine.UI.Navigation.Mode[] array = obj as UnityEngine.UI.Navigation.Mode[];
				translator.PushUnityEngineUINavigationMode(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.MovementType[]))
			{
			    UnityEngine.UI.ScrollRect.MovementType[] array = obj as UnityEngine.UI.ScrollRect.MovementType[];
				translator.PushUnityEngineUIScrollRectMovementType(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility[]))
			{
			    UnityEngine.UI.ScrollRect.ScrollbarVisibility[] array = obj as UnityEngine.UI.ScrollRect.ScrollbarVisibility[];
				translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Scrollbar.Direction[]))
			{
			    UnityEngine.UI.Scrollbar.Direction[] array = obj as UnityEngine.UI.Scrollbar.Direction[];
				translator.PushUnityEngineUIScrollbarDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Slider.Direction[]))
			{
			    UnityEngine.UI.Slider.Direction[] array = obj as UnityEngine.UI.Slider.Direction[];
				translator.PushUnityEngineUISliderDirection(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Toggle.ToggleTransition[]))
			{
			    UnityEngine.UI.Toggle.ToggleTransition[] array = obj as UnityEngine.UI.Toggle.ToggleTransition[];
				translator.PushUnityEngineUIToggleToggleTransition(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.PointerEventData.InputButton[]))
			{
			    UnityEngine.EventSystems.PointerEventData.InputButton[] array = obj as UnityEngine.EventSystems.PointerEventData.InputButton[];
				translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.PointerEventData.FramePressState[]))
			{
			    UnityEngine.EventSystems.PointerEventData.FramePressState[] array = obj as UnityEngine.EventSystems.PointerEventData.FramePressState[];
				translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, array[index]);
				return true;
			}
            return false;
		}
		
		internal static bool __tryArraySet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
		{
		
			if (type == typeof(UnityEngine.Vector2[]))
			{
			    UnityEngine.Vector2[] array = obj as UnityEngine.Vector2[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector3[]))
			{
			    UnityEngine.Vector3[] array = obj as UnityEngine.Vector3[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector4[]))
			{
			    UnityEngine.Vector4[] array = obj as UnityEngine.Vector4[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Color[]))
			{
			    UnityEngine.Color[] array = obj as UnityEngine.Color[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Quaternion[]))
			{
			    UnityEngine.Quaternion[] array = obj as UnityEngine.Quaternion[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray[]))
			{
			    UnityEngine.Ray[] array = obj as UnityEngine.Ray[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Bounds[]))
			{
			    UnityEngine.Bounds[] array = obj as UnityEngine.Bounds[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray2D[]))
			{
			    UnityEngine.Ray2D[] array = obj as UnityEngine.Ray2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.AddressFamily[]))
			{
			    System.Net.Sockets.AddressFamily[] array = obj as System.Net.Sockets.AddressFamily[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.SocketType[]))
			{
			    System.Net.Sockets.SocketType[] array = obj as System.Net.Sockets.SocketType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.ProtocolType[]))
			{
			    System.Net.Sockets.ProtocolType[] array = obj as System.Net.Sockets.ProtocolType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Axis[]))
			{
			    UnityEngine.RectTransform.Axis[] array = obj as UnityEngine.RectTransform.Axis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Edge[]))
			{
			    UnityEngine.RectTransform.Edge[] array = obj as UnityEngine.RectTransform.Edge[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Selectable.Transition[]))
			{
			    UnityEngine.UI.Selectable.Transition[] array = obj as UnityEngine.UI.Selectable.Transition[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(System.IO.SeekOrigin[]))
			{
			    System.IO.SeekOrigin[] array = obj as System.IO.SeekOrigin[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Texture2D.EXRFlags[]))
			{
			    UnityEngine.Texture2D.EXRFlags[] array = obj as UnityEngine.Texture2D.EXRFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(libx.LoadState[]))
			{
			    libx.LoadState[] array = obj as libx.LoadState[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(libx.VerifyBy[]))
			{
			    libx.VerifyBy[] array = obj as libx.VerifyBy[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(Battlehub.UIControls.ItemDropAction[]))
			{
			    Battlehub.UIControls.ItemDropAction[] array = obj as Battlehub.UIControls.ItemDropAction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(Battlehub.UIControls.VirtualizingMode[]))
			{
			    Battlehub.UIControls.VirtualizingMode[] array = obj as Battlehub.UIControls.VirtualizingMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(Battlehub.UIControls.DockPanels.RegionSplitType[]))
			{
			    Battlehub.UIControls.DockPanels.RegionSplitType[] array = obj as Battlehub.UIControls.DockPanels.RegionSplitType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(Battlehub.Utils.KnownCursor[]))
			{
			    Battlehub.Utils.KnownCursor[] array = obj as Battlehub.Utils.KnownCursor[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.BlendMode[]))
			{
			    FairyGUI.BlendMode[] array = obj as FairyGUI.BlendMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.HitTestMode[]))
			{
			    FairyGUI.HitTestMode[] array = obj as FairyGUI.HitTestMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.MaterialFlags[]))
			{
			    FairyGUI.MaterialFlags[] array = obj as FairyGUI.MaterialFlags[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.DestroyMethod[]))
			{
			    FairyGUI.DestroyMethod[] array = obj as FairyGUI.DestroyMethod[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.EaseType[]))
			{
			    FairyGUI.EaseType[] array = obj as FairyGUI.EaseType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.TweenPropType[]))
			{
			    FairyGUI.TweenPropType[] array = obj as FairyGUI.TweenPropType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.PackageItemType[]))
			{
			    FairyGUI.PackageItemType[] array = obj as FairyGUI.PackageItemType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ObjectType[]))
			{
			    FairyGUI.ObjectType[] array = obj as FairyGUI.ObjectType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.AlignType[]))
			{
			    FairyGUI.AlignType[] array = obj as FairyGUI.AlignType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.VertAlignType[]))
			{
			    FairyGUI.VertAlignType[] array = obj as FairyGUI.VertAlignType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.OverflowType[]))
			{
			    FairyGUI.OverflowType[] array = obj as FairyGUI.OverflowType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.FillType[]))
			{
			    FairyGUI.FillType[] array = obj as FairyGUI.FillType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.AutoSizeType[]))
			{
			    FairyGUI.AutoSizeType[] array = obj as FairyGUI.AutoSizeType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ScrollType[]))
			{
			    FairyGUI.ScrollType[] array = obj as FairyGUI.ScrollType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ScrollBarDisplayType[]))
			{
			    FairyGUI.ScrollBarDisplayType[] array = obj as FairyGUI.ScrollBarDisplayType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.RelationType[]))
			{
			    FairyGUI.RelationType[] array = obj as FairyGUI.RelationType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ListLayoutType[]))
			{
			    FairyGUI.ListLayoutType[] array = obj as FairyGUI.ListLayoutType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ListSelectionMode[]))
			{
			    FairyGUI.ListSelectionMode[] array = obj as FairyGUI.ListSelectionMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ProgressTitleType[]))
			{
			    FairyGUI.ProgressTitleType[] array = obj as FairyGUI.ProgressTitleType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ButtonMode[]))
			{
			    FairyGUI.ButtonMode[] array = obj as FairyGUI.ButtonMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.TransitionActionType[]))
			{
			    FairyGUI.TransitionActionType[] array = obj as FairyGUI.TransitionActionType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.GroupLayoutType[]))
			{
			    FairyGUI.GroupLayoutType[] array = obj as FairyGUI.GroupLayoutType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ChildrenRenderOrder[]))
			{
			    FairyGUI.ChildrenRenderOrder[] array = obj as FairyGUI.ChildrenRenderOrder[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.PopupDirection[]))
			{
			    FairyGUI.PopupDirection[] array = obj as FairyGUI.PopupDirection[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.FlipType[]))
			{
			    FairyGUI.FlipType[] array = obj as FairyGUI.FlipType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.FillMethod[]))
			{
			    FairyGUI.FillMethod[] array = obj as FairyGUI.FillMethod[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.OriginHorizontal[]))
			{
			    FairyGUI.OriginHorizontal[] array = obj as FairyGUI.OriginHorizontal[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.OriginVertical[]))
			{
			    FairyGUI.OriginVertical[] array = obj as FairyGUI.OriginVertical[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.Origin90[]))
			{
			    FairyGUI.Origin90[] array = obj as FairyGUI.Origin90[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.Origin180[]))
			{
			    FairyGUI.Origin180[] array = obj as FairyGUI.Origin180[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.Origin360[]))
			{
			    FairyGUI.Origin360[] array = obj as FairyGUI.Origin360[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.FocusRule[]))
			{
			    FairyGUI.FocusRule[] array = obj as FairyGUI.FocusRule[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.FitScreen[]))
			{
			    FairyGUI.FitScreen[] array = obj as FairyGUI.FitScreen[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.Utils.HtmlElementType[]))
			{
			    FairyGUI.Utils.HtmlElementType[] array = obj as FairyGUI.Utils.HtmlElementType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.Utils.XMLTagType[]))
			{
			    FairyGUI.Utils.XMLTagType[] array = obj as FairyGUI.Utils.XMLTagType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(ETCold.DebugType[]))
			{
			    ETCold.DebugType[] array = obj as ETCold.DebugType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(ETCold.UILayer[]))
			{
			    ETCold.UILayer[] array = obj as ETCold.UILayer[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(ET.AwaiterStatus[]))
			{
			    ET.AwaiterStatus[] array = obj as ET.AwaiterStatus[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(MessageBox.EventId[]))
			{
			    MessageBox.EventId[] array = obj as MessageBox.EventId[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.RTLSupport.DirectionType[]))
			{
			    FairyGUI.RTLSupport.DirectionType[] array = obj as FairyGUI.RTLSupport.DirectionType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.TextFormat.SpecialStyle[]))
			{
			    FairyGUI.TextFormat.SpecialStyle[] array = obj as FairyGUI.TextFormat.SpecialStyle[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.GPathPoint.CurveType[]))
			{
			    FairyGUI.GPathPoint.CurveType[] array = obj as FairyGUI.GPathPoint.CurveType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.ControllerAction.ActionType[]))
			{
			    FairyGUI.ControllerAction.ActionType[] array = obj as FairyGUI.ControllerAction.ActionType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.UIConfig.ConfigKey[]))
			{
			    FairyGUI.UIConfig.ConfigKey[] array = obj as FairyGUI.UIConfig.ConfigKey[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.UIContentScaler.ScaleMode[]))
			{
			    FairyGUI.UIContentScaler.ScaleMode[] array = obj as FairyGUI.UIContentScaler.ScaleMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(FairyGUI.UIContentScaler.ScreenMatchMode[]))
			{
			    FairyGUI.UIContentScaler.ScreenMatchMode[] array = obj as FairyGUI.UIContentScaler.ScreenMatchMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.SocketAsyncOperation[]))
			{
			    System.Net.Sockets.SocketAsyncOperation[] array = obj as System.Net.Sockets.SocketAsyncOperation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(System.Net.Sockets.SocketError[]))
			{
			    System.Net.Sockets.SocketError[] array = obj as System.Net.Sockets.SocketError[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasUpdate[]))
			{
			    UnityEngine.UI.CanvasUpdate[] array = obj as UnityEngine.UI.CanvasUpdate[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.EventHandle[]))
			{
			    UnityEngine.EventSystems.EventHandle[] array = obj as UnityEngine.EventSystems.EventHandle[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.EventTriggerType[]))
			{
			    UnityEngine.EventSystems.EventTriggerType[] array = obj as UnityEngine.EventSystems.EventTriggerType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.MoveDirection[]))
			{
			    UnityEngine.EventSystems.MoveDirection[] array = obj as UnityEngine.EventSystems.MoveDirection[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects[]))
			{
			    UnityEngine.UI.GraphicRaycaster.BlockingObjects[] array = obj as UnityEngine.UI.GraphicRaycaster.BlockingObjects[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Type[]))
			{
			    UnityEngine.UI.Image.Type[] array = obj as UnityEngine.UI.Image.Type[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.FillMethod[]))
			{
			    UnityEngine.UI.Image.FillMethod[] array = obj as UnityEngine.UI.Image.FillMethod[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginHorizontal[]))
			{
			    UnityEngine.UI.Image.OriginHorizontal[] array = obj as UnityEngine.UI.Image.OriginHorizontal[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginVertical[]))
			{
			    UnityEngine.UI.Image.OriginVertical[] array = obj as UnityEngine.UI.Image.OriginVertical[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin90[]))
			{
			    UnityEngine.UI.Image.Origin90[] array = obj as UnityEngine.UI.Image.Origin90[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin180[]))
			{
			    UnityEngine.UI.Image.Origin180[] array = obj as UnityEngine.UI.Image.Origin180[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin360[]))
			{
			    UnityEngine.UI.Image.Origin360[] array = obj as UnityEngine.UI.Image.Origin360[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.ContentType[]))
			{
			    UnityEngine.UI.InputField.ContentType[] array = obj as UnityEngine.UI.InputField.ContentType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.InputType[]))
			{
			    UnityEngine.UI.InputField.InputType[] array = obj as UnityEngine.UI.InputField.InputType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.CharacterValidation[]))
			{
			    UnityEngine.UI.InputField.CharacterValidation[] array = obj as UnityEngine.UI.InputField.CharacterValidation[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.InputField.LineType[]))
			{
			    UnityEngine.UI.InputField.LineType[] array = obj as UnityEngine.UI.InputField.LineType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.AspectRatioFitter.AspectMode[]))
			{
			    UnityEngine.UI.AspectRatioFitter.AspectMode[] array = obj as UnityEngine.UI.AspectRatioFitter.AspectMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScaleMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScaleMode[] array = obj as UnityEngine.UI.CanvasScaler.ScaleMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode[]))
			{
			    UnityEngine.UI.CanvasScaler.ScreenMatchMode[] array = obj as UnityEngine.UI.CanvasScaler.ScreenMatchMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.CanvasScaler.Unit[]))
			{
			    UnityEngine.UI.CanvasScaler.Unit[] array = obj as UnityEngine.UI.CanvasScaler.Unit[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ContentSizeFitter.FitMode[]))
			{
			    UnityEngine.UI.ContentSizeFitter.FitMode[] array = obj as UnityEngine.UI.ContentSizeFitter.FitMode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Corner[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Corner[] array = obj as UnityEngine.UI.GridLayoutGroup.Corner[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Axis[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Axis[] array = obj as UnityEngine.UI.GridLayoutGroup.Axis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.GridLayoutGroup.Constraint[]))
			{
			    UnityEngine.UI.GridLayoutGroup.Constraint[] array = obj as UnityEngine.UI.GridLayoutGroup.Constraint[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Navigation.Mode[]))
			{
			    UnityEngine.UI.Navigation.Mode[] array = obj as UnityEngine.UI.Navigation.Mode[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.MovementType[]))
			{
			    UnityEngine.UI.ScrollRect.MovementType[] array = obj as UnityEngine.UI.ScrollRect.MovementType[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility[]))
			{
			    UnityEngine.UI.ScrollRect.ScrollbarVisibility[] array = obj as UnityEngine.UI.ScrollRect.ScrollbarVisibility[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Scrollbar.Direction[]))
			{
			    UnityEngine.UI.Scrollbar.Direction[] array = obj as UnityEngine.UI.Scrollbar.Direction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Slider.Direction[]))
			{
			    UnityEngine.UI.Slider.Direction[] array = obj as UnityEngine.UI.Slider.Direction[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Toggle.ToggleTransition[]))
			{
			    UnityEngine.UI.Toggle.ToggleTransition[] array = obj as UnityEngine.UI.Toggle.ToggleTransition[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.PointerEventData.InputButton[]))
			{
			    UnityEngine.EventSystems.PointerEventData.InputButton[] array = obj as UnityEngine.EventSystems.PointerEventData.InputButton[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.EventSystems.PointerEventData.FramePressState[]))
			{
			    UnityEngine.EventSystems.PointerEventData.FramePressState[] array = obj as UnityEngine.EventSystems.PointerEventData.FramePressState[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
            return false;
		}
	}
}