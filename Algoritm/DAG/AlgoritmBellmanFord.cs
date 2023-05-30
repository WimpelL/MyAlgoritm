using Algoritm.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.DAG
{
    public  class AlgoritmBellmanFord
    {
        /// <summary>
        /// Використовується для пошуку найкоротшого шляху у масиві графів
        /// з відомою початковою точкою i присутніми циклами.
        /// </summary>
        private static List<Graph> graphs = BuildArrGraph.LGBBellmanFord;
        private static int[] shortest = new int[graphs.Count];
        private static Graph[] pred = new Graph[graphs.Count];


        // sp(s,v) вага найкоротшого шляху від s до v. Де v контрольна вершина
        // u попередня вершина від контрольної v
        // n нумерація вершин
        // shortest[] містить sp(s,v) для v 
        // pred[] мфстить u для v 



        public static void BellmanFord()
        {
            for (int i = 0; i < shortest.Length; i++) shortest[i] = 0;
            graphs[0].infinity = false;

            int idex = 0;
            for (int i = 0; i < graphs.Count; i++)
            {
                foreach (Graph g in graphs)
                {
                    idex++; // for Console
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\ninteracia " + idex + "\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    foreach (Edge edg in g.edgeOut)
                    {
                        if (edg.wid == 0) break;
                        Relax(edg);
                    }
                }
            }
        }
        public static void Relax(Edge edg)
        {
            Graph u = new Graph();
            Graph v = new Graph();
            foreach (Graph g in graphs)
            {
                if (edg.u == g.numberVertex) u = g;
                else if (edg.v == g.numberVertex) v = g;
            }
            Console.WriteLine(" u = " + u.numberVertex +
                                " v = " + v.numberVertex +
                                " Wes= " + edg.wid);


            Console.WriteLine("!!!!!!!!INFINITY!!!!!!!!" + shortest[(v.numberVertex - 1)]);
            if (shortest[v.numberVertex - 1] == 0 && v.infinity != false)
            {
                v.infinity = false;
            }
            else v.infinity = true;

            Console.WriteLine("ORD: else if ((shortest[" + (u.numberVertex - 1)
                                      + "](" + shortest[u.numberVertex - 1]
                                      + ") + edg.wid(" + edg.wid + ") < shortest["
                                      + (v.numberVertex - 1) + "]("
                                      + shortest[(v.numberVertex - 1)] + ") v.infinity = " + v.infinity);

            if ((shortest[u.numberVertex - 1] + edg.wid) < shortest[v.numberVertex - 1] || v.infinity != true)
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
