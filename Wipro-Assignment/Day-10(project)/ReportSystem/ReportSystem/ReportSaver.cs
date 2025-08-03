using System.IO;

namespace ReportSystem
{
    public class ReportSaver
    {
        public void Save(IReport rpt, string path)
        {
            File.WriteAllText(path, $"{rpt.Title}\r\n{rpt.Content}");
        }
    }
}