using AreaCaluculator.ShapesRealisation;

namespace AreaCaluculator.MIddlewarePoints
{
    internal static class AreaCalculatorSelector
    {
        public static Func<Point[], double> GetAreaCalculator(Point[] points)
        {
            var shape = points.Length switch
            {
                1 => throw new NotImplementedException("Can not calculate area for shape with just 1 point"),
                2 => Shapes.Circle,
                3 => Shapes.Triangle,
                _ => Shapes.Poligon
            };
            return ShapesAreaCalculatorsMediator.GetCalculatorForShape(shape);
        }

        private class ShapesAreaCalculatorsMediator
        {
            public static Func<Point[], double> GetCalculatorForShape(Shapes shape) => shape switch
            {
                Shapes.Circle => (points) =>
                {
                    var radius = points[0].Substract(points[1]).Length;
                    return Math.PI * radius * radius;
                }

                ,
                Shapes.Triangle => Triangle.CalculateArea,
                _ => throw new NotImplementedException($"Unexpected shape {shape}"),
            };
        }
    }
}
