using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ceo = new Employee("Jhon", "CEO", 30000);
            Employee headSales = new Employee("Robert", "Head Sales", 20000);
            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExcutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExcutive2 = new Employee("Rob", "Sales", 10000);

            ceo.Add(headSales);
            ceo.Add(headMarketing);

            headSales.Add(salesExcutive1);
            headSales.Add(salesExcutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            Console.WriteLine(ceo);
            foreach (Employee heaEmployee in ceo.subordinates)
            {
                Console.WriteLine(heaEmployee);
                foreach (Employee employee in heaEmployee.subordinates)
                {
                    Console.WriteLine(employee);
                }
            }

            Console.Read();
        }
    }
}
