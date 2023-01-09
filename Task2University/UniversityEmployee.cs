namespace Task2University
{
    public class UniversityEmployee
    {
        
        public Person person;
        public long taxiID;

        public UniversityEmployee(Person person, long taxiID)
        {
            this.person = person;
            this.taxiID = taxiID;
        }
        virtual public string GetOfficialDuties()
        {
            return "Go to work";
        }
        public string GetPersonName()
        {
            return person.GetName();
        }
    }

}
