using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsFirstHomework.classes
{
  
    class ShapeStore:IShapeStore
    {
        private List<Shape> shapes;

        public ShapeStore()
        {
            shapes = new List<Shape>();
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DeleteShape()
        {
            shapes.Clear();
        }

        public List<Shape> GetAllShapes()
        {
            return shapes;

        }
    }
}
