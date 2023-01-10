namespace candidate
{
    public class Candidate
    {
        Person person;
        SubjectScore[] score;

        public string Street
        {
            get 
            {
                return person.Address.Street;
            }
        }

        public Candidate(Person person, SubjectScore[] score)
        {
            this.person = person;
            this.score = score;
        }
       
        public int GetScore(string nameSub)
        {
            foreach (SubjectScore score in score)
            {
                if (score.Subject == nameSub)
                    return score.Score;         
            }
            return 0;
        }   
    }
    
}

