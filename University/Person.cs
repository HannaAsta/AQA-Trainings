namespace University
{
    internal class Person
    {
        public string Last { get; private set; }
        public string First { get; set; }

        public Person(string lastName, string firstName)
        {
            if (lastName.Length + firstName.Length > 15)
                throw new ArgumentException("Last name and Fist name too long");
            Last = lastName;
            First = firstName;
        }
    }
}
