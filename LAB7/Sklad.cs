using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    internal class Sklad
    {
       
       public struct Sklad1
        {
            public string Name {  get; set; }
            public int Count {  get; set; }
            public int Price {  get; set; }
            public Sklad1(string name,int count,int price) 
            {
             Name = name;
                Count = count;
                Price = price;
            } 
            public int AllPrice()
            {
                Console.Write(Name+":");
                return Price*Count;
            }
            public override string ToString()
            {
                return $"Name:{Name}\nCount:{Count}\nPrice:{Price}";
            }
            public static Sklad1 Init()
            {
                try
                { 
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Count:");
                int count = int.Parse(Console.ReadLine());
                Console.Write("Price:");
                int price = int.Parse(Console.ReadLine());
                return new Sklad1(name, count, price);
                }
                catch { return Init(); }
            }
        }
    }
}
