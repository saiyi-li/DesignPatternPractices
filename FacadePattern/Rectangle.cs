using System;

namespace FacadePattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Recangle: Draw()");
        }
    }
}
