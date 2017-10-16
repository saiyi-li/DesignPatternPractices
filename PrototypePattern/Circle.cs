using System;

namespace PrototypePattern
{
    public class Circle : Shape
    {
        public Circle()
        {
            this.type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle.Draw() method");
        }
    }
}
