namespace University
{
    public class Room
    {
        public int Number { get; set; }
        public string Assignment { get; set; }

        public Room(int number, string assignment)
        { 
            Number = number;
            Assignment = assignment;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Room room)
            {
                return Number == room.Number && Assignment == room.Assignment;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Number.GetHashCode() + Assignment.GetHashCode();
        }
    }

}
