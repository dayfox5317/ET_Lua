//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ETCold
//{
//   public static class TypeHelper
//    {
//        public static System.Reflection.MemberInfo[] GetMembers(Type type)
//        {

//            return type.GetMembers();
//        }
//        public static bool IsRawType(object type)
//        {
//            if(type is Type)
//            {
//                return true;
//            }
//            if (type is XLua.LuaTable)
//            {
//                return false;
//            }
//            return false;
//        }

//        public static RawTypeInfo ConvertTo(Type type)
//        {
//            var raw = new RawTypeInfo();

//            raw.Type = type;

//            var rw = type.GetMembers();
//            raw.memberInfos = new  RawMemberInfo[rw.Length];
          
//            for (int i = 0; i < rw.Length; i++)
//            {
//                raw.memberInfos[i]=(new RawMemberInfo { Name = rw[i].Name });
//            }
//            return raw;
//        }

//        public static void TestT(object obj)
//        {
           

//  //       var et=    Lua.Default.LuaEnv.Global.Get<XLua.LuaTable>("ET.Game");
//            var  lua_type=LuaRuntimeAssembly.CreateFromLuaTable(obj as XLua.LuaTable);
//            UnityEngine.Debug.Log(lua_type.BaseType);
//            var str_type = (Type)LuaRuntimeAssembly.CreateFromFullName("System.String");
//            var eq=typeof(int).Equals(typeof(int));
//            UnityEngine.Debug.Log("string  type eq? :" + eq);
//           // var test_str = LuaRuntimeAssembly.CreateFromFullName("System.String");




//            //  var act2 = LuaRuntimeActivator.CreateInstance(test_str, "传教士");
//            var test_wrap = LuaRuntimeAssembly.CreateFromFullName("ET.TestWrap");
         
//            var act = LuaRuntimeActivator.CreateInstance(test_wrap, "fyindex","|b");

//            //var e= Lua.Default.LuaEnv.DoString("return ET.TypeHelper.Type_GetFullName");
//            //var func = e[0] as XLua.LuaFunction;
//            //var str=func.Call(obj);
//            //UnityEngine.Debug.LogError(str[0]);
//        }

//    }
//    public class FastRawList : List<RawMemberInfo>
//    {

//    }


//    public class RawTypeInfo:Type
//    {

//        public override string FullName => Type.FullName;
//        public override string Name=>Type.Name;

//        public override Assembly Assembly => throw new NotImplementedException();

//        public override string AssemblyQualifiedName => throw new NotImplementedException();

//        public override Type BaseType => throw new NotImplementedException();


//        public override Guid GUID => throw new NotImplementedException();

//        public override Module Module => throw new NotImplementedException();

//        public override string Namespace => throw new NotImplementedException();

//        public override Type UnderlyingSystemType => throw new NotImplementedException();

     

//        public Type Type;

//        public RawMemberInfo[] memberInfos;

//        protected override TypeAttributes GetAttributeFlagsImpl()
//        {
//            throw new NotImplementedException();
//        }

//        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
//        {
//            throw new NotImplementedException();
//        }

//        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override Type GetElementType()
//        {
//            throw new NotImplementedException();
//        }

//        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override Type GetInterface(string name, bool ignoreCase)
//        {
//            throw new NotImplementedException();
//        }

//        public override Type[] GetInterfaces()
//        {
//            throw new NotImplementedException();
//        }

//        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
//        {
//            throw new NotImplementedException();
//        }

//        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override Type GetNestedType(string name, BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
//        {
//            throw new NotImplementedException();
//        }

//        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
//        {
//            throw new NotImplementedException();
//        }

//        protected override bool HasElementTypeImpl()
//        {
//            throw new NotImplementedException();
//        }

//        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
//        {
//            throw new NotImplementedException();
//        }

//        protected override bool IsArrayImpl()
//        {
//            throw new NotImplementedException();
//        }

//        protected override bool IsByRefImpl()
//        {
//            throw new NotImplementedException();
//        }

//        protected override bool IsCOMObjectImpl()
//        {
//            throw new NotImplementedException();
//        }

//        protected override bool IsPointerImpl()
//        {
//            throw new NotImplementedException();
//        }

//        protected override bool IsPrimitiveImpl()
//        {
//            throw new NotImplementedException();
//        }

//        public override object[] GetCustomAttributes(bool inherit)
//        {
//            throw new NotImplementedException();
//        }

//        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
//        {
//            throw new NotImplementedException();
//        }

//        public override bool IsDefined(Type attributeType, bool inherit)
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class RawMemberInfo
//    {
//        public string Name;

//        public RawTypeInfo TargetType;

//        public bool IsStatic;
//    }
//    public class RawFieldInfo: RawMemberInfo
//    {

       
//        public Func<object,object> GetValue;
//        public Action<object,object> SetValue;
//    }
//}
