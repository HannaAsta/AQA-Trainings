namespace Candidate
{
    public class Address
    {
        public uint NumberHome { get; set; }
        public uint NumberLokal { get; set; } 
        public string Street { get; set; }
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
