using System;

namespace FactoryPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle.Draw() method");
        }
    }
}
