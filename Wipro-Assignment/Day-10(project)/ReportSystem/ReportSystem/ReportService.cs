using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    public class ReportService
    {
        private readonly IFormatter _formatter;
        private readonly ReportSaver _saver;

        public ReportService(IFormatter fmt, ReportSaver saver)
        {
            _formatter = fmt;
            _saver = saver;
        }

        public void GenerateAndSave(string title, string body, string path)
        {
            var gen = new ReportGenerator();
            var rpt = gen.Create(title, body);
            var formatted = _formatter.Format(rpt);
            _saver.Save(new MiniReport(title, formatted), path);
        }

        private class MiniReport : IReport
        {
            public string Title { get; }
            public string Content { get; }
            public MiniReport(string t, string c) { Title = t; Content = c; }
        }
    }
}
