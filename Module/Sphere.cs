using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Клас для шара
    public class Sphere : ThreeDimensionalShape, ICircleCalculations
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateSurfaceArea()
        {
            return 4 * Math.PI * radius * radius;
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * radius * radius * radius;
        }

        public double CalculateInscribedCircleRadius()
        {
            return radius;
        }

        public double CalculateCircumscribedCircleRadius()
        {
            return radius * Math.Sqrt(3);
        }
    }
}
