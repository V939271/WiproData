using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class OverloadEx2
    {
        public int Sum()
        {
            return 5;
        }

        public int Sum(int x) 
        { 
            return x;
        
        }

        public int Sum(int x, int y)
        {
            return x+ y;
        }

        static void Main()
        {
            OverloadEx2 obj = new OverloadEx2();
            Console.WriteLine("Sum w.r.t Zero Args..."+obj.Sum());
            Console.WriteLine("Sum w.r.t One Arg..."+obj.Sum(5));
            Console.WriteLine("Sum w.r.t Two Args..."+obj.Sum(5,5));
        }
    }
}
