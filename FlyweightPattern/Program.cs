using System;

namespace FlyweightPattern
{
    class Program
    {
        private static string[] _colors = new[] {"Red", "Green", "Blue", "White", "Black"};
        private static Random random = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(GetRandomColor());
                circle.x = GetRandomX();
                circle.y = GetRandomY();
                circle.radius = 100;
                circle.Draw();
            }

            Console.Read();
        }

        private static string GetRandomColor()
        {
            return _colors[random.Next(_colors.Length)];
        }

        private static int GetRandomX()
        {
            return random.Next(100);
        }

        private static int GetRandomY()
        {
            return random.Next(100);
        }
    }
}
