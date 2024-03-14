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
            Country country=new Country("Russia", 17100000);
            Kingdom kingdom = new Kingdom("Russia", 17100000);
            Gosud gosud =  Gosud.Init();
            List<Country> strings=new List<Country>() {country,kingdom,gosud };
            foreach(var elem in strings)
            {
                Console.WriteLine(elem.ToString());
            }
            Console.ReadLine();
        }
    }
}
