using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    class PrintableReport : IReport, IPrintable
    {
        public string Title { get; }
        public string Content { get; }
        public PrintableReport(string t, string c) { Title = t; Content = c; }
        public void Print() { /* send to printer */ }
    }
}
