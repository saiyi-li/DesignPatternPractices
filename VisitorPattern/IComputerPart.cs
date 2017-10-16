namespace VisitorPattern
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
