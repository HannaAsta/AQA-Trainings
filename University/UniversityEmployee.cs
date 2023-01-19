namespace University
{
    internal class UniversityEmployee
    {
        public Person Person { get; set; }
        public ulong TaxId { get; set; }

        public UniversityEmployee(Person person, ulong taxId)
        {
            Person = person;
            TaxId = taxId;
        }
        public override bool Equals(object? obj)
        {
            if (obj is UniversityEmployee)
            {
                UniversityEmployee employee = obj as UniversityEmployee;
                return TaxId == employee.TaxId; 
            }
            return false;
        }
    }
}
