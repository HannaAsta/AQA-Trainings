using static Task2University.Positions;

namespace Task2University
{
    public class SupportStaff : UniversityEmployee
    {
        public Position Position { get; set; } 

        public SupportStaff(Person person, ulong taxiId, Position position) : base(person, taxiId)
        {
            Position = position;
        }
        public override string GetOfficialDuties()
        {
            string duties = PersonInfo;

            switch (Position)
            {
                case Position.Driver:
                    duties += " This Driver drive a car";
                    break;
                case Position.CleanPerson:
                    duties += " This Cleanperson clean the room";
                    break;
                case Position.SecurityGuard:
                    duties += " This Securityguard guards the room";
                    break;
            }
            return duties;
        } 
    }
}