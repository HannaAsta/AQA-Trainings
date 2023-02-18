using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace University
{
    public class Person
    {
        public string Last { get; private set; }
        public string First { get; set; }

        public int FullNameLength 
        {
            get
            {
                return Last.Length + First.Length;
            }
        }
        public Person(string lastName, string firstName)
        {
            Last = lastName;
            First = firstName;

            if (FullNameLength >= 15)
                throw new ArgumentException("Last name and Fist name too long");      
            
        }     
    }
}
