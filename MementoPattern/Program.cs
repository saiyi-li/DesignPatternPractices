using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.state = "State #1";
            originator.state = "State #2";
            careTaker.Add(originator.SaveStateToMemento());
            originator.state = "State #3";
            careTaker.Add(originator.SaveStateToMemento());
            originator.state = "State #4";

            Console.WriteLine("Current State: " + originator.state);
            originator.GetStateFromMemento(careTaker.Get(0));
            Console.WriteLine("First Saved State: " + originator.state);
            originator.GetStateFromMemento(careTaker.Get(1));
            Console.WriteLine("Second Saved State: " + originator.state);

            Console.Read();
        }
    }
}
