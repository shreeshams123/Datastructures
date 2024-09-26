using System;
using System.Collections.Generic;

namespace GraphExamples
{
    class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Add a vertex to the graph
        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }
        }

        // Add an edge between two vertices (undirected)
        public void AddEdge(int vertex1, int vertex2)
        {
            AddVertex(vertex1);
            AddVertex(vertex2);

            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1); // Since it's undirected
        }

        // Display the graph
        public void Display()
        {
            foreach (var vertex in adjacencyList)
            {
                Console.Write(vertex.Key + ": ");
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            // Add edges
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 5);

            // Display the graph
            graph.Display();
        }
    }
}
