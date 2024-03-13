using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Exam
    {
       public string FIO {  get; set; }
        public DateTime Date { get; set; }
        public int Mark {  get; set; }
        public List<string> Q {  get; set; }
        public Exam() { }
        public Exam(string fIO, DateTime date, int mark, List<string> q)
        {
            FIO = fIO;
            Date = date;
            Mark = mark;
            Q = q;
        }
        public override string ToString()
        {
            return $"Fio{FIO}\tMark{Mark}";
        }
    }
}
