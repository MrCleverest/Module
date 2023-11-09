using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public abstract class ThreeDimensionalShape : IGeometryCalculator
    {
        public abstract double CalculateSurfaceArea();
        public abstract double CalculateVolume();
    }
}
