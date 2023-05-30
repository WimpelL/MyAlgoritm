using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class AlgoritmLeener
    {
        public static void AL( int a)
        {
            int[] arr = BuildArr.Arr;
            Console.WriteLine("Name algoritm  = Leener");

            var sw = new Stopwatch();
            sw.Start();
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (a == arr[i])
                {
                    b = i;
                    break;
                }
            }
            sw.Stop();

            long swLong = sw.ElapsedMilliseconds;
            Console.WriteLine(RaportResult.TestSearch(a, arr, b, swLong));

        }
    }
}
