using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute2
{
    internal class Demo
    {
        public static void PrintClassInfor(Type t)
        {
            MemberInfo memberInfo = t;
            object[] arr = memberInfo.GetCustomAttributes(typeof(VendorAttribute), false);
            foreach (object ob in arr)
            {
                VendorAttribute v = (VendorAttribute)ob;
                Console.WriteLine(v.vendorName);
                Console.WriteLine(v.premiumAmount);
            }
        }

    }
}
