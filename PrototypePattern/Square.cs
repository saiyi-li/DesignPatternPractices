using System;

namespace PrototypePattern
{
    public class Square : Shape
    {
        public Square()
        {
            this.type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square.Draw() method");
        }
    }
}
