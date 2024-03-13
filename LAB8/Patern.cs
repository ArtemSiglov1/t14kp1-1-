using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Patern:Bilet
    {
        public Bilet bilet=new Bilet();
       public  Exam exam=new Exam();
        public void Exam()
        {
            bilet.Zadachi = new List<string> {"2+2","2*2","2*3","3*3","3+3","4+4","4*4","4+1","4*1","6*2" };
            bilet.Q = new List<string> {"а?","d?","f?","g?","h?","k?","j?","n?","m?","c?","x?","z?","e?","w?","q?","r?","t?","y?","u?","i?","o?" };
            for(int i = 1;i<10;i++)
            {
                Bilets.Add(Q[i]+ Q[bilet.Q.Count - i] +Zadachi[i]);

            }
            foreach (var v in Bilets)
            {
                Console.WriteLine(v);
            }
        }
    }
}
