using System.Net.Sockets;

namespace candidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addr = new Address(15, 1, "Stadionnaya", "Minsk");
            Person person = new Person("Vasya", "Pupkin", addr);
            Candidate candidate = new Candidate(person);
            Candidate[] candidates = new Candidate[5];
        }
    }
}