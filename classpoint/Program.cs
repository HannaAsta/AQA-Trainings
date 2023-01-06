using System;

namespace classpoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point dot1 = new Point();
            dot1.x = 50;
            dot1.y = 6.3f;
            
            Point dot2 = new Point();
            dot2.x = 40;
            dot2.y = 65;

            Point dot3 = new Point();
            dot3.x = 34;
            dot3.y = 4.6f;

            Point dot4 = new Point();
            dot4.x = 80;
            dot4.y = 63;
            
            Point dot5 = new Point();
            dot5.x = 60;
            dot5.y = 45;

            Point dot6 = new Point();
            dot6.y = 80;

            Point dot7 = new Point();
            dot7.x = 61;
            dot7.y = 90;

            Point dot8 = new Point();
            dot8.x = 2;
            dot8.y = 75;

            Point dot9 = new Point();
            dot9.x = 0;
            dot9.y = 64;

            Point dot10 = new Point();
            dot10.x = 88;
            dot10.y = 3;

            Point[] dots = {dot1 , dot2, dot3, dot4, dot5, dot6, dot7, dot8, dot9, dot10 };

            foreach (Point pt in dots)
            {
                pt.print();
            }

            Console.WriteLine(dot5.distance(dot8));
         
        }
    }
}