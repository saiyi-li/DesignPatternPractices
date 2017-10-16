using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LocalCache();
            Shape clonedShape1 = (Shape) ShapeCache.GetShape("1");
            Console.WriteLine("Shape: " + clonedShape1.GetType());

            Shape clonedShape2 = (Shape)ShapeCache.GetShape("2");
            Console.WriteLine("Shape: " + clonedShape2.GetType());

            Shape clonedShape3 = (Shape)ShapeCache.GetShape("3");
            Console.WriteLine("Shape: " + clonedShape3.GetType());

            Console.Read();
        }
    }
}
