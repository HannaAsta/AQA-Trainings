namespace University
{
        public enum Position
        {
            SecurityGuard,
            CleanPerson,
            Secretary,
        }

        public class SupportStaff : UniversityEmployee
        {
            private Position position;

            public SupportStaff(Person person, ulong taxID, Position position) : base(person, taxID)
            {
                this.position = position;
            }
        }
    }