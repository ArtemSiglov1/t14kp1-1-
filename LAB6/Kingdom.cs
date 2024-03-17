using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Kingdom:Qwe
    {
        public Kingdom() { }
        public Kingdom(string name,int s):base(name,s) { }
        public override string ToString()
        {
            return $"{Name}\n{S}";
        }
        public override double SPercent()
        {
            return base.SPercent();
        }
         static public Kingdom Init()
        {
            try
            {
                Console.WriteLine("name");
                string name = Console.ReadLine();
                Console.WriteLine("s");
                int s = int.Parse(Console.ReadLine());
                return new Kingdom(name, s);
            }
            catch { return Init(); }
        }
    }
}
