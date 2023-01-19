namespace University
{
    internal class Univer
    {
        public UniversityEmployee[] Employees;
        public Rector Rector;
        public Building[] Buildings;
        public Adress Adress; 

        public Univer(Rector rector, Adress adress, UniversityEmployee[] employees, Building[] buildings)
        {
           Employees = employees;
           Rector = rector;
           Buildings = buildings;
           Adress = adress;
        }    
    }   
}
