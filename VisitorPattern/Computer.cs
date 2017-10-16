namespace VisitorPattern
{
    public class Computer: IComputerPart
    {
        private IComputerPart[] _parts;

        public Computer()
        {
            _parts = new IComputerPart[] {new Mouse(), new Keyboard(), new Mouse()};
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (IComputerPart part in _parts)
            {
                part.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}
