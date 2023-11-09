using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Інтерфейс обчислення тривимірних фігур
    public interface IGeometryCalculator
    {
        double CalculateSurfaceArea();
        double CalculateVolume();
    }
}
