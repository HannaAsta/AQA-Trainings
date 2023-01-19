namespace University
{
    internal class Teacher : UniversityEmployee
    { 
     public string[] Courses; 
     public string Degree;

        public Teacher(Person person, ulong taxId, string[] courses, string degree) : base(person, taxId)
        {
            Courses = courses;
            Degree = degree;
        }
    }
}  