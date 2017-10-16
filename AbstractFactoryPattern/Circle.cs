using System;

namespace AbstractFactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle.Draw() method");
        }
    }
}
