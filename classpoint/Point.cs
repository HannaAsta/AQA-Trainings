namespace classpoint
{
    public class Point
    {
        public double x;
        public double y;
        public double distance(Point pt) 
        {
            return Math.Sqrt(Math.Pow((pt.x - x), 2) + Math.Pow((pt.y - y), 2)); 
        }                  

        public void print()
        {
            Console.WriteLine($"x= {x},y= {y}");

        }

    }
}
