using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute2
{
    [System.AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class VendorAttribute : Attribute
    {
        public string vendorName;
        public double premiumAmount;

        public VendorAttribute(string vendorName)
        {
            this.vendorName = vendorName;
            //this.premiumAmount = premiumAmount;
        }
    }
}
