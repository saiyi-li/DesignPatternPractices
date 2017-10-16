using System.Collections.Generic;

namespace FilterPattern
{
    public class AndCriteria : ICriteria
    {
        private ICriteria _criteria;
        private ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> firstCriteriaPeople = _criteria.MeetCriteria(people);
            return _otherCriteria.MeetCriteria(firstCriteriaPeople);
        }
    }
}
