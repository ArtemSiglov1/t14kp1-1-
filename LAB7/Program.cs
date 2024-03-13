using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Sklad.Sklad1 sklad11 = new Sklad.Sklad1("Motors", 10, 200);
                Sklad.Sklad1 sklad1 = new Sklad.Sklad1("Car", 5, 20000);
                Sklad.Sklad1 sklad12 = new Sklad.Sklad1("Wheel", 20, 50);
                Sklad.Sklad1 sklad = Sklad.Sklad1.Init();
                List<Sklad.Sklad1> sklads = new List<Sklad.Sklad1> { sklad1, sklad11, sklad12, sklad };
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine($"1-Info\n2-all item price\nend");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            foreach (var item in sklads)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        case 2:
                            foreach (var item in sklads)
                            {
                                Console.WriteLine(item.AllPrice());
                            }
                            break;
                        case 3: flag = false; break;

                        default: Console.WriteLine("not correct data"); break;
                    }
                }
            }
            catch { Main(); }
            

        }
    }
}
