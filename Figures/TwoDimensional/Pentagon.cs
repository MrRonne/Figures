﻿namespace Figures.TwoDimensional
{
    public class Pentagon : RegularPolygon
    {
        public Pentagon(double sideLength) : base(sideLength) { }

        public override uint AnglesCount => 5;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}