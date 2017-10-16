using System;

namespace StatePattern
{
    public class StopState: IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.state = this;
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
