namespace IteratorPattern
{
    public class NameIterator: IIterator
    {
        private int _index;
        private readonly string[] _names;

        public NameIterator(string[] names)
        {
            _names = names;
        }

        public bool hasNext()
        {
            return _index < _names.Length;
        }

        public object next()
        {
            return hasNext() ? _names[_index++] : null;
        }
    }
}
