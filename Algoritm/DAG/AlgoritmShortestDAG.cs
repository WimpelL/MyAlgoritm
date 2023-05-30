using Algoritm.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.DAG
{
    internal class AlgoritmShortestDAG
    {
        /// <summary>
        /// Використовується для пошуку критичного шляху у ДФГ(наприклад Перт).
        /// У ацикличних графах без ваги ребра.
        /// Нажаль ця функция повнистю ще не реализована.
        /// </summary>
        private static List<Graph> graphs = BuildArrGraph.LGBPERT;
        private static int[] shortest = new int[graphs.Count];
        private static Graph[] pred = new Graph[graphs.Count];

        public static void ShoDAG()
        {
            for (int i = 0;i <shortest.Length;i++) shortest[i] = 0;
                // sp(s,v) wes crotchaishego puty gde s perwaia wershina, a v controlinaz wershina
                // u predidyshaia wershina ot kontrolinoi v
                // n numeracia wershin
                // shortest[] hranit sp(s,v) dlia v 
                // pred[] hranit u dlia v 
            Graph u;
            Graph v;
            AlgoritmTopologicalSort.ATSGetSet = graphs;
            graphs = AlgoritmTopologicalSort.ATSGetSet;
            int numCountGraphs = 0;

            foreach (Graph g in graphs)
            {
                numCountGraphs ++;
                Console.WriteLine("\ninteracia\n");
                foreach (Edge edg in g.edgeOut)
                {
                    if (edg.wid == 0) break;

                    u = g;
                    v = graphs[edg.v - 1];
                    Console.WriteLine(" u = " + u.numberVertex +
                                        " v = " + v.numberVertex +
                                        " Wes= " + edg.wid);
                    Relax(u, v, numCountGraphs);

                }

            }

        }
        public static void Relax(Graph u, Graph v, int numCountGraphs)
        {

            foreach (Edge edg in u.edgeOut)
            {
                if (edg.v == v.numberVertex)
                {
                    Console.WriteLine("else if ((shortest[" + (u.numberVertex - 1) 
                                      + "](" + shortest[u.numberVertex - 1]
                                      + ") + edg.wid(" + edg.wid + ") < shortest["
                                      + (v.numberVertex - 1) + "](" 
                                      + shortest[(v.numberVertex - 1)] + ")");
                    if (numCountGraphs == 1)
                    {
                        Console.WriteLine("War 1");
                        shortest[v.numberVertex - 1] = 0;
                        Console.WriteLine("shortest [" + ((v.numberVertex - 1)) 
                                        + "] = " + shortest[v.numberVertex - 1]);

                    }
                    else if (shortest[v.numberVertex - 1] == 0)
                    {
                        Console.WriteLine("War 4");
                        Console.WriteLine(u.edgeIn[0].u);
                        shortest[v.numberVertex - 1] = shortest[u.numberVertex - 1] + edg.wid;
                        pred[v.numberVertex - 1] = u;
                        Console.WriteLine("shortest [" + (v.numberVertex - 1) 
                                         + "] = " + shortest[v.numberVertex - 1]);
                    }
                    else if ((shortest[u.numberVertex - 1] + edg.wid) < shortest[v.numberVertex - 1])
                    {
                        Console.WriteLine("War 3");
                        shortest[v.numberVertex - 1] = shortest[u.numberVertex - 1] + edg.wid;
                        Console.WriteLine("else if ((shortest[" + v.numberVertex 
                                            + "] + edg.wid(" + edg.wid + ") < shortest[" 
                                            + v.numberVertex + "]");
                        Console.WriteLine("shortest [" + (v.numberVertex) + "] = " 
                                            + shortest[v.numberVertex - 1]);
                        pred[v.numberVertex -1 ] = u;
                        Console.WriteLine("pred [" + (v.numberVertex)+ "] = "
                                            + pred[v.numberVertex - 1].numberVertex);


                    }


                    foreach (int i in shortest) Console.Write(" " + i);
                    Console.WriteLine("\n");
                    for(int i = 0; i<pred.Length; i++) if (pred[i] != null) Console.Write(" pred["+(i+1)+"]= " + pred[i].numberVertex);
                    Console.WriteLine("\n");
                }


            }


        }
    }
}
