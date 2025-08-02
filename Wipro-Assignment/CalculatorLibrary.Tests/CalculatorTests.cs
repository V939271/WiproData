using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ValidInputs_ReturnsSum()
        {
            Assert.AreEqual(5, calculator.Add(2, 3));
        }

        [Test]
        public void Subtract_ValidInputs_ReturnsDifference()
        {
            Assert.AreEqual(-1, calculator.Subtract(2, 3));
        }

        [Test]
        public void Multiply_ValidInputs_ReturnsProduct()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(2, 0));
        }

        [Test]
        public void Divide_ValidInputs_ReturnsQuotient()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
        }

        [Test]
        public void Add_AddingZero_ReturnsSameNumber()
        {
            Assert.AreEqual(3, calculator.Add(3, 0));
        }
    }
}
