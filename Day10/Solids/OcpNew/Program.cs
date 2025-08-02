using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpNew
{
    internal class Program
    {
        public static void ShowBillInfo(int meterId, string personName, IElectricity iElectricity)
        {
            Console.WriteLine("Meter Id " + meterId);
            Console.WriteLine("Payment from Mr/Miss/Mrs " + personName);
            Console.WriteLine("Paymode is  " + iElectricity.Payment(2000));
        }
        static void Main(string[] args)
        {
            IElectricity billSource;

            billSource = new NetBanking();

            ShowBillInfo(6624, "Rajesh", billSource);

            billSource = new CreditCard();
            ShowBillInfo(8822, "Venkata", billSource);

            billSource = new DebitCard();
            ShowBillInfo(8811, "Uday", billSource);

            billSource = new Phonepe();
            ShowBillInfo(8991, "Ganesh", billSource);
        }
    }
}
