namespace University
{
        public enum Position
        {
            Securityguard,
            Cleanperson,
            Secretary,
        }
        public class SupportStaff : UniversityEmployee
        {
            public Position position;

            public SupportStaff(Person person, ulong taxID, Position position) : base(person, taxID)
            {
                this.position = position;
            }
        }
    }


