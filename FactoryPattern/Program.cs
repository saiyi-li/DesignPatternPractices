using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shapeCircle = shapeFactory.GetShape("circle");
            shapeCircle.Draw();
            IShape shapeRectangle = shapeFactory.GetShape("rectangle");
            shapeRectangle.Draw();
            IShape shapeSquare = shapeFactory.GetShape("square");
            shapeSquare.Draw();

            Console.Read();
        }
    }
}
