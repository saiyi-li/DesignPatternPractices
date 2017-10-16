using System;

namespace FlyweightPattern
{
    public class Circle: IShape
    {
        private string _color;
        public int x { private get; set; }
        public int y { private get; set; }
        public int radius { private get; set; }

        public Circle(string color)
        {
            _color = color;
        }

        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : "+ _color + ", x: "+ x + ", y: " + y + ", radius: " + radius);
        }
    }
}
