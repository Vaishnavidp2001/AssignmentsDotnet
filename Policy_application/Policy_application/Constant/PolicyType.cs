using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policy_application.Constant
{
    internal class PolicyType
    {
        public static explicit operator PolicyType(int v)
        {
            throw new NotImplementedException();
        }

        public enum MyEnum
        {
            Life = 0,
            Health,
            Vehicle,
            Property
        }
    }
}
