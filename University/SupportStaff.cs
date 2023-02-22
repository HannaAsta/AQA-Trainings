using static University.Positions;

namespace University
{
    public class SupportStaff : UniversityEmployee
    {
        public Position Position { get; set; }
        public SupportStaff(Person person, uint taxId, Position position) : base(person, taxId)
        {
            Position = position;
        }
    }
}