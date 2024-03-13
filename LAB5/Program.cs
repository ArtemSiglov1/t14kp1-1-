using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadacha zadacha = Zadacha.Init();
            Console.WriteLine(zadacha.Time());
            Console.ReadKey();
        }
    }
}
