using System;

namespace AbstractFactoryPattern
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red.Fill() method");
        }
    }
}
