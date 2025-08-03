using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    public class ExcelFormatter : IFormatter
    {
        public string Format(IReport rpt) =>
            $"{rpt.Title}\t{rpt.Content}";
    }
}
