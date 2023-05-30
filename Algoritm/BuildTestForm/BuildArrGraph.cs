using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class Graph
    {
        public int numberVertex;
        public List<Edge> edgeIn = new List<Edge>();
        public List<Edge> edgeOut = new List<Edge>();
        public bool infinity = true;


    }
    public class Edge
    {
        public int u;
        public int v;
        public int wid;
    }
    public class BuildArrGraph
    {
        private static List<Graph> graphs1 = BuildListGaph();
        private static List<Graph> graphs2 = BuildListGaphPERT();
        private static List<Graph> graphs3 = BuildListGaphDijkstra();
        private static List<Graph> graphs4 = BuildListGaphBellmanFord();
        private static List<Graph> graphs5 = BuildListFloydWarshall();

        public static List<Graph> LGB
        {
            get
            {
                List<Graph> graphs = new List<Graph>();
                for (int i = 0; i < graphs1.Count; i++) graphs.Add(graphs1[i]);
                return graphs;
            }
        }
        public static List<Graph> LGBPERT
        {
            get
            {
                List<Graph> graphs = new List<Graph>();
                for (int i = 0; i < graphs2.Count; i++) graphs.Add(graphs2[i]);
                return graphs;
            }
        }
        public static List<Graph> LGBDijkstra
        {
            get
            {
                List<Graph> graphs = new List<Graph>();
                for (int i = 0; i < graphs3.Count; i++) graphs.Add(graphs3[i]);
                return graphs;
            }
        }
        public static List<Graph> LGBBellmanFord
        {
            get
            {
                List<Graph> graphs = new List<Graph>();
                for (int i = 0; i < graphs4.Count; i++) graphs.Add(graphs4[i]);
                return graphs;
            }
        }
        public static List<Graph> LGFloydWarshall
        {
            get
            {
                List<Graph> graphs = new List<Graph>();
                for (int i = 0; i < graphs5.Count; i++) graphs.Add(graphs5[i]);
                return graphs;
            }
        }

        public static Edge SaveToEdge(int a, int b, int c)
        {
            Edge edge = new Edge();
            edge.u = a;
            edge.v = b;
            edge.wid = c;

            return edge;
        }
        private static List<Graph> BuildListGaph()
        {


            List<Graph> graphs = new List<Graph>();
            List<Edge> edges = new List<Edge>();


            Graph graph = new Graph { numberVertex = 1 };
            graph.edgeIn.Add(SaveToEdge(0, 1, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 2 };
            graph.edgeIn.Add(SaveToEdge(0, 2, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 3 };
            graph.edgeIn.Add(SaveToEdge(1, 3, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 4 };
            graph.edgeIn.Add(SaveToEdge(2, 4, 0));
            graph.edgeIn.Add(SaveToEdge(3, 4, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 5 };
            graph.edgeIn.Add(SaveToEdge(3, 5, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 6 };
            graph.edgeIn.Add(SaveToEdge(4, 6, 0));
            graph.edgeIn.Add(SaveToEdge(5, 6, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 7 };
            graph.edgeIn.Add(SaveToEdge(6, 7, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 8 };
            graph.edgeIn.Add(SaveToEdge(7, 8, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 9 };
            graph.edgeIn.Add(SaveToEdge(0, 9, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 10 };
            graph.edgeIn.Add(SaveToEdge(9, 10, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 11 };
            graph.edgeIn.Add(SaveToEdge(10, 11, 0));
            graph.edgeIn.Add(SaveToEdge(6, 11, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 12 };
            graph.edgeIn.Add(SaveToEdge(11, 12, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 13 };
            graph.edgeIn.Add(SaveToEdge(12, 13, 0));
            graph.edgeIn.Add(SaveToEdge(8, 13, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 14 };
            graph.edgeIn.Add(SaveToEdge(13, 14, 0));
            graphs.Add(graph);

            return graphs;

        }
        private static List<Graph> BuildListGaphPERT()
        {


            List<Graph> graphs = new List<Graph>();
            List<Edge> edgeIn = new List<Edge>();


            /*Graph graph = new Graph { numberVertex = 1 };
            graph.edges.Add(SaveToEdge(0, 1, 0));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 2 };
            graph.edges.Add(SaveToEdge(1, 2, -6));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 3 };
            graph.edges.Add(SaveToEdge(2, 3, -15));
            graph.edges.Add(SaveToEdge(4, 3, -15));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 4 };
            graph.edges.Add(SaveToEdge(1, 4, -2));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 5 };
            graph.edges.Add(SaveToEdge(3, 5, -4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 6 };
            graph.edges.Add(SaveToEdge(3, 6, -1));
            graph.edges.Add(SaveToEdge(7, 6, -1));
            graph.edges.Add(SaveToEdge(8, 6, -1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 7 };
            graph.edges.Add(SaveToEdge(1, 7, -1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 8 };
            graph.edges.Add(SaveToEdge(1, 8, -4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 9 };
            graph.edges.Add(SaveToEdge(6, 9, -2));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 10 };
            graph.edges.Add(SaveToEdge(9, 10, -1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 11 };
            graph.edges.Add(SaveToEdge(10, 11, -4));
            graph.edges.Add(SaveToEdge(12, 11, -4));
            graph.edges.Add(SaveToEdge(13, 11, -4));
            graph.edges.Add(SaveToEdge(14, 11, -4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 12 };
            graph.edges.Add(SaveToEdge(1, 12, -2));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 13 };
            graph.edges.Add(SaveToEdge(1, 13, -3));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 14 };
            graph.edges.Add(SaveToEdge(1, 14, -4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 15 };
            graph.edges.Add(SaveToEdge(14, 15, -1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 16 };
            graph.edges.Add(SaveToEdge(15, 16, -1));
            graph.edges.Add(SaveToEdge(17, 16, -1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 17 };
            graph.edges.Add(SaveToEdge(1, 17, -3));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 18 };
            graph.edges.Add(SaveToEdge(16, 18, -3));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 19 };
            graph.edges.Add(SaveToEdge(18, 19, -1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 20 };
            graph.edges.Add(SaveToEdge(19, 20, 0));
            graphs.Add(graph);*/

            Graph graph = new Graph { numberVertex = 1 };
            graph.edgeIn.Add(SaveToEdge(0, 1, 0));
            graph.edgeOut.Add(SaveToEdge(1, 2, 5));
            graph.edgeOut.Add(SaveToEdge(1, 3, 3));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 2 };
            graph.edgeIn.Add(SaveToEdge(1, 2, 5));
            graph.edgeOut.Add(SaveToEdge(2, 3, 2));
            graph.edgeOut.Add(SaveToEdge(2, 4, 6));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 3 };
            graph.edgeIn.Add(SaveToEdge(1, 3, 3));
            graph.edgeOut.Add(SaveToEdge(3, 4, 7));
            graph.edgeOut.Add(SaveToEdge(3, 5, 4));
            graph.edgeOut.Add(SaveToEdge(3, 6, 2));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 4 };
            graph.edgeIn.Add(SaveToEdge(2, 4, 6));
            graph.edgeIn.Add(SaveToEdge(3, 4, 7));
            graph.edgeOut.Add(SaveToEdge(4, 6, 1));
            graph.edgeOut.Add(SaveToEdge(4, 5, -1));

            graphs.Add(graph);

            graph = new Graph { numberVertex = 5 };
            graph.edgeIn.Add(SaveToEdge(3, 5, 4));
            graph.edgeIn.Add(SaveToEdge(4, 5, -1));
            graph.edgeOut.Add(SaveToEdge(5, 6, -2));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 6 };
            graph.edgeIn.Add(SaveToEdge(5, 6, -2));
            graph.edgeIn.Add(SaveToEdge(3, 6, 2));
            graph.edgeIn.Add(SaveToEdge(4, 6, 1));
            graph.edgeOut.Add(SaveToEdge(6, 7, 0));
            graphs.Add(graph);

            return graphs;

        }

        private static List<Graph> BuildListGaphDijkstra()
        {


            List<Graph> graphs = new List<Graph>();
            Graph graph;

            graph = new Graph { numberVertex = 1 };
            graph.edgeIn.Add(SaveToEdge(0, 1, 0));
            graph.edgeOut.Add(SaveToEdge(1, 2, 6));
            graph.edgeOut.Add(SaveToEdge(1, 4, 4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 2 };
            graph.edgeIn.Add(SaveToEdge(1, 2, 6));
            graph.edgeIn.Add(SaveToEdge(4, 2, 1));
            graph.edgeOut.Add(SaveToEdge(2, 4, 2));
            graph.edgeOut.Add(SaveToEdge(2, 3, 3));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 3 };
            graph.edgeIn.Add(SaveToEdge(2, 3, 3));
            graph.edgeIn.Add(SaveToEdge(4, 3, 9));
            graph.edgeIn.Add(SaveToEdge(5, 3, 5));
            graph.edgeOut.Add(SaveToEdge(3, 5, 4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 4 };
            graph.edgeIn.Add(SaveToEdge(1, 4, 4));
            graph.edgeIn.Add(SaveToEdge(2, 4, 2));
            graph.edgeOut.Add(SaveToEdge(4, 2, 1));
            graph.edgeOut.Add(SaveToEdge(4, 3, 9));
            graph.edgeOut.Add(SaveToEdge(4, 5, 3));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 5 };
            graph.edgeIn.Add(SaveToEdge(4, 5, 3));
            graph.edgeIn.Add(SaveToEdge(3, 5, 4));
            graph.edgeOut.Add(SaveToEdge(5, 1, 7));
            graph.edgeOut.Add(SaveToEdge(5, 3, 5));
            graphs.Add(graph);
            return graphs;
        }

        private static List<Graph> BuildListGaphBellmanFord()
        {
            List<Graph> graphs = new List<Graph>();
            Graph graph;

            graph = new Graph { numberVertex = 1 };
            graph.edgeIn.Add(SaveToEdge(0, 1, 0));
            graph.edgeOut.Add(SaveToEdge(1, 2, 6));
            graph.edgeOut.Add(SaveToEdge(1, 4, 7));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 2 };
            graph.edgeIn.Add(SaveToEdge(1, 2, 6));
            graph.edgeIn.Add(SaveToEdge(3, 2, -2));
            graph.edgeOut.Add(SaveToEdge(2, 3, 5));
            graph.edgeOut.Add(SaveToEdge(2, 4, 8));
            graph.edgeOut.Add(SaveToEdge(2, 5, -4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 3 };
            graph.edgeIn.Add(SaveToEdge(2, 3, 5));
            graph.edgeIn.Add(SaveToEdge(4, 3, -3));
            graph.edgeIn.Add(SaveToEdge(5, 3, 7));
            graph.edgeOut.Add(SaveToEdge(3, 2, -2));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 4 };
            graph.edgeIn.Add(SaveToEdge(1, 4, 7));
            graph.edgeIn.Add(SaveToEdge(2, 4, 8));
            graph.edgeOut.Add(SaveToEdge(4, 3, -3));
            graph.edgeOut.Add(SaveToEdge(4, 5, 9));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 5 };
            graph.edgeIn.Add(SaveToEdge(2, 5, -4));
            graph.edgeIn.Add(SaveToEdge(4, 5, 9));
            graph.edgeOut.Add(SaveToEdge(5, 1, 2));
            graph.edgeOut.Add(SaveToEdge(5, 3, 7));
            graphs.Add(graph);
            return graphs;

        }

        private static List<Graph> BuildListFloydWarshall()
        {
            List<Graph> graphs = new List<Graph>();
            Graph graph;

            graph = new Graph { numberVertex = 1 };
            graph.edgeIn.Add(SaveToEdge(4, 1, 2));
            graph.edgeOut.Add(SaveToEdge(1, 2, 3));
            graph.edgeOut.Add(SaveToEdge(1, 3, 8));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 2 };
            graph.edgeIn.Add(SaveToEdge(1, 2, 3));
            graph.edgeIn.Add(SaveToEdge(3, 2, 4));
            graph.edgeOut.Add(SaveToEdge(2, 4, 1));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 3 };
            graph.edgeIn.Add(SaveToEdge(1, 3, 8));
            graph.edgeIn.Add(SaveToEdge(4, 3, -5));
            graph.edgeOut.Add(SaveToEdge(3, 2, 4));
            graphs.Add(graph);

            graph = new Graph { numberVertex = 4 };
            graph.edgeIn.Add(SaveToEdge(2, 4, 1));
            graph.edgeOut.Add(SaveToEdge(4, 1, 2));
            graph.edgeOut.Add(SaveToEdge(4, 3, -5));
            graphs.Add(graph);

            return graphs;
        }
    }

}

