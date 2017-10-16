namespace InterpreterPattern
{
    public class TerminalExpression: IExpression
    {
        private string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(_data))
            {
                return true;
            }
            return false;
        }
    }
}
