using System;

namespace BridgePattern
{
    public class RedCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[color: red, radius: {0}, x: {1}, y: {2}]", radius, x, y);
        }
    }
}
