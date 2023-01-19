namespace University
{
    internal class Teacher : UniversityEmployee
    { 
        public List<string> Courses { get; set; } 
        public string Degree { get; set; }

        public Teacher(Person person, ulong taxId, List<string> courses, string degree) : base(person, taxId)
        {
            Courses = courses;
            Degree = degree;
             
        }
    }
}  