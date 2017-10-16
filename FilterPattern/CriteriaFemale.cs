using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> femalePeople = new List<Person>();
            foreach (Person person in people)
            {
                if (person.gender.ToLower() == "female")
                {
                    femalePeople.Add(person);
                }
            }
            return femalePeople;
        }
    }
}
