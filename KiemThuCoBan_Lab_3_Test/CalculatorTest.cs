using KiemThuCoBan_Lab_3_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_3_Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        [TearDown]
        public void Teardown()
        {
            _calculator = null;
        }
        #region Test cases data
        public static IEnumerable<TestCaseData> AddTestCases()
        {
            yield return new TestCaseData(1, 2).Returns(3);
            yield return new TestCaseData(-1, -1).Returns(-2);
            yield return new TestCaseData(0, 0).Returns(0);
            yield return new TestCaseData(100, 200).Returns(300);
            yield return new TestCaseData(-5, 5).Returns(0);
        }
        #endregion


        #region Test exception Divide by zero
        [Test]
        public void Calculator_Divide_ReturnsQuotientWithZeroDenominator()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Attempted to divide by zero."));
        }
        #endregion

        #region Test Assert Multiple
        [Test]
        public void Calculator_Test_DivideAndSqrt()
        {
            Assert.Multiple(() =>
            {
                // Kiểm tra phương thức Divide
                var divideResult = _calculator.Divide(10, 2);
                Assert.That(divideResult, Is.EqualTo(5));

                // Kiểm tra phương thức Sqrt
                var sqrtResult = _calculator.SquareRoot(16);
                Assert.That(sqrtResult, Is.EqualTo(4).Within(0.001));
            });
        }
        #endregion

        #region Test Square root throw exception
        [Test]
        public void Calculator_SquareRoot_NegativeInput_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.SquareRoot(-1));
        }
        #endregion

        #region Test cases of add and subtract
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(-1, -1, ExpectedResult = -2)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(100, 200, ExpectedResult = 300)]
        [TestCase(-5, 5, ExpectedResult = 0)]
        public int Calculator_Add(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        [TestCase(5, 3, ExpectedResult = 2)]
        [TestCase(-1, -1, ExpectedResult = 0)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(100, 50, ExpectedResult = 50)]
        [TestCase(-5, -10, ExpectedResult = 5)]
        public int Calculator_Subtract(int a, int b)
        {
            return _calculator.Subtract(a, b);
        }
        #endregion

        #region Testcases using Test case source
        [Test, TestCaseSource(nameof(AddTestCases))]
        public int Calculator_TestCaseSource_Add(int a, int b)
        {
            return _calculator.Add(a, b);
        }
        #endregion
    }
}
