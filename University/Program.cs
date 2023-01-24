using System.Linq;
using System.Security.Claims;
using University;
using static University.Positions;

internal class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Koka", "Klava");
        var person2 = new Person("Fotus", "Vlad");
        var person3 = new Person("Huk", "Zinaida");
        var person4 = new Person("Huk", "Vova");
        var person5 = new Person("Burak", "Ivan");
        var person6 = new Person("Hukis", "Daryia");

        var addr1 = new Adress(12, "Plechanova", "Minsk");
        var addr2 = new Adress(152, "Halturina", "Minsk");
        var addr3 = new Adress(45, "Stadionnaya", "Minsk");
        var addr4 = new Adress(85, "Pionerskaya", "Minsk");
        var addr5 = new Adress(442, "Veselaya", "Minsk");


        var rector = new Rector(person1, 55453312, "+48-551-12-54");
        var teacher = new Teacher(person2, 5471121, new List<string> { "chemistry", "mathematic" }, "Ph.D");
        var teacher1 = new Teacher(person6, 544554, new List<string> { "mathematic" }, "Ph.D");

        var staff = new SupportStaff(person3, 122455, Position.SecurityGuard);
        var staff1 = new SupportStaff(person4, 5445, Position.CleanPerson);
        var staff2 = new SupportStaff(person5, 445454, Position.SecurityGuard);

        List<UniversityEmployee> employees = new List<UniversityEmployee> 
        { 
            rector,
            teacher,
            staff,
            staff1,
            staff2,
            teacher1
        };

        
        Room room1 = new Room(545, "for lecturing");
        Room room5 = new Room(545, "for lecturing");
        Room room2 = new Room(231, "for laboratory works");
        Room room3 = new Room(196, "for seminar works");
        Room room4 = new Room(745, "secondary");


        Building build1 = new Building(new List<Room> { room1, room2 }, addr1);
        Building build2 = new Building(new List<Room> { room3, room4, room5 }, addr2);

        Univer univer = new Univer(rector, addr5, new List<Building> { build1, build2 });
        foreach (UniversityEmployee employee in employees)
        {
            univer.AddEmployee(employee);
        }
        // task 1
        Console.WriteLine("Enter employee letter:");
        var letter = Console.ReadLine();

        var sortedEmployees = univer.Employees.Where(x => x.Person.Last.StartsWith(letter)).OrderBy(x => x.TaxId);

        var outputEmployees = sortedEmployees.Select(x => $"{x.Person.Last}: {x.TaxId}");
        Console.WriteLine(string.Join(", ", outputEmployees));

        // task 2
        Console.WriteLine("Enter course:");
        var course = Console.ReadLine();

        var courseTeachers = univer.Employees.Where(x => x is Teacher && (x as Teacher).Courses.Contains(course));
        Console.WriteLine(string.Join(", ", courseTeachers.Select(x => $"{x.Person.First} {x.Person.Last}")));

        // task 3
        Console.WriteLine(string.Join(", ", univer.Employees.Select(x => $"{x.TaxId}")));

        // task 4
        Console.WriteLine("Enter room number:");
        var numberStr = Console.ReadLine();
        int number = 0;
        int.TryParse(numberStr, out number);

        var buildingsWithRoomNumber = univer.Buildings.Where(building => building.Rooms.Any(room => room.Number == number));

        Console.WriteLine(string.Join(", ", buildingsWithRoomNumber.Select(building => building.Adress.ToString())));

        // task 5
        var building = univer.Buildings.MaxBy(building => building.Rooms.Count());
        Console.WriteLine(building.Adress.ToString());

        // task 6
        var groupedEmployees = univer.Employees.GroupBy(employee => employee.Person.Last);
        var maxOccur = groupedEmployees.MaxBy(gr => gr.LongCount());
        Console.WriteLine($"{maxOccur.Key}: {maxOccur.LongCount()}");
    }
}
