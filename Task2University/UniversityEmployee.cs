using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task2University
{
    public class UniversityEmployee
    {
        
         
        public Person person;
        public long taxiID;

        public UniversityEmployee(Person person, long taxiID)
        {
            this.person = person;
            this.taxiID = taxiID;
        }
        virtual public string GetOfficialDuties()
        {
            return "Go to work";
        }


    }

}
