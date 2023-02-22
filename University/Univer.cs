namespace University
{
    public class Univer
    {
        public List<UniversityEmployee> Employees { get; private set; } = new List<UniversityEmployee>();
        public Rector Rector;
        public List<Building> Buildings { get; set; }
        public Adress Adress;
        public Univer(Rector rector, Adress adress, List<Building> buildings)
        {
            Rector = rector;
            Buildings = buildings;
            Adress = adress;
        }
        public bool AddEmployee(UniversityEmployee employee)
        {
            if (Employees.Contains(employee))
            {            
              return false;
            }    
            Employees.Add(employee);
            return true;
        }
    }
}
