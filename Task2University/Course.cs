namespace Task2University
{
    public class Course
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public Course(string name, string descript)
        {
            Name = name;   
            Description = descript;
        }
    }
}
