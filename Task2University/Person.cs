namespace Task2University
{
    public class Person
    {
        private string last;
        private string first;

        public string FullName
        {
            get
            {
                return $"{last} {first}";
            }
        }
        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }
    }
}
