using Algoritm.BuildTestForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Sort
{
    public class AlgoritmSortSelection 
    {
        public static void ASS()
        {
            int[] arr = BuildArrSort.ArrRandBuild;
            Console.WriteLine("Name algoritm  = AlgoritmSortSelection");
            Console.WriteLine(RaportResult.TestSortZad(arr));

            long swLong = TimeTest(arr);

            Console.WriteLine(RaportResult.TestSort(arr, swLong));
        }
        private static long TimeTest(int[] arr)
        {
            var sw = new Stopwatch();
            sw.Start();

            ASSMain(arr);

            sw.Stop();
            long swLong = sw.ElapsedMilliseconds;
            return swLong;

        }
        private static int[] ASSMain(int[] arr)
        {

            int smolest = 0;
            int a;
            int vib;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                vib = arr[i];

                for (int j = i; j < arr.Length; j++)
                {
                    if (vib > arr[j])
                    {
                        smolest = j;
                        vib = arr[j];
                    }
                }

                a = arr[i];
                arr[i] = arr[smolest];
                arr[smolest] = a;
                smolest = i + 1;
            }
            return arr;
        }
    }
}
