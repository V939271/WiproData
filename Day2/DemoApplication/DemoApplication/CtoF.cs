using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class CtoF
    {
        public double CtoF1(double celsius) 
        {
            double f = ((9 * celsius) / 5) + 32;
            return f;
        
        }
        static void Main()
        {
            double celsius;
            Console.WriteLine("Enter celsius value: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            CtoF obj = new CtoF();
            Console.WriteLine("Fahrenheit value is " +obj.CtoF1(celsius));

        }
    }
}
