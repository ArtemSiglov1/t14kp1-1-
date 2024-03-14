using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Kingdom:Country
    {
        public Kingdom() { }
        public Kingdom(string name,double s):base(name,s) { }
        public override string Print()
        {
            return base.Print();
        }
        new static public Kingdom Init()
        {
            try
            {
                Console.WriteLine();
                string name = Console.ReadLine();
                Console.WriteLine();
                double s = double.Parse(Console.ReadLine());
                return new Kingdom(name, s);
            }
            catch { return Init(); }
        }
    }
}
