using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFirstLibrary
{
    public class Demo
    {
        private string privateStr = "Venkat";
        public string publicStr = "Sunil";
        protected string protectedStr = "Kasi";
        internal string internalStr = "Siva";
        internal protected string ipStr = "Hari";

        void Show()
        {
            Console.WriteLine(privateStr);
            Console.WriteLine(publicStr);
            Console.WriteLine(protectedStr);
            Console.WriteLine(internalStr);
            Console.WriteLine(ipStr);
        }
    }
}