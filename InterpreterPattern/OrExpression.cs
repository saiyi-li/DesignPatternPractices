namespace InterpreterPattern
{
    public class OrExpression: IExpression
    {
        private IExpression _expr1;
        private IExpression _expr2;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return _expr1.Interpret(context) || _expr2.Interpret(context);
        }
    }
}
