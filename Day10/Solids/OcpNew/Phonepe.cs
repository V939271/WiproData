using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpNew
{
    internal class Phonepe : IElectricity
    {
        public string Payment(double billAmount)
        {
            return "Your Bill AMount is " + billAmount + " through payment PhonePe...";
        }
    }
}
