namespace University
{
    public class UniversityEmployee
    {
        protected Person person;
        public ulong TaxID;

        public UniversityEmployee(Person person, ulong taxID)
        {
            this.person = person;
            this.TaxID = taxID;
        }

    }
}
