namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factoryType)
        {
            switch (factoryType.ToLower())
            {
                case "shape":
                    return new ShapeFactpry();
                case "color":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
