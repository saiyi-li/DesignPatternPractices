using System;

namespace PrototypePattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            this.type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle.Draw() method");
        }
    }
}
