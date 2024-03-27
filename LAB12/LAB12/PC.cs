using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    internal class PC
    {
        public string Name {  get; set; }
        public PC() { }
        public PC(string name)
        {
            Name = name;
        }
        public static Exception Iron()
        {
            return new Exception("отказ «железа»");
        }
        public static Exception NoCorrectMove()
        {
            return new Exception("неправильные действия оператора");
        }
        public static Exception MisteakOS()
        {
            return new Exception("сбой в операционной системе");
        }
        public static Exception Peregrev()
        {
            return new Exception("перегрев");
        }
        public static Exception AllExceptoin()
        {
            Random random = new Random();
            switch (random.Next(1,5))
            {
                case 1:return Iron();
                case 2:return NoCorrectMove();
                case 3:return MisteakOS();
                case 4:return Peregrev();
                default:return new Exception("Работа Коректная");
            }
        }
    }
}
