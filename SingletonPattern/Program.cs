using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonObject instance = SingletonObject.GetInstance();
            instance.ShowMessage();

            Console.Read();
        }
    }
}
