// See https://aka.ms/new-console-template for more information
using System.Security.Claims;
using University;
using static University.Positions;

internal class Program
{
    static void Main(string[] args)
    { 
        Person person1 = new Person("Koka", "Klava");
        Person person2 = new Person("Fotus", "Vlad");
        Person person3 = new Person("Huk", "Zinaida");
        Person person4 = new Person("Gusovski", "Vova");
        Person person5 = new Person("Burak", "Ivan");
        Person person6 = new Person("Hukis", "Daryia");

        Adress addr1 = new Adress(12, "Plechanova", "Minsk");
        Adress addr2 = new Adress(152, "Halturina", "Minsk");
        Adress addr3 = new Adress(45, "Stadionnaya", "Minsk");
        Adress addr4 = new Adress(85, "Pionerskaya", "Minsk");
        Adress addr5 = new Adress(442, "Veselaya", "Minsk");


        Rector rector = new Rector(person1, 55453312, "+48-551-12-54");
        Teacher teacher = new Teacher(person2, 5471121, new List<string> { "chemistry" }, "Ph.D");
        Teacher teacher1 = new Teacher(person6, 544554, new List<string> { "mathematic" }, "Ph.D");

        SupportStaff staff = new SupportStaff(person3, 122455, Position.SecurityGuard);
        SupportStaff staff1 = new SupportStaff(person4, 5445, Position.CleanPerson);
        SupportStaff staff2 = new SupportStaff(person5, 445454, Position.SecurityGuard);

        List<UniversityEmployee> employees = new List<UniversityEmployee> { rector, teacher, staff, staff1, staff2, teacher1 };

        
        Room room1 = new Room(545, "for lecturing");
        Room room5 = new Room(545, "for lecturing");
        Room room2 = new Room(231, "for laboratory works");
        Room room3 = new Room(196, "for seminar works");
        Room room4 = new Room(745, "secondary");


        Building build1 = new Building(new List<Room> { room1, room2 },addr1);
        Building build2 = new Building(new List<Room> { room3, room4 }, addr2);
        
        Univer univer = new Univer(rector, addr5, new List<Building> { build1, build2 });
        foreach (UniversityEmployee employee in employees)
        {
            univer.AddEmployee(employee);
        }
    }
}
