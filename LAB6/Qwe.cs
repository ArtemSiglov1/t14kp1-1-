using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
   abstract class Qwe
    {
        public string Name { get; set; }
        public int S {  get; set; }
        public Qwe() { }
        public Qwe(string name, int s) {  Name = name; S = s; }
        public abstract override string ToString();// { return $"{Name}\n{S}"; }
        public virtual double SPercent() 
        {
            int allS = 149939063;
            int percent=allS / 100;


            return S/percent; 
        }
    }
}
