using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class MultiCastDelegate4
    {
        public delegate void Dotnet();

        public static void Project()
        {
            Console.WriteLine("Capstone Project to be done Last Pahse..");
        }

        public static void MileStone1()
        {
            Console.WriteLine("Milestone 1 to be conducted on core Topics...");
        }

        public static void MileStone3()
        {
            Console.WriteLine("MileStone 3 to be on Asp.net Core Web API");
        }

        public static void MileStone4()
        {
            Console.WriteLine("MileStone 4 to be On React Framework...");
        }


        static void Main()
        {
            Dotnet obj = new Dotnet(MileStone1);
            obj += Project;
            obj += MileStone3;
            obj += MileStone4;

            obj();

        }
    }
}
