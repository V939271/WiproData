using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipWithout
{
    internal class JavaTrainingInfo
    {
        private JavaTrg javaTrg;

        public JavaTrainingInfo(JavaTrg javaTrg)
        {
            this.javaTrg = javaTrg;
        }

        public void Details()
        {
            javaTrg.TrainerName();
            javaTrg.City();
        }
    }
}
