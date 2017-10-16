using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //Image will be loaded from disk
            image.Display();
            Console.WriteLine("");
            //Image cannot be loaded from disk
            image.Display();

            Console.Read();
        }
    }
}
