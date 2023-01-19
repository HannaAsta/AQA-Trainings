namespace University
{
    internal class Adress
    {
        public uint NumberLokal { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Adress(uint numberLokal,string street, string city)
        { 
            NumberLokal = numberLokal;  
            Street = street;
            City = city;
        }
    }
}
