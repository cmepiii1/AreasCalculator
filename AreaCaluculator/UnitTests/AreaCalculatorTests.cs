using AreaCaluculator;

namespace UnitTests
{
    [TestFixture]
    internal class AreaCalculatorTests
    {
        [Test]
        public void NoParameters_ShouldFail()
        {
            Assert.Throws<ArgumentException>(()=>AreaCalculator.CalculateAreaByPoints());
            Assert.Throws<ArgumentException>(()=>AreaCalculator.CalculateAreaBySides());
        }

        [Test]
        public void UnexpectedAmmountOfParameters_ShouldFail()
        {
            Assert.Throws<NotImplementedException>(()=>AreaCalculator.CalculateAreaByPoints(new Point()));
            Assert.Throws<NotImplementedException>(()=>AreaCalculator.CalculateAreaBySides(1,1));
        }

        [Test]
        public void CalculatingPoligon_ShouldFail()
        {
            Assert.Throws<NotImplementedException>(()=>AreaCalculator.CalculateAreaByPoints(new Point(), new Point(), new Point(), new Point()));
            Assert.Throws<NotImplementedException>(()=>AreaCalculator.CalculateAreaBySides(1,1,1,1));
        }
    }
}
