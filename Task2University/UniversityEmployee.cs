namespace Task2University
{
    public abstract class UniversityEmployee
    {
        protected Person person; 
        public ulong TaxID { get; private set; }

        virtual public string PersonInfo 
        {
            get 
            {
                return $"Employee: {person.FullName} TaxId: {TaxID} ";
            }
        }
        public UniversityEmployee(Person person, ulong numberTaxID)
        {
            this.person = person;
            TaxID = numberTaxID;
        }

        abstract public string GetOfficialDuties();
    }
}
