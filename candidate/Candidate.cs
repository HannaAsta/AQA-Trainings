namespace Candidate
{
    public class Candidate
    {
        public Person Person { get; set; }
        public SubjectScore[] Score { get; set; }

        public string Street
        {
            get 
            {
                return Person.Address.Street;
            }
        }

        public Candidate(Person person, SubjectScore[] score)
        {
            Person = person;
            Score = score;
        }
       
        public uint GetScore(string nameSub)
        {
            foreach (SubjectScore score in Score)
            {
                if (score.Subject == nameSub)
                    return score.Score;         
            }
            return 0;
        }   
    }
    
}

