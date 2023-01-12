namespace University
{
    public class Teacher : UniversityEmployee
    { 
        private string[] courses; 
        private string degree;

        public Teacher(Person person, ulong taxID, string[] courses, string degree) : base(person, taxID)
        {
            this.courses = courses;
            this.degree = degree;
        }
    }
}  