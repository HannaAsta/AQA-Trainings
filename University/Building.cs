namespace University
{
    public class Building
    {
        private Room[] rooms;
        private Adress adress;
        
        public Building(Room[] rooms, Adress adress)
        {
            this.rooms = rooms;
            this.adress = adress;
        }   
    }
}
