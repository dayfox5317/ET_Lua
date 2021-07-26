// using System;
// using System.IO;
// using MongoDB.Bson;
// using MongoDB.Bson.IO;
// using MongoDB.Bson.Serialization;
// using MongoDB.Bson.Serialization.Serializers;
// using System.Collections.Generic;
// using MongoDB.Bson.Serialization.Conventions;
// using UnityEngine;
//
// namespace ETCold
// {
// 	public static class MongoHelper
// 	{
//         static MongoHelper()
// 		{
// 			// 自动注册IgnoreExtraElements
//
// 			ConventionPack conventionPack = new ConventionPack { new IgnoreExtraElementsConvention(true) };
//
// 			ConventionRegistry.Register("IgnoreExtraElements", conventionPack, type => true);
//
//
//             BsonSerializer.RegisterSerializer(typeof(System.Numerics. Vector2), new StructBsonSerialize<System.Numerics.Vector2>());
//             BsonSerializer.RegisterSerializer(typeof(System.Numerics.Vector3), new StructBsonSerialize<System.Numerics.Vector3>());
// #if UNITY
//             BsonSerializer.RegisterSerializer(typeof(UnityEngine.Rect), new StructBsonSerialize<UnityEngine.Rect>());
//             BsonSerializer.RegisterSerializer(typeof(UnityEngine.Vector2), new StructBsonSerialize<UnityEngine.Vector2>());
//             BsonSerializer.RegisterSerializer(typeof(UnityEngine.Vector3), new StructBsonSerialize<UnityEngine.Vector3>());
//             BsonSerializer.RegisterSerializer(typeof(UnityEngine.Vector4), new StructBsonSerialize<UnityEngine.Vector4>());
// #endif
//         }
//
//
//         public static void LookupTypes(IEnumerable<Type> types)
// 		{
// 			if(types != null)
// 			{
// 				foreach (Type item in types)
// 				{
// 					if (item.IsAbstract)
// 					{
// 						continue;
// 					}
//
// 					if (item.IsGenericType)
// 					{
// 						continue;
// 					}
//
// 					BsonClassMap.LookupClassMap(item);
// 				}
// 			}
// 		}
// public static void LookupType(Type type)
// 		{
// 					if (type.IsAbstract)
// 					{
// 						return;
// 					}
// 					if (type.IsGenericType)
// 					{
// 						return;
// 					}
//
// 					BsonClassMap.LookupClassMap(type);
// 		}
// 		public static string ToJson(object obj)
// 		{
// 			return obj.ToJson();
// 		}
//
// 		public static string ToJson(object obj, JsonWriterSettings settings)
// 		{
// 			return obj.ToJson(settings);
// 		}
//
// 		public static T FromJson<T>(string str)
// 		{
// 			return BsonSerializer.Deserialize<T>(str);
// 		}
//
// 		public static object FromJson(Type type, string str)
// 		{
// 			return BsonSerializer.Deserialize(str, type);
// 		}
//
// 		public static byte[] ToBson(object obj)
// 		{
// 			return obj.ToBson();
// 		}
// 		
// 		public static void ToBson(object obj, MemoryStream stream)
// 		{
// 			using (BsonBinaryWriter bsonWriter = new BsonBinaryWriter(stream, BsonBinaryWriterSettings.Defaults))
// 			{
// 				BsonSerializationContext context = BsonSerializationContext.CreateRoot(bsonWriter);
// 				BsonSerializationArgs args = default (BsonSerializationArgs);
// 				args.NominalType = typeof(object);
// 				IBsonSerializer serializer = BsonSerializer.LookupSerializer(args.NominalType);
// 				serializer.Serialize(context, args, obj);
// 			}
// 		}
// 		
// 		public static object FromBson(Type type, byte[] bytes)
// 		{
// 			return BsonSerializer.Deserialize(bytes, type);
// 		}
//
// 		public static object FromBson(Type type, byte[] bytes, int index, int count)
// 		{
// 			using (MemoryStream memoryStream = new MemoryStream(bytes, index, count))
// 			{
// 				return BsonSerializer.Deserialize(memoryStream, type);
// 			}
// 		}
// 		
// 		public static object FromBson(object instance, byte[] bytes, int index, int count)
// 		{
// 			using (MemoryStream memoryStream = new MemoryStream(bytes, index, count))
// 			{
// 				return BsonSerializer.Deserialize(memoryStream, instance.GetType());
// 			}
// 		}
// 		
// 		public static object FromBson(object instance, Stream stream)
// 		{
// 			return BsonSerializer.Deserialize(stream, instance.GetType());
// 		}
// 		
// 		public static object FromStream(Type type, Stream stream)
// 		{
// 			return BsonSerializer.Deserialize(stream, type);
// 		}
//
// 		public static T FromBson<T>(byte[] bytes)
// 		{
// 			using (MemoryStream memoryStream = new MemoryStream(bytes))
// 			{
// 				return (T) BsonSerializer.Deserialize(memoryStream, typeof (T));
// 			}
// 		}
//
// 		public static T FromBson<T>(byte[] bytes, int index, int count)
// 		{
// 			return (T) FromBson(typeof (T), bytes, index, count);
// 		}
//
// 		public static T Clone<T>(T t)
// 		{
// 			return FromBson<T>(ToBson(t));
// 		}
//
//         public static void RegisterStruct(Type type)
//         {
// 			Log.Info($"{type}");
//             BsonSerializer.RegisterSerializer(type, new StructBsonSerialize(type));
//         }
//         public static void RegisterClass(Type type)
//         {
// 			BsonSerializer.LookupSerializer(type);
//         }
//
//         public static void AvoidAOT()
//         {
//             ArraySerializer<int> aint = new ArraySerializer<int>();
//             ArraySerializer<string> astring = new ArraySerializer<string>();
//             ArraySerializer<long> along = new ArraySerializer<long>();
//             EnumerableInterfaceImplementerSerializer<List<int>> e = new EnumerableInterfaceImplementerSerializer<List<int>>();
//             EnumerableInterfaceImplementerSerializer<List<int>, int> elistint = new EnumerableInterfaceImplementerSerializer<List<int>, int>();
//         }
// 	}
// }