using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> _circleDict = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            IShape circle;
            if (!_circleDict.ContainsKey(color))
            {
                circle = new Circle(color);
                _circleDict.Add(color, circle);
                Console.WriteLine("Creatig circle of color: " + color);
            }
            else
            {
                circle = _circleDict[color];
            }


            return circle;
        }
    }
}
