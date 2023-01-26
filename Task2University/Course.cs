namespace Task2University
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Course(string name, string descript)
        {
            Name = name;   
            Description = descript;
        }
    }
}