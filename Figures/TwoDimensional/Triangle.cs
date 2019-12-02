namespace Figures.TwoDimensional
{
    public class Triangle : RegularPolygon
    {
        public Triangle(uint sideLength) : base(sideLength) { }

        public override string Name => "Triangle";

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}