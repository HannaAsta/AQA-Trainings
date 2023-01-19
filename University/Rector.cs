namespace University
{
    internal class Rector : UniversityEmployee
    {
        public string PhoneNumber { get; private set; }

        public Rector(Person person, ulong taxId, string phoneNumber) : base(person, taxId)
        {
            PhoneNumber = phoneNumber;
        }
    }
}