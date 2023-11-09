using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    // Оновлення таблиці
    internal class DataGridViewHelper
    {
        private DataGridView dataGridView;

        public DataGridViewHelper(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Назва фігури";
            dataGridView.Columns[1].Name = "Периметр";
            dataGridView.Columns[2].Name = "Площа";
            dataGridView.Columns[3].Name = "Об'єм";
            dataGridView.Columns[4].Name = "Радіус вписаної окружності";
            dataGridView.Columns[5].Name = "Радіус описаної окружності";
        }

        public void RefreshData(IEnumerable<object> shapes)
        {
            dataGridView.Rows.Clear();

            foreach (var shape in shapes)
            {
                string figureName = GetFigureName(shape);
                string perimeter = CalculatePerimeter(shape).ToString("F2");
                string area = CalculateArea(shape).ToString("F2");
                string volume = CalculateVolume(shape).ToString("F2");
                string inscribedCircleRadius = CalculateInscribedCircleRadius(shape).ToString("F2");
                string circumscribedCircleRadius = CalculateCircumscribedCircleRadius(shape).ToString("F2");

                dataGridView.Rows.Add(figureName, perimeter, area, volume, inscribedCircleRadius, circumscribedCircleRadius);
            }
        }
        private double CalculateVolume(object shape)
        {
            if (shape is Cylinder cylinder)
            {
                return cylinder.CalculateVolume();
            }
            else if (shape is Sphere sphere)
            {
                return sphere.CalculateVolume();
            }
            else if (shape is Cone cone)
            {
                return cone.CalculateVolume();
            }

            return 0.0;
        }

        private double CalculateInscribedCircleRadius(object shape)
        {
            if (shape is Circle circle)
            {
                return circle.CalculateInscribedCircleRadius();
            }
            else if (shape is Sphere sphere)
            {
                return sphere.CalculateInscribedCircleRadius();
            }

            return 0.0;
        }

        private double CalculateCircumscribedCircleRadius(object shape)
        {
            if (shape is Circle circle)
            {
                return circle.CalculateCircumscribedCircleRadius();
            }
            else if (shape is Sphere sphere)
            {
                return sphere.CalculateCircumscribedCircleRadius();
            }

            return 0.0;
        }
        private string GetFigureName(object shape)
        {
            if (shape is Square)
            {
                return "Квадрат";
            }
            else if (shape is Circle)
            {
                return "Коло";
            }
            else if (shape is Cylinder)
            {
                return "Циліндр";
            }
            else if (shape is Sphere)
            {
                return "Шар";
            }
            else if (shape is Cone)
            {
                return "Конус";
            }

            return "Невідома фігура";
        }
        private double CalculatePerimeter(object shape)
        {
            if (shape is Square square)
            {
                return square.CalculatePerimeter();
            }
            else if (shape is Circle circle)
            {
                return circle.CalculatePerimeter();
            }
            return 0.0;
        }
        private double CalculateArea(object shape)
        {
            if (shape is Square square)
            {
                return square.CalculateArea();
            }
            else if (shape is Circle circle)
            {
                return circle.CalculateArea();
            }
            else if (shape is Cylinder cylinder)
            {
                return cylinder.CalculateSurfaceArea();
            }
            else if (shape is Sphere sphere)
            {
                return sphere.CalculateSurfaceArea();
            }
            else if (shape is Cone cone)
            {
                return cone.CalculateSurfaceArea();
            }

            return 0.0;
        }
    }
}
