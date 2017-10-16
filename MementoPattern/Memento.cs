namespace MementoPattern
{
    public class Memento
    {
        public string state { get; private set; }

        public Memento(string state)
        {
            this.state = state;
        }
    }
}
