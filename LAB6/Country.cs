using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Country:Qwe
    {
       
        public Country() { }
        
        public Country(string name, int s):base(name,s) 
        {
            S = s;
        }
        public override string ToString()
        {
            return $"{Name}\n{S}";
        }
        public override double SPercent()
        {
            return base.SPercent();
        }
        public static Country Init()
        {
            try
            {
                Console.WriteLine("name");
                string name = Console.ReadLine();
                Console.WriteLine("s");
                int s = int.Parse(Console.ReadLine());
                return new Country(name, s);
            }
            catch { return Init(); }
        }
    }
}
