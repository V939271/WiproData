using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
        internal class FilterExampleException : ApplicationException 
        {
            public FilterExampleException(string error) : base(error) { }
        }
   
}
