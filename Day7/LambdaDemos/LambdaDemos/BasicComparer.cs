using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemos
{
    internal class BasicComparer : Comparer<Employ>
    {
        public override int Compare(Employ x, Employ y)
        {
            if(x.Basic >= y.Basic)
            {
                return 1;

            }
            return -1;
        }
    }
}
