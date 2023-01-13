using Task2University;
using static Task2University.Positions;


Person Person  = new Person("Varvara", "Pupkina");
Person person1 = new Person(" Homik", "Fine");
Person person2 = new Person("Gusik", "Kokis");
Person person3 = new Person("Makalin", " Danya");
Person person4 = new Person(" Halturina", "Daryia");

Course[] courses = new Course[] {
    new Course("philosophy", "bla-bla"),
    new Course("mathematics", "sin-kos"),
    new Course("physical Culture","la-la") };
Teacher teacher = new Teacher(Person, 12165465 , courses);


SupportStaff staff = new SupportStaff(person1, 122455, Position.Driver);
SupportStaff staff1 = new SupportStaff(person2, 5445, Position.CleanPerson);
SupportStaff staff2 = new SupportStaff(person3, 445454, Position.SecurityGuard);


Course[] courses4 = new Course[] {
    new Course("chemistry", ""),
    new Course("history", "")
};

DegreeTeacher degree = new DegreeTeacher (person4, 126546 , courses4, "doctor", "professor");

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