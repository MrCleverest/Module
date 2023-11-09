using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Інтерфейс обчислення радіусів кола
    public interface ICircleCalculations
    {
        double CalculateInscribedCircleRadius();
        double CalculateCircumscribedCircleRadius();
    }
}
