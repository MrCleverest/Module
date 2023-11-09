using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Module;

namespace Unit_Testing
{
    [TestClass]
    public class ShapeTests
    {
        // Тестування кола
        [TestMethod]
        public void CircleCalculate_Area()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;

            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void CircleCalculate_Perimeter()
        {
            Circle circle = new Circle(5);
            double expectedPerimeter = 2 * Math.PI * 5;

            double actualPerimeter = circle.CalculatePerimeter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        // Тестування квадрату
        [TestMethod]
        public void SquareCalculate_Area()
        {
            Square square = new Square(4);
            double expectedArea = 16;

            double actualArea = square.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void SquareCalculate_Perimeter()
        {
            Square square = new Square(4);
            double expectedPerimeter = 16;

            double actualPerimeter = square.CalculatePerimeter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        // Тестування циліндру
        [TestMethod]
        public void CylinderCalculate_Area()
        {
            Cylinder cylinder = new Cylinder(4, 10);
            double expectedArea = 2 * Math.PI * 4 * (4 + 10);

            double actualArea = cylinder.CalculateSurfaceArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void CylinderCalculate_Volume()
        {
            Cylinder cylinder = new Cylinder(4, 10);
            double expectedVolume = Math.PI * 4 * 4 * 10;

            double actualVolume = cylinder.CalculateVolume();

            Assert.AreEqual(expectedVolume, actualVolume);
        }

        // Тестування конусу
        [TestMethod]
        public void ConeCalculate_Volume()
        {
            Cone cone = new Cone(4, 10);
            double expectedVolume = (1.0 / 3.0) * Math.PI * 4 * 4 * 10;

            double actualVolume = cone.CalculateVolume();

            Assert.AreEqual(expectedVolume, actualVolume);
        }
        [TestMethod]
        public void ConeCalculate_Area()
        {
            Cone cone = new Cone(4, 10);
            double expectedArea = Math.PI * 4 * (4 + Math.Sqrt(4 * 4 + 10 * 10));

            double actualArea = cone.CalculateSurfaceArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        // Тестування шару
        [TestMethod]
        public void SphereCalculate_Area()
        {
            Sphere sphere = new Sphere(5);
            double expectedArea = 4 * Math.PI * 5 * 5;

            double actualArea = sphere.CalculateSurfaceArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void SphereCalculate_Volume()
        {
            Sphere sphere = new Sphere(5);
            double expectedVolume = (4.0 / 3.0) * Math.PI * 5 * 5 * 5;

            double actualVolume = sphere.CalculateVolume();

            Assert.AreEqual(expectedVolume, actualVolume);
        }
    }
}