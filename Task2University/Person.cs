namespace Task2University
{
    public class Person
    {
        public string Last { get; set; }
        public string First { get; set; }

        public string FullName
        {
            get
            {
                return $"{Last} {First}";
            }
        }
        public Person(string lastName, string firstName)
        {
            Last = lastName;
            First = firstName;
        }
    }
}