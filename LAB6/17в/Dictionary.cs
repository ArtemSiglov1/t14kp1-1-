using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6._17в
{
    internal class Dictionary
    {
        public int KvoList {  get; set; }
        public Dictionary() { }
        public Dictionary(int kvoList) { 
        KvoList = kvoList;
        }
        public override string ToString()
        {
            return $"{KvoList}";
        }
        public static Dictionary Init()
        {
            int count = int.Parse(Console.ReadLine());
            return new Dictionary(count);
        }
    }
}
