using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7.cs
{
    class Program
    {
        static double Input(string sentence, double minBorder = double.MinValue, double maxBorder = double.MaxValue)
        {
            double result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        static int IntInput(string sentence, int minBorder = int.MinValue, int maxBorder = int.MaxValue)
        {
            int result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = int.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        static bool NextSet(int[] a, int n, int m)
        {
            int j = m - 1; // Инициализация переменной j (индекс последнего элемента)
            while (j >= 0 && a[j] == n ) j--;
            if (j < 0) return false;
            if (a[j] >= n)
                j--;
            a[j]++;
            if (j == m - 1) return true;
            for (int k = j + 1; k < m; k++)
                a[k] = a[j];
            return true;
        }
        static void Print(int[] main, int[] sec, int m)
        {
            
            for(int i = 0; i < m; i++)
            {
                Console.Write(main[sec[i]-1] + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int n = IntInput("N = ", 1);
            int m;
            
            do
            {
                m = IntInput("M = ");
                if (m > n)
                {
                    Console.WriteLine("N должно быть больше или равно M");
                }
            } while (m > n);
            int[] mainArray = new int[n];
            int[] secodnaryArray = new int[n];
            for(int i = 0; i < n; i++)
            {
                mainArray[i] = IntInput($"Ввод {i+1}-го элемента массива: ");
                secodnaryArray[i] = 1;
            }
            Array.Sort(mainArray);
            int num = 0;
            do
            {
                num++;
                Console.Write(num + ": ");
                Print(mainArray, secodnaryArray, m);
            } while (NextSet(secodnaryArray, n, m));

            Console.ReadKey();
            /*
             * 1 2 5 7
             * 
             * 1 1 1 
             * 1 1 2
             * 1 1 5
             * 1 1 7
             * 1 2 2
             * 1 2 5
             * 1 2 7
             * 1 5 5
             * 1 5 7
             * 2 2 2
             * 2 2 5
             * 2 2 7
             * 2 5 5
             * 2 5 7
             * 2 7 7
             * 5 5 5
             * 5 5 7
             * 5 7 7
             * 7 7 7
             */

        }
    }
}
