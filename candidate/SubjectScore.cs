namespace candidate
{
    public class SubjectScore
    {
        public ushort Score { get; private set; }
        public string Subject { get; private set; }

        public SubjectScore(ushort score, string subject)
        {
            Score = score;
            Subject = subject;
        }
    }
}
