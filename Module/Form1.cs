using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    public partial class Form1 : Form
    {
        private ShapeContainer container;
        private DataGridViewHelper dataGridViewHelper;
        public Form1()
        {
            InitializeComponent();
            container = new ShapeContainer();
            // Визначення стовпців для DataGridView
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Назва фігури";
            dataGridView1.Columns[1].Name = "Периметр";
            dataGridView1.Columns[2].Name = "Площа";
            dataGridView1.Columns[3].Name = "Об'єм";
            dataGridView1.Columns[4].Name = "Радіус вписаної окружності";
            dataGridView1.Columns[5].Name = "Радіус описаної окружності";
            dataGridViewHelper = new DataGridViewHelper(dataGridView1);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримати вибрану фігуру з CheckedListBox
                string selectedFigure = comboBox1.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedFigure))
                {
                    // Якщо обрано Коло
                    if (selectedFigure == "Коло" && double.TryParse(radiusTextBox.Text, out double radius))
                    {
                        Circle circle = new Circle(radius);
                        container.AddShape(circle);
                    }
                    else if (selectedFigure == "Квадрат" && double.TryParse(sideTextBox.Text, out double side))
                    {
                        Square square = new Square(side);
                        container.AddShape(square);
                    }
                    else if (selectedFigure == "Циліндр" && double.TryParse(radiusTextBox.Text, out double radiusCylinder) &&
                             double.TryParse(heightTextBox.Text, out double heightCylinder))
                    {
                        Cylinder cylinder = new Cylinder(radiusCylinder, heightCylinder);
                        container.AddShape(cylinder);
                    }
                    else if (selectedFigure == "Шар" && double.TryParse(radiusTextBox.Text, out double radiusSphere))
                    {
                        Sphere sphere = new Sphere(radiusSphere);
                        container.AddShape(sphere);
                    }
                    else if (selectedFigure == "Конус" && double.TryParse(radiusTextBox.Text, out double radiusCone) &&
                             double.TryParse(heightTextBox.Text, out double heightCone))
                    {
                        Cone cone = new Cone(radiusCone, heightCone);
                        container.AddShape(cone);
                    }
                    else
                    {
                        throw new Exception("Введено неправильні дані!");
                    }
                }
                else
                {
                    throw new Exception("Будь-ласка виберіть фігуру!");
                }
                // Оновлення DataGridView після додавання фігур
                dataGridViewHelper.RefreshData(container.GetShapes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
