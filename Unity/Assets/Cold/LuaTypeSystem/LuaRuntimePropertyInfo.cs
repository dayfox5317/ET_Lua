using System;
using System.Globalization;
using System.Reflection;

namespace ETCold
{
    public class LuaRuntimePropertyInfo : System.Reflection.PropertyInfo
    {
        public XLua.LuaTable Target;

        private string name;
        private Type fieldType;
        private Type declaringType;
        protected internal LuaRuntimePropertyInfo(XLua.LuaTable table)
        {
            Target = table;

            name = LuaRuntimeMemberInfo.getName_raw(Target);
            fieldType = LuaRuntimeMemberInfo.getFieldType_raw(Target);
            declaringType = LuaRuntimeMemberInfo.getDeclaringType_raw(Target);
        }
        public override PropertyAttributes Attributes => throw new NotImplementedException();

        public override bool CanRead => throw new NotImplementedException();

        public override bool CanWrite => throw new NotImplementedException();

        public override Type PropertyType => fieldType;

        public override Type DeclaringType => declaringType;

        public override string Name => name;

        public override Type ReflectedType => throw new NotImplementedException();

        public override MethodInfo[] GetAccessors(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override MethodInfo GetGetMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        public override ParameterInfo[] GetIndexParameters()
        {
            throw new NotImplementedException();
        }

        public override MethodInfo GetSetMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            return LuaRuntimeMemberInfo.getValue_raw(Target, obj);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
             LuaRuntimeMemberInfo.setValue_raw(Target, obj,value);
        }
    }
}
