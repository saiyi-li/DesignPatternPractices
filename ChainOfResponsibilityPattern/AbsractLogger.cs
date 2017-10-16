namespace ChainOfResponsibilityPattern
{
    public abstract class AbsractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;

        public AbsractLogger nextLogger;

        public void LogMessage(int level, string message)
        {
            if (this.level <= level)
            {
                Write(message);
            }
            if (nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        protected abstract void Write(string message);
    }
}
