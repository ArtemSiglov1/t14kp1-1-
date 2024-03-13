using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string NameR {  get; set; }
        public Point (int x, int y,string namer)
        {
            X = x;
            Y = y;
            NameR = namer;
        }
        public void Print()
        {
            Console.WriteLine($"x={X},y={Y}, Название точки:{NameR}");
        }
        public double S(int x1,int y1,int x2,int y2)
        {
            return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }
    }
}
