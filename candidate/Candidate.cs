namespace Candidate
{
    public class Candidate
    {
        private Person person;
        private SubjectScore[] score;

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
       
        public uint GetScore(string nameSub)
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

