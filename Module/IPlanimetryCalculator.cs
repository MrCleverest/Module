using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Інтерфейс обчислення двовимірних фігур
    internal interface IPlanimetryCalculator
    {
        double CalculateArea();
        double CalculatePerimeter();
    }
}
