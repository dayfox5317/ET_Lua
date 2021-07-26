using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETCold
{
    public class LuaRuntimeMethodInfo : System.Reflection.MethodInfo
    {
        public XLua.LuaTable Target;

        private string name;
      
        private Type declaringType;
        protected internal LuaRuntimeMethodInfo(XLua.LuaTable table)
        {
            Target = table;

            name = LuaRuntimeMemberInfo.getName_raw(Target);
           
            declaringType = LuaRuntimeMemberInfo.getDeclaringType_raw(Target);
        }
        public override ICustomAttributeProvider ReturnTypeCustomAttributes => throw new NotImplementedException();

        public override MethodAttributes Attributes => throw new NotImplementedException();

        public override RuntimeMethodHandle MethodHandle => throw new NotImplementedException();

        public override Type DeclaringType => declaringType;

        public override string Name => name;

        public override Type ReflectedType => throw new NotImplementedException();

        public override MethodInfo GetBaseDefinition()
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

        public override MethodImplAttributes GetMethodImplementationFlags()
        {
            throw new NotImplementedException();
        }

        public override ParameterInfo[] GetParameters()
        {
            throw new NotImplementedException();
        }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
          return  LuaRuntimeMemberInfo.invoke_raw(Target,obj, parameters);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }
     
    }
}
