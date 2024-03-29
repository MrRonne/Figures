﻿namespace Figures.TwoDimensional
{
    public class EquilateralTriangle : RegularPolygon
    {
        public EquilateralTriangle(double sideLength) : base(sideLength) { }

        public override uint AnglesCount => 3;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}