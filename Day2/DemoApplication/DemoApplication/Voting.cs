using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Voting
    {
        public void Voting1 (int age) 
        {
            if (age < 18)
            {
                Console.WriteLine("Not Eligible for Vote");
            }
            else
            {
                Console.WriteLine("Eligible for Voting..");
            }
        
        }
        static void Main()
        {
            Console.WriteLine("Enter age...");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            Voting obj = new Voting();
            obj.Voting1(age);

        }
    }
}
