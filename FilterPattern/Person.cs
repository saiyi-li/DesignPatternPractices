namespace FilterPattern
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string maritalStatus { get; set; }

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }
    }
}
