using System;

namespace ChainOfResponsibilityPattern
{
    public class FileLogger: AbsractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File:Logger: " + message);
        }
    }
}
