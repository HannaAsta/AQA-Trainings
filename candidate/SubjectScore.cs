namespace Candidate
{
    public class SubjectScore
    {
        private const uint MaxScore = 10;
        private uint score;
        public string Subject { get; private set; }
        public uint Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value <= MaxScore)
                {
                    score = value;
                }
            }   
        }
        public SubjectScore(uint score, string subject)
        {
            Score = score;
            Subject = subject;
        }
    } 
}
