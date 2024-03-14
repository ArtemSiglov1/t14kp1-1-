using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Country
    {
        public string Name {  get; set; }
        public double S {  get; set; }
        public Country() { }
        public Country(string name)
        {
            Name=name;
        }
        public Country(string name, double s):this(name) 
        {
            S = s;
        }   
        public virtual string Print()
        {
            return $"Name:{Name}\nS:{S}";
        }
        public static Country Init()
        {
            try
            {
                Console.WriteLine();
                string name = Console.ReadLine();
                Console.WriteLine();
                double s = double.Parse(Console.ReadLine());
                return new Country(name, s);
            }
            catch { return Init(); }
        }
    }
}
