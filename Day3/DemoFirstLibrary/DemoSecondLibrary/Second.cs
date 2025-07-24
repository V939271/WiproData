using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSecondLibrary
{
    public class Second
    {
        public void Show()
        {
            DemoFirstLibrary.Demo obj = new DemoFirstLibrary.Demo();
            Console.WriteLine(obj.publicStr);

        }
    }
}