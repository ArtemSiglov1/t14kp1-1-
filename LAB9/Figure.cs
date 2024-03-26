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
       
    }
}
