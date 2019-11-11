using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit rozmir masuvy (m x n):");
            int n;
            int m;
            do
            {
                Console.Write("m = ");
                m = Convert.ToInt32(Console.ReadLine());
                if (m <= 0)
                    Console.WriteLine("Error(n<=0)!");
            } while (m <= 0);
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Error(n<=0)!");
            } while (n <= 0);
            int[,] array = new int[m,n];

          
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"array[{i+1},{j+1}] = ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int S = 0;
            int D=1;
            int k;
            Console.WriteLine("Vvedit k:");
            do
            {
                Console.Write("k = ");
                k = Convert.ToInt32(Console.ReadLine());
                if (k <= 0 || k > n)
                    Console.WriteLine("Error!");
            } while (k <= 0 || k>n);
            k = k - 1;
            for (int i = 0; i < m; i++)
            {
                S = S + array[i,k];
            }
            Console.WriteLine($"Suma = {S}");
            for (int i = 0; i < m; i++)
            {
                D = D * array[i, k];
            }
            Console.WriteLine($"Dobytok = {D}");
            Console.ReadKey();
        }
    }
}
