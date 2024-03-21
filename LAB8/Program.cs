using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam bilet = new Exam("Siglov Artem Vitaleivich",new DateTime(2007,03,23));
           bilet.PrintMark();
            Console.ReadLine();
        }
    }
}
