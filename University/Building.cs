namespace University
{
    public class Building
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
            if (obj is Building building)
            {
                return Adress == building.Adress;
            }
            return false;
        }
        public override int GetHashCode() 
        {
            return Adress.GetHashCode();
        }
    }
}
