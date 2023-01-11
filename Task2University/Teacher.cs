namespace Task2University
{
    public class Teacher : UniversityEmployee
    {
        private Course[] courses;

        public override string PersonInfo
        {
            get
            {
                return $"Teacher: {person.FullName} taxId: {TaxID} ";
            }
        }

        public Teacher(Person person, ulong taxID, Course[] courses): base (person,taxID)
        {            
            this.courses = courses;
        }

        public override string GetOfficialDuties()
        {
            string duties = $"{PersonInfo} Courses:";
            foreach (Course course in courses)
            {
                duties += " " + course.Name;  
            }    
            return duties;
        }
    }

}
