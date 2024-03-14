using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Gosud:Country
    {
        public Gosud() { }
        public Gosud(string name,double s):base(name,s) { }
        public override string Print()
        {
            return base.Print();
        }
        new static public Gosud Init()
        {
            try
            {
                Console.WriteLine();
                string name = Console.ReadLine();
                Console.WriteLine();
                double s = double.Parse(Console.ReadLine());
                return new Gosud(name, s);
            }
            catch { return Init(); }
        }
    }
}
