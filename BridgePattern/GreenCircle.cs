using System;

namespace BridgePattern
{
    public class GreenCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[color: green, radius: {0}, x: {1}, y: {2}]", radius, x, y);
        }
    }
}
