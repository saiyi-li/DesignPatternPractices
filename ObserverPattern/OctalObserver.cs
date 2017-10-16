using System;
using System.Runtime.CompilerServices;

namespace ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(this.subject.state, 8));
        }
    }
}
