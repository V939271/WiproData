using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    public class WiproData : IWiproData
    {
        public string MileStone1()
        {
            return "MileStone Exam 1 on July 30...";
        }

        public string MileStone2()
        {
            return "MileStone Exam 2 On Aug 8...";
        }
    }
}
