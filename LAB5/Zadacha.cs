using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class Zadacha
    {
        public int Speed1 {  get; set; }
        public int Speed2 { get; set;}
        public int Rast {  get; set;}
        public Zadacha() { }
        public Zadacha(int speed1, int speed2,int rast) 
        {
            Speed1 = speed1;
            Speed2 = speed2;
            Rast = rast;
        }
        public double Time()
        {
            int speedRaz = Speed2 - Speed1;
            double time = Rast / speedRaz;
            return time;
        }
        public static Zadacha Init() 
        {
            try
            {
                Console.Write("Speed1:");
                int speed1 = int.Parse(Console.ReadLine());
                Console.Write("Speed2:");
                int speed2 = int.Parse(Console.ReadLine());
                Console.Write("Rast:");
                int rast = int.Parse(Console.ReadLine());
                return new Zadacha(speed1, speed2, rast);
            } 
            catch { return Init(); }
        }
    }
}
