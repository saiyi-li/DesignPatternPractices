using System;

namespace VisitorPattern
{
    public class ComputerPartDisplayVisitor: IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse");            
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Display monitor");
        }
    }
}
