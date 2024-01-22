using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            Point point1= new Point(x,y);

            ////point.setX(x);
            ////point.setY(y);
            ////Console.WriteLine(point.ToString());
            //Point[] points= new Point[4];
            //Random rnd = new Random();
            //for (int i = 0; i < points.Length; i++)
            //{
            //    x = rnd.NextDouble() * 10 - 5;
            //    y = rnd.NextDouble() * 10 - 5;
            //    points[i] = new Point(x, y);
            //}
            // Point.LenghtPoints(point1.getX(),point1.getY(),point.getX(),point.getY());
            Point.LenghtPoints(point,point1);
            //foreach (Point p in points)
            //{
            //    Console.WriteLine(p);
            //}

            Console.ReadLine();
        }
    }
}
