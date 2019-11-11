using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_29
{
    
    class Program
    {
        static void Menshe()
        {

        }
        static void Bilshe()
        {

        }
        static void Rivna()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit rozmir masuvy:");
            int n;
         
            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Error(n<=0)!");
            } while (n <= 0);
  
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Vvedit k:");
            int k;
            Console.Write("k = ");
            k = Convert.ToInt32(Console.ReadLine());
            int x=A[0];
            int s=0;
            for (int i = 0; i < n; i++)
            {
                
                if (x == A[i])
                    s++;
                else
                {
                    if(k==s)

                    x = A[i];
                }



            }

        }
    }
}
