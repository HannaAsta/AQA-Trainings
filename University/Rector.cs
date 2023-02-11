namespace University
{
    public class Rector : UniversityEmployee
    {
        public string PhoneNumber { get; private set; }

        public Rector(Person person, uint taxId, string phoneNumber) : base(person, taxId)
        {
            PhoneNumber = phoneNumber;
        }
    }
}