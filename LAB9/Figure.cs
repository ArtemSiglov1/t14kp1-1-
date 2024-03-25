using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    abstract class Figure
    {
        public int A {  get; set; }
        public Figure() { }
        public Figure(int a)
        {
            A = a;
        }
        public abstract double S();
        // S полн . = S бок . + 2 ⋅ S осн .  Sб. п. = P•H P = 3 ⋅ a Sосн = V/h
        //public int A {  get; set; }
        //public int H { get; set; }
        //public int V { get; set; }
        //public Figure() { }
        //public Figure(int a, int h, int v)
        //{
        //    A = a;
        //    H = h;
        //    V = v;
        //}
        //public double S()
        //{
        //    double sO = V / H;
        //    int P = 3 * A;
        //    int sB = P * H;
        //    return sB+2*sO ;
        //}
    }
}
