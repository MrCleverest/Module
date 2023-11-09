using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Клас для квадрата
    public class Square : TwoDimensionalShape
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double CalculateArea()
        {
            return sideLength * sideLength;
        }

        public override double CalculatePerimeter()
        {
            return 4 * sideLength;
        }
    }
}
