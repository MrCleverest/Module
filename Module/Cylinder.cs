using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Клас для циліндра
    public class Cylinder : ThreeDimensionalShape
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double CalculateSurfaceArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override double CalculateVolume()
        {
            return Math.PI * radius * radius * height;
        }
    }
}
