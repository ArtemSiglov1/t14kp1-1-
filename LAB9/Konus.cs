using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    internal class Konus:Figure
    {
        
        public int R {  get; set; }
        public Konus(int a,int r):base(a)
        {
            R = r;
        }
        public override double S()
        {
            return Math.PI*R*A+Math.PI*Math.Pow(R,2);
        }
    }
}
