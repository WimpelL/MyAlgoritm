using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.BuildTestForm
{
    internal class BuildArrSort
    {
        private static int n1 = 100000000;
        private static int arrRandLenght = n1 / 10000;

        private static int[] arrRand = BuildArrRand(arrRandLenght);
        //private static int[] arrRandSD = BuildArrRand(arrRandLenght);
        private static int[] arrRandSD = BuildArrRandSD(arrRandLenght, arrRandLenght/1);


        public static int[] ArrRandBuild
        {
            set { arrRand = value; }
            get
            {
                int[] arr = new int[arrRand.Length];
                for (int arR = 0; arR < arr.Length; arR++) arr[arR] = arrRand[arR];
                return arr;
            }
        }
        public static int[] ArrRandBuildSD
        {
            set { arrRandSD = value; }
            get
            {
                int[] arr = new int[arrRandSD.Length];
                for (int arR = 0; arR < arr.Length; arR++) arr[arR] = arrRandSD[arR];
                return arr;
            }
        }


        private static int[] BuildArrRandSD(int arrRandLenght, int diapazone)
        {
            Random rnd = new Random();
            int[] arr = new int[arrRandLenght];
            for (int i = 0; i < arrRandLenght; i++)
            {
                arr[i] = rnd.Next(diapazone);
            }
            Console.WriteLine("Arr RendSmolDiapazone Build!");
            return arr;

        }

        private static int[] BuildArrRand(int n)
        {
            Random rnd = new Random();
            int[] arr = Enumerable.Range(1, n).ToArray();
            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(n);
                int x = arr[i];
                arr[i] = arr[j];
                arr[j] = x;
            }
            Console.WriteLine("Arr Rend Build!");
            return arr;
        }






}
}

