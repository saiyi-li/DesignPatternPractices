using System;

namespace ObserverPattern
{
    public class BinaryObserver: Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(this.subject.state, 2));
        }
    }
}
