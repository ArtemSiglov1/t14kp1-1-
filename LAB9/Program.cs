using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prizma prizma = new Prizma(12,15,200);
            Console.WriteLine(prizma.S());
            Konus konus = new Konus(10,5);
            Console.WriteLine(konus.S());
            List<PC>n= new List<PC> {new PC(31,11),new PC(32,11),new PC(31,1),new PC(35,5) };
            PC pC= new PC(31,11);
            pC.SearchPC(n);
            Console.ReadKey();
        }
    }
}
