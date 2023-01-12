namespace University
{
    public class Adress
    {
        private uint numberLokal;
        private string street;
        private string city;

        public Adress(uint numberLokal,string street, string city)
        { 
            this.numberLokal = numberLokal;  
            this.street = street;
            this.city = city;
        }
    }
}
