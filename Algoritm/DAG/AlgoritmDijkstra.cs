using Algoritm.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.DAG
{
    internal class AlgoritmDijkstra
    {
        /// <summary>
        /// Використовується для пошуку найкоротшого шляху у масиві графів
        /// з відомою початковою точкою
        /// присутніми циклами
        /// з невідемною вагою.
        /// </summary>
        private static List<Graph> graphs = BuildArrGraph.LGBDijkstra;
        private static int[] shortest = new int[graphs.Count];
        private static Graph[] pred = new Graph[graphs.Count];
        // sp(s,v) вага найкоротшого шляху від s до v. Де v контрольна вершина
        // u попередня вершина від контрольної v
        // n нумерація вершин
        // shortest[] містить sp(s,v) для v 
        // pred[] мфстить u для v 



        public static void Dijkstra()
        {
            for (int i = 0; i < shortest.Length; i++) shortest[i] = 0;

            List<Graph> grQ= graphs;

            Graph u;
            Graph v;

            int idex = 0;
            int a;

            grQ[0].infinity = false;

            foreach (Graph g in grQ)
            {
                idex++ ; // for Console
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\ninteracia "+ idex + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Edge edg in g.edgeOut)
                {
                    if (edg.wid == 0) break;

                    u = g;
                    v = graphs[edg.v - 1];
                    Console.WriteLine(" u = " + u.numberVertex +
                                        " v = " + v.numberVertex +
                                        " Wes= " + edg.wid);
                    Relax(u, v);

                }
                a = shortest.Min();
                Console.WriteLine("naimenshii"+a);



            }

        }
        public static void Relax(Graph u, Graph v)
        {
            Console.WriteLine("!!!!!!!!INFINITY!!!!!!!!" + shortest[(v.numberVertex - 1)]);
            if (shortest[v.numberVertex - 1] == 0 && v.infinity != false)
            {
                v.infinity = false;
            }
            else v.infinity = true;

            foreach (Edge edg in u.edgeOut)
            {
                if (edg.v == v.numberVertex)
                {
                    Console.WriteLine("ORD: else if ((shortest[" + (u.numberVertex - 1)
                                      + "](" + shortest[u.numberVertex - 1]
                                      + ") + edg.wid(" + edg.wid + ") < shortest["
                                      + (v.numberVertex - 1) + "]("
                                      + shortest[(v.numberVertex - 1)] + ") v.infinity = " + v.infinity);

                    if ((shortest[u.numberVertex - 1] + edg.wid) < shortest[v.numberVertex - 1] || v.infinity != true )
                    {
                        Console.WriteLine("War 1");
                        shortest[v.numberVertex - 1] = shortest[u.numberVertex - 1] + edg.wid;

                        Console.WriteLine("shortest [" + (v.numberVertex) + "] = "
                                            + shortest[v.numberVertex - 1]);
                        pred[v.numberVertex - 1] = u;
                        Console.WriteLine("pred [" + (v.numberVertex) + "] = "
                                            + pred[v.numberVertex - 1].numberVertex);
                        v.infinity = true;


                    }
                    else Console.WriteLine("War 2: NON!");


                    foreach (int i in shortest) Console.Write(" " + i);
                    Console.WriteLine("\n");
                    for (int i = 0; i < pred.Length; i++) if (pred[i] != null) Console.Write(" pred[" + (i + 1) + "]= " + pred[i].numberVertex);
                    Console.WriteLine("\n");
                }


            }


        }
    }
}
