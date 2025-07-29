using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoProject1.Tests
{
    [TestFixture]
    public class DataTest
    {
        [Test]
        public void TestEvenOdd()
        {
            Data demo = new Data();
            Assert.True(demo.EvenOdd(4));
            Assert.False(demo.EvenOdd(5));
        }

        [Test]
        public void TestSum()
        {
            Data demo = new Data();
            Assert.AreEqual(5, demo.Sum(2, 3));
        }
        [Test]
        public void TestSayHello()
        {
            Data demo = new Data();
            Assert.AreEqual("Welcome to C# FSD Programming...", demo.SayHello());
        }
        [Test]
        public void TestNullCheck()
        {
            Data demo = new Data();
            Assert.IsNotNull(demo);
            Data demo1 = null;
            Assert.IsNull(demo1);
        }
        [Test]
        public void TestMax3()
        {
            Data demo = new Data();
            Assert.AreEqual(7, demo.Max3(7, 3, 2));
            Assert.AreEqual(7, demo.Max3(3, 7, 2));
            Assert.AreEqual(7, demo.Max3(2, 3, 7));
        }
    }
}
