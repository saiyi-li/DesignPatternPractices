using System;

namespace ObserverPattern
{
    public class HexaObserrver: Observer
    {
        public HexaObserrver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Hex String: " + Convert.ToString(this.subject.state, 16));
        }
    }
}
