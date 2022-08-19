namespace ShapeHierarchy
{
    public class Square : Rectangle
    {
        public Square(Segment a, Segment b, Segment c, Segment d) : base(a, b, c, d)
        {
            if (a.Length != b.Length | c.Length != d.Length)
            {
                throw new Exception("стороны квадрата не равны");
            }
        }
        public override double GetSquare()
        {
            return Math.Pow(Segments[0].Length, 2);
        }
        public override void EnterSegmentInside(Point a, Point b)
        {
            InnerSegment = new Segment(a, b);
        }
    }
}
