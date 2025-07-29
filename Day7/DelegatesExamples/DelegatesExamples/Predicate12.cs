using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class Predicate12
    {
        public static bool check(string gender)
        {
            if (gender.Equals("Male") || gender.Equals("Female"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool maritalStatus(int status)
            {
                if (status == 1 || status == 0)
                {
                    return true;
                }
                return false;
            }

        static void Main()
        {
            Console.WriteLine("Enter Gender (Male/Female) ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter MaritalSattus (0 or 1) ");
            int mstat = Convert.ToInt32(Console.ReadLine());
            Predicate<string> res1 = check;
            Console.WriteLine(res1(gender));
            Predicate<int> res2 = maritalStatus;
            Console.WriteLine(res2(mstat));
        }
        
    }
}
