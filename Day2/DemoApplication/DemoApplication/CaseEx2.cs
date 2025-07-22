using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class CaseEx2
    {
        public void show(string Dayname)
        {
            switch (Dayname.ToUpper())
            {
                case "SUN":
                    Console.WriteLine("its Sunday..");
                    break;
                case "MON":
                    Console.WriteLine("Its Monday...");
                    break;
                case "TUE":
                    Console.WriteLine("Its Tuesday...");
                    break;
                case "WED":
                    Console.WriteLine("Its Wednesday...");
                    break;
                case "THU":
                    Console.WriteLine("Its Thursday...");
                    break;
                case "FRI":
                    Console.WriteLine("Its Friday...");
                    break;
                case "SAT":
                    Console.WriteLine("Its Saturday...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;



            }
        }
        static void Main()
        {
            string Dayname;
            Dayname = Console.ReadLine();
            CaseEx2 obj = new CaseEx2();
            obj.show(Dayname);

        }
    }
}
