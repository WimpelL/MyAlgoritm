using Algoritm.BuildTestForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class AlgoritmMergeSort
    {
        
        /*  static int[] MargeSort(int[] arrr)
          {
              int[] arrr1;
              int[] arrr2;
              if (arrr.Length == 1) return arrr;

              else
              {
                  int a;
                  if (arrr.Length % 2 == 0) a = 0;
                  else a = 1;

                  arrr1 = new int[(arrr.Length / 2) + a];
                  for (int i = 0; i < arrr1.Length; i++)
                  {
                      arrr1[i] = arrr[i];
                  }
                  foreach (int c in arrr1) Console.WriteLine("MargeSort arrr1[i]=" + c);
                  Console.WriteLine("\n");

                  arrr2 = new int[arrr.Length / 2];
                  for (int i = arrr2.Length - 1; i >= 0; i--)
                  {
                      arrr2[i] = arrr[i + (arrr.Length / 2) + a];
                  }
                  foreach (int c in arrr2) Console.WriteLine("MargeSort arrr2[i]=" + c);
                  Console.WriteLine("\n");
              }

                  MargeSort(arrr1);
                  MargeSort(arrr2);
              int[] arrr3 = new int[] { };


              return Marge(arrr1, arrr2, arrr3);




          }
          static int [] Marge(int[] arrr1, int[] arrr2, int[] arrr3)
          {

              if (arrr3.Length == 3) return arrr3;
              else
              {
                  arrr3 = new int[arrr1.Length + arrr2.Length];

                  int indAr1 = 0;
                  int indAr2 = 0;

                  if (arrr1.Length == 1 && arrr2.Length == 1)
                  {
                      if (arrr1[indAr1] < arrr2[indAr2])
                      {
                          arrr3[0] = (arrr1[indAr1]);
                          arrr3[1] = (arrr2[indAr2]);
                      }
                      else if (arrr2[indAr2] < arrr1[indAr1])
                      {
                          arrr3[0] = (arrr2[indAr2]);
                          arrr3[1] = (arrr1[indAr1]);
                      }
                  }

                  if (arrr1.Length != 1 && arrr2.Length == 1)
                  {
                      arrr3[2] = (arrr2[indAr2]);
                  }



                  foreach (int c in arrr3) Console.WriteLine("list[i] = " + c);
                  Console.WriteLine("\n");
                  Marge( arrr1, arrr2, arrr3);

                  return arrr3;
              }



          }
        */

        //метод для слияния массивов
        public static void AMS()
        {
            int[] arr = BuildArrSort.ArrRandBuild;
            Console.WriteLine("Name algoritm  = AlgoritmMergeSort");
            Console.WriteLine(RaportResult.TestSortZad(arr));

            var sw = new Stopwatch();
            sw.Start();
            MergeSort(arr);
            sw.Stop();
            long swLong = sw.ElapsedMilliseconds;
            Console.WriteLine(RaportResult.TestSort(arr, swLong));


        }
        private static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        //сортировка слиянием
        private static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            

            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;

        }

        private static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }






    }
}
