using System.Runtime.CompilerServices;
using University;

namespace University
{
    public class UniversityEmployeeComparer : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee? x, UniversityEmployee? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x != null && y == null)
            {
                return 1;
            }
            if (x == null && y != null)
            {
                return -1;
            }
            return (x?.Person?.FullNameLength?? 0).CompareTo(y.Person.FullNameLength);
        }
    }
}
