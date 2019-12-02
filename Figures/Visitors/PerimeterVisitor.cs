using System;
using System.Collections.Generic;
using Figures.TwoDimensional;

namespace Figures.Visitors
{
    public class PerimeterVisitor : IVisitor
    {
        public readonly Dictionary<RegularPolygon, uint> Results = new Dictionary<RegularPolygon, uint>();
        public uint LastResult { get; private set; }

        public string OperationName => "Calculating perimeter";
        
        public void Visit(EquilateralTriangle equilateralTriangle)
        {
            if (!Results.TryGetValue(equilateralTriangle, out var lastResult))
            {
                lastResult = 3 * equilateralTriangle.SideLength;
                Results.Add(equilateralTriangle, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Perimeter of equilateral triangle = {lastResult}");
        }

        public void Visit(Square square)
        {
            if (!Results.TryGetValue(square, out var lastResult))
            {
                lastResult = 4 * square.SideLength;
                Results.Add(square, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Perimeter of square = {lastResult}");
        }

        public void Visit(Pentagon pentagon)
        {
            if (!Results.TryGetValue(pentagon, out var lastResult))
            {
                lastResult = 5 * pentagon.SideLength;
                Results.Add(pentagon, lastResult);
            }
            LastResult = lastResult;
            Console.WriteLine($"Perimeter of pentagon = {lastResult}");
        }
    }
}