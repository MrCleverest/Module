using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    // Поліморфний контейнер
    public class ShapeContainer
    {
        private List<object> shapes;

        public ShapeContainer()
        {
            shapes = new List<object>();
        }

        public void AddShape(object shape)
        {
            shapes.Add(shape);
        }
        public IEnumerator<object> GetEnumerator()
        {
            return shapes.GetEnumerator();
        }
        public List<object> GetShapes()
        {
            return shapes;
        }
    }
}
