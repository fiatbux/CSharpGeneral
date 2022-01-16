

using NUnit.Framework;
using StandardCalculator;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddTest()
        {
            const double expected = 3;
            var actual = calculator.Add(1, 2);

            Assert.AreEqual(expected, actual, "Sum of doubles is not equal");
        }

        [TestCase(3,3, 9,"Standard multiplication of 3 by 3")]
        [TestCase(2.5, 5.5, 13.75)]
        [TestCase(-2.5, -5.5, 13.75)]
        [TestCase(2.5, -5.5, -13.75)]
        public void MultiplyTest(double x, double y, double expected)
        {

            var actual = calculator.Multiply(x, y);

            Assert.AreEqual(expected, actual, "Sum of doubles is not equal");
        }
    }
}
