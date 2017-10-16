using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository nameRepository = new NameRepository();
            for (IIterator iter = nameRepository.GetIterator(); iter.hasNext();)
            {
                string name = (string) iter.next();
                Console.WriteLine("Name: " + name);
            }

            Console.Read();
        }
    }
}
