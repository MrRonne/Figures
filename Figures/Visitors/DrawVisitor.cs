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
            Console.WriteLine($"Equilateral triangle at ({X},{Y}) with side = {equilateralTriangle.SideLength}");
        }

        public void Visit(Square square)
        {
            Console.WriteLine($"Square at ({X},{Y}) with side = {square.SideLength}");
        }

        public void Visit(Pentagon pentagon)
        {
            Console.WriteLine($"Pentagon at ({X},{Y}) with side = {pentagon.SideLength}");
        }
    }
}