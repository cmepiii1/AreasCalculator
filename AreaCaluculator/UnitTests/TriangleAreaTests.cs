using AreaCaluculator;

namespace UnitTests
{
    [TestFixture]
    public class TriangleAreaTests
    {
        [Test]
        public void CalculateTriangleArea_Usually()
        {
            var resultArea = AreaCalculator.CalculateTriangleArea(3,4,5);
            Assert.That(resultArea.AreEqual(6));
        }

        [Test]
        public void CalculateTriangleArea_NegativeValue_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.CalculateTriangleArea(-1, -1, -1));
        }

        [Test]
        public void CalculateTriangleArea_ZeroValue_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.CalculateTriangleArea(0,0,0));
        }

        [Test]
        public void CalculateTriangleArea_ImpossibleTriangle_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.CalculateTriangleArea(100,1,1));
        }

        [Test]
        public void IsRightTriangle_Usually()
        {
            Assert.That(AreaCalculator.IsRightTriangle(3, 4, 5));
        }

        [Test]
        public void IsRightTriangle_NotARightTriangle_ShouldRetrnFalse()
        {
            Assert.That(AreaCalculator.IsRightTriangle(3, 4, 6), Is.False);
        }

        [Test]
        public void IsRightTriangle_NegativeValue_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.IsRightTriangle(-1, -1, -1));
        }

        [Test]
        public void IsRightTriangle_ZeroValue_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.IsRightTriangle(0,0,0));
        }

        [Test]
        public void CalculateAreaByPoints_Usually()
        {
            var resultArea = AreaCalculator.CalculateAreaByPoints(new Point(1,1), new Point(4,3), new Point(4,7));
            Assert.That(resultArea.AreEqual(6));
        }

        [Test]
        public void CalculateAreaBySides_Usually()
        {
            Assert.That(AreaCalculator.CalculateAreaBySides(3,4,5).AreEqual(6));
        }

        [TestCase(-1,-1,-1, Description = "Negative values")]
        [TestCase(0,0,0, Description = "Zero values")]
        [TestCase(10,1,1, Description = "Impossible triangle")]
        public void CalculateAreaBySides_NegativeValue_ShouldFail(params double[] sides)
        {
            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateAreaBySides(-1, -1, -1));
        }
    }
}