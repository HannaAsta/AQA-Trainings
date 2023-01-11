namespace Task2University
{
    public class DegreeTeacher : Teacher
    {
        private string scienceDegree;
        private string degree;
        public override string PersonInfo
        {
            get
            {
                return $"DegreeTeacher: {person.FullName} TaxId: {TaxID} Degree: {degree} {scienceDegree}";
            }
        }

        public DegreeTeacher(Person person, ulong taxID, Course[] course, string scienceDegree, string degree) 
                            : base(person, taxID, course)
        {
            this.scienceDegree = scienceDegree;
            this.degree = degree;
        }             
    }
}
