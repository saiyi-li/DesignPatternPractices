using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());

            Console.Read();
        }
    }
}
