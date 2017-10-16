namespace BridgePattern
{
    public class Circle : Shape
    {
        private int _x;
        private int _y;
        private int _radius;

        public Circle(int x, int y, int radius, IDrawApi drawApi) : base(drawApi)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Draw()
        {
            drawApi.DrawCircle(_radius, _x, _y);
        }
    }
}
