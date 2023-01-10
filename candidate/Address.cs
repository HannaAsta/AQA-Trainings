namespace candidate
{
    public class Address
    {
        public uint NumberHome { get; private set; }
        public uint NumberLokal { get; private set; } 
        public string Street { get; private set; }
        public string City { get; private set; }
    
        
        public Address(uint numberHome, uint numberLokal, string street, string city)
        {
            NumberHome = numberHome;
            NumberLokal = numberLokal;
            Street = street;
            City = city;   
        }
    }

}
