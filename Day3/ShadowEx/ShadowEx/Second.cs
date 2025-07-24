using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowEx
{
    internal class Second : First
    {
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Show Method From Class Second..");
        }
    }
}
