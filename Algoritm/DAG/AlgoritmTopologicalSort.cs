using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.DAG
{
    public class AlgoritmTopologicalSort
    {
        private static List<Graph> graphs = BuildArrGraph.LGB;

        public static List<Graph> ATSGetSet
        {
            get { return ATS(); }
            set { graphs = value; }
        }

        public static List<Graph> ATS()
        {
            Console.WriteLine("Назва алгоритму  = AlgoritmTopologicalSort");

            int[] inDergee = new int[graphs.Count];
            List<Graph> next = new List<Graph>();
            List<Graph> result = new List<Graph>();

            var sw = new Stopwatch();
            sw.Start();

            result = ATSort(inDergee, next, result);

            sw.Stop();

            long swLong = sw.ElapsedMilliseconds;

            RaportResult.TestTopologic(graphs, result, swLong);

            return result;


        }
        private static List<Graph> ATSort(int[] inDergee,
                                          List<Graph> next,List<Graph> result)
        {
            foreach (Graph gr in graphs)
            {
                foreach (Edge edg in gr.edgeIn)
                {
                    inDergee[edg.v - 1]++;
                    if (edg.u == 0)
                    {
                        inDergee[edg.v - 1] = -1;
                        next.Add(gr);
                    }
                }
            }
            while (graphs.Count != result.Count)
            {
                result.Add(next[0]);
                foreach (Graph gr in graphs)
                {
                    foreach (Edge edg in gr.edgeIn)
                    {
                        if (edg.u == next[0].edgeIn[0].v) inDergee[edg.v - 1] -= 1;
                        if (inDergee[edg.v - 1] == 0)
                        {
                            next.Add(gr);
                            inDergee[edg.v - 1] -= 1;
                        }       
                    }
                }
                next.RemoveAt(0);
            }
            return result;
        }



    }

}
