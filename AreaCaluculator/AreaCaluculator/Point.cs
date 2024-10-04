namespace AreaCaluculator
{
    public readonly struct Point(double x, double y)
    {
        public double X { get; init; } = x; public double Y { get; init; } = y;

        internal Point Substract(Point point)
        {
            return new()
            {
                X = point.X - this.X,
                Y = point.Y - this.Y
            };
        }

        internal double Length => Math.Sqrt(X * X + Y * Y);

    }
}
