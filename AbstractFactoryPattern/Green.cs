using System;

namespace AbstractFactoryPattern
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green.Fill() method");
        }
    }
}
