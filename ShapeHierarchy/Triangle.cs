namespace ShapeHierarchy
{
    public class Triangle : Poligon
    {
        public Triangle(Segment a, Segment b, Segment c)
        {
            Segments.Add(a);
            Segments.Add(b);
            Segments.Add(c);
        }

        public override void EnterSegmentInside(Point a, Point b)
        {
            InnerSegment = new Segment(a, b);
        }

        public override double GetSquare()
        {
            double perimeter = Segments[0].Length + Segments[1].Length + Segments[2].Length;
            return Math.Sqrt(perimeter * (perimeter - Segments[0].Length) * (perimeter - Segments[1].Length) * (perimeter - Segments[2].Length));
        }
    }
}
