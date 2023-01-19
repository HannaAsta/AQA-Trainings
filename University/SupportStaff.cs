using static University.Positions;

namespace University
{
       internal class SupportStaff : UniversityEmployee
        {
            public Position Position { get; set; }

            public SupportStaff(Person person, ulong taxId, Position position) : base(person, taxId)
            {
                Position = position;
            }
        }
    }