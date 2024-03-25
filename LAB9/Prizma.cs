using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    internal class Prizma:Figure
    {
       // S полн. = S бок . + 2 ⋅ S осн .  Sб.п. = P•H P = 3 ⋅ a Sосн = V / h
        public int H { get; set; }
        public int V { get; set; }
        public Prizma() { }
        public Prizma(int a, int h, int v):base(a)
        {
            H = h;
            V = v;
        }
        public override double S()
        {
            double sO = V / H;
            int P = 3 * A;
            int sB = P * H;
            return sB + 2 * sO;
        }
    }
}
