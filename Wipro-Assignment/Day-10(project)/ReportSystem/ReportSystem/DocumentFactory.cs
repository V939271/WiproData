using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    public static class DocumentFactory
    {
        public static IDocument Create(string type, string text)
        {
            switch (type)
            {
                case "PDF": return new PdfDoc(text);
                case "WORD": return new WordDoc(text);
                default: throw new ArgumentException("Unknown type");
            }
        }

        private class PdfDoc : IDocument { private string t; public PdfDoc(string x) { t = x; } public string Render() => $"<pdf>{t}</pdf>"; }
        private class WordDoc : IDocument { private string t; public WordDoc(string x) { t = x; } public string Render() => $"<word>{t}</word>"; }
    }
}
