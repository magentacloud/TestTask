namespace ShapeHierarchy
{
    public abstract class Shape
    {
        private string color = "#000000";

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}