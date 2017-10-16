using System;

namespace FactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle.Draw() method");
        }
    }
}
