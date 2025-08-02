using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspWith
{
    internal class Venkat : IPersonalDetails, IProjectDetails
    {
        public void BillingInfo()
        {
            Console.WriteLine("Billing Started as its 75$ per Hour...");
        }

        public void ProjectName()
        {
            Console.WriteLine("Hi I am in to ND (North Dakota) Project...");
        }

        public void ShowPersonalInfo()
        {
            Console.WriteLine("Hi I am Venkat...");
        }
    }
}
