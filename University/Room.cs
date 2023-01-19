namespace University
{
    internal class Room
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
            if (obj is Room)
            {
                Room room = obj as Room;
                return Number == room.Number && Assignment == room.Assignment;
            }
            return false;
        }
    }
}
