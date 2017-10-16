using System.Collections.Generic;

namespace CompositePattern
{
    public class Employee
    {
        private string _name;
        private string _dept;
        private int _salary;
        public List<Employee> subordinates { get; private set; }

        public Employee(string name, string dept, int salary)
        {
            _name = name;
            _dept = dept;
            _salary = salary;
            subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public override string ToString()
        {
            return string.Format("Employee: [ Name: {0}, dept: {1}, salary: {2}]", _name, _dept,
                _salary);
        }
    }
}
