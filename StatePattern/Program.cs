using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.state.ToString());

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.state.ToString());

            Console.Read();
        }
    }
}
