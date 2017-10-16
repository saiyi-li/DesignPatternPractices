using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            IShape redCircle = new RedShapeDecorator(circle);
            IShape redRectangle = new RedShapeDecorator(rectangle);

            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle with red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle with normal border");
            rectangle.Draw();

            Console.WriteLine("\nRectangle with red border");
            redRectangle.Draw();

            Console.Read();
        }
    }
}
