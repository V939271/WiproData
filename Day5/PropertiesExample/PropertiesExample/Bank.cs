using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Bank
    {
        public int Account { get; } = 12;
        public string BranchName { get; } = "Hastinapuram";
        public string BankName { get; } = "ICICI";
    }

    internal class ReadOnlyExample
    {
        static void Main()
        {
            Bank bank = new Bank();
            Console.WriteLine("Account No.."+bank.Account);
            Console.WriteLine("Bank Name..."+bank.BankName);
            Console.WriteLine("Bramch Name...."+bank.BranchName);
        }
    }
}
