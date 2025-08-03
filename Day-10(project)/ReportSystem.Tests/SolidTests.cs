using System;
using System.IO;
using NUnit.Framework;
using ReportSystem;

namespace ReportSystem.Tests
{
    [TestFixture]
    public class SolidTests
    {
        [Test]
        public void GeneratorCreatesReport()
        {
            var rpt = (IReport)new ReportGenerator().Create("t", "c");  // <- typed as IReport
            Assert.IsNotNull(rpt);
            Assert.AreEqual("t", rpt.Title);
            Assert.AreEqual("c", rpt.Content);
        }
        /* … other tests unchanged … */
    

        // 2. --- Saver test (unique temp file avoids FileShare overload issues) --
        [Test]
        public void SaverWritesFile()
        {
            var rpt = new ReportGenerator().Create("t", "c");
            var saver = new ReportSaver();
            var path = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".txt");

            saver.Save(rpt, path);

            Assert.IsTrue(File.Exists(path), "File should exist after Save.");
            File.Delete(path);                // clean-up
        }

        // 3. --- Factory test ----------------------------------------------------
        [Test]
        public void FactoryReturnsPdf()
        {
            var doc = DocumentFactory.Create("PDF", "hello");
            StringAssert.StartsWith("<pdf", doc.Render());
        }
    }
}
