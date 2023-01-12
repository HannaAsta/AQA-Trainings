namespace University
{
    public class Adress
    {
        public uint NumberLokal;
        public string Street;
        public string City;

        public Adress(uint numberLokal,string street, string city)
        { 
            NumberLokal = numberLokal;  
            Street = street;
            City = city;
        }
    }
}
