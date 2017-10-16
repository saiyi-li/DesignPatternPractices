using System;
using System.Reflection;

namespace NullObjectPattern
{
    public class CustomerFactory
    {
        public static string[] names = new[] {"Rob", "Joe", "Julie"};

        public static AbstractCustomer GetCustomer(string name)
        {
            foreach (string n in names)
            {
                if (n.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return new RealCustomer(n);
            }
            return  new NullCustomer();
        }
    }
}
