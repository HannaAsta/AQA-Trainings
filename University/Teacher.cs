namespace University
{
    public class Teacher : UniversityEmployee
    { 
    private string lessons; 
    private string degree;
    public Teacher(Person person, ulong taxID, string lessons, string degree) : base(person, taxID)
        {
          this.lessons = lessons;
          this.degree = degree;
        }
    }
}


    