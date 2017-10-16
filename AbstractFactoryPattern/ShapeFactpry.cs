namespace AbstractFactoryPattern
{
    public class ShapeFactpry : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
