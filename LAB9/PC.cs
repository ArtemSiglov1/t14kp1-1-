using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    internal class PC:Shool
    {
        public int InventNom {  get; set; }
        public PC() { }
        public PC(int nomKab,int inventNom):base(nomKab)
        {
            InventNom = inventNom;
        }
        public override void SearchPC(List<PC> n)
        {
            n =new List<PC>{ new PC(31, 11),new PC(32, 11),new PC(31, 1),new PC(35, 5)};
            Console.WriteLine("Способ поиска:1-номер кабинета,2-табельный номер");
            int search = int.Parse(Console.ReadLine());
                switch (search)
                {
                    case 1: int nomkab = int.Parse(Console.ReadLine());
                        foreach (var i in n)
                        {
                            if (i.NomKab == nomkab)
                            {
                                Console.WriteLine(i.ToString());
                            }
                        }
                        break;
                    case 2: int tabNom = int.Parse(Console.ReadLine());
                        foreach (var i in n)
                        {
                            if (i.InventNom == tabNom)
                            {
                                Console.WriteLine(i.ToString());
                            }
                        }
                        break;
                    default:SearchPC(n);break;
                }
                
                    
            }
        public override string ToString()
        {
            return $"NomKab-{NomKab}\nInventNom-{InventNom}";
        }
    }
    }

