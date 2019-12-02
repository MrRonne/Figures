namespace Figures.TwoDimensional
{
    public class Square : RegularPolygon
    {
        public Square(double sideLength) : base(sideLength) { }

        public override uint AnglesCount => 4;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}