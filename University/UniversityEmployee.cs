namespace University
{
    internal class UniversityEmployee: IComparable 
    {
        public Person Person { get; set; }
        public ulong TaxId { get; set; }

        public UniversityEmployee(Person person, ulong taxId)
        {
            if (taxId <= 0)
            {
                throw new ArgumentException("taxId must be more than 0");
            }
            Person = person;
            TaxId = taxId;
        }
        public override bool Equals(object? obj)
        {
            if (obj is UniversityEmployee)
            {
                UniversityEmployee employee = obj as UniversityEmployee;
                return employee.TaxId.Equals(TaxId); 
            }
            return false;
        }
        public int CompareTo(object? obj)
        {
            if (obj is UniversityEmployee)
            {
                var current = Person.Last.Length + Person.First.Length;
                var employee = (obj as UniversityEmployee);
                var compareTo = employee.Person.Last.Length + employee.Person.First.Length;
                return compareTo - current;
            }
            return -1;
        }
    }
}
