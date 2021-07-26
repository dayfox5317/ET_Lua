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
        
        
            translator.DelayWrapLoader(typeof(ETCold.ArrayHelper), ETColdArrayHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform.Axis), UnityEngineRectTransformAxisWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform.Edge), UnityEngineRectTransformEdgeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable), UnityEngineUISelectableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable.Transition), UnityEngineUISelectableTransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngineUIButtonButtonClickedEventWrap.__Register);
        
        }
        
        static void wrapInit2(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(System.IO.SeekOrigin), SystemIOSeekOriginWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Reflection.MemberInfo), SystemReflectionMemberInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ReferenceCollectorData), ReferenceCollectorDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ReferenceCollectorDataComparer), ReferenceCollectorDataComparerWrap.__Register);
        
        
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
        
        
            translator.DelayWrapLoader(typeof(ETModel.IDisposableClassInheritanceAdaptor), ETModelIDisposableClassInheritanceAdaptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETModel.ILAdapterAttribute), ETModelILAdapterAttributeWrap.__Register);
        
        
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
        
        }
        
        static void wrapInit3(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(ETCold.ProcessHelper), ETColdProcessHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.RandomHelper), ETColdRandomHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.ResourcesHelper), ETColdResourcesHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.StringHelper), ETColdStringHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.TypeHelper), ETColdTypeHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.FastRawList), ETColdFastRawListWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.RawTypeInfo), ETColdRawTypeInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.RawMemberInfo), ETColdRawMemberInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.RawFieldInfo), ETColdRawFieldInfoWrap.__Register);
        
        
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
        
        
            translator.DelayWrapLoader(typeof(ET.ETAsyncTaskMethodBuilder), ETETAsyncTaskMethodBuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.AsyncETVoidMethodBuilder), ETAsyncETVoidMethodBuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ETTask), ETETTaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ETTaskCompleted), ETETTaskCompletedWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ETVoid), ETETVoidWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.AwaiterStatus), ETAwaiterStatusWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ISupportInitialize), ETISupportInitializeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.Object), ETObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.Hotfix), ETHotfixWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.CanvasConfig), ETCanvasConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.IStaticMethod), ETIStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ILStaticMethod), ETILStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.MonoStaticMethod), ETMonoStaticMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.ILHelper), ETILHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.IAsyncStateMachineClassInheritanceAdaptor), ETIAsyncStateMachineClassInheritanceAdaptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(MessageBox.EventId), MessageBoxEventIdWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETModel.IDisposableClassInheritanceAdaptor.IDisposableAdaptor), ETModelIDisposableClassInheritanceAdaptorIDisposableAdaptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ETCold.Define.GlobalProto), ETColdDefineGlobalProtoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ET.IAsyncStateMachineClassInheritanceAdaptor.IAsyncStateMachineAdaptor), ETIAsyncStateMachineClassInheritanceAdaptorIAsyncStateMachineAdaptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.SocketAsyncOperation), SystemNetSocketsSocketAsyncOperationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Net.Sockets.SocketError), SystemNetSocketsSocketErrorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AnimationTriggers), UnityEngineUIAnimationTriggersWrap.__Register);
        
        }
        
        static void wrapInit4(LuaEnv luaenv, ObjectTranslator translator)
        {
        
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
        
        }
        
        static void wrapInit5(LuaEnv luaenv, ObjectTranslator translator)
        {
        
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
        
        }
        
        static void wrapInit6(LuaEnv luaenv, ObjectTranslator translator)
        {
        
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
