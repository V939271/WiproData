using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    public class PdfFormatter : IFormatter
    {
        public string Format(IReport rpt) =>
            $"<pdf><h1>{rpt.Title}</h1><p>{rpt.Content}</p></pdf>";
    }
}
