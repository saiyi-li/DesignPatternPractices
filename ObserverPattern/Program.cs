using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            new HexaObserrver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.state = 15;
            Console.WriteLine("Second state change: 16");
            subject.state = 16;

            Console.Read();
        }
    }
}
