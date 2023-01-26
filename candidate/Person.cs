namespace Candidate
{
    public class Person
    {
        public string Last { get; set; }
        public string First { get; set; }
        public Address Address { get; set; }

        public Person(string lastName, string firstName, Address address)
        {
            Last = lastName;
            First = firstName;
            Address = address;
        }
    }
}
