using System.IO;
using System.Linq;
using System.Reflection;
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace ETCold
{
    public static class CalLuaHelper
    {
        private static Type ListType = typeof(List<>);
        private static Type ArrayType = typeof(Array);
        private static Type HashSetType = typeof(HashSet<>);
        private static Type DictType = typeof(Dictionary<,>);
        private static int index = 0;
        private static void AvoidLoopOver()
        {
            index++;
            if (index > 1000)
                throw new Exception("stack overflow");
        }
        public static string ToJson(object obj, string fieldName = null)
        {
            AvoidLoopOver();
            if (obj == null)   return $"\"{fieldName}\":null";
            Type type = obj.GetType();
            TypeCode typeCode = System.Type.GetTypeCode(type);
            if (typeCode == TypeCode.Object)
            {
                return GenerateObjectToLua(obj, fieldName);
            }
            if(type.IsEnum){
                return $"\"{fieldName}\":{(int)obj}";
            }
            switch (typeCode)
            {
                default:
                case TypeCode.Empty: return "null";
                case TypeCode.Int32:
                case TypeCode.Int16:
                case TypeCode.Int64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Boolean:
                    if (fieldName != null)
                        return $"\"{fieldName}\":{obj}";
                    else return obj.ToString();
                case TypeCode.String:
                    if (fieldName != null)
                        return $"\"{fieldName}\":\"{obj}\"";
                    else return $"\"{obj}\"";
            }
        }

        private static string GenerateObjectToLua(object obj, string fieldName = null)
        {
            if (obj == null) return "null";
            Type type = obj.GetType();
            string generucString = GetGenericType(obj, type);
            if (generucString != null)
            {
                if (fieldName != null)
                    return $"\"{fieldName}\":{generucString}";
                else
                    return generucString;
            }
            string ret = null;
            if (fieldName != null)
                ret += $"\"{fieldName}\":{{";
            else
                ret += "{";
            List<MemberInfo> memList = new List<MemberInfo>();
            memList.AddRange(type.GetMembers().Where(t => t.MemberType == MemberTypes.Field || ((t.MemberType == MemberTypes.Property) && (t as PropertyInfo).CanWrite)));
            ret += $"\"_t\":\"{type}\",";
            foreach (var memberInfo in memList)
            {
                if (memberInfo is FieldInfo fieldInfo)
                {
                    ret += ToJson(fieldInfo.GetValue(obj), fieldInfo.Name);
                }
                else if (memberInfo is PropertyInfo propertyInfo)
                {
                    ret += ToJson(propertyInfo.GetValue(obj), propertyInfo.Name);
                }
                ret += ",";
            }
            ret = ret.Substring(0, ret.Length - 1);
            return ret += "}";
        }

        private static string GetGenericType(object obj, Type type)
        {
            string ret = null;
            if (type.IsArray)
            {
                var arr = obj as Array;
                ret = $"[\"_t\":\"{type}\",";
                foreach (var item in arr)
                {
                    ret += ToJson(item) + ",";
                }
                ret = ret.Substring(0, ret.Length - 1) + "]";
                return ret;
            }
            if (type.IsGenericType)
            {
                var definitionType = type.GetGenericTypeDefinition();
                if (definitionType == ListType || definitionType == HashSetType)
                {
                    var list = obj as IList;
                    ret = $"[\"_t\":\"{type}\",";
                    foreach (var item in list)
                    {
                        ret += ToJson(item) + ",";
                    }
                    ret = ret.Substring(0, ret.Length - 1) + "]";
                }
                if (definitionType == DictType)
                {
                    var dic = obj as IDictionary;
                    ret = $"{{\"_t\":\"{type}\",";
                    foreach (DictionaryEntry item in dic)
                    {
                        ret += $"\"{item.Key}\":{ToJson(item.Value)},";
                    }
                    ret = ret.Substring(0, ret.Length - 1) + "}";
                }
            }
            return ret;
        }

        private struct DataInfo
        {
            public static DataInfo Empty = default;
            public enum Type__ { None, Field, Property }
            private Type__ type;
            private FieldInfo fieldInfo;
            private PropertyInfo propertyInfo;

            public System.Type Type => fieldInfo != null ? fieldInfo.FieldType : propertyInfo.PropertyType;

            public string Name => fieldInfo != null ? fieldInfo.Name : propertyInfo.Name;

            public static bool operator ==(DataInfo x, DataInfo y)
            {
                return x.type == y.type;
            }
            public static bool operator !=(DataInfo x, DataInfo y)
            {
                return !(x == y);
            }
            public DataInfo(Type__ type, MemberInfo info)
            {
                fieldInfo = null;
                propertyInfo = null;
                this.type = type;
                switch (type)
                {
                    case Type__.Field:
                        fieldInfo = info as FieldInfo;
                        break;
                    case Type__.Property:
                        propertyInfo = info as PropertyInfo;
                        break;
                }
            }
            public void SetData(object obj, object value)
            {
                if (fieldInfo != null)
                    fieldInfo.SetValue(obj, value);
                else
                    propertyInfo.SetValue(obj, value);
            }
        }
        public static T ToObject<T>(string str)
        {
            var ret = ToObject(str, 0, typeof(T));
            return (T)ret.Item1;
        }
        private static (object, int) ToObject(string str, int startPos, Type type)
        {
            startPos = DecodeSpace(str, startPos);
            var currChar = str[startPos];
            switch (currChar)
            {
                case '{':
                    return DecodeObject(str, type, startPos);
                case '[':
                    return DecodeArray(str, type, startPos);
                case '"':
                    return DecodeString(str, startPos);
                default:
                    break;
            }
            if (NumStr.Contains(currChar))
            {
                return DecodeNumber(str, type, startPos);
            }
            //true ,false ,null
            return DecodeConst(str, type, startPos);
        }

        private static (object, int) DecodeType(string str, Type type, int startPos)
        {
            char currChar = str[startPos];
            if (currChar != '<')
                throw new Exception($"pos = {startPos} str = {str} not <");

            object t = null;
            startPos++;
            while (true)
            {
                AvoidLoopOver();
                currChar = str[startPos];
                if (currChar == '>')
                {
                    return (t, startPos + 1);
                }
                else
                if (currChar == '_')
                {
                    currChar = str[++startPos];
                    if (currChar == 't')
                    {
                        startPos += 2;
                        (_, startPos) = DecodeString(str, startPos);
                        startPos = DecodeSpace(str, startPos);
                        if (str[startPos] == ',')
                            startPos++;
                        else
                            throw new Exception($@"cann't decode the str not ',' in pos = {startPos} str = {str} char = {str[startPos]} 
                    string = {str.Substring(Math.Max(0, startPos - 10), startPos - Math.Max(0, startPos - 10) + 1)}");

                        (t, startPos) = ToObject(str, startPos, type);
                    }
                }
            }
        }
        private static (object, int) DecodeObject(string str, Type type, int startPos)
        {
            var currChar = str[startPos];
            if (currChar != '{')
                throw new Exception($"pos = {startPos} str = {str} not {{");
            if (type.IsGenericType)
            {
                return DecodeDict(str, type, startPos);
            }
            List<DataInfo> list = new List<DataInfo>();
            foreach (var item in type.GetMembers())
            {
                if (item.MemberType == MemberTypes.Field)
                {
                    list.Add(new DataInfo(DataInfo.Type__.Field, item));
                }
                else
                if (item.MemberType == MemberTypes.Property && (item as PropertyInfo).CanWrite)
                {
                    list.Add(new DataInfo(DataInfo.Type__.Property, item));
                }
            }
            object t = Activator.CreateInstance(type);
            startPos++;
            while (true)
            {
                AvoidLoopOver();
                startPos = DecodeSpace(str, startPos);
                currChar = str[startPos];
                if (currChar == '}')
                {
                    return (t, startPos + 1);
                }
                else
                if (currChar == ',')
                {
                    startPos = DecodeSpace(str, startPos + 1);
                }
                object key;
                (key, startPos) = DecodeString(str, startPos);
                startPos = DecodeSpace(str, startPos);
                if (str[startPos] == ':')
                    startPos++;
                else
                    throw new Exception($@"cann't decode the str not ':' in pos = {startPos} str = {str} char = {str[startPos]} 
                    string = {str.Substring(Math.Max(0, startPos - 10), startPos - Math.Max(0, startPos - 10) + 1)}");
                string keyStr = key as string;
                startPos = DecodeSpace(str, startPos);
                if (keyStr.Equals("_t", StringComparison.Ordinal))
                {
                    (_, startPos) = DecodeString(str, startPos);
                }
                else
                {
                    DataInfo fieldInfo = DataInfo.Empty;
                    foreach (var item in list)
                    {
                        if (item.Name == keyStr)
                        {
                            fieldInfo = item;
                            break;
                        }
                    }
                    if (fieldInfo != DataInfo.Empty)
                    {
                        object value;
                        (value, startPos) = ToObject(str, startPos, fieldInfo.Type);
                        fieldInfo.SetData(t, value);
                    }
                }

            }
        }

        private static (object, int) DecodeDict(string str, Type type, int startPos)
        {
            object t = Activator.CreateInstance(type);
            Type keyType = type.GenericTypeArguments[0];
            Type valueType = type.GenericTypeArguments[1];
            var methodInfo = type.GetMethod("Add");
            //   Action<object> add = methodInfo.CreateDelegate(typeof(Action<object>), t) as Action<object>;
            startPos++;
            object[] arr = new object[2];
            while (true)
            {
                AvoidLoopOver();
                startPos = DecodeSpace(str, startPos);
                var currChar = str[startPos];
                if (currChar == '}')
                {
                    return (t, startPos + 1);
                }
                if (currChar == ',')
                {
                    startPos = DecodeSpace(str, startPos + 1);
                }
                object key, value;
                (key, startPos) = ToObject(str, startPos, keyType);
                startPos = DecodeSpace(str, startPos);
                if (str[startPos] == ':')
                    startPos++;
                else
                    throw new Exception($@"cann't decode the str not ':' in pos = {startPos} str = {str} char = {str[startPos]} 
                    string = {str.Substring(Math.Max(0, startPos - 10), startPos - Math.Max(0, startPos - 10) + 1)}");
                startPos = DecodeSpace(str, startPos);
                if (key.ToString().Equals("_t", StringComparison.Ordinal))
                {
                    (_, startPos) = DecodeString(str, startPos);
                }
                else
                {
                    (value, startPos) = ToObject(str, startPos, valueType);
                    startPos = DecodeSpace(str, startPos);
                    // add.Invoke(value);
                    var keyObj = Convert.ChangeType(key, keyType);
                    arr[0] = keyObj;
                    arr[1] = value;
                    methodInfo.Invoke(t, arr);
                }

            }
        }

        private static (object, int) DecodeArray(string str, Type type, int startPos)
        {
            var currChar = str[startPos];
            if (currChar != '[')
                throw new Exception($"pos = {startPos} str = {str} not [");
            object t = null;
            startPos = DecodeSpace(str, startPos);
          
            if (type.IsArray)
            {
                
                int index = 0;
                Type elementTyep = type.GetElementType();
                Array arr = null;
                startPos++;
                while (true)
                {
                    AvoidLoopOver();
                    startPos = DecodeSpace(str, startPos);
                    currChar = str[startPos];
                    if (currChar == ']')
                    {
                        return (t, startPos + 1);
                    }
                    if (currChar == '\"')
                    {
                        object key;
                        (key, startPos) = DecodeString(str, startPos);
                        startPos = DecodeSpace(str, startPos);
                        if (str[startPos] == ':')
                            startPos++;
                        else
                            throw new Exception($@"cann't decode the str not ':' in pos = {startPos} str = {str} char = {str[startPos]} 
                    string = {str.Substring(Math.Max(0, startPos - 10), startPos - Math.Max(0, startPos - 10) + 1)}");
                        startPos = DecodeSpace(str, startPos);
                        if (key.ToString().Equals("_t", StringComparison.Ordinal))
                        {
                            (_, startPos) = DecodeString(str, startPos);
                            startPos = DecodeSpace(str, startPos+1);
                            string temp = str.Substring(startPos);
                            string subStr = temp.Substring(0, temp.IndexOf(']'));
                            int len;
                            if (temp[0]=='{')
                            {
                                len = subStr.Split('{').Length-1;
                            }
                            else
                            if (temp[0] == '[')
                            {
                                len = subStr.Split('[').Length-1;
                            }
                            else
                            {
                                len = subStr.Split(',').Length;
                            }
                            arr =Array.CreateInstance(elementTyep, len);

                        }
                    }
                    else
                    {

                        if (currChar == ',')
                        {
                            startPos = DecodeSpace(str, startPos + 1);
                        }
                        object value;
                        (value, startPos) = ToObject(str, startPos, elementTyep);
                        startPos = DecodeSpace(str, startPos);
                        arr.SetValue(value, index++);
                        t = arr;
                    }
                }
            }
            else
         if (type.IsGenericType)
            {
                t = Activator.CreateInstance(type);
                Type argType = type.GenericTypeArguments[0];
                var methodInfo = type.GetMethod("Add");
                //   Action<object> add = methodInfo.CreateDelegate(typeof(Action<object>), t) as Action<object>;
                startPos++;
                object[] arr = new object[1];
                while (true)
                {
                    AvoidLoopOver();
                    startPos = DecodeSpace(str, startPos);
                    currChar = str[startPos];
                    if (currChar == ']')
                    {
                        return (t, startPos + 1);
                    }
                    if (currChar == '\"')
                    {
                        object key;
                        (key, startPos) = DecodeString(str, startPos);
                        startPos = DecodeSpace(str, startPos);
                        if (str[startPos] == ':')
                            startPos++;
                        else
                            throw new Exception($@"cann't decode the str not ':' in pos = {startPos} str = {str} char = {str[startPos]} 
                    string = {str.Substring(Math.Max(0, startPos - 10), startPos - Math.Max(0, startPos - 10) + 1)}");
                        startPos = DecodeSpace(str, startPos);
                        if (key.ToString().Equals("_t", StringComparison.Ordinal))
                        {
                            (_, startPos) = DecodeString(str, startPos);
                        }
                    }
                    else
                    {

                        if (currChar == ',')
                        {
                            startPos = DecodeSpace(str, startPos + 1);
                        }
                        object value;
                        (value, startPos) = ToObject(str, startPos, argType);
                        startPos = DecodeSpace(str, startPos);
                        // add.Invoke(value);
                        arr[0] = value;
                        methodInfo.Invoke(t, arr);
                    }
                }
            }

            return (null, startPos);
        }

        private static (object, int) DecodeString(string str, int startPos)
        {
            int len = str.Length;
            int endPos = startPos;
            startPos++;
            while (++endPos < len && str[endPos] != '"')
            {

            }
            var t = str.Substring(startPos, endPos - startPos);
            return (t, endPos + 1);
        }
        private static int DecodeSpace(string str, int startPos)
        {
            int endPos = startPos;
            int stringLen = str.Length;
            while (endPos < stringLen && SpaceStr.Contains(str[endPos]))
            {
                endPos++;
            }
            return endPos;
        }
        static string NumStr = "+-0123456789.e";
        static string SpaceStr = " \n\t\r";
        static string[] ConstStr = new[] { "true", "false", "null" };
        private static (object, int) DecodeNumber(string str, Type type, int startPos)
        {
            int endPos = startPos + 1;
            int stringLen = str.Length;
            while (endPos < stringLen && NumStr.Contains(str[endPos]))
            {
                endPos++;
            }
            string subStr = str.Substring(startPos, endPos - startPos);
            object t;
            if(type.IsEnum){
                int num = int.Parse(subStr);
                t =Enum.ToObject(type,num);
            }
            else
                t = Convert.ChangeType(subStr, type);
            return (t, endPos);
        }
        private static (object, int) DecodeConst(string str, Type type, int startPos)
        {
            foreach (var item in ConstStr)
            {
                int len = item.Length;
                if (startPos < str.Length && startPos + len <= str.Length && str.Substring(startPos, len) == item)
                {
                    if(item == "null")
                    return (null, startPos + len);
                    var t = Convert.ChangeType(item, type);
                    return (t, startPos + len);
                }
            }
            throw new Exception($"cann't decode the str in pos = {startPos} str = {str} char = {str[startPos]} string = {str.Substring(Math.Max(0, startPos - 10), startPos - Math.Max(0, startPos - 10) + 1)}");
        }
    }
}