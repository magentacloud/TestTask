namespace ShapeHierarchy
{
    public class Circle : CurveLineFigure
    {
        public Circle(Point center, double radius)
        {
            this.radius = radius;
            this.Center = center;
        }

        private double radius;
        public override double GetSquare()
        {
            return 2 * Math.PI * radius;
        }

        public override void EnterSegmentInside(Point a, Point b)
        {
            InnerSegment = new Segment(a, b);
        }
    }
}
