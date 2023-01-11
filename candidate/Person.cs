namespace Candidate
{
    public class Person
    {
        public string Last { get; private set; }
        public string First { get; private set; }
        public Address Address { get; private set; }

        public Person(string lastName, string firstName, Address address)
        {
            Last = lastName;
            First = firstName;
            Address = address;
        }
    }
}
