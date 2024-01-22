using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// не статический класс описывающий точку 
    /// </summary>
    internal class Point
    {
        /// <summary>
        /// внутренние поля описывающие координаты точек 
        /// </summary>
        private double x, y;
        /// <summary>
        ///Внешнее поле для подсчета количества созданных экземпляров 
        /// </summary>
        public static int count;
        /// <summary>
        ///  статический конструктор Point(), который инициализирует статическую переменную count нулевым значением;
        /// </summary>
        static Point()
        {
            count = 0;
        }
        /// <summary>
        ///    нестатический конструктор Point(double, double) с двумя параметрами, которые инициализируют одноименные внутренние поля класса;
        /// </summary>
        /// <param name="x">описывающий поле х</param>
        /// <param name="y">описывающий поле у</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            //   count++;
            Point.count++;
        }
        /// <summary>
        /// нестатический конструктор Point() без параметров, который инициализирует внутренние поля класса значением 1.0;
        /// </summary>
        public Point()
        {
            this.x = 1.0;
            this.y = 1.0;
            count++;
        }
        /// <summary>
        /// метод для возврата значения х
        /// </summary>
        /// <returns>значение х</returns>
        public double getX()
        {
            return x;
        }
        /// <summary>
        /// метод для возврата значения y
        /// </summary>
        /// <returns>значение у</returns>
        public double getY()
        {
            return y;
        }
        /// <summary>
        /// метод для инициальзации поля х
        /// </summary>
        /// <param name="x">описывающий поле х</param>
        public void setX(double x)
        {
            this.x = x;
        }
        /// <summary>
        /// метод для инициализации поля у
        /// </summary>
        /// <param name="y">описывающий поле у</param>
        public void setY(double y)
        {
            this.y = y;
        }
        /// <summary>
        /// метод для вывода координат точки
        /// </summary>
        /// <returns>значение х и у</returns>
        public override string ToString()
        {
            return $"Координаты точки:{getX():f1}\t{getY():f1}";
        }
        //public static void LenghtPoints(double x,double y,double x1,double y1)
        // {
        //     Console.WriteLine(Math.Sqrt(Math.Pow(x1-x,2)+(Math.Pow(y1-y,2))));
        // }
        public static void LenghtPoints(Point p1,Point p2)
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + (Math.Pow(p1.y - p2.y, 2))));
        }

    }
}
