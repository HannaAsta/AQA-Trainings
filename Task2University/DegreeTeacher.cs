namespace Task2University
{
    public class DegreeTeacher : Teacher
    {
        string Sciencedegree;
        string Degree;
        public DegreeTeacher(Person person, long taxID, Course[] course, string Sciencedegree, string Degree) : base (person, taxID, course)
        {
            this.Sciencedegree = Sciencedegree;
            this.Degree= Degree;
        }               
    }
}
