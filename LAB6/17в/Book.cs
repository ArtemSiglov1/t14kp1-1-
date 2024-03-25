using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6._17в
{
    internal class Book:Textbook
    {
       
        public string Avtor { get; set; }
            public Book() { }
        public Book(int kvoList, string name, string avtor):base(kvoList,name)
        {
            Avtor=avtor;
        }
        public override string ToString()
        {
            return $"{Name} {Avtor} {KvoList}";
        }
        public static new Book Init()
        {
            int count=int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string avtor = Console.ReadLine();
            return new Book(count,name,avtor);
        }
    }
}
