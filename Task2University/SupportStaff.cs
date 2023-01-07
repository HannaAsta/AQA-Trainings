using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2University
{
    public enum Position
    {
        Securityguard,
        Cleanperson,
        Driver

    }
    public class SupportStaff : UniversityEmployee
    {
    Position position;
    public SupportStaff(Person person, long taxiID, Position position): base(person, taxiID) 
        {
            this.position = position;
        }
    }
}
