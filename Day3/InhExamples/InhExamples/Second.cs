using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhExamples
{
    internal class Second : First
    {
        public void Show()
        {
            base.Show();
            Console.WriteLine("Show Method From class Second..");

        }
    
        
    }
}
