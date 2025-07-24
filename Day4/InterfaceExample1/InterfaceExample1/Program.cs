using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITraining[] arr = new ITraining[]
            {
                new Venkat(), new Kasi()

            };
            foreach (ITraining t in arr) 
            {
                t.Name();
                t.Email();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
