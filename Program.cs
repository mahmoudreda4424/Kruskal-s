using System;
using System.Collections.Generic;

class Edge : IComparable<Edge>
{
    public int Src, Dest, Weight;

    public Edge(int src, int dest, int weight)
    {
        Src = src;
        Dest = dest;
        Weight = weight;
    }

    public int CompareTo(Edge other)
    {
        return Weight.CompareTo(other.Weight);
    }
}

class Graph
{
    private int Vertices;
    private List<Edge> Edges;

    public Graph(int vertices)
    {
        Vertices = vertices;
        Edges = new List<Edge>();
    }

    public void AddEdge(int src, int dest, int weight)
    {
        Edges.Add(new Edge(src, dest, weight));
    }

    private int Find(int[] parent, int i)
    {
        if (parent[i] != i)
            parent[i] = Find(parent, parent[i]);
        return parent[i];
    }

    private void Union(int[] parent, int[] rank, int x, int y)
    {
        int rootX = Find(parent, x);
        int rootY = Find(parent, y);

        if (rank[rootX] < rank[rootY])
        {
            parent[rootX] = rootY;
        }
        else if (rank[rootX] > rank[rootY])
        {
            parent[rootY] = rootX;
        }
        else
        {
            parent[rootY] = rootX;
            rank[rootX]++;
        }
    }

    public void KruskalMST()
    {
        List<Edge> result = new List<Edge>();

        // Step 1: Sort edges by weight
        Edges.Sort();

        int[] parent = new int[Vertices];
        int[] rank = new int[Vertices];

        for (int v = 0; v < Vertices; ++v)
        {
            parent[v] = v;
            rank[v] = 0;
        }

        int edgeCount = 0;
        int i = 0;

        // Step 2: Iterate through sorted edges and pick valid edges for MST
        while (edgeCount < Vertices - 1 && i < Edges.Count)
        {
            Edge nextEdge = Edges[i++];
            int x = Find(parent, nextEdge.Src);
            int y = Find(parent, nextEdge.Dest);

            // If including this edge doesn't cause a cycle
            if (x != y)
            {
                result.Add(nextEdge);
                Union(parent, rank, x, y);
                edgeCount++;
            }
        }

        // Print the MST
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n       **********<< Edges in the MST: >>**********\n");
        Console.ForegroundColor = ConsoleColor.White;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        foreach (Edge edge in result)
        {
            
            Console.WriteLine($"Src {edge.Src}  --> Dest {edge.Dest} == Weight {edge.Weight}");
            
        }

        int minimumCost = 0;
        for (i = 0; i < edgeCount; ++i)
        {
            minimumCost += result[i].Weight;
        }
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Minimum Cost Spanning Tree (MST): " + minimumCost);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1, 2);
        g.AddEdge(0, 2, 4);
        g.AddEdge(0, 3, 4);
        g.AddEdge(1, 2, 2);
        g.AddEdge(2, 3, 1);

        g.KruskalMST();
    }
}
