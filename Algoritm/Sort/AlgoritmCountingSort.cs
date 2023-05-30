using Algoritm.BuildTestForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Algoritm.Sort
{
    public class AlgoritmCountingSort
    {
        private static int[] arr = BuildArrSort.ArrRandBuildSD;
        private static int mMax = arr.Max();

        private static int[] CountKeysEqual(int[] arr, int mMax)
        {
            int[] equal = new int[mMax+1];
            int key;
            for(int i = 0;i<arr.Length ;i++)
            {
                key = arr[i];
                equal[key] = equal[key] + 1; 
            }
            
            return equal;
        }
        private static int[] CountKeysLess(int[] equal, int mMax)
        {
            int[] less = new int[mMax+1];
            for (int i = 1; i < less.Length; i++)
            {
                less[i] = less[i - 1] + equal[i - 1];
            }

            return less;
        }
        private static int[] Rearraange(int[] arr, int[] less, int mMax)
        {
            int[] arrResult = new int[arr.Length];
            int[] next = new int[mMax+1];
            int key;
            int index;
            for (int i = 0; i <= mMax; i++)
            {
                next[i] = less[i] + 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                key = arr[i];
                index = next[key];
                arrResult[index-1] = arr[i]; 
                next[key] = next[key]+1;
            }

            return arrResult;
        }


        public static void CS()
        {
            Console.WriteLine("Назва Алгоритму  = AlgoritmInsortSelection");
            Console.WriteLine(RaportResult.TestSortZad(arr));

            var sw = new Stopwatch();
            sw.Start();

            int [] equal = CountKeysEqual(arr, mMax);
            int [] less = CountKeysLess(equal, mMax);
            arr = Rearraange(arr, less, mMax);
           
            sw.Stop();
            long swLong = sw.ElapsedMilliseconds;
            Console.WriteLine(RaportResult.TestSort(arr, swLong));
        }
    }
}
        