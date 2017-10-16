using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("shape");
            IShape shapeCirle = shapeFactory.GetShape("circle");
            shapeCirle.Draw();
            IShape shapeRectangle = shapeFactory.GetShape("rectangle");
            shapeRectangle.Draw();
            IShape shapeSquare = shapeFactory.GetShape("square");
            shapeSquare.Draw();

            AbstractFactory colorFactory = FactoryProducer.GetFactory("color");
            IColor colorRed = colorFactory.GetColor("red");
            colorRed.Fill();
            IColor colorGreen = colorFactory.GetColor("green");
            colorGreen.Fill();
            IColor colorBlue = colorFactory.GetColor("blue");
            colorBlue.Fill();

            Console.Read();
        }
    }
}
