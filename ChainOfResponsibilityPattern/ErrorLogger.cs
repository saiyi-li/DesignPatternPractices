using System;

namespace ChainOfResponsibilityPattern
{
    public class ErrorLogger: AbsractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Error Console: Logger: " + message);
        }
    }
}
