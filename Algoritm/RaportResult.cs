using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public class RaportResult
    {

        public static string TestSearch(int a, int[] arr, int b, long swLong)
        {
            string str = "";

            if (a <= (arr.Length/3)) str = " Значение в начале списка";
            else if ((a > (arr.Length/3)) && (a <= ((arr.Length/3)*2)))
            {
                str = "Значение в середине списка";
            }
            else str = " Значение в конце списка";

            string c = str + "\n" 
                           + "A = " + a + " == Arr= " + arr[b] 
                           + " u punkti " + b + "\n"
                           + "Algoritm time work in milisecond= "
                           + swLong + " mls" + "\n";
            return c;
        }
        public static string TestSort(int[] arr, long swLong)
        {

            string c = "Вiдсортовано = " + Convert.ToString(arr.Length) + " значень." + "\n"
                       + "приклад сортування :" + "\n";

            c = TestSortObhod(arr, c);


            c = c + "\n" + "Час дii алгоритму = "
                       + swLong + " mls" + "\n";
            return c;
        }
        public static string TestSortZad(int[] arr)
        {

            string c = "Створено масив даних на " + Convert.ToString(arr.Length) + " значень." + "\n"
                       + "Короткий перелiк значень :" + "\n";


            c = TestSortObhod(arr, c);
            return c;
        }
        private static string TestSortObhod(int[] arr, string c)
        {
            for (int i = 0; i < arr.Length; i = i + (arr.Length / 10))
            {
                for (int j = i; j < i + 10; j++)
                {
                    c += ProbStr(arr[j], arr.Length) + Convert.ToString(arr[j]) + "||";
                }
                c += "\n";
            }
            return c;
        }
        private static string ProbStr(int a, int b)
        {
            a = Convert.ToString(a).Length;
            b = Convert.ToString(b).Length-1;
            string s = "";
            for(int i = 0; i < b - a; i ++)
            {
                s = s + " ";
            }
            return s;
        }

        public static void TestTopologic(List<Graph> graphs, List<Graph> result, long swLong)
        {
            Console.WriteLine("Внесено масив вершин Vertex: ");
            Topo(graphs);
            Console.WriteLine("Результат топологичного сортування: ");
            Topo(result);
            Console.WriteLine("Процедуру було виконано за : " + swLong + " mls");

        }
        private static void Topo(List<Graph> result)
        {
            foreach (Graph gr in result)
            {
                Console.Write("numberVertex= " + gr.numberVertex + " ");
                foreach (Edge edg in gr.edgeIn)
                {
                    Console.Write("( u= " + edg.u + " v= " + edg.v + " Wes= "+ edg.wid+" )");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
