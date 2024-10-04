namespace AreaCaluculator.ShapesRealisation
{
    internal static class Triangle
    {
        public static double CalculateArea(Point[] points)
        {
            var vectorA = points[0].Substract(points[1]);
            var vectorB = points[0].Substract(points[2]);
            return (vectorA.X * vectorB.Y - vectorA.Y * vectorB.X) / 2;
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            var sides = GetTriangleSidesOrder(side1, side2, side3);
            return (sides.Item1 * sides.Item1).AreEqual(sides.Item2 * sides.Item2 + sides.Item3 * sides.Item3);
        }

        public static double CalculateArea(double[] sides)
        {
            var side1 = sides[0];
            var side2 = sides[1];
            var side3 = sides[2];
            var orderedSides = GetTriangleSidesOrder(side1, side2, side3);
            if (orderedSides.Item1 >= orderedSides.Item2 + orderedSides.Item3)
            {
                throw new ArgumentException("Triangle can not have this sides");
            }
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        private static ValueTuple<double, double, double> GetTriangleSidesOrder(double side1, double side2, double side3)
        {
            double sum = side1 + side2 + side3;
            var max = Math.Max(Math.Max(side1, side2), side3);
            var min = Math.Min(Math.Min(side1, side2), side3);
            if (min <= 0)
            {
                throw new ArgumentException("All sides must have postive length");
            }
            var middle = sum - max - min;
            return (max, middle, min);
        }
    }
}
