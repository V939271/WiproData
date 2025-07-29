using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class PredicateNew14
    {
        public static bool Attendance(string status)
        {
            if (status.ToUpper().Equals("YES"))
            {
                return true;

            }
            return false;
        }

        static void Main()
        {
            Console.WriteLine("Enter Attendence status (YES/NO) ");
            string status = Console.ReadLine();
            Predicate<string> result = Attendance;
            Console.WriteLine(result(status));
        }
    }
}
