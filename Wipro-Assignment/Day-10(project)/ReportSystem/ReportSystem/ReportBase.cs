using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    public abstract class ReportBase : IReport
    {
        public string Title { get; protected set; }
        public string Content { get; protected set; }
        public abstract void Append(string more);
    }

    public class HtmlReport : ReportBase
    {
        public HtmlReport(string t, string c) { Title = t; Content = c; }
        public override void Append(string more) { Content += $"<p>{more}</p>"; }
    }
}
