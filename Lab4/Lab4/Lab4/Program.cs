using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ввести размерност коллекции:");
            //int n=Convert.ToInt32(Console.ReadLine());
            //List<Point>list = new List<Point>(n);
            //for(int i = 0; i < list.Capacity; i++)
            //{
            //    Console.Write("Введите x=");
            //    int x= Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите y=");
            //    int y= Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите название точки:");
            //    string namer = Console.ReadLine();
            //    list.Add(new Point(x,y,namer));
            //}
            //Console.Write("Ввести индекс точки старта:");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ввести индекс точки конца:");
            //int end = Convert.ToInt32(Console.ReadLine());
            //if (list[start].S(list[start].X, list[start].Y, list[start + 1].X, list[start + 1].Y) < list[start].S(list[start].X, list[start].Y, list[start - 1].X, list[start - 1].Y))
            //{

            //    //три точки
            //    Console.WriteLine($"{list[start].NameR}:{list[start + 1].NameR}:{list[end].NameR}");
            //}
            //else
            //{
            //    //Три точки
            //    Console.WriteLine($"{list[start].NameR}:{list[end - 1].NameR}:{list[end].NameR}");
            //}

            var g = new Graph();

            //добавление вершин
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");

            //добавление ребер
            g.AddEdge("A", "B", 22);
            g.AddEdge("A", "C", 33);
            g.AddEdge("A", "D", 61);
            g.AddEdge("B", "C", 47);
            g.AddEdge("B", "E", 93);
            g.AddEdge("C", "D", 11);
            g.AddEdge("C", "E", 79);
            g.AddEdge("C", "F", 63);
            g.AddEdge("D", "F", 41);
            g.AddEdge("E", "F", 17);
            g.AddEdge("E", "G", 58);
            g.AddEdge("F", "G", 84);

            var dijkstra = new Dijkstra(g);
            var path = dijkstra.FindShortestPath("A", "G");
            Console.WriteLine(path);
            Console.ReadKey();
        }
    }
}
