using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class BuildArr
    {
        private static int n1 = 100000000;
        private static int[] arr = Build(n1);
        public static int[] Arr
        {
            get
            {
                return arr;
            }
        }
        private static int[] Build(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Console.WriteLine("Arr  Build!");
            return arr;
            
        }
    }
}

