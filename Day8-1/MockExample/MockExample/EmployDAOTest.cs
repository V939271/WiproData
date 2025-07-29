using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    [TestFixture]
    public class EmployDAOTest
    {
        List<Employ> employList = new List<Employ>()
         {
                 new Employ{Empno=1,Name="Rajesh",Basic=88323},
                new Employ{Empno=2,Name="Uday",Basic=91911},
                new Employ{Empno=3,Name="Pravali",Basic=86444},
        };
        Employ e1 = new Employ { Empno = 1, Name = "Datta", Basic = 84234 };
        Employ e2 = new Employ { Empno = 2, Name = "Vandana", Basic = 82234 };

        Employ e3 = null;
        [Test]
        public void TestShowEmployList()
        {
            Mock<IEmployDAO> mockDao = new Mock<IEmployDAO>();
            mockDao.Setup(x => x.ShowEmploy()).Returns(employList);
            Assert.AreEqual(3, mockDao.Object.ShowEmploy().Count);
        }

        [Test]

        public void TestSeachEmploy()
        {
            Mock<IEmployDAO> mockDao = new Mock<IEmployDAO>();
            mockDao.Setup(x => x.SearchEmploy(1)).Returns(e1);
            Assert.IsNotNull(mockDao.Object.SearchEmploy(1));
            mockDao.Setup(x => x.SearchEmploy(100)).Returns(e2);
            Assert.IsNotNull(mockDao.Object.SearchEmploy(100));
            mockDao.Setup(x => x.SearchEmploy(200)).Returns(e3);
            Assert.IsNull(mockDao.Object.SearchEmploy(200));
        }
    }
}
