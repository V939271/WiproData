using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class MileStoneException : ApplicationException
    {
        public MileStoneException(string error) : base(error) { }
    }
}
