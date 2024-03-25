using System;
using System.Collections.Generic;
using System.Linq;
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
        public override void SearchPC(List<Shool> n)
        {
            Console.WriteLine("Способ поиска:1-номер кабинета,2-табельный номер");
            int search = int.Parse(Console.ReadLine());
            switch (search)
            {
                case 1:int nomkab = int.Parse(Console.ReadLine());
                    foreach(var i in n)
                    {
                        if(i.NomKab==nomkab)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
            }
        }
    }
}
