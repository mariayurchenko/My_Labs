using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_12
{
    class Program
    {
     static bool IsPrime(int x)
     {
         if (x == 1)
             return false;
            int d = 2;
            while (x % d != 0)
                d ++;
            if (d == x)
                return true;
            else
                return false;
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
            Console.WriteLine("Vvedit elementu:");
            int x;
            List<int> A = new List<int>(n);
            for (int element =1;element<=n;element++ ) 
            {
                Console.Write($"A[{element}] = ");
                x = Convert.ToInt32(Console.ReadLine());
                A.Add(x);
            }   
            int S = 0;
            bool test;
            foreach (int element in A)
            {
                test =IsPrime(element);
                if (test == true )
                {
                    S = S + element;
                }
                
            }
            Console.WriteLine($"Suma prostuh: {S}");
            int parni = 0;
            foreach (int element in A)
            {
                
                if (element%2==0)
                {
                    parni = parni + element;
                }

            }
            parni = Math.Abs(S-parni);
            Console.WriteLine($"Riznutha prostuh i parnuh: {parni}");
            S = 0;
            foreach (int element in A)
            {
                
                S = S + element;
            }
            S = S / n;
            Console.WriteLine($"Serene arufmetuchne: {S}");
            Console.ReadKey();
        }
    }
}
