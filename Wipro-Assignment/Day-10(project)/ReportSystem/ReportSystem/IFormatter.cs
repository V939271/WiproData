using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    public interface IFormatter
    {
        string Format(IReport rpt);
    }
}
