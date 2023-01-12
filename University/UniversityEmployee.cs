namespace University
{
    public class UniversityEmployee
    {
        protected Person person;
        private ulong taxID;

        public UniversityEmployee(Person person, ulong taxID)
        {
            this.person = person;
            this.taxID = taxID;
        }
    }
}
