using System;

namespace SingletonPattern
{
    public class SingletonObject
    {
        private static readonly SingletonObject Instance = new SingletonObject();
        private SingletonObject() { }

        public static SingletonObject GetInstance()
        {
            return Instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
