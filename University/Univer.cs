namespace University
{
    internal class Univer
    {
        public List<UniversityEmployee> Employees { get; set; } = new List<UniversityEmployee>();
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
            bool isExist = Employees.Exists(empl => empl.Equals(employee));
            if (!isExist) 
            {
                Employees.Add(employee);
            }    
            return !isExist;
        }
    }
}
