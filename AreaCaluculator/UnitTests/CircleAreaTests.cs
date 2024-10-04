using AreaCaluculator;

namespace UnitTests
{
    [TestFixture]
    public class CircleAreaTests
    {
        [Test]
        public void CalculateCircleArea_Usually()
        {
            var resultArea = AreaCalculator.CalculateCircleArea(1);
            Assert.That(resultArea.AreEqual(Math.PI));

            resultArea = AreaCalculator.CalculateCircleArea(1/Math.Sqrt(Math.PI));
            Assert.That(resultArea.AreEqual(1));
        }

        [Test]
        public void CalculateCircleArea_NegativeValue_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.CalculateCircleArea(-1));
        }

        [Test]
        public void CalculateAreaByPoints_Usually()
        {
            var resultArea = AreaCalculator.CalculateAreaByPoints(new Point(0,0), new Point(1/Math.Sqrt(Math.PI),0));
            Assert.That(resultArea.AreEqual(1));
        }

        [TestCase(Math.PI,1)]
        [TestCase(4*Math.PI,2)]
        [TestCase(0,0)]
        public void CalculateAreaBySides_Usually(double expectedValue, params double[]inputSides)
        {
            Assert.That(AreaCalculator.CalculateAreaBySides(inputSides).AreEqual(expectedValue));
        }

        [Test]
        public void CalculateAreaBySides_NegativeValue_ShouldFail()
        {
            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateAreaBySides(-1));
        }
    }
}