using System;

namespace DecoratorPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
