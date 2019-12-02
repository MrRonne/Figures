using System.Collections.Generic;
using Figures.TwoDimensional;

namespace Figures
{
    public interface ICalculator
    {
        Dictionary<RegularPolygon, double> Results { get; }
        double LastResult { get; }
    }
}