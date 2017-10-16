using System;
using System.Collections.Generic;

namespace FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Robert", "Male", "Single"),
                new Person("Jhon", "Male", "Married"),
                new Person("Laura", "Female", "Married"),
                new Person("Diana", "Female", "Single"),
                new Person("Mike", "Male", "Single"),
                new Person("Bobby", "Male", "Single")
            };

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Male: ");
            PrintPeople(male.MeetCriteria(people));

            Console.WriteLine("\nFemale: ");
            PrintPeople(female.MeetCriteria(people));

            Console.WriteLine("\nSingle Male: ");
            PrintPeople(singleMale.MeetCriteria(people));

            Console.WriteLine("\nSingle Or Female: ");
            PrintPeople(singleOrFemale.MeetCriteria(people));

            Console.Read();
        }

        static void PrintPeople(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine("Person: [ Name: {0}, Gender: {1}, Marital Status: {2}", person.name, person.gender, person.maritalStatus);
            }
        }
    }
}
