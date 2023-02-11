using System.Runtime.CompilerServices;
using University;

namespace University
{
    public class UniversityEmployeeComparer : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee x, UniversityEmployee y)
        {
            return x.Person.FullNameLength.CompareTo(y.Person.FullNameLength);
        }
    }
}
