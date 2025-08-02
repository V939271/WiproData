using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspWithout
{
    internal class Venkat : IEmployDetails
    {
        public void AccountDetails()
        {
            throw new NotImplementedException();
        }

        public void PersonalDetails()
        {
            Console.WriteLine("Hi I am Venkat...");
        }

        public void ProjectDetails()
        {
            throw new NotImplementedException();
        }
    }
}
