using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class Example1
    {
        static void Main()
        {
            ArrayList namelist = new ArrayList();
            namelist.Add("Venkat");
            namelist.Add("Kasi");
            namelist.Add("Sunil");
            namelist.Add("Charan");

            Console.WriteLine("Default Arraylist Elements are....");
            foreach (object obj in namelist)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");


            namelist.Insert(3,"Manjula");
            Console.WriteLine("List after inserting new Elements...");
            foreach(object obj in namelist)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");


            namelist.Remove("Madhu");
            Console.WriteLine("List after Removing By Name  ");
            foreach (object obj in namelist)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            namelist.RemoveAt(2);
            Console.WriteLine("List after Removing By Position  ");
            foreach (object obj in namelist)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
