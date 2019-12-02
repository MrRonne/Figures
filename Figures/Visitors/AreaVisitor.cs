using System;
using System.Collections.Generic;
using Figures.TwoDimensional;

namespace Figures.Visitors
{
    public class AreaVisitor : IVisitor
    {
        public readonly Dictionary<RegularPolygon, double> Results = new Dictionary<RegularPolygon, double>();
        public double LastResult { get; private set; }

        public string OperationName => "Calculating area";
        
        public void Visit(EquilateralTriangle equilateralTriangle)
        {
            if (!Results.TryGetValue(equilateralTriangle, out var lastResult))
            {
                lastResult = (Math.Sqrt(3) / 4) * equilateralTriangle.SideLength * equilateralTriangle.SideLength;
                Results.Add(equilateralTriangle, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Area of equilateral triangle = {lastResult}");
        }

        public void Visit(Square square)
        {
            if (!Results.TryGetValue(square, out var lastResult))
            {
                LastResult = square.SideLength * square.SideLength;
                Results.Add(square, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Area of square = {LastResult}");
        }

        public void Visit(Pentagon pentagon)
        {
            if (!Results.TryGetValue(pentagon, out var lastResult))
            {
                LastResult = (5.0 / 4) * pentagon.SideLength * pentagon.SideLength * (1.0 / Math.Tan(Math.PI / 5));
                Results.Add(pentagon, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Area of pentagon = {LastResult}");
        }
    }
}