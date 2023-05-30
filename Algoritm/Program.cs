using Algoritm.DAG;
using Algoritm.Sort;
using Algoritm.Strings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algoritm
{
    internal class Program
    {
        public static bool startAlgo = false;

        public static void Main(string[] args)
        {
            Console.WriteLine("Start");

            if (startAlgo)
            {
                for(int i = 0; i< BuildArr.Arr.Length; i = i + 20000000)
                {
                    AlgoritmLeener.AL(i);
                    AlgoritmLeenerSorch.ALSStatr(i);
                    AlgoritmBeeSorch.ABS(i);
                }


                AlgoritmSortSelection.ASS();
                AlgoritmMergeSort.AMS();
                AlgoritmQuickSort.AQS();
                AlgoritmCountingSort.CS();
                AlgoritmTopologicalSort.ATS();
                AlgoritmInsortSelection.AIS();
                AlgoritmShortestDAG.ShoDAG();
                AlgoritmDijkstra.Dijkstra();
                AlgoritmBellmanFord.BellmanFord();
                AlgoritmFloydWarshall.AFW();
                AlgoritmLCS.AssembleLCS();
            }
            AlgoritmAsamblTransform.AsambleTrans();



        }
    }
}
