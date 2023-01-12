namespace University
{
    public class Univer
    {
        UniversityEmployee[] employees;
        Rector rector;
        Building[] buildings;
        Adress adress; 

        public Univer(Rector rector, Adress adress, UniversityEmployee[] employees, Building[] buildings)
        {
            this.employees = employees;
            this.rector = rector;
            this.buildings = buildings;
            this.adress = adress;
        }    
    }   
}
