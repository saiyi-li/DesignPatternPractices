using System;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpression isMale = GetMaleExpression();
            IExpression isMarriedWoman = GetMarriedFemaleExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is a married woman? " + isMarriedWoman.Interpret("Married Julie"));

            Console.Read();
        }

        public static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        public static IExpression GetMarriedFemaleExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
    }
}
