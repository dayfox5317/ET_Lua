using System;

namespace ET
{
    public static class ReflectHelper
    {
        public static int GetMemberInfoType(object obj)
        {


            if (obj is System.Reflection.FieldInfo fi)
            {
                return 0;
            }
            if (obj is System.Reflection.PropertyInfo pi)
            {
                return 1;
            }
            if (obj is System.Reflection.MethodInfo mi)
            {
                return 2;
            }
            return -1;
        }
        public static object GetValue(object obj, object target)
        {


            if (obj is System.Reflection.FieldInfo fi)
            {
                return fi.GetValue(target);
            }
            if (obj is System.Reflection.PropertyInfo pi)
            {
                return pi.GetValue(target);
            }
            return string.Empty;
        }
        public static void SetValue(object obj, object target, object value)
        {

            if (obj is System.Reflection.FieldInfo fi)
            {
                fi.SetValue(target, value);
            }
            if (obj is System.Reflection.PropertyInfo pi)
            {
                pi.SetValue(target, value);
            }

        }
        public static object GetDeclaringType(object obj)
        {

            if (obj is System.Reflection.MemberInfo fi)
            {
               return fi.DeclaringType;
            }
          
            return string.Empty;
        }
        public static object GetFieldType(object obj)
        {
          //  return obj.FieldType;
            if (obj is System.Reflection.FieldInfo fi)
            {
                return fi.FieldType;
            }
            if (obj is System.Reflection.PropertyInfo pi)
            {
                return pi.PropertyType;
            }
            return string.Empty;
        }
        public static string GetName(object obj)
        {
            if (obj is Type type)
            {
                return type.Name;
            }
            if (obj is System.Reflection.MemberInfo mb)
            {
                return mb.Name;
            }

            return string.Empty;
        }
        public static string GetNamespace(Type type)
        {

            return type.Namespace;
        }
        public static string GetFullName(Type type)
        {

            return type.FullName;
        }
        public static object GetBaseType(Type type)
        {

            return type.BaseType;
        }
        public static string GetAssemblyQualifiedName(Type type)
        {

            return type.AssemblyQualifiedName;
        }

        public static System.Reflection.MemberInfo[] GetMembers(Type type)
        {

            return type.GetMembers();
        }
        public static int GetMembersLen(System.Reflection.MemberInfo[] type)
        {

            return type.Length;
        }

    }
}
