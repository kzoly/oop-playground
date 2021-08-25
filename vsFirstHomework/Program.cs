using System;
using vsFirstHomework.classes;

namespace vsFirstHomework
{
    class Program
    {
          

        static void Main(string[] args)
        {
            IShapeStore store = new ShapeStore();


            Shape firstShape = new Shape("Rectangle");           
            store.AddShape(firstShape);

            Shape secandShape = new Shape("Square");
            store.AddShape(secandShape);
            Shape thirdShape = new Shape("Circle");
            store.AddShape(thirdShape);

            var allShapes = store.GetAllShapes();
            foreach (var shape in allShapes)
            {
                Console.WriteLine( shape.GetName());

            }
        }
    }
}
