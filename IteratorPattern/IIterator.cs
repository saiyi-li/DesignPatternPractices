using System.Runtime.Remoting;

namespace IteratorPattern
{
    public interface IIterator
    {
        bool hasNext();
        object next();
    }
}
