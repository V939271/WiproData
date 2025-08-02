using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspWithout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployDetails obj = new Venkat();
            obj.PersonalDetails();
            obj.ProjectDetails();
            obj.AccountDetails();
        }
    }
}
