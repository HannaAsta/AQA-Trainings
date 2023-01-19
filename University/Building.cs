namespace University
{
    internal class Building
    {
        public Room[] Rooms;
        public Adress Adress;
        
        public Building(Room[] rooms, Adress adress)
        {
            Rooms = rooms;
            Adress = adress;
        }   
    }
}
