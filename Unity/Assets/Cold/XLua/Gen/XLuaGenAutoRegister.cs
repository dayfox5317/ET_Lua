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
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Concurrent.ConcurrentDictionary<long, ulong>), SystemCollectionsConcurrentConcurrentDictionary_2_SystemInt64SystemUInt64_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<string>), SystemCollectionsGenericList_1_SystemString_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngineSceneManagementSceneManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Type), SystemTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RuntimeAnimatorController), UnityEngineRuntimeAnimatorControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorControllerParameter), UnityEngineAnimatorControllerParameterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.Socket), SystemNetSocketsSocketWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.IPEndPoint), SystemNetIPEndPointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.EndPoint), SystemNetEndPointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.IPAddress), SystemNetIPAddressWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.AddressFamily), SystemNetSocketsAddressFamilyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.SocketType), SystemNetSocketsSocketTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.ProtocolType), SystemNetSocketsProtocolTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.SocketAsyncEventArgs), SystemNetSocketsSocketAsyncEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.SerializableAttribute), SystemSerializableAttributeWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(System.IO.Path), SystemIOPathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleManifest), UnityEngineAssetBundleManifestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.IO.IOException), SystemIOIOExceptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoMemberAttribute), ProtoBufProtoMemberAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoContractAttribute), ProtoBufProtoContractAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Text.Encoding), SystemTextEncodingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.IO.Stream), SystemIOStreamWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.IO.MemoryStream), SystemIOMemoryStreamWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonIdAttribute), MongoDBBsonSerializationAttributesBsonIdAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreAttribute), MongoDBBsonSerializationAttributesBsonIgnoreAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute), MongoDBBsonSerializationAttributesBsonIgnoreExtraElementsAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfDefaultAttribute), MongoDBBsonSerializationAttributesBsonIgnoreIfDefaultAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute), MongoDBBsonSerializationAttributesBsonIgnoreIfNullAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonDefaultValueAttribute), MongoDBBsonSerializationAttributesBsonDefaultValueAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonRequiredAttribute), MongoDBBsonSerializationAttributesBsonRequiredAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonElementAttribute), MongoDBBsonSerializationAttributesBsonElementAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute), MongoDBBsonSerializationAttributesBsonDictionaryOptionsAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MongoDB.Bson.Serialization.BsonSerializer), MongoDBBsonSerializationBsonSerializerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Runtime.Serialization.IgnoreDataMemberAttribute), SystemRuntimeSerializationIgnoreDataMemberAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Runtime.CompilerServices.AsyncMethodBuilderAttribute), SystemRuntimeCompilerServicesAsyncMethodBuilderAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoConverterAttribute), ProtoBufProtoConverterAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoEnumAttribute), ProtoBufProtoEnumAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoIgnoreAttribute), ProtoBufProtoIgnoreAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoIncludeAttribute), ProtoBufProtoIncludeAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoPartialIgnoreAttribute), ProtoBufProtoPartialIgnoreAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ProtoBuf.ProtoPartialMemberAttribute), ProtoBufProtoPartialMemberAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngineAsyncOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.UnityLogger), ETColdUnityLoggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.Kcp), ETColdKcpWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ThreadSynchronizationContext), ETColdThreadSynchronizationContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.ComponentModel.ISupportInitialize), SystemComponentModelISupportInitializeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Guid), SystemGuidWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ComponentView), ETColdComponentViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.UILayerScript), ETColdUILayerScriptWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.CircularBuffer), ETColdCircularBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ByteHelper), ETColdByteHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.StreamHelper), ETColdStreamHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.LoadHelper), ETColdLoadHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ReferenceCollector), ReferenceCollectorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngineUIInputFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.AssetRequest), libxAssetRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Assets), libxAssetsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform.Axis), UnityEngineRectTransformAxisWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform.Edge), UnityEngineRectTransformEdgeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable), UnityEngineUISelectableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable.Transition), UnityEngineUISelectableTransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngineUIButtonButtonClickedEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.IO.SeekOrigin), SystemIOSeekOriginWrap.__Register);
        
        }
        
        static void wrapInit2(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(System.Reflection.MemberInfo), SystemReflectionMemberInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Screen), UnityEngineScreenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture2D), UnityEngineTexture2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture2D.EXRFlags), UnityEngineTexture2DEXRFlagsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PackageItem), FairyGUIPackageItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GObject), FairyGUIGObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EventListener), FairyGUIEventListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ReferenceCollectorData), ReferenceCollectorDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ReferenceCollectorDataComparer), ReferenceCollectorDataComparerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(IMGUITester), IMGUITesterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TestLayout), TestLayoutWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(BuildinSceneLoader), BuildinSceneLoaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MessageBox), MessageBoxWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Download), libxDownloadWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Downloader), libxDownloaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.AssetRef), libxAssetRefWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.BundleRef), libxBundleRefWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Manifest), libxManifestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.INetworkMonitorListener), libxINetworkMonitorListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.NetworkMonitor), libxNetworkMonitorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Reference), libxReferenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.LoadState), libxLoadStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.ManifestRequest), libxManifestRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.BundleAssetRequest), libxBundleAssetRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.BundleAssetAsyncRequest), libxBundleAssetAsyncRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.SceneAssetRequest), libxSceneAssetRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.SceneAssetAsyncRequest), libxSceneAssetAsyncRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.WebAssetRequest), libxWebAssetRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.BundleRequest), libxBundleRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.BundleAsyncRequest), libxBundleAsyncRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.WebBundleRequest), libxWebBundleRequestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.IUpdater), libxIUpdaterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Updater), libxUpdaterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.VFile), libxVFileWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.VDisk), libxVDiskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.VerifyBy), libxVerifyByWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Versions), libxVersionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.BackgroundAdapter), libxBackgroundAdapterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.ScrollContent), libxScrollContentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.UpdateScreen), libxUpdateScreenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.StringExtension), libxStringExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(libx.Utility), libxUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.CancelArgs), BattlehubUIControlsCancelArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.IUpdateFocusedHandler), BattlehubUIControlsIUpdateFocusedHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.InputProvider), BattlehubUIControlsInputProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.InputProviderAdapter), BattlehubUIControlsInputProviderAdapterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ProgressBar), BattlehubUIControlsProgressBarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.RectTransformChangeListener), BattlehubUIControlsRectTransformChangeListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.RectTransformExtensions), BattlehubUIControlsRectTransformExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.Repeater), BattlehubUIControlsRepeaterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TransformChildrenChangeListener), BattlehubUIControlsTransformChildrenChangeListenerWrap.__Register);
        
        }
        
        static void wrapInit3(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.UIStyle), BattlehubUIControlsUIStyleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.UnityEventHelper), BattlehubUIControlsUnityEventHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.UIMenuStyle), BattlehubUIControlsUIMenuStyleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MultiToggle), BattlehubUIControlsMultiToggleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MultiToggleLayer), BattlehubUIControlsMultiToggleLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MultiTogglePanel), BattlehubUIControlsMultiTogglePanelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MultiselectDropdown), BattlehubUIControlsMultiselectDropdownWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemContainer), BattlehubUIControlsItemContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemDropAction), BattlehubUIControlsItemDropActionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemDropMarker), BattlehubUIControlsItemDropMarkerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.SelectionChangedArgs), BattlehubUIControlsSelectionChangedArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemsCancelArgs), BattlehubUIControlsItemsCancelArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemsRemovedArgs), BattlehubUIControlsItemsRemovedArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemDataBindingArgs), BattlehubUIControlsItemDataBindingArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemArgs), BattlehubUIControlsItemArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemDropCancelArgs), BattlehubUIControlsItemDropCancelArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemDropArgs), BattlehubUIControlsItemDropArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemsControl), BattlehubUIControlsItemsControlWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.LayoutElementResizer), BattlehubUIControlsLayoutElementResizerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ListBox), BattlehubUIControlsListBoxWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ListBoxItem), BattlehubUIControlsListBoxItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemExpandingArgs), BattlehubUIControlsItemExpandingArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TreeViewItemDataBindingArgs), BattlehubUIControlsTreeViewItemDataBindingArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TreeView), BattlehubUIControlsTreeViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TreeViewDropMarker), BattlehubUIControlsTreeViewDropMarkerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TreeViewExpander), BattlehubUIControlsTreeViewExpanderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ParentChangedEventArgs), BattlehubUIControlsParentChangedEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TreeViewItem), BattlehubUIControlsTreeViewItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.PointerEnterExitListener), BattlehubUIControlsPointerEnterExitListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingItemContainer), BattlehubUIControlsVirtualizingItemContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingItemDropMarker), BattlehubUIControlsVirtualizingItemDropMarkerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.ItemContainerData), BattlehubUIControlsItemContainerDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.PointerEventArgs), BattlehubUIControlsPointerEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingItemsControl), BattlehubUIControlsVirtualizingItemsControlWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingItemsControlInputProvider), BattlehubUIControlsVirtualizingItemsControlInputProviderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingMode), BattlehubUIControlsVirtualizingModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingScrollRect), BattlehubUIControlsVirtualizingScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingItemExpandingArgs), BattlehubUIControlsVirtualizingItemExpandingArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingItemCollapsedArgs), BattlehubUIControlsVirtualizingItemCollapsedArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingTreeViewItemDataBindingArgs), BattlehubUIControlsVirtualizingTreeViewItemDataBindingArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingParentChangedEventArgs), BattlehubUIControlsVirtualizingParentChangedEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TreeViewItemContainerData), BattlehubUIControlsTreeViewItemContainerDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingTreeView), BattlehubUIControlsVirtualizingTreeViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingTreeViewExtension), BattlehubUIControlsVirtualizingTreeViewExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingTreeViewDropMarker), BattlehubUIControlsVirtualizingTreeViewDropMarkerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.VirtualizingTreeViewItem), BattlehubUIControlsVirtualizingTreeViewItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TooltipControl.ToggleTooltip), BattlehubUIControlsTooltipControlToggleTooltipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TooltipControl.Tooltip), BattlehubUIControlsTooltipControlTooltipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TooltipControl.TooltipLayer), BattlehubUIControlsTooltipControlTooltipLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.TooltipControl.TooltipUI), BattlehubUIControlsTooltipControlTooltipUIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.ContextMenuTrigger), BattlehubUIControlsMenuControlContextMenuTriggerWrap.__Register);
        
        }
        
        static void wrapInit4(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MainMenuButton), BattlehubUIControlsMenuControlMainMenuButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuItemValidationArgs), BattlehubUIControlsMenuControlMenuItemValidationArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuItemValidationEvent), BattlehubUIControlsMenuControlMenuItemValidationEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuItemEvent), BattlehubUIControlsMenuControlMenuItemEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuItemInfo), BattlehubUIControlsMenuControlMenuItemInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.Menu), BattlehubUIControlsMenuControlMenuWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuDefinitionAttribute), BattlehubUIControlsMenuControlMenuDefinitionAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuCommandAttribute), BattlehubUIControlsMenuControlMenuCommandAttributeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuCreator), BattlehubUIControlsMenuControlMenuCreatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MenuControl.MenuItem), BattlehubUIControlsMenuControlMenuItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.DepthMaskingBehavior), BattlehubUIControlsDockPanelsDepthMaskingBehaviorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.DockPanel), BattlehubUIControlsDockPanelsDockPanelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.EatDragEvent), BattlehubUIControlsDockPanelsEatDragEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.HeaderPanel), BattlehubUIControlsDockPanelsHeaderPanelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.RegionSplitType), BattlehubUIControlsDockPanelsRegionSplitTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.PersistentLayoutInfo), BattlehubUIControlsDockPanelsPersistentLayoutInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.LayoutInfo), BattlehubUIControlsDockPanelsLayoutInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.Region), BattlehubUIControlsDockPanelsRegionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.RepeatButton), BattlehubUIControlsDockPanelsRepeatButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.Resizer), BattlehubUIControlsDockPanelsResizerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.PointerEventArgs), BattlehubUIControlsDockPanelsPointerEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.ITabDelegate), BattlehubUIControlsDockPanelsITabDelegateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.Tab), BattlehubUIControlsDockPanelsTabWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.DockPanels.TabPanelScroller), BattlehubUIControlsDockPanelsTabPanelScrollerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.Dialogs.DialogCancelArgs), BattlehubUIControlsDialogsDialogCancelArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.Dialogs.Dialog), BattlehubUIControlsDialogsDialogWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.Dialogs.DialogManager), BattlehubUIControlsDialogsDialogManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.Common.DragAndDropListener), BattlehubUIControlsCommonDragAndDropListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.RTCommon.UGUIEventTrigger), BattlehubRTCommonUGUIEventTriggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.Utils.KnownCursor), BattlehubUtilsKnownCursorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.Utils.CursorHelper), BattlehubUtilsCursorHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BlendMode), FairyGUIBlendModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BlendModeUtils), FairyGUIBlendModeUtilsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.CaptureCamera), FairyGUICaptureCameraWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Container), FairyGUIContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.DisplayObject), FairyGUIDisplayObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.DisplayObjectInfo), FairyGUIDisplayObjectInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GoWrapper), FairyGUIGoWrapperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ColliderHitTest), FairyGUIColliderHitTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.HitTestContext), FairyGUIHitTestContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.HitTestMode), FairyGUIHitTestModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IHitTest), FairyGUIIHitTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.MeshColliderHitTest), FairyGUIMeshColliderHitTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PixelHitTestData), FairyGUIPixelHitTestDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PixelHitTest), FairyGUIPixelHitTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RectHitTest), FairyGUIRectHitTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ShapeHitTest), FairyGUIShapeHitTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Image), FairyGUIImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.MaterialFlags), FairyGUIMaterialFlagsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.MaterialManager), FairyGUIMaterialManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.CompositeMesh), FairyGUICompositeMeshWrap.__Register);
        
        }
        
        static void wrapInit5(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(FairyGUI.EllipseMesh), FairyGUIEllipseMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FillMesh), FairyGUIFillMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.LineMesh), FairyGUILineMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IMeshFactory), FairyGUIIMeshFactoryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PlaneMesh), FairyGUIPlaneMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PolygonMesh), FairyGUIPolygonMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RectMesh), FairyGUIRectMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RegularPolygonMesh), FairyGUIRegularPolygonMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RoundedRectMesh), FairyGUIRoundedRectMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.StraightLineMesh), FairyGUIStraightLineMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.VertexBuffer), FairyGUIVertexBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.MovieClip), FairyGUIMovieClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.NAudioClip), FairyGUINAudioClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.NGraphics), FairyGUINGraphicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.DestroyMethod), FairyGUIDestroyMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.NTexture), FairyGUINTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ShaderConfig), FairyGUIShaderConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Shape), FairyGUIShapeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Stage), FairyGUIStageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.StageCamera), FairyGUIStageCameraWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.StageEngine), FairyGUIStageEngineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Stats), FairyGUIStatsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BaseFont), FairyGUIBaseFontWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BitmapFont), FairyGUIBitmapFontWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.DynamicFont), FairyGUIDynamicFontWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Emoji), FairyGUIEmojiWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FontManager), FairyGUIFontManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IKeyboard), FairyGUIIKeyboardWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.InputTextField), FairyGUIInputTextFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RTLSupport), FairyGUIRTLSupportWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RichTextField), FairyGUIRichTextFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.SelectionShape), FairyGUISelectionShapeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TextField), FairyGUITextFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TextFormat), FairyGUITextFormatWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TouchScreenKeyboard), FairyGUITouchScreenKeyboardWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TypingEffect), FairyGUITypingEffectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UpdateContext), FairyGUIUpdateContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EventContext), FairyGUIEventContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EventDispatcher), FairyGUIEventDispatcherWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IEventDispatcher), FairyGUIIEventDispatcherWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.InputEvent), FairyGUIInputEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BlurFilter), FairyGUIBlurFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ColorFilter), FairyGUIColorFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IFilter), FairyGUIIFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.LongPressGesture), FairyGUILongPressGestureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PinchGesture), FairyGUIPinchGestureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RotationGesture), FairyGUIRotationGestureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.SwipeGesture), FairyGUISwipeGestureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EaseManager), FairyGUIEaseManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EaseType), FairyGUIEaseTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.CustomEase), FairyGUICustomEaseWrap.__Register);
        
        }
        
        static void wrapInit6(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(FairyGUI.GPathPoint), FairyGUIGPathPointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GPath), FairyGUIGPathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GTween), FairyGUIGTweenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ITweenListener), FairyGUIITweenListenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GTweener), FairyGUIGTweenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TweenPropType), FairyGUITweenPropTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TweenValue), FairyGUITweenValueWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ChangePageAction), FairyGUIChangePageActionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ControllerAction), FairyGUIControllerActionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PlayTransitionAction), FairyGUIPlayTransitionActionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.AsyncCreationHelper), FairyGUIAsyncCreationHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Controller), FairyGUIControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.DragDropManager), FairyGUIDragDropManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EMRenderTarget), FairyGUIEMRenderTargetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.EMRenderSupport), FairyGUIEMRenderSupportWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PackageItemType), FairyGUIPackageItemTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ObjectType), FairyGUIObjectTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.AlignType), FairyGUIAlignTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.VertAlignType), FairyGUIVertAlignTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.OverflowType), FairyGUIOverflowTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FillType), FairyGUIFillTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.AutoSizeType), FairyGUIAutoSizeTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ScrollType), FairyGUIScrollTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ScrollBarDisplayType), FairyGUIScrollBarDisplayTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RelationType), FairyGUIRelationTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ListLayoutType), FairyGUIListLayoutTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ListSelectionMode), FairyGUIListSelectionModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ProgressTitleType), FairyGUIProgressTitleTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ButtonMode), FairyGUIButtonModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TransitionActionType), FairyGUITransitionActionTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GroupLayoutType), FairyGUIGroupLayoutTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ChildrenRenderOrder), FairyGUIChildrenRenderOrderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PopupDirection), FairyGUIPopupDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FlipType), FairyGUIFlipTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FillMethod), FairyGUIFillMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.OriginHorizontal), FairyGUIOriginHorizontalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.OriginVertical), FairyGUIOriginVerticalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Origin90), FairyGUIOrigin90Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Origin180), FairyGUIOrigin180Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Origin360), FairyGUIOrigin360Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FocusRule), FairyGUIFocusRuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GButton), FairyGUIGButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GComboBox), FairyGUIGComboBoxWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GComponent), FairyGUIGComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GGraph), FairyGUIGGraphWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GGroup), FairyGUIGGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GImage), FairyGUIGImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GLabel), FairyGUIGLabelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GList), FairyGUIGListWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GLoader), FairyGUIGLoaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GLoader3D), FairyGUIGLoader3DWrap.__Register);
        
        }
        
        static void wrapInit7(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(FairyGUI.GMovieClip), FairyGUIGMovieClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GObjectPool), FairyGUIGObjectPoolWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GProgressBar), FairyGUIGProgressBarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GRichTextField), FairyGUIGRichTextFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GRoot), FairyGUIGRootWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GScrollBar), FairyGUIGScrollBarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GSlider), FairyGUIGSliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GTextField), FairyGUIGTextFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GTextInput), FairyGUIGTextInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GTree), FairyGUIGTreeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GTreeNode), FairyGUIGTreeNodeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearAnimation), FairyGUIGearAnimationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearBase), FairyGUIGearBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearTweenConfig), FairyGUIGearTweenConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearColor), FairyGUIGearColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearDisplay), FairyGUIGearDisplayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearDisplay2), FairyGUIGearDisplay2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearFontSize), FairyGUIGearFontSizeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearIcon), FairyGUIGearIconWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearLook), FairyGUIGearLookWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearSize), FairyGUIGearSizeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearText), FairyGUIGearTextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GearXY), FairyGUIGearXYWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IAnimationGear), FairyGUIIAnimationGearWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IColorGear), FairyGUIIColorGearWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ITextColorGear), FairyGUIITextColorGearWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.IUISource), FairyGUIIUISourceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Margin), FairyGUIMarginWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.PopupMenu), FairyGUIPopupMenuWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Relations), FairyGUIRelationsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ScrollPane), FairyGUIScrollPaneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Transition), FairyGUITransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TranslationHelper), FairyGUITranslationHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIConfig), FairyGUIUIConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIContentScaler), FairyGUIUIContentScalerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIObjectFactory), FairyGUIUIObjectFactoryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIPackage), FairyGUIUIPackageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIPainter), FairyGUIUIPainterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.FitScreen), FairyGUIFitScreenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIPanel), FairyGUIUIPanelWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Window), FairyGUIWindowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Timers), FairyGUITimersWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.ByteBuffer), FairyGUIUtilsByteBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlButton), FairyGUIUtilsHtmlButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlElementType), FairyGUIUtilsHtmlElementTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlElement), FairyGUIUtilsHtmlElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlImage), FairyGUIUtilsHtmlImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlInput), FairyGUIUtilsHtmlInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlLink), FairyGUIUtilsHtmlLinkWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlPageContext), FairyGUIUtilsHtmlPageContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlParseOptions), FairyGUIUtilsHtmlParseOptionsWrap.__Register);
        
        }
        
        static void wrapInit8(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlParser), FairyGUIUtilsHtmlParserWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.HtmlSelect), FairyGUIUtilsHtmlSelectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.IHtmlObject), FairyGUIUtilsIHtmlObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.IHtmlPageContext), FairyGUIUtilsIHtmlPageContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.ToolSet), FairyGUIUtilsToolSetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.UBBParser), FairyGUIUtilsUBBParserWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.XML), FairyGUIUtilsXMLWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.XMLTagType), FairyGUIUtilsXMLTagTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.XMLIterator), FairyGUIUtilsXMLIteratorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.XMLList), FairyGUIUtilsXMLListWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.XMLUtils), FairyGUIUtilsXMLUtilsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.ZipReader), FairyGUIUtilsZipReaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ABPathHelper), ETColdABPathHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.AnimatorHelper), ETColdAnimatorHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.AssetDatabaseHelper), ETColdAssetDatabaseHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.CalLuaHelper), ETColdCalLuaHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.CompareHelper), ETColdCompareHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.FileHelper), ETColdFileHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.GameObjectHelper), ETColdGameObjectHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.HotfixHelper), ETColdHotfixHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.JsonHelper), ETColdJsonHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.LocalTimeHelper), ETColdLocalTimeHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.MD5Helper), ETColdMD5HelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.MathHelper), ETColdMathHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.MonoHelper), ETColdMonoHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ObjectHelper), ETColdObjectHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.PathHelper), ETColdPathHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ProcessHelper), ETColdProcessHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.RandomHelper), ETColdRandomHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ResourcesHelper), ETColdResourcesHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.StringHelper), ETColdStringHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ZipHelper), ETColdZipHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.FileLogger), ETColdFileLoggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ILog), ETColdILogWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.Define), ETColdDefineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.GameInit), ETColdGameInitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.GameLoop), ETColdGameLoopWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.KcpWraper), ETColdKcpWraperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.AssetBundleLoaderAsync), ETColdAssetBundleLoaderAsyncWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.AssetBundles), ETColdAssetBundlesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.AssetLoaderAsync), ETColdAssetLoaderAsyncWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.LogData), ETColdLogDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.DebugType), ETColdDebugTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.DebuggerComponent), ETColdDebuggerComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.GizmosDebug), ETColdGizmosDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.IStaticMethod), ETColdIStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.MonoStaticMethod), ETColdMonoStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.UILayer), ETColdUILayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.Lua), ETColdLuaWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.LuaHelper), ETColdLuaHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.AsyncETTaskCompletedMethodBuilder), ETAsyncETTaskCompletedMethodBuilderWrap.__Register);
        
        }
        
        static void wrapInit9(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(ET.ETAsyncTaskMethodBuilder), ETETAsyncTaskMethodBuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.AsyncETVoidMethodBuilder), ETAsyncETVoidMethodBuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ETTask), ETETTaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ETTaskCompleted), ETETTaskCompletedWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ETVoid), ETETVoidWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.AwaiterStatus), ETAwaiterStatusWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ISupportInitialize), ETISupportInitializeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.Object), ETObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.CanvasConfig), ETCanvasConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.IStaticMethod), ETIStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.MonoStaticMethod), ETMonoStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MessageBox.EventId), MessageBoxEventIdWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Battlehub.UIControls.MultiselectDropdown.OptionData), BattlehubUIControlsMultiselectDropdownOptionDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BlendModeUtils.BlendFactor), FairyGUIBlendModeUtilsBlendFactorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.MovieClip.Frame), FairyGUIMovieClipFrameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.NGraphics.VertexMatrix), FairyGUINGraphicsVertexMatrixWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.BitmapFont.BMGlyph), FairyGUIBitmapFontBMGlyphWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.RTLSupport.DirectionType), FairyGUIRTLSupportDirectionTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TextField.LineInfo), FairyGUITextFieldLineInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TextField.LineCharInfo), FairyGUITextFieldLineCharInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TextField.CharPosition), FairyGUITextFieldCharPositionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.TextFormat.SpecialStyle), FairyGUITextFormatSpecialStyleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UpdateContext.ClipInfo), FairyGUIUpdateContextClipInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.GPathPoint.CurveType), FairyGUIGPathPointCurveTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.ControllerAction.ActionType), FairyGUIControllerActionActionTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIConfig.ConfigKey), FairyGUIUIConfigConfigKeyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIConfig.ConfigValue), FairyGUIUIConfigConfigValueWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIContentScaler.ScaleMode), FairyGUIUIContentScalerScaleModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), FairyGUIUIContentScalerScreenMatchModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.XMLList.Enumerator), FairyGUIUtilsXMLListEnumeratorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(FairyGUI.Utils.ZipReader.ZipEntry), FairyGUIUtilsZipReaderZipEntryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.Define.GlobalProto), ETColdDefineGlobalProtoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.SocketAsyncOperation), SystemNetSocketsSocketAsyncOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.SocketError), SystemNetSocketsSocketErrorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AnimationTriggers), UnityEngineUIAnimationTriggersWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasUpdate), UnityEngineUICanvasUpdateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ICanvasElement), UnityEngineUIICanvasElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasUpdateRegistry), UnityEngineUICanvasUpdateRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ColorBlock), UnityEngineUIColorBlockWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ClipperRegistry), UnityEngineUIClipperRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Clipping), UnityEngineUIClippingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IClipper), UnityEngineUIIClipperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IClippable), UnityEngineUIIClippableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown), UnityEngineUIDropdownWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.FontData), UnityEngineUIFontDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.FontUpdateTracker), UnityEngineUIFontUpdateTrackerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster), UnityEngineUIGraphicRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRegistry), UnityEngineUIGraphicRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IMaskable), UnityEngineUIIMaskableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AspectRatioFitter), UnityEngineUIAspectRatioFitterWrap.__Register);
        
        }
        
        static void wrapInit10(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler), UnityEngineUICanvasScalerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter), UnityEngineUIContentSizeFitterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup), UnityEngineUIGridLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalLayoutGroup), UnityEngineUIHorizontalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), UnityEngineUIHorizontalOrVerticalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutElement), UnityEngineUIILayoutElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutController), UnityEngineUIILayoutControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutGroup), UnityEngineUIILayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutSelfController), UnityEngineUIILayoutSelfControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutIgnorer), UnityEngineUIILayoutIgnorerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutElement), UnityEngineUILayoutElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutGroup), UnityEngineUILayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutRebuilder), UnityEngineUILayoutRebuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutUtility), UnityEngineUILayoutUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.VerticalLayoutGroup), UnityEngineUIVerticalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Mask), UnityEngineUIMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskUtilities), UnityEngineUIMaskUtilitiesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic), UnityEngineUIMaskableGraphicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IMaterialModifier), UnityEngineUIIMaterialModifierWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation), UnityEngineUINavigationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.RawImage), UnityEngineUIRawImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.RectMask2D), UnityEngineUIRectMask2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), UnityEngineUIScrollbarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.SpriteState), UnityEngineUISpriteStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.StencilMaterial), UnityEngineUIStencilMaterialWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngineUIToggleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ToggleGroup), UnityEngineUIToggleGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.VertexHelper), UnityEngineUIVertexHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.BaseMeshEffect), UnityEngineUIBaseMeshEffectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IMeshModifier), UnityEngineUIIMeshModifierWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Outline), UnityEngineUIOutlineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.PositionAsUV1), UnityEngineUIPositionAsUV1Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Shadow), UnityEngineUIShadowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AxisEventData), UnityEngineEventSystemsAxisEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AbstractEventData), UnityEngineEventSystemsAbstractEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseEventData), UnityEngineEventSystemsBaseEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData), UnityEngineEventSystemsPointerEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventHandle), UnityEngineEventSystemsEventHandleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IEventSystemHandler), UnityEngineEventSystemsIEventSystemHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerEnterHandler), UnityEngineEventSystemsIPointerEnterHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerExitHandler), UnityEngineEventSystemsIPointerExitHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerDownHandler), UnityEngineEventSystemsIPointerDownHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerUpHandler), UnityEngineEventSystemsIPointerUpHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerClickHandler), UnityEngineEventSystemsIPointerClickHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IBeginDragHandler), UnityEngineEventSystemsIBeginDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IInitializePotentialDragHandler), UnityEngineEventSystemsIInitializePotentialDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDragHandler), UnityEngineEventSystemsIDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IEndDragHandler), UnityEngineEventSystemsIEndDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDropHandler), UnityEngineEventSystemsIDropHandlerWrap.__Register);
        
        }
        
        static void wrapInit11(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IScrollHandler), UnityEngineEventSystemsIScrollHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IUpdateSelectedHandler), UnityEngineEventSystemsIUpdateSelectedHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ISelectHandler), UnityEngineEventSystemsISelectHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDeselectHandler), UnityEngineEventSystemsIDeselectHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IMoveHandler), UnityEngineEventSystemsIMoveHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ISubmitHandler), UnityEngineEventSystemsISubmitHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ICancelHandler), UnityEngineEventSystemsICancelHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventSystem), UnityEngineEventSystemsEventSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger), UnityEngineEventSystemsEventTriggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTriggerType), UnityEngineEventSystemsEventTriggerTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ExecuteEvents), UnityEngineEventSystemsExecuteEventsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInput), UnityEngineEventSystemsBaseInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInputModule), UnityEngineEventSystemsBaseInputModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerInputModule), UnityEngineEventSystemsPointerInputModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.StandaloneInputModule), UnityEngineEventSystemsStandaloneInputModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.MoveDirection), UnityEngineEventSystemsMoveDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.RaycastResult), UnityEngineEventSystemsRaycastResultWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseRaycaster), UnityEngineEventSystemsBaseRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.Physics2DRaycaster), UnityEngineEventSystemsPhysics2DRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PhysicsRaycaster), UnityEngineEventSystemsPhysicsRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.UIBehaviour), UnityEngineEventSystemsUIBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls.IFactoryControls), UnityEngineUIDefaultControlsIFactoryControlsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls.Resources), UnityEngineUIDefaultControlsResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.OptionData), UnityEngineUIDropdownOptionDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.OptionDataList), UnityEngineUIDropdownOptionDataListWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.DropdownEvent), UnityEngineUIDropdownDropdownEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), UnityEngineUIGraphicRaycasterBlockingObjectsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Type), UnityEngineUIImageTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.FillMethod), UnityEngineUIImageFillMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.OriginHorizontal), UnityEngineUIImageOriginHorizontalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.OriginVertical), UnityEngineUIImageOriginVerticalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin90), UnityEngineUIImageOrigin90Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin180), UnityEngineUIImageOrigin180Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin360), UnityEngineUIImageOrigin360Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.ContentType), UnityEngineUIInputFieldContentTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.InputType), UnityEngineUIInputFieldInputTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.CharacterValidation), UnityEngineUIInputFieldCharacterValidationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.LineType), UnityEngineUIInputFieldLineTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.SubmitEvent), UnityEngineUIInputFieldSubmitEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.OnChangeEvent), UnityEngineUIInputFieldOnChangeEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), UnityEngineUIAspectRatioFitterAspectModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), UnityEngineUICanvasScalerScaleModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), UnityEngineUICanvasScalerScreenMatchModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.Unit), UnityEngineUICanvasScalerUnitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), UnityEngineUIContentSizeFitterFitModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup.Corner), UnityEngineUIGridLayoutGroupCornerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup.Axis), UnityEngineUIGridLayoutGroupAxisWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), UnityEngineUIGridLayoutGroupConstraintWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent), UnityEngineUIMaskableGraphicCullStateChangedEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation.Mode), UnityEngineUINavigationModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.MovementType), UnityEngineUIScrollRectMovementTypeWrap.__Register);
        
        }
        
        static void wrapInit12(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), UnityEngineUIScrollRectScrollbarVisibilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent), UnityEngineUIScrollRectScrollRectEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar.Direction), UnityEngineUIScrollbarDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar.ScrollEvent), UnityEngineUIScrollbarScrollEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider.Direction), UnityEngineUISliderDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider.SliderEvent), UnityEngineUISliderSliderEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle.ToggleTransition), UnityEngineUIToggleToggleTransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle.ToggleEvent), UnityEngineUIToggleToggleEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), UnityEngineEventSystemsPointerEventDataInputButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), UnityEngineEventSystemsPointerEventDataFramePressStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent), UnityEngineEventSystemsEventTriggerTriggerEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.Entry), UnityEngineEventSystemsEventTriggerEntryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), UnityEngineEventSystemsPointerInputModuleMouseButtonEventDataWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            wrapInit2(luaenv, translator);
            
            wrapInit3(luaenv, translator);
            
            wrapInit4(luaenv, translator);
            
            wrapInit5(luaenv, translator);
            
            wrapInit6(luaenv, translator);
            
            wrapInit7(luaenv, translator);
            
            wrapInit8(luaenv, translator);
            
            wrapInit9(luaenv, translator);
            
            wrapInit10(luaenv, translator);
            
            wrapInit11(luaenv, translator);
            
            wrapInit12(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
