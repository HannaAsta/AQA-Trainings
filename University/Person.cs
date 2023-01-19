namespace University
{
    internal class Person
    {
        public string Last { get; private set; }
        public string First { get; set; }

        public Person(string lastName, string firstName)
        {
            Last = lastName;
            First = firstName;
        }
    }
}
