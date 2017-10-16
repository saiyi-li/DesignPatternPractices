namespace AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            switch (colorType.ToLower())
            {
                case "red":
                    return new Red();
                case "green":
                    return new Green();
                case "blue":
                    return new Blue();
                default:
                    return null;
            }
        }

        public override IShape GetShape(string shapeType)
        {
            return null;
        }
    }
}
