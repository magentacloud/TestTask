namespace ShapeHierarchy
{

    public abstract class Poligon : FlatShape
    {
        private List<Segment> segments;

        public List<Segment> Segments
        {
            get { return segments; }
            set { segments = value; }
        }
    }
}
