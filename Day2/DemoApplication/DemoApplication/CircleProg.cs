using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class CircleProg
    {
        public CircleProg(double radius) {
            double area, circ;
            area = Math.PI * radius * radius;
            circ = 2*Math.PI*radius;
            Console.WriteLine("Area of Circle "+area);
            Console.WriteLine("Circumerence "+circ);


        }
        static void Main()
        {
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            CircleProg circleProg = new CircleProg(radius);
        }
    }
}
