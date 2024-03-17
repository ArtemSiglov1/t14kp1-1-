using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17)	книга, учебник, словарь;
            //12)	страна, королевство, государство;
            List<Qwe> qwes = new List<Qwe>();

            qwes.Add(Country.Init());
            qwes.Add(Kingdom.Init());
            qwes.Add(Gosud.Init());
            
            foreach(var q in qwes)
            {
                Console.WriteLine($"{q.ToString()}\n{q.SPercent()}");
            }
            Console.ReadLine();
        }
    }
}
