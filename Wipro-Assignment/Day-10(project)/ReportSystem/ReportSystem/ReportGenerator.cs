using System.IO;


namespace ReportSystem
{
    public class ReportGenerator
    {
        public IReport Create(string title, string body)
        {
            return new BasicReport(title, body);   // now returns a *valid* IReport
        }

        private class BasicReport : IReport        // ← implements the interface
        {
            public string Title { get; }
            public string Content { get; }

            public BasicReport(string t, string c)
            {
                Title = t;
                Content = c;
            }
        }
    }
}
