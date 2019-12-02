using System;
using Figures.TwoDimensional;

namespace Figures.Visitors
{
    public class DrawVisitor : IVisitor
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public void SetDrawingCoordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string OperationName => "Drawing";

        public void Visit(EquilateralTriangle equilateralTriangle)
        {
            Console.WriteLine($"Equilateral triangle with side {equilateralTriangle.SideLength} at ({X},{Y})");
        }

        public void Visit(Square square)
        {
            Console.WriteLine($"Square with side {square.SideLength} at ({X},{Y})");
        }

        public void Visit(Pentagon pentagon)
        {
            Console.WriteLine($"Pentagon with side {pentagon.SideLength} at ({X},{Y})");
        }
    }
}