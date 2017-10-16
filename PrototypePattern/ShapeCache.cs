using System.Collections.Generic;

namespace PrototypePattern
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = shapeMap[shapeId];
            return (Shape) cachedShape.Clone();
        }

        public static void LocalCache()
        {
            Circle circle = new Circle();
            circle.id = "1";
            shapeMap.Add(circle.id, circle);

            Square square = new Square();
            square.id = "2";
            shapeMap.Add(square.id, square);

            Rectangle rectangle = new Rectangle();
            rectangle.id = "3";
            shapeMap.Add(rectangle.id, rectangle);
        }
    }
}
