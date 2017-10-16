namespace StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExectureStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
