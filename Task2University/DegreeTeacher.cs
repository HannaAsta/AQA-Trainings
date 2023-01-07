using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2University
{
    public class DegreeTeacher : Teacher
    {
        string Sciencedegree;
        string Degree;
        public DegreeTeacher(Person person, long taxID, string course, string Sciencedegree, string Degree) : base (person, taxID, course)
        {
            this.Sciencedegree = Sciencedegree;
            this.Degree= Degree;

        }               
    }
}
