namespace University
{
    internal class Building
    {
        public List<Room> Rooms { get; set; }
        public Adress Adress;

        public Building(List<Room> rooms, Adress adress)
        {
            Rooms = rooms;
            Adress = adress;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Building)
            {
                Building building  = obj as Building;
                return Adress == building.Adress;
            }
            return false;
        }
    }
}
