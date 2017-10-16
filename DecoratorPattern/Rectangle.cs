using System;

namespace DecoratorPattern
{
    public class Rectangle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
