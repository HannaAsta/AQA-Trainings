namespace candidate
{
    public class Address
    {
        int numberhome;
        int numberlokal;
        string street;
        string city;
        public Address(int numberhome_,int numberlokal_, string street_, string city_)
        {
            this.numberhome = numberhome_;
            this.numberlokal = numberlokal_;
            this.street= street_;
            this.city= city_;   
        }
        public string Getstreet()
        { 
            return street;
        }
    }

}
