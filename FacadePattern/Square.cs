using System;

namespace FacadePattern
{
    public class Square: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square: Draw()");
        }
    }
}
