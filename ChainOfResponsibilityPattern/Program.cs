using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        private static AbsractLogger GetChainOfLoggers()
        {
            AbsractLogger errorLogger = new ErrorLogger(AbsractLogger.ERROR);
            AbsractLogger fileLogger = new FileLogger(AbsractLogger.DEBUG);
            AbsractLogger consoleLogger = new ConsoleLogger(AbsractLogger.INFO);

            errorLogger.nextLogger = fileLogger;
            fileLogger.nextLogger = consoleLogger;

            return errorLogger;
        }

        static void Main(string[] args)
        {
            AbsractLogger loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbsractLogger.INFO, "This is an information");
            loggerChain.LogMessage(AbsractLogger.DEBUG, "This is a debug level information");
            loggerChain.LogMessage(AbsractLogger.ERROR, "This is an error level information");

            Console.Read();

        }
    }
}
