namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string colorType);
        public abstract IShape GetShape(string shapeType);
    }
}
