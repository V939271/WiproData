using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    [Serializable]
    // In short: You can convert the object into a file,
    // stream, or byte array and later recreate the same object.
    internal class Employ
    {
            public int Empno { get; set; }
            public string Name { get; set; }
            public double Basic { get; set; }

            public override string ToString()
            {
                return "Employ No  " + Empno + " Employ Name " + Name + " Basic  " + Basic;
            }

    }
}
