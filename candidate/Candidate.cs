using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace candidate
{
    public class Candidate
    {
        Person person;
        SubjectScore[] Score;

        public Candidate(Person person_, SubjectScore[] scr)
        {
            person = person_;
            Score = scr;
        }
        public string GetStreet()
        {
            return person.Getstreet();
        }

        public int Getscore(string namesub)
        {
            foreach (SubjectScore score in Score)
            {
                if (score.Getsubject() == namesub)
                    return score.Getscore();         
            }
            return 0;
        }
            
    }
    
}

