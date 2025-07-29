using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    public class Calculation
    {
        public virtual int Sum(int a, int b)
        {
            return a + a;
        }

        public virtual int Sub(int a, int b)
        {
            return b - a;
        }

        public virtual int Mult(int a, int b)
        {
            return b * 1;
        }
    }
}
