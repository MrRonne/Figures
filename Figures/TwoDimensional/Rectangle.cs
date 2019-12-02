namespace Figures.TwoDimensional
{
    public class Rectangle : RegularPolygon
    {
        public Rectangle(uint sideLength) : base(sideLength) { }

        public override string Name => "Rectangle";

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}