using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectCycleDirectedGraph
{
    class Graph
    {
        int Vertex;
        List<List<int>> adj = new List<List<int>>();
        bool[] Withe;


        public Graph(int V)
        {
            Vertex = V;
            Withe = new bool[V];
            for (int i = 0; i < V; i++)
            {
                adj.Add(new List<int>());
            }
        }

        public void AddEdge(int Source, int Destination)
        {

            adj[Source].Add(Destination);
            Withe[Source] = true;
        }

        public void Detect()
        {
            bool[] Gray = new bool[Vertex];
            bool[] Black = new bool[Vertex];

            for (int i = 0; i < Vertex; i++)
            {
                if (Withe[i])
                {
                    DetectUtil(Gray, Black, i);
                }
            }
        }

        public void DetectUtil(bool[] Gray, bool[] Black, int Vertex)
        {
            Stack<int> S = new Stack<int>();
            Withe[Vertex] = false;
            Gray[Vertex] = true;

            foreach (var child in adj[Vertex])
            {
                if (Withe[child] || !Black[child])
                {
                    if(!Gray[child])
                        DetectUtil(Gray, Black, child);
                    else
                    {
                        for (int i = 0; i < Gray.Length; i++)
                        {
                            if (Gray[i])
                            {
                                Console.Write(i + " ,");
                                Gray[i] = false;
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            
            
            Black[Vertex] = true;
            Gray[Vertex] = false;
            
        }
    }
}
