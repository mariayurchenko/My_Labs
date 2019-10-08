using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_24
{
    class Program
    {
        static void DeleteStovpchuk()
        {

        }
        static void DeleteRadok()
        {

        }

        static int Dia()
        {
            int x;
            do
            {
                Console.Write("m = ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 || x > 2)
                    Console.WriteLine("Error(x < 0 || x > 2)!");
            } while (x < 0 || x > 2);

            return (x);
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
            Console.WriteLine("Vuberit diu(x):");
            Console.WriteLine("1 - delete k-stovpchuk");
            Console.WriteLine("2 - delete k-radok");
            Console.WriteLine("0 - exit");
            int x;
            do
            {
               
                x=Dia();
                switch (x)
                {
                    case "1":
                    {

                    }

                }
                if (x == 1)
                {
                    if(n==0)
                        Console.WriteLine("Pusto!");
                    else
                        DeleteStovpchuk();
                    n--;
                }

                if (x == 0)
                {
                    if (m == 0)
                        Console.WriteLine("Pusto!");
                    else
                        DeleteRadok();
                    m--;
                }

                if (x == 3)
                {

                }
            } while (x!=0);
        }
    }
}
