namespace Task2University
{
    public class DegreeTeacher : Teacher
    {
        public string ScienceDegree { get; set; }
        public string Degree { get; set; }
        public override string PersonInfo
        {
            get
            {
                return $"DegreeTeacher: {Person.FullName} TaxId: {TaxId} Degree: {Degree} {ScienceDegree}";
            }
        }

        public DegreeTeacher(Person person, ulong taxId, Course[] course, string scienceDegree, string degree) 
                            : base(person, taxId, course)
        {
            ScienceDegree = scienceDegree;
            Degree = degree;
        }             
    }
}