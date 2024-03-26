using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    abstract class Shool
    {
        public int NomKab {  get; set; }
        public Shool() { }
        public Shool(int nomKab) { NomKab = nomKab; }
        public abstract void SearchPC(List<PC> n);

    }
}
