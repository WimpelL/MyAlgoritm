using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.DAG
{
    public class AlgoritmFloydWarshall
    {
        /// <summary>
        /// Використовується для пошуку критичного шляху у ДФГ (наприклад Перт).
        /// У цикличних зважених графах без відємного циклу.
        /// </summary>


        private static List<Graph> graphs = BuildArrGraph.LGFloydWarshall;
        private static int gC = graphs.Count;
        private static int[,,] shortest = new int[gC, gC, gC+1];
        private static Graph[,,] pred = new Graph[gC, gC, gC+1];

        //private static int[,] W = new int[gC + 1, gC + 1];

        public static void Wesmatrix()
        {

            List<Edge> edgs = new List<Edge>();

            foreach (Graph g in graphs)
            {
                foreach (Edge edg in g.edgeOut) edgs.Add(edg);

            }


            for (int u = 0; u < gC; u++)
            {
                for (int v = 0; v < gC; v++)
                {
                    foreach (Edge edg in edgs)
                    {
                        if (edg.u - 1 == u && edg.v - 1 == v)
                        {
                            shortest[u, v, 0] = edg.wid;
                            foreach (Graph g in graphs)
                                if (g.numberVertex == edg.u) pred[u, v, 0] = g;

                        }


                    }
                }
            }

            Console.WriteLine("shortest[u, v, 0]");
            for (int u = 0; u < gC; u++)
            {
                for (int v = 0; v < gC; v++)
                {
                    Console.Write(shortest[u, v,0]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("pred[u, v, 0]");
            for (int u = 0; u < gC; u++)
            {
                for (int v = 0; v < gC; v++)
                {
                    if (pred[u, v, 0] == null) Console.Write(" Null ");
                    else Console.Write("  "+pred[u, v, 0].numberVertex + "   ");
      
                }
                Console.WriteLine();
            }

        }

        public static void AFW()
        {
            Wesmatrix();
            // sp(s,v) wes crotchaishego puty gde 's' perwaia wershina,
            // a 'v' controlinaz wershina
            // 'u' predidyshaia wershina ot kontrolinoi 'v'
            // n numeracia wershin
            // shortest[u,v,n] hranit sp(s,v) dlia u\v w n wershine
            // pred[u,v,n] hranit u dlia v.
            // Wsewaia matrica smezhnosti




            for (int x = 1; x < gC+1; x++)
            {
                for (int u = 0; u < gC; u++)
                    for (int v = 0; v < gC; v++)
                    {
                        


						if (Put( u, x, v))//&& v != xu != v && u+1 != x && v+1 != x && u!=x
                        {
                            Console.WriteLine("if (shortest[" + u + "," + v + "," + (x) + "](" +
                                                + shortest[u, v, x] + ")" +
                                              " >  shortest[" + u + "," + (x - 1) + "," + (x - 1) + "](" +
                                                + shortest[u, x - 1, x - 1] + ")" +
                                              " +  shortest[" + (x - 1) + "," + v + "," + (x - 1) +"]("
                                                + shortest[x - 1, v, x - 1] + ")" );




                            if (shortest[u, v, x ] > (shortest[u, x - 1, x - 1] + shortest[x - 1, v, x - 1]) || shortest[u, v, x-1] == 0)
                            {
                                Console.WriteLine("War1");
                                shortest[u, v, x] = shortest[u, x - 1, x - 1] + shortest[x - 1, v, x - 1];

                                Console.WriteLine("shortest[" + u + ", " + v + ", " + x + "] = "
                                                    + shortest[u, v, x]);
                                pred[u, v, x] = pred[x-1, v, x - 1];
                                if (pred[u, v, x] != null) Console.WriteLine("pred [" + u + "," + v + "," + x + "] = "
                                                    + pred[u, v, x].numberVertex + "\n");

                            }
                            else
                            {
								Console.WriteLine("War2");
								shortest[u, v, x] = shortest[u, v, x - 1];
                                Console.WriteLine("shortest[" + u + ", " + v + ", " + x + "] = "
                                                    + shortest[u, v, x]);
                                pred[u, v, x] = pred[u, v, x - 1];
                                if (pred[u, v, x] != null) Console.WriteLine("pred [" + u + "," + v + "," + x + "] = "
                                                    + pred[u, v, x].numberVertex+"\n");
                            }
                        }
						if (shortest[u, v, x] == 0) shortest[u, v, x] = shortest[u, v, x - 1];
						if (pred[u, v, x] == null) pred[u, v, x] = pred[u, v, x - 1];
					}
                Console.WriteLine("shortest[u, v, "+x+"]");
                for (int u = 0; u < gC; u++)
                {
                    for (int v = 0; v < gC; v++)
                    {
                        Console.Write(shortest[u, v, x] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("pred[u, v, "+x+"]");
                for (int u = 0; u < gC; u++)
                {
                    for (int v = 0; v < gC; v++)
                    {
                            if (pred[u, v, x] == null) Console.Write(" Null ");
                            else Console.Write("  " + pred[u, v, x].numberVertex + "   ");

                    }
                    Console.WriteLine();
                }


            }


        }
        private static bool Put(int u, int x, int v)
        {
            bool a = pred[u, x - 1, x - 1] != null && pred[x - 1, v, x - 1] != null && u!=v;
			return a;

        }

    }
}
