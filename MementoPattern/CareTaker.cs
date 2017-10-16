using System.Collections.Generic;

namespace MementoPattern
{
    public class CareTaker
    {
        private  List<Memento> mementoList = new List<Memento>();

        public void Add(Memento memento)
        {
            this.mementoList.Add(memento);
        }

        public Memento Get(int index)
        {
            return this.mementoList[index];
        }
    }
}
