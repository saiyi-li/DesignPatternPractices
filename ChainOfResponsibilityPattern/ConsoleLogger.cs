using System;

namespace ChainOfResponsibilityPattern
{
    public class ConsoleLogger: AbsractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console: Logger: " + message);
        }
    }
}
