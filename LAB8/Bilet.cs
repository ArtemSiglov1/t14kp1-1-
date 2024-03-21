using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Bilet
    {
        public List<string > Bilets { get; set; }
        public List<string> Zadachi { get;set; }
        public List <string> Answer { get; set; }
        public List<string> Q { get; set; }
        public Bilet() { }
       // public Bilet(string fIO,DateTime date,int mark)//:base(fIO,date,mark)
        //{
           // Exam();
            
        //}
        //public void Exam() 
        //{
        //    Zadachi = new List<string> { "2+2", "2*2", "2*3", "3*3", "3+3", "4+4", "4*4", "4+1", "4*1", "6*2" };
        //    Q = new List<string> { "а?", "d?", "f?", "g?", "h?", "k?", "j?", "n?", "m?", "c?", "x?", "z?", "e?", "w?", "q?", "r?", "t?", "y?", "u?", "i?" };
        //    Bilets = new List<string>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Bilets.Add("1-"+Q[i] +" 2-"+ Q[Q.Count-1 - i] +" 3-"+ Zadachi[i]);
        //    }
        //    Random rnd=new Random();
        //    string bilet=Bilets[rnd.Next(0, 10)];
        //    Console.WriteLine(bilet);
        //    Answer = new List<string>();
        //    Answer.Add("1-" + Console.ReadLine() + " 2-" + Console.ReadLine() + " 3-" + Console.ReadLine());
        //    foreach(var elem in Answer)
        //    {
        //        Console.WriteLine(elem);
        //    }
        // }
           
        
    }
}
