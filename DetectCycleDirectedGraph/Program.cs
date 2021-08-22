using System;

namespace DetectCycleDirectedGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph G = new Graph(6);
            G.AddEdge(0, 1);
            G.AddEdge(1, 2);
            G.AddEdge(2, 0);
            G.AddEdge(3, 0);
            G.AddEdge(3, 4);
            G.AddEdge(4, 5);
            G.AddEdge(5, 3);

            G.Detect();
            Console.WriteLine();
        }
    }
}
