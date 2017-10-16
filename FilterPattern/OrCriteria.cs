using System.Collections.Generic;

namespace FilterPattern
{
    public class OrCriteria: ICriteria
    {
        private ICriteria _criteria;
        private ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> firstCriteriaPeople = _criteria.MeetCriteria(people);
            List<Person> otherCriteriaPeople = _otherCriteria.MeetCriteria(people);

            foreach (Person person in otherCriteriaPeople)
            {
                if (!firstCriteriaPeople.Contains(person))
                    firstCriteriaPeople.Add(person);
            }
            return firstCriteriaPeople;
        }
    }
}
