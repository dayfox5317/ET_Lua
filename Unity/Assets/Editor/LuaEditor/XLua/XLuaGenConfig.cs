﻿/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/


using ETCold;
using ProtoBuf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using XLua;
using AsyncOperation = UnityEngine.AsyncOperation;
using Component = UnityEngine.Component;

public class XLuaGenConfigData
{
    public List<string> assemblyNames;
    public List<string> blackTypes;
}

public static class XLuaGenConfig
{
    public const string path = @"./Assets/Res/GenConfig.txt";

    [LuaCallCSharp]
    public static List<Type> assemblyTypes
    {
        get
        {
            var assemblys = AppDomain.CurrentDomain.GetAssemblies();
            var list = new List<Type>();

            if (assemblys != null)
            {
                foreach (var assembly in assemblys)
                {
                    if (assembly == null || assembly.ManifestModule == null)
                    {
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(assembly.ManifestModule.Name))
                    {
                        continue;
                    }

                    if (File.Exists(path))
                    {
                        var xLuaGenConfigData = JsonHelper.FromJson<XLuaGenConfigData>(File.ReadAllText(path));

                        if (xLuaGenConfigData != null)
                        {
                            if (xLuaGenConfigData.assemblyNames != null && xLuaGenConfigData.assemblyNames.Contains(assembly.ManifestModule.Name))
                            {
                                var types = assembly.GetTypes();

                                if (types != null)
                                {
                                    foreach (var item in types)
                                    {
                                        if (list.Contains(item))
                                        {
                                            continue;
                                        }

                                        if (xLuaGenConfigData.blackTypes != null && xLuaGenConfigData.blackTypes.Contains(item.FullName))
                                        {
                                            continue;
                                        }

                                        list.Add(item);
                                    }
                                }
                            }
                        }
                    }


                }
            }

            return list;
        }
    }

    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp
    {
        get
        {

            var list = new List<Type>() {
        typeof(object),
        typeof(UnityEngine.Object),
        typeof(UnityEngine.Application),
        typeof(UnityEngine.AssetBundle),
        typeof(UnityEngine.LayerMask),
        typeof(Vector2),
        typeof(Vector3),
        typeof(Vector4),
        typeof(Quaternion),
        typeof(Color),
        typeof(Ray),
        typeof(Bounds),
        typeof(Ray2D),
        typeof(Time),
        typeof(GameObject),
        typeof(Component),
        typeof(Behaviour),
        typeof(Transform),
        typeof(Resources),
        typeof(TextAsset),
        typeof(Keyframe),
        typeof(AnimationCurve),
        typeof(AnimationClip),
        typeof(MonoBehaviour),
        typeof(ParticleSystem),
        typeof(SkinnedMeshRenderer),
        typeof(Renderer),
        typeof(Light),
        typeof(Mathf),
        typeof(List<int>),
        typeof(Action<string>),
        typeof(Debug),
        typeof(ConcurrentDictionary<long,ulong>),
        typeof(RaycastHit),
        typeof(Input),
        typeof(Physics),
        typeof(Camera),
        typeof(Animator),
        typeof(List<string>),
        typeof(UnityEngine.SceneManagement.SceneManager),
        typeof(Type),
        typeof(RuntimeAnimatorController),
        typeof(AnimatorControllerParameter),
        typeof(Socket),
        typeof(IPEndPoint),
        typeof(EndPoint),
        typeof(IPAddress),
        typeof(AddressFamily),
        typeof(SocketType),
        typeof(ProtocolType),
        typeof(SocketAsyncEventArgs),
        typeof(SerializableAttribute),
        typeof(Path),
        typeof(AssetBundleManifest),
        typeof(TextAsset),
        typeof(IOException),
        typeof(ProtoMemberAttribute),
        typeof(ProtoContractAttribute),
        typeof(Encoding),
        typeof(Stream),
        typeof(MemoryStream),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIdAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfDefaultAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreIfNullAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonDefaultValueAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonRequiredAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonElementAttribute),
        typeof(MongoDB.Bson.Serialization.Attributes.BsonDictionaryOptionsAttribute),
        typeof(MongoDB.Bson.Serialization.BsonSerializer),
        typeof(System.Runtime.Serialization.IgnoreDataMemberAttribute),
        typeof(System.Runtime.CompilerServices.AsyncMethodBuilderAttribute),
        typeof(ProtoMemberAttribute),
        typeof(ProtoContractAttribute),
        typeof(ProtoConverterAttribute),
        typeof(ProtoEnumAttribute),
        typeof(ProtoIgnoreAttribute),
        typeof(ProtoIncludeAttribute),
        typeof(ProtoPartialIgnoreAttribute),
        typeof(ProtoPartialMemberAttribute),
        typeof(AsyncOperation),
        typeof(UnityLogger),
        typeof(Kcp),
        typeof(ThreadSynchronizationContext),
        typeof(ISupportInitialize),
        typeof(Guid),
        typeof(ComponentView),
        typeof(UILayerScript),
        typeof(CircularBuffer),
        typeof(ByteHelper),
        typeof(StreamHelper),
        typeof(LoadHelper),
        typeof(ReferenceCollector),
        typeof(Button),
        typeof(Text),
        typeof(InputField),
        typeof(libx.AssetRequest),
        typeof(libx.Assets),

        typeof(UnityEngine.RectTransform),
        typeof(UnityEngine.RectTransform.Axis),
        typeof(UnityEngine.RectTransform.Edge),
        typeof( UnityEngine.UI.Selectable),
        typeof( UnityEngine.UI.Selectable.Transition),
        typeof( UnityEngine.UI.Button.ButtonClickedEvent),
        typeof(System.IO.SeekOrigin),
        typeof(System.Reflection.MemberInfo),
        //typeof(System.Runtime.InteropServices.StructLayoutAttribute),
        //typeof(System.Runtime.InteropServices.LayoutKind),

        };
            var types = typeof(CircularBuffer).Assembly.GetTypes();


            list.AddRange(types.Where(x => !x.FullName.StartsWith("XLua")));

            list.Add(typeof(SocketAsyncOperation));
            list.Add(typeof(SocketError));
            // list.Add(typeof(con).Assembly.GetTypes());
            list.AddRange(typeof(UnityEngine.UI.InputField).Assembly.GetTypes());
            list.Remove(typeof(UnityEngine.UI.Graphic));
            list.Remove(typeof(UnityEngine.UI.DefaultControls));
            list.Remove(typeof(UnityEngine.UI.GraphicRebuildTracker));

            //var cfg = AutoGenMissingConfig.Load().types;
            //foreach (var item in AppDomain.CurrentDomain.GetAssemblies())
            //{
            //    foreach (var item2 in item.GetTypes())
            //    {
            //        if (cfg.Contains(item2.FullName))
            //        {
            //            list.Add(item2);
            //        }
            //    }
            //}
            //    list.Remove(typeof(UnityEngine.UI.GraphicRebuildTracker));
            return list;
        }
    }

    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
                typeof(System.Action),
                typeof(Func<double, double, double>),
                typeof(Action<string>),
                typeof(Action<double>),
                typeof(UnityEngine.Events.UnityAction),
                typeof(System.Collections.IEnumerator),

                typeof(EventHandler<SocketAsyncEventArgs>),
                typeof(System.Threading.SendOrPostCallback),

                typeof(KcpOutput),
                typeof(KcpLog),
                typeof(Action<long, int>),
                typeof(Action<long, MemoryStream>),
                typeof(Action<long, IPEndPoint>),
                typeof(Func<byte[],uint, int>),
                typeof(Action<libx.AssetRequest>)
            };


    private static List<List<string>> internalBlackList = null;

    [BlackList]
    public static List<List<string>> BlackList
    {
        get
        {
            if (internalBlackList == null)
            {
                internalBlackList = new List<List<string>>();
                internalBlackList.Add(new List<string>() { "System.Xml.XmlNodeList", "ItemOf" });
                internalBlackList.Add(new List<string>() { "UnityEngine.WWW", "movie" });
#if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"});
#endif
                internalBlackList.Add(new List<string>() { "UnityEngine.Texture2D", "alphaIsTransparency" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Security", "GetChainOfTrustValue" });
                internalBlackList.Add(new List<string>() { "UnityEngine.CanvasRenderer", "onRequestRebuild" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Input", "IsJoystickPreconfigured", "System.String" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Light", "areaSize" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Light", "lightmapBakeType" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Light", "SetLightDirty" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Light", "shadowRadius" });
                internalBlackList.Add(new List<string>() { "UnityEngine.Light", "shadowAngle" });
                internalBlackList.Add(new List<string>() { "UnityEngine.WWW", "MovieTexture" });
                internalBlackList.Add(new List<string>() { "UnityEngine.WWW", "GetMovieTexture" });
                /*internalBlackList.Add(new List<string>() { "UnityEngine.AnimatorControllerParameter", "name" });*/
                internalBlackList.Add(new List<string>() { "UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup" });
#if !UNITY_WEBPLAYER
                internalBlackList.Add(new List<string>() { "UnityEngine.Application", "ExternalEval" });
#endif
                internalBlackList.Add(new List<string>() { "UnityEngine.GameObject", "networkView" }); //4.6.2 not support
                internalBlackList.Add(new List<string>() { "UnityEngine.Component", "networkView" });  //4.6.2 not support
                internalBlackList.Add(new List<string>() { "System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections" });
                internalBlackList.Add(new List<string>() { "System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity" });
                internalBlackList.Add(new List<string>() { "System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections" });
                internalBlackList.Add(new List<string>() { "System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity" });
                internalBlackList.Add(new List<string>() { "System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity" });
                internalBlackList.Add(new List<string>() { "System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity" });
                internalBlackList.Add(new List<string>() { "UnityEngine.MonoBehaviour", "runInEditMode" });

                internalBlackList.AddRange(GetStreamBlackList(typeof(Stream).ToString()));
                internalBlackList.AddRange(GetStreamBlackList(typeof(MemoryStream).ToString()));
                internalBlackList.Add(new List<string>() { "System.Linq.Expressions.ElementInit", "GetArgument", "System.Int32" });
                internalBlackList.Add(new List<string>() { "ETCold.ReferenceCollector", "Add", "System.String", "UnityEngine.Object" });
                internalBlackList.Add(new List<string>() { "ETCold.ReferenceCollector", "Remove", "System.String" });
                internalBlackList.Add(new List<string>() { "ETCold.ReferenceCollector", "Clear" });
                internalBlackList.Add(new List<string>() { "ETCold.ReferenceCollector", "Sort" });
                internalBlackList.Add(new List<string>() { "Pathfinding.AlternativePath", "AddComp", "UnityEditor.MenuCommand" });
                internalBlackList.Add(new List<string>() { "Pathfinding.FunnelModifier", "AddComp", "UnityEditor.MenuCommand" });
                internalBlackList.Add(new List<string>() { "Pathfinding.RadiusModifier", "AddComp", "UnityEditor.MenuCommand" });
                internalBlackList.Add(new List<string>() { "Pathfinding.RaycastModifier", "AddComp", "UnityEditor.MenuCommand" });
                internalBlackList.Add(new List<string>() { "Pathfinding.SimpleSmoothModifier", "AddComp", "UnityEditor.MenuCommand" });
                internalBlackList.Add(new List<string>() { "Pathfinding.NodeLink", "LinkObjects" });
                internalBlackList.Add(new List<string>() { "Pathfinding.NodeLink", "UnlinkObjects" });
                internalBlackList.Add(new List<string>() { "Pathfinding.NodeLink", "DeleteLinks" });
                internalBlackList.Add(new List<string>() { "Pathfinding.NodeLink", "LinkObjects", "UnityEngine.Transform", "UnityEngine.Transform", "System.Boolean" });
                internalBlackList.Add(new List<string>() { "System.Linq.Expressions.ElementInit", "ArgumentCount" });
                internalBlackList.Add(new List<string>() { "System.Net.Sockets.SocketAsyncEventArgs", "SocketClientAccessPolicyProtocol" });
                internalBlackList.Add(new List<string>() { "System.Type", "IsSZArray" });
                internalBlackList.Add(new List<string>() { "UnityEngine.UI.Text", "OnRebuildRequested" });
                //internalBlackList.Add(new List<string>() { "UnityEngine.AnimatorControllerParameter", "name" });

            }

            return internalBlackList;
        }
    }

    public static List<List<string>> GetStreamBlackList(string typeName)
    {
        return new List<List<string>>()
        {
            new List<string>(){ typeName, "Read","System.Span`1[System.Byte]" },
            new List<string>(){ typeName, "ReadAsync", "System.Memory`1[System.Byte]" },
            new List<string>(){ typeName, "ReadAsync", "System.Memory`1[System.Byte]", "System.Threading.CancellationToken"},
            new List<string>(){ typeName, "Write", "System.ReadOnlySpan`1[System.Byte]" },
            new List<string>(){ typeName, "WriteAsync", "System.ReadOnlyMemory`1[System.Byte]" },
            new List<string>(){ typeName, "WriteAsync", "System.ReadOnlyMemory`1[System.Byte]","System.Threading.CancellationToken"  },
        };
    }
}

