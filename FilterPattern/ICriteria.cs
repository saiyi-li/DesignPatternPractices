using System.Collections.Generic;

namespace FilterPattern
{
    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> people);
    }
}
