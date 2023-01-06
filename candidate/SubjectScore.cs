using System;

namespace candidate
{
    public class SubjectScore
    {
        int score;
        string subject;
        public SubjectScore(int score_, string subject_)
        {
            this.score = score_;
            this.subject = subject_;
        }
        public string Getsubject()
        { 
            return subject;
        }
        public int Getscore() 
        {
            return score;
        }
    }
}
