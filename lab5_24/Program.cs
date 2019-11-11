using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab5_24
{
    class Program
    {
        static void DeleteStovpchuk( int [,]A,int k,int m,int n)
        {
            k--;     
            
            for (int j = k; j < n; j++)
            for (int i = 0; i < m; i++)
                    A[i, j] = A[i, j + 1];
            for (int i = 0; i < m; i++)
                A[i, n] = 0;
        }
        static void DeleteRadok(int[,] A, int k, int m, int n)
        {
            k--;
            for (int i = k; i < m; i++)
            for (int j = 0; j < n; j++)
                A[i, j] = A[i + 1, j];
            for (int j = 0; j < n; j++)
                A[m, j] = 0;

        }

        static int Nomer(int x)
        {
            int k;
            do
            {
                Console.Write("k = ");
                k = Convert.ToInt32(Console.ReadLine());
                if (k < 1 || k > x)
                    Console.WriteLine($"Error (k < 1 || k > {x})!");
            } while (k < 1 || k > x);
             
            return k;
        }

        static void Print(int[,] A, int m, int n)
        {
            Console.WriteLine("Masuv:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{A[i, j]} ");
                Console.WriteLine();
            }
        }

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
            int[,] array = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"array[{i + 1},{j + 1}] = ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Print(array, m, n);
            Console.WriteLine("Vuberit diu:");
            Console.WriteLine("S - delete k-stovpchuk");
            Console.WriteLine("R - delete k-radok");
            Console.WriteLine("E - exit");
            string x;
            int k;
            int test = 0;
            do
            {
                Console.Write("dia - ");
                x = Console.ReadLine();
                switch (x)
                {
                    case "R":
                        if (m == 0 || n==0)
                        {
                            Console.WriteLine("Masuv pustui!");
                            test = 1;
                        }
                        k = Nomer(m);
                        m--;
                        DeleteRadok(array,k,m,n);
                        if (n > 0 || m > 0)
                            Print(array, m, n);
                        else
                        {
                            Console.WriteLine("<NULL>");
                        }
                        break;
                    
                    case "S":
                        if (n == 0 || m==0)
                        {
                            Console.WriteLine("Masuv pustui!");
                            test = 1;
                            break;
                        }
                        k = Nomer(n);
                        n--;
                        DeleteStovpchuk(array, k, m, n);
                        if (n == 0 || m == 0)
                            Console.WriteLine("<NULL>");
                        else
                            Print(array, m, n);
                        break;

                    case "E":
                        Console.WriteLine("The End!");
                        test = 1;
                        break;
                    default:
                        Console.WriteLine("Vu natusnylu ne virny bykvy!");
                        break;

                }
             
            } while (test!=1);

            Console.ReadKey();
        }
    }
}
