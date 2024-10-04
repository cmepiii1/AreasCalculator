using AreaCaluculator.ShapesRealisation;

namespace AreaCaluculator.MIddlewareSides
{
    internal static class AreaCalculatorSelector
    {
        public static Func<double[], double> GetAreaCalculator(double[] sides)
        {
            var shape = sides.Length switch
            {
                1 => Shapes.Circle,
                2 => throw new NotImplementedException("Can not calculate area for shape with just 2 sides"),
                3 => Shapes.Triangle,
                _ => Shapes.Poligon
            };
            return ShapesAreaCalculatorsMediator.GetCalculatorForShape(shape);
        }

        public static Func<double[], double> GetCalculatorForSpecificShape(Shapes shape)
        {
            return ShapesAreaCalculatorsMediator.GetCalculatorForShape(shape);
        }

        private class ShapesAreaCalculatorsMediator
        {
            public static Func<double[], double> GetCalculatorForShape(Shapes shape) => shape switch
            {
                Shapes.Circle => (sides) =>
                {
                    var radius = sides[0];
                    if (radius < 0)
                    {
                        throw new ArgumentException("radius must be positive");
                    }
                    return Math.PI * radius * radius;
                },
                Shapes.Triangle => Triangle.CalculateArea,
                _ => throw new NotImplementedException($"Unexpected shape {shape}"),
            };
        }
    }
}
