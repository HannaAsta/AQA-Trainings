namespace University
{
    internal class UniversityEmployee
    {
        public Person Person;
        public ulong TaxId { get; set; }

        public UniversityEmployee(Person person, ulong taxId)
        {
            Person = person;
            TaxId = taxId;
        }
    }
}
