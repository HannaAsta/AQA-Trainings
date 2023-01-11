using Task2University;

Person person  = new Person("Varvara", "Pupkina");
Person person1 = new Person(" Homik", "Fine");
Person person2 = new Person("Gusik", "Kokis");
Person person3 = new Person("Makalin", " Danya");
Person person4 = new Person(" Halturina", "Daryia");

Course[] course = new Course[] {
    new Course("phylosofia", "bla-bla"),
    new Course("mathematics", "sin-kos"),
    new Course("fizra","la-la") };
Teacher teacher = new Teacher(person, 12165465 , course);


SupportStaff staff = new SupportStaff(person1, 122455, Position.Driver);
SupportStaff staff1 = new SupportStaff(person2, 5445, Position.Cleanperson);
SupportStaff staff2 = new SupportStaff(person3, 445454, Position.Securityguard);


Course[] course4 = new Course[] {
    new Course("chimical", ""),
    new Course("history", "")
};
DegreeTeacher degree = new DegreeTeacher (person4, 126546 , course4, "doctor", "professor");

UniversityEmployee[] employees = { teacher, staff, staff1, staff2, degree };

Console.WriteLine("Teaches:");
foreach (var employee in employees)
{
    if (employee is Teacher)
    {
       Console.WriteLine(employee.PersonInfo);
    }
}

Console.WriteLine();
Console.WriteLine("All employees:");
foreach (var employee in employees)
{
     Console.WriteLine(employee.GetOfficialDuties());
}