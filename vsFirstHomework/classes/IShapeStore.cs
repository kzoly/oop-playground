using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsFirstHomework.classes
{
    interface IShapeStore
    {
        public List<Shape> GetAllShapes();

        public void AddShape(Shape shape);
        public void DeleteShape();

    }
}
