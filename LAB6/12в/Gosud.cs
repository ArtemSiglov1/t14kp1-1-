using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Gosud:Qwe
    {
        public Gosud() { }
        public Gosud(string name,int s):base(name,s) { }
        public override string ToString()
        {
            return $"{Name}\n{S}";
        }
        public override double SPercent()
        {
            return base.SPercent();
        }
         static public Gosud Init()
        {
            try
            {
                Console.WriteLine("name");
                string name = Console.ReadLine();
                Console.WriteLine("s");
                int s = int.Parse(Console.ReadLine());
                return new Gosud(name, s);
            }
            catch { return Init(); }
        }
    }
}
