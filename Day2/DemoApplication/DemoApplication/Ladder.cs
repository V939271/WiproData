using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Ladder
    {
        public void Show(int choice)
        {
            if (choice == 0)
            {
                Console.WriteLine("Hi iam Venkat..");
            }
            else if (choice == 1)
            {
                Console.WriteLine("Hi iam kasi");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi iam Siva");
            }
            else
            {
                Console.WriteLine("Invalid Choice  ");
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter you choice :");
            choice = Convert.ToInt32(Console.ReadLine());
            Ladder obj = new Ladder();
            obj.Show(choice);

        }
    }
}
