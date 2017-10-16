namespace IteratorPattern
{
    public class NameRepository : IContainer
    {
        public string [] names = {"Robert", "John", "Julie", "Lora"};

        public IIterator GetIterator()
        {
            
            return new NameIterator(names);
        }
    }
}
