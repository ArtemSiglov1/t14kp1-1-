using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Bilet:Exam
    {
        public List<string > Bilets { get; set; }
        public List<string> Zadachi { get;set; }
        public List <string> Answer { get; set; }
        public Bilet() { }
        public Bilet(string fIO,DateTime date,int mark,List<string> q,List<string> bilets, List<string> zadachi, List<string> answer):base(fIO,date,mark,q)
        {
            Bilets = bilets;
            Zadachi = zadachi;
            Answer = answer;
        }
        
    }
}
