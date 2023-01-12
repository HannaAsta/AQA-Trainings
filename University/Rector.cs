namespace University
{
    public class Rector : UniversityEmployee
    {
        private string phoneNumber;

        public Rector(Person person, ulong taxID, string phoneNumber) : base(person, taxID)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}