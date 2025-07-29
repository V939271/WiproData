using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    [TestFixture]
    public class MockTest
    {
        [Test]
        public void TestMileStone1()
        {
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MileStone1()).Returns("MileStone Exam 1 on Aug 1...");
            Assert.AreEqual("MileStone Exam 1 on Aug 1...", mock.Object.MileStone1());
        }

        [Test]
        public void TestMileStone2()
        {
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MileStone2()).Returns("MileStone Exam 2 On Aug 10...");
            Assert.AreEqual("MileStone Exam 2 On Aug 10...", mock.Object.MileStone2());
        }
    }
}
