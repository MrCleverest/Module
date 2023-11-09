using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Клас для кола
    public class Circle : TwoDimensionalShape, ICircleCalculations
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateInscribedCircleRadius()
        {
            return radius / Math.Sqrt(2);
        }

        public double CalculateCircumscribedCircleRadius()
        {
            return radius * Math.Sqrt(2);
        }
    }
}
