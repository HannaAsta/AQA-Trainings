using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace candidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Address addr1 = new Address(15, 1, "Stadionnaya", "Minsk");
            Person person1 = new Person("Vasya", "Pupkin", addr1);

            Address addr2 = new Address(20, 5, "Vostochnaya", "Minsk");
            Person person2 = new Person("Petyia", "Volkov", addr2);

            Address addr3 = new Address(160, 25, "Repina", "Minsk");
            Person person3 = new Person("Katya", "Kos", addr3);

            Address addr4 = new Address(115, 83, "Mulyavina", "Minsk");
            Person person4 = new Person("Maryia", "Kukusina", addr4);

            Address addr5 = new Address(9, 125, "Plechanova", "Minsk");
            Person person5 = new Person("Dmitryi", "Saloho", addr5);


            SubjectScore[] scores1 = { new SubjectScore(5, "math"), new SubjectScore(5, "phyz") };
            SubjectScore[] scores2 = { new SubjectScore(3, "math"), new SubjectScore(3, "phyz") };
            SubjectScore[] scores3 = { new SubjectScore(6, "math"), new SubjectScore(9, "phyz") };
            SubjectScore[] scores4 = { new SubjectScore(7, "math"), new SubjectScore(10, "phyz") };
            SubjectScore[] scores5 = { new SubjectScore(4, "math"), new SubjectScore(4, "phyz") };



            Candidate candidate1 = new Candidate(person1, scores1);
            Candidate candidate2 = new Candidate(person2, scores2);
            Candidate candidate3 = new Candidate(person3, scores3);
            Candidate candidate4 = new Candidate(person4, scores4);
            Candidate candidate5 = new Candidate(person5, scores5);



            Candidate[] candidates = {candidate1, candidate2, candidate3, candidate4, candidate5};

            foreach (Candidate candidate in candidates)
            {
                string street = candidate.GetStreet();
                Console.WriteLine(street);
            }

            int maxScore = 0;
            foreach (Candidate candidate in candidates)
            {
                int score = candidate.Getscore("phyz");
                if (maxScore < score)
                    maxScore = score;
            }
            Console.WriteLine(maxScore);
        }

    }
}