using AreaCaluculator.ShapesRealisation;
using AreaCalculatorSelectorPoints = AreaCaluculator.MIddlewarePoints.AreaCalculatorSelector;
using AreaCalculatorSelectorSides = AreaCaluculator.MIddlewareSides.AreaCalculatorSelector;

namespace AreaCaluculator
{
    public static class AreaCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return AreaCalculatorSelectorSides.GetCalculatorForSpecificShape(Shapes.Circle)([radius]);
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            return AreaCalculatorSelectorSides.GetCalculatorForSpecificShape(Shapes.Triangle)([side1,side2, side3]);
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            return Triangle.IsRightTriangle(side1, side2, side3);
        }

        public static double CalculateAreaByPoints(params Point[] points)
        {
            if (points.Length == 0)
            {
                throw new ArgumentException("Must be at least one point");
            }
            var areaCalculator = AreaCalculatorSelectorPoints.GetAreaCalculator(points);
            return areaCalculator(points);
        }

        public static double CalculateAreaBySides(params double[] sides)
        {
            if (sides.Length == 0)
            {
                throw new ArgumentException("Must be at least one side");
            }
            var areaCalculator = AreaCalculatorSelectorSides.GetAreaCalculator(sides);
            return areaCalculator(sides);
        }
    }
}
