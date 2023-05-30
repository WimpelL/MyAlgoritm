using Algoritm.BuildTestForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Sort
{
    public class AlgoritmQuickSort
    {
        public static void AQS()
        {
            int[] arr = BuildArrSort.ArrRandBuild;
            Console.WriteLine("Name algoritm  = AlgoritmQuickSort");
            Console.WriteLine(RaportResult.TestSortZad(arr));

            var sw = new Stopwatch();
            sw.Start();
            QuickSort(arr);
            sw.Stop();
            long swLong = sw.ElapsedMilliseconds;
            Console.WriteLine(RaportResult.TestSort(arr, swLong));


        }
        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }




    }
    
}
