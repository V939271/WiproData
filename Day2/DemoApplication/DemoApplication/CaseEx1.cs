using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class CaseEx1
    {
        
        public void Check(char choice)
        {
            switch (choice)
            {
                case 'a':
                case 'A':
                case '1':
                    Console.WriteLine("Hi iam Venkat");
                    break;
                case 'b':
                case 'B':
                case '2':
                    Console.WriteLine("Hi iam kasi");
                    break;
                case 'c':
                case 'C':
                case '3':
                    Console.WriteLine("Hi iam Siva");
                    break;
                default:
                    Console.WriteLine("Invalid intput");
                    break;

            }
        }
       

        static void Main()
        {
            char choice;
            Console.WriteLine("Enter your Choice :");
            choice = Convert.ToChar(Console.ReadLine());
            CaseEx1 obj = new CaseEx1();
            obj.Check(choice);
        }
    }
}
