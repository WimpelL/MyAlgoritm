using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Strings
{
    public class AlgoritmLCS
    {

        public static void AssembleLCS()
        {
            string yI = "olerodominatyscwetreihamerknet";
            string xI = "dictatorzagnanvugol";


            string s1 = xI;
            string s2 = yI;

            int[,] arr = arrComputeLCSTable(xI, yI);

            int maxLeng = arr[xI.Length, yI.Length];

            string output = LongComSub(xI, yI, maxLeng, arr);
            Console.WriteLine(output + maxLeng);
        }


        private static string LongComSub(string s1, string s2, int maxLeng, int[,] arr)
        {
            int k,i, j;
            char[] t = new char[maxLeng];

            for (i = s1.Length, j = s2.Length,  k = maxLeng - 1; k >= 0;)
            {
                if (s1[i - 1] == s2[j - 1])
                {
                    t[k] = s1[i - 1];
                    --i;
                    --j;
                    --k;
                }
                else if (arr[i, j - 1] > arr[i - 1, j])
                    --j;
                else
                    --i;
            }


            string s = "";
            foreach(char c in t)
                s += c;

            return s ;
        }
        private static int[,] arrComputeLCSTable(string xI, string yI)
        {
            int[,] arr = new int[ xI.Length + 1, yI.Length + 1];

            for (int a = 0; a < xI.Length; a++)
            {
                for (int b = 0; b < yI.Length; b++)
                {
                    if (xI[a] == yI[b]) arr[a + 1, b + 1] = arr[a, b] + 1;
                    else
                    {
                        if(arr[a + 1, b] >= arr[a, b + 1])
                        arr[a + 1, b + 1] = arr[a + 1, b];
                        else arr[a + 1, b + 1] = arr[a, b + 1];
                    }
                }
            }

            for (int a = 0; a< xI.Length + 1; a++)
            {
                for(int b = 0; b < yI.Length + 1; b++)
                {
                    Console.Write(arr[a,b]+ " ");
                }
                Console.WriteLine();
            }
            return arr;
        }




    }
}
