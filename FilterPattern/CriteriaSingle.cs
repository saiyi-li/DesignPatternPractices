using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaSingle: ICriteria
    {
        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> singlePeople = new List<Person>();
            foreach (Person person in people)
            {
                if (person.maritalStatus.ToLower() == "single")
                {
                    singlePeople.Add(person);
                }
            }
            return singlePeople;
        }
    }
}
