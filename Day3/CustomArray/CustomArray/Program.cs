using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] array = new Student[]
            {
                new Student(1,"venkat","HYD"),
                new Student(2,"Sunil","AP"),
                new Student(2,"Rajesh","AP")
            };

            foreach (Student s in array) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
