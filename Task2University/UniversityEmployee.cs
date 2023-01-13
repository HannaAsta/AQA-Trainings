namespace Task2University
{
    public abstract class UniversityEmployee
    {
        public Person Person { get; set; }
        public ulong TaxId { get; private set; }

        virtual public string PersonInfo 
        {
            get 
            {
                return $"Employee: {Person.FullName} TaxId: {TaxId} ";
            }
        }
        public UniversityEmployee(Person person, ulong numberTaxId)
        {
            Person = person;
            TaxId = numberTaxId;
        }
        abstract public string GetOfficialDuties();
    }
}