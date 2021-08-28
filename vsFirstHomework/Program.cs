using System;
using vsFirstHomework.classes;

namespace vsFirstHomework
{
    class Program
    {
          

        static void Main(string[] args)
        {
            IShapeStore store = new ShapeStore();


            Shape firstShape = new Shape("Rectangle",3,5);           
            store.AddShape(firstShape);
           //Console.WriteLine( firstShape.GetArea());

            Shape secandShape = new Shape("Square",4,4);
            store.AddShape(secandShape);
             Shape thirdShape = new Shape("Circle",7);
            store.AddShape(thirdShape);

            Shape fourthShape = new Shape("Rectangle", 9, 11);
            store.AddShape(fourthShape);

            var allShapes = store.GetAllShapes();
            foreach (var shape in allShapes)
            {
                Console.WriteLine( shape.GetName()+ " with area:" + shape.GetArea()+ " and with perimeter:" + shape.GetPerimeter());

            }
        }
    }
}
