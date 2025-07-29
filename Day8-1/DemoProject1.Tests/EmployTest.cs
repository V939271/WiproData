using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1.Tests
{
    [TestFixture]
    internal class EmployTest
    {
        [Test]
        public void TestSearchEmploy()
        {
            EmployDao employDao = new EmployDao();
            Employ employFound = employDao.SearchEmploy(1);
            Assert.IsNotNull(employFound);
            employFound = employDao.SearchEmploy(-1);
            Assert.Null(employFound);
        }

        [Test]
        public void TestToString()
        {
            //Empno=1,Name="Bash", Basic=31241
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Bash";
            employ.Basic = 31241;

            string expected = "Empno 1 Name Bash Basic 31241";
            Assert.AreEqual(expected, employ.ToString());
        }
        [Test]
        public void TestShowEmploy()
        {
            List<Employ> employList = new EmployDao().ShowEmploy();
            Assert.AreEqual(3, employList.Count);
        }

        [Test]
        public void TestGettersAndSetters()
        {
            Employ employ = new Employ();
            employ.Empno = 10;
            employ.Name = "Rajesh";
            employ.Basic = 88321;

            Assert.AreEqual(10, employ.Empno);
            Assert.AreEqual("Rajesh", employ.Name);
            Assert.AreEqual(88321, employ.Basic);
        }

        [Test]
        public void TestConstructor()
        {
            Employ employ = new Employ();
            Assert.NotNull(employ);
            Employ employ1 = new Employ(88, "Venkata", 99923);
            Assert.AreEqual(88, employ1.Empno);
            Assert.AreEqual("Venkata", employ1.Name);
            Assert.AreEqual(99923, employ1.Basic);
        }

    }
}
