namespace Task2University
{
    public enum Position
    {
        Securityguard,
        Cleanperson,
        Driver
    }

    public class SupportStaff : UniversityEmployee
    {
        private Position position;

        public SupportStaff(Person person, ulong taxiID, Position position) : base(person, taxiID)
        {
            this.position = position;
        }
        public override string GetOfficialDuties()
        {
            string duties = PersonInfo;
            switch (position)
            {
                case Position.Driver:
                    duties += " This Driver drive a car";
                    break;
                case Position.Cleanperson:
                    duties += " This Cleanperson clean the room";
                    break;
                case Position.Securityguard:
                    duties += " This Securityguard guards the room";
                    break;
            }
            return duties;
        } 
    }
}
