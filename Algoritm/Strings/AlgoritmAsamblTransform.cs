using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Strings
{
    public class AlgoritmAsamblTransform
    {
        public static void AsambleTrans()
        {
            string yI = "ABABAGALAMAGA";
            string xI = "MANGYSTOMANYACAL";

            string[,] arr = arrComputeLCSTable(xI, yI);

            AssembleTransformation(arr, xI.Length, yI.Length);

		}

        private static string[,] arrComputeLCSTable(string xI, string yI)
        {
            int[,] arr = new int[xI.Length+1, yI.Length+1];
            string[,] strs = new string[xI.Length + 1, yI.Length + 1];
            strs[0, 0] = "     ";


            // Cd = Ci =  +2
            // Cc = -1
            // Cr = +1





            for (int a = 1; a < xI.Length+1; a++)
            {
                for (int b = 1; b < yI.Length+1; b++)
                {
                    arr[a, 0] = a * 2;
                    arr[0, b] = b * 2;
                    strs[a, 0] = "ins" + xI[a - 1] + "   ";
                    strs[0, b] = "del" + yI[b - 1] + "   ";
                }
            }

            strs[0, 0] = "       ";

            for (int a = 1; a < xI.Length + 1; a++)
            {
                for (int b = 1; b < yI.Length + 1; b++)
                {
                    if (xI[a - 1] == yI[b - 1])
                    {
                        arr[a, b] = arr[a - 1, b - 1] - 1;
                        strs[a, b] = "copy" + xI[a - 1]+"  ";
                    }
                    else
                    {
                        arr[a, b] = arr[a - 1, b - 1] + 1;
                        strs[a, b] = "rep" +yI[b - 1] +"by"+ xI[a - 1];
                    }
                    if (arr[a - 1, b] + 2 < arr[a, b])
                    {
                        arr[a, b] = arr[a - 1, b] + 2;
                        strs[a, b] = "ins" + xI[a - 1]+"   ";
                    }
                    if (arr[a, b - 1] + 2 < arr[a, b])
                    {
                        arr[a, b] = arr[a, b - 1] + 2;
                        strs[a, b] = "del" + yI[b - 1]+"   ";
                    }
                }
            }
            


            for (int a = 0; a <yI.Length+1 ; a++)
            {
                for (int b = 0; b < xI.Length+1; b++)
                {
                    Console.Write(arr[b, a] + " ");
                }
                Console.WriteLine();
            }

            for (int a = 0; a <  yI.Length+ 1; a++)
            {
                for (int b = 0; b <  xI.Length+ 1; b++)
                {
                    Console.Write(strs[b, a] + " ");
                }
                Console.WriteLine();
            }

            return strs;
        }
        private static void AssembleTransformation(string[,] arr, int xISize, int yISize )
        {

			List<string> strs = new List<string>();



			strs.Add(arr[xISize, yISize]);
			while ( xISize > 0)
            {
				if (arr[xISize, yISize][0] == 'c' || arr[xISize, yISize][0] == 'r')
				{
					yISize--;
                    xISize--;
					strs.Add(arr[xISize, yISize]);
				}
				else if (arr[xISize, yISize][0] == 'd')
                {

					yISize--;
					strs.Add(arr[xISize, yISize]);
				}
				else if (arr[xISize, yISize][0] == 'i')
				{
					xISize--;
					strs.Add(arr[xISize, yISize]);
				}
			}
            strs.Reverse();

            foreach(string str in strs) Console.WriteLine(str); 
        }
    }
}
