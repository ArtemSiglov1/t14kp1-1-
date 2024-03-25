using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6._17в
{
    internal class Textbook:Dictionary
    {
       public string Name { get; set; }
        public Textbook() { }
        public Textbook(int kvoList,string name):base(kvoList) { Name = name; }
        public override string ToString() { return $"{Name} {base.ToString()}"; }
        public new static Textbook Init()
        {
            int count = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            return new Textbook(count, name);
        }
    }
}
