using System;
using System.Globalization;
using System.Reflection;

namespace ETCold
{

    public class LuaRuntimeFieldInfo : System.Reflection.FieldInfo
    {
        public XLua.LuaTable Target;

        private string name; 
        private Type fieldType;
        private Type declaringType;
        protected internal LuaRuntimeFieldInfo (XLua.LuaTable table)
        {
            Target = table;

            name = LuaRuntimeMemberInfo.getName_raw(Target);
            fieldType = LuaRuntimeMemberInfo.getFieldType_raw(Target);
            declaringType = LuaRuntimeMemberInfo.getDeclaringType_raw(Target);
        }

        public override FieldAttributes Attributes => throw new NotImplementedException();

        public override RuntimeFieldHandle FieldHandle => throw new NotImplementedException();

        public override Type FieldType => fieldType;

        public override Type DeclaringType => declaringType;

        public override string Name => name;

        public override Type ReflectedType => throw new NotImplementedException();

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object GetValue(object obj)
        {
            return LuaRuntimeMemberInfo.getValue_raw(Target, obj);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
            LuaRuntimeMemberInfo.setValue_raw(this.Target, obj, value);
        }






    }
}
