namespace MementoPattern
{
    public class Originator
    {
        public string state { get; set; }

        public Memento SaveStateToMemento()
        {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            this.state = memento.state;
        }
    }
}
