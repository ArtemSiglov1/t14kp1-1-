using LAB6._17в;
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
            //12)	страна, королевство, государство;
            //List<Qwe> qwes = new List<Qwe>();

            //qwes.Add(Country.Init());
            //qwes.Add(Kingdom.Init());
            //qwes.Add(Gosud.Init());

            //foreach(var q in qwes)
            //{
            //    Console.WriteLine($"{q.ToString()}\n{q.SPercent()}");
            //}
            //17 книга словарь учебник
            Dictionary dictionary = new Dictionary(100);
            Textbook textbook = new Textbook(100,"df");
            Book book = new Book(100, "df", "I");
            Console.WriteLine($"{dictionary.ToString()}\n {textbook.ToString()}\n {book.ToString()}");
            Console.ReadLine();
        }
    }
}
