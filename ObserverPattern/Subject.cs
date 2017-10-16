using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int _state;

        public int state
        {
            get { return this._state; }
            set
            {
                this._state = value;
                this.NotifyAllObservers();
            }
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }
}
