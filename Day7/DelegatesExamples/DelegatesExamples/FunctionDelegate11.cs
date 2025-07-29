using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class FunctionDelegate11
    {

        public static string Display(int n)
        {
            return "Hello " + n;
        }

        public static int Compare(string s1, string s2)
        {
            return s1.CompareTo(s2);
        }

        public static bool Status(int mstatus)
        {
            if (mstatus == 0)
            {
                return true;
            }
            return false;
        }

        public static string Show(int n)
        {
            if (n == 1)
            {
                return "Venkat";
            }
            else if (n == 2)
            {
                return "Sunil";
            }
            return "UnKnow..";

        }

        static void Main()
        {
            Func<int,string> obj = Display;
            Console.WriteLine(obj(5));
            Func<string, string, int> obj1 = Compare;
            Console.WriteLine(obj1("Venkat","Sunil"));
            Func<int,string> obj2 = Show;
            obj2 += Display;
            Console.WriteLine(obj2(2));

            Func<int,bool> obj3 = Status;
            Console.WriteLine(obj3(1));
        }
    }
}
