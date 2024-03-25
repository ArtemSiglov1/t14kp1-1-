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
            Console.ReadKey();
        }
    }
}
