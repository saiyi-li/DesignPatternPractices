namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
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
