namespace University
{
    public class UniversityEmployee: IComparable 
    {
        public Person Person { get; set; }
        public uint TaxId { get; set; }

        public UniversityEmployee(Person person, uint taxId)
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
            if (obj is UniversityEmployee employee)
            {
               return TaxId == employee.TaxId; 
            }
            return false;
        }
        public override int GetHashCode()
        {
            return TaxId.GetHashCode();
        }
        public int CompareTo(object? obj)
        {
            if (obj is UniversityEmployee)
            {
                var current = Person.FullNameLength;
                var employee = (obj as UniversityEmployee);
                var compareTo = employee.Person.FullNameLength;
                return compareTo - current;
            }
            return -1;
        }
    }
}
