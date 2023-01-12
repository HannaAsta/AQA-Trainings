// See https://aka.ms/new-console-template for more information
using University;

public class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Koka", "Klava");
        Person person2 = new Person("Fotus", "Vlad");
        Person person3 = new Person("Huk", "Zinaida");
        Person person4 = new Person("Gusovski", "Vova");
        Person person5 = new Person("Burak", "Ivan");

        Adress addr1 = new Adress(12, "Plechanova", "Minsk");
        Adress addr2 = new Adress(152, "Halturina", "Minsk");
        Adress addr3 = new Adress(45, "Stadionnaya", "Minsk");
        Adress addr4 = new Adress(85, "Pionerskaya", "Minsk");
        Adress addr5 = new Adress(442, "Veselaya", "Minsk");


        Rector rector = new Rector(person1, 55453312, "+48-551-12-54");
        Teacher teacher = new Teacher(person2, 5471121, new string[]{ "chemistry" }, "Ph.D");

        SupportStaff staff = new SupportStaff(person3, 122455, Position.SecurityGuard);
        SupportStaff staff1 = new SupportStaff(person4, 5445, Position.CleanPerson);
        SupportStaff staff2 = new SupportStaff(person5, 445454, Position.SecurityGuard);

        UniversityEmployee[] employees = { rector, teacher, staff, staff1, staff2 };

        Room room1 = new Room(545, "for lecturing");
        Room room2 = new Room(231, "for laboratory works");
        Room room3 = new Room(196, "for seminar works");
        Room room4 = new Room(745, "secondary");

        Building build1 = new Building(new Room[] { room1, room2 },addr1);
        Building build2 = new Building(new Room[] { room3, room4 }, addr2);
        
        Univer univer = new Univer(rector, addr5, employees, new Building[] { build1, build2 });
    }
}
