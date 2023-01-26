namespace Task2University
{
    public class Teacher : UniversityEmployee
    {
       public Course[] Courses { get; set; }

        public override string PersonInfo
        {
            get
            {
                return $"Teacher: {Person.FullName} taxId: {TaxId} ";
            }
        }

        public Teacher(Person person, ulong taxID, Course[] courses): base (person,taxID)
        {            
            Courses = courses;
        }

        public override string GetOfficialDuties()
        {
            string duties = $"{PersonInfo} Courses:";
            foreach (Course course in Courses)
            {
                duties += " " + course.Name;  
            }    
            return duties;
        }
    }

}