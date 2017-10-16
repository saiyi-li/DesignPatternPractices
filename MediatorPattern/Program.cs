using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("john");

            robert.SendMessage("Hi! John");
            john.SendMessage("Hi! Robert");

            Console.Read();
        }
    }
}
