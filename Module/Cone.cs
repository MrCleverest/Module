using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Клас для конуса
    public class Cone : ThreeDimensionalShape
    {
        private double radius;
        private double height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double CalculateSurfaceArea()
        {
            double slantHeight = Math.Sqrt(radius * radius + height * height);
            return Math.PI * radius * (radius + slantHeight);
        }

        public override double CalculateVolume()
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;
        }
    }

}
