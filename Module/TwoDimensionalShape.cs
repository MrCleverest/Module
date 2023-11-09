using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public abstract class TwoDimensionalShape : IPlanimetryCalculator
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
