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
    }
}
