using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaMale: ICriteria
    {
        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> malePeople = new List<Person>();
            foreach (Person person in people)
            {
                if (person.gender.ToLower() == "male")
                {
                    malePeople.Add(person);
                }
            }
            return malePeople;
        }
    }
}
