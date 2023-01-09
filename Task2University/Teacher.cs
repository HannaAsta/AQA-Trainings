namespace Task2University
{
    public class Teacher : UniversityEmployee
    {
        public Course[] courses;
                     
        public Teacher(Person person, long taxID, Course[] courses): base (person,taxID)
        {            
            this.courses = courses;
        }

        public override string GetOfficialDuties()
        {
            string duties = string.Empty;
            foreach (Course course in courses)
            {
                duties += " " + course.Name;  
            }    
            return duties;
        }
    }

}
