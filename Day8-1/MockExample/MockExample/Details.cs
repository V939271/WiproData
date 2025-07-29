using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    internal class Details : IDetails
    {
        public string ShowCompany()
        {
            return "Its from Wipro Chennai...";
        }

        public string ShowStudent()
        {
            return "Hi I am Uday...";
        }
    }
}
