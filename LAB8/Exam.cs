using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Exam:Bilet
    {
       public string FIO {  get; set; }
        public DateTime Date { get; set; }
        public int Mark {  get; set; }
        public List<int> Marks { get; set; }
        public Exam() { }
        public Exam(string fIO, DateTime date)
        {
            FIO = fIO;
            Date = date;
            Examen();
            Mark = 1;
            
                Marks = new List<int> { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            
        }
        public void PrintMark()
        {
            Console.WriteLine("1 obsh def all");
            int output = int.Parse(Console.ReadLine());
            switch (output)
            {
                case 1: foreach (int i in Marks)
                        {
                        Mark += i;
                        }
                    Console.WriteLine($"Fio-{FIO}\tMark-{Mark/= 3}");
                    break;
                default:foreach (int i in Marks) { Console.WriteLine( $"Fio-{FIO}\tMark-{i}"); }break;
                    
            }
        }
        private void Examen()
        {
            Zadachi = new List<string> { "2+2", "2*2", "2*3", "3*3", "3+3", "4+4", "4*4", "4+1", "4*1", "6*2" };
            Q = new List<string> { "а?", "d?", "f?", "g?", "h?", "k?", "j?", "n?", "m?", "c?", "x?", "z?", "e?", "w?", "q?", "r?", "t?", "y?", "u?", "i?" };
            Bilets = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Bilets.Add("1-" + Q[i] + " 2-" + Q[Q.Count - 1 - i] + " 3-" + Zadachi[i]);
            }
            Random rnd = new Random();
            string bilet = Bilets[rnd.Next(0, 10)];
            Console.WriteLine(bilet);
            Answer = new List<string>();
            Answer.Add("1-" + Console.ReadLine() + " 2-" + Console.ReadLine() + " 3-" + Console.ReadLine());
            foreach (var elem in Answer)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
