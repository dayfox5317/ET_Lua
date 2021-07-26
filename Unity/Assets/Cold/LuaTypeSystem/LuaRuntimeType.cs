using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
    public partial class LuaRuntimeType : System.Type,IEquatable<Type>, IEquatable<object>
    {



        public string TargetTypeName;

        private string m__FullName;
        private string m__Name;


        private string m__Namespace;
        private Type m__BaseType;


        public List<XLua.LuaTable> m__members; 
        
        public List<System.Reflection.MemberInfo> members;
        protected internal LuaRuntimeType(XLua.LuaTable t)
        {
            Target = t;
            TargetTypeName = getFullName_raw(t);
            UnityEngine.Debug.LogWarning("raw lua type->" + TargetTypeName);

            m__FullName = getFullName_raw(t);

            m__Namespace = getNamespace_raw(t);

            m__Name = getName_raw(t);

           

            m__BaseType = LuaRuntimeAssembly.CreateFromLuaTable(Lua.Default.LuaEnv.DoString($"return System.typeof({m__FullName}):getBaseType()")[0] as XLua.LuaTable);


            m__members = new List<XLua.LuaTable>();
            members = new List<MemberInfo>();

            if (m__FullName == typeof(object).FullName)
                return;

            var mbs_func = Lua.Default.LuaEnv.DoString($"return ET.ReflectHelper.GetMembers")[0] as XLua.LuaFunction;
            var str = mbs_func.Call(Target)[0] as XLua.LuaTable;
            str.ForEach((int x, XLua.LuaTable y) =>
            {
                var name = LuaRuntimeMemberInfo.getName_raw(y);

                if (name.StartsWith("__") && name.EndsWith("__"))
                {
                    return;
                }
                System.Reflection.MemberInfo luaRuntimeMemberInfo = null;
                var mb_type = LuaRuntimeMemberInfo.getMemberInfoType_raw(y);
                switch (mb_type)
                {
                    case 0:

                        luaRuntimeMemberInfo = new LuaRuntimeFieldInfo(y);

                        break;
                    case 1:

                        luaRuntimeMemberInfo = new LuaRuntimePropertyInfo(y);
                        break;
                    case 2:

                        luaRuntimeMemberInfo = new LuaRuntimeMethodInfo(y);
                        break;
                }
                if (luaRuntimeMemberInfo != null)
                {
                    members.Add(luaRuntimeMemberInfo);
                }
                //UnityEngine.Debug.Log("lua table x:" + x.GetType() + "|y:" + y);
                //var df = y.Cast<Dictionary<object, object>>();
            });


        }

        public   XLua.LuaTable Target;

        public override Assembly Assembly => null;

        public override string AssemblyQualifiedName => FullName;

        public override Type BaseType => m__BaseType;

        public override string FullName => m__FullName;

        public override Guid GUID => default;

        public override Module Module => null;

        public override string Namespace => m__Namespace;

        public override Type UnderlyingSystemType => m__BaseType;

        public override string Name => m__Name;

        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
        {
            throw new NotSupportedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override Type GetElementType()
        {
            throw new NotImplementedException();
        }

        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetInterface(string name, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetInterfaces()
        {
            throw new NotImplementedException();
        }

        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
            return members.ToArray();
        }

        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
            return null;
        }

        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        protected override TypeAttributes GetAttributeFlagsImpl()
        {
            throw new NotImplementedException();
        }

        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override bool HasElementTypeImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsArrayImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsByRefImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsCOMObjectImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPointerImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPrimitiveImpl()
        {
            throw new NotImplementedException();
        }
        public override int GetHashCode()
        {
            return Target.GetHashCode();
        }
        public override bool Equals(object o)
        {
            if(o is Type type)
            {
             return   Equals(type);
            }
            return base.Equals(o);
        }
        public override bool Equals(Type o)
        {
            if (o.FullName.Equals(this.FullName))
            {
                return true;
            }
            return base.Equals(o);
        }
    }
}
