using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class AlgoritmBeeSorch
    {
        public static void ABS( int a)
        {
            Console.WriteLine("Name algoritm  = AlgoritmBeeSorch");

            int[] arr = BuildArr.Arr;
            var sw = new Stopwatch();



            sw.Start();

            int left = 0;
            int right = arr[arr.Length - 1];
            int point = 0;

            while (a != arr[point])
            {
                point = (left + right) / 2;
                if (arr[point] > a)
                {
                    right = point - 1;
                }
                else if (arr[point] < a)
                {
                    left = point + 1;
                }
            }
            sw.Stop();

            long swLong = sw.ElapsedMilliseconds;
            Console.WriteLine(RaportResult.TestSearch(a, arr, point, swLong));
        }
    }
}
