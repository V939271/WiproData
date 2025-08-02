using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWithout
{
    internal class Program
    {
        public static void ShowInfo(string str)
        {
            if (str == "Dotnet")
            {
                DotnetTraining trg = new DotnetTraining();
                trg.Show();
                trg.Timing();
            }
            if (str == "Java")
            {
                JavaTraining trg = new JavaTraining();
                trg.Show();
                trg.Timing();
            }
            if (str == "Sap")
            {
                SapTraining trg = new SapTraining();
                trg.Show();
                trg.Timing();
            }
        }
        static void Main(string[] args)
        {
            string tinfo;
            Console.WriteLine("Enter Training (Java/Dotnet/Sap)  ");
            tinfo = Console.ReadLine();
            ShowInfo(tinfo);
        }
    }
}
