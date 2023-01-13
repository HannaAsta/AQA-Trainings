namespace Candidate
{
    public class SubjectScore
    {
        private const uint MaxScore = 10;
        private uint _score;
        public string Subject { get; set; }
        
        public uint Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value <= MaxScore)
                {
                    _score = value;
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
