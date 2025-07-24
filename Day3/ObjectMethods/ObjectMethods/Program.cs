using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ obj = new Employ(1,"Venkat",3323.31);
            Employ obj1 = new Employ(2,"kasi",3634.88);
            Console.WriteLine(obj); 
            //Internally calls obj.ToString() to get a string and prints it to the console
            Console.WriteLine(obj1);
        }
    }
}
