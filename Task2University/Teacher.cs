using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2University
{
    public class Teacher : UniversityEmployee
    {

        public string[] course;
                
        public Teacher(Person person, long taxID, string[] course): base (person,taxID)
        {            
            this.course = course;

        }

        public override string GetOfficialDuties()
        {
            return string.Join(", ",course);
        }
    }

}
