using System;

namespace AbstractFactoryPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square.Draw() method");
        }
    }
}
