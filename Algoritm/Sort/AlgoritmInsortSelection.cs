using Algoritm.BuildTestForm;
using Algoritm.Sort;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class AlgoritmInsortSelection
    {
        public static void AIS()
        {
            int[] arr = BuildArrSort.ArrRandBuild;
            Console.WriteLine("Назва алгоритму  = AlgoritmInsortSelection");
            Console.WriteLine(RaportResult.TestSortZad(arr));

            long swLong = TimeTest(arr);

            Console.WriteLine(RaportResult.TestSort(arr, swLong));
        }
        private static long TimeTest(int []arr)
        {
            var sw = new Stopwatch();
            sw.Start();

            AISMain(arr);

            sw.Stop();
            long swLong = sw.ElapsedMilliseconds;
            return swLong;

        }
        private static int[] AISMain(int[]arr)
        {
            int b = arr[0];
            int c = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < b)
                {
                    b = arr[i];
                    c = i;
                }
            }

            int a = arr[0];
            arr[0] = arr[c];
            arr[c] = a;

            for (int j = 1; j < arr.Length; j++)
            {
                while (arr[j] < arr[j - 1])
                {
                    a = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = a;
                    j--;
                }
            }
            return arr;
        }
    }
}
