using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class AlgoritmLeenerSorch
    {

        private static int[] arr = BuildArr.Arr;

        public static int ALS(int a, int[] arr)
        {
            return  ALSMain( a, arr); 
        }


        public static void ALSStatr(int a)
        {
            Console.WriteLine("Назва алгоритму  = AlgoritmLeenerSorch");

            long swLong = TimeTest(a,arr);

            Console.WriteLine(RaportResult.TestSearch(a, arr, ALS(a, arr), swLong));
        }



        private static long TimeTest(int a, int[] arr)
        {
            var sw = new Stopwatch();
            sw.Start();

            ALSMain(a, arr);

            sw.Stop();
            long swLong = sw.ElapsedMilliseconds;
            return swLong;
        }


        private static int ALSMain(int a, int[] arr)
        {
            int i = 0;
            if (arr[arr.Length - 1] != a)
            {
                arr[arr.Length - 1] = a;
                while (arr[i] != a)
                {
                    i++;
                }
            }
            Console.WriteLine("!!!!!!" + i);
            return i;

        }






    }
}
