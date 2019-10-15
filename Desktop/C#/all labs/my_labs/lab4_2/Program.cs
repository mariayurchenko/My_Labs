using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit rozmir masuvy:");
            int n;
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n<=0)
                    Console.WriteLine("Error(n<=0)!");
            }while (n <= 0) ;
            int []A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            int test = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]+" ");
                i++;
                if (i +1>= n && test != 1)
                {
                    i = 0;
                    test = 1;
                }
            }
            Console.WriteLine();
            test = 0;

            for (int i = 1; i < n; i++)
            {
                Console.Write(A[i] + " ");
                i++;
                if (i + 1 >= n && test != 1)
                {
                    i = -1;
                    test = 1;
                }
            }

            Console.ReadKey();

        }
    }
}
