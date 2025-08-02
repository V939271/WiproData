using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpNew
{
    internal class CreditCard : IElectricity
    {
        public string Payment(double billAmount)
        {
            return "Your Bill AMount is " + billAmount + " through payment CreditCard...";

        }
    }
}
