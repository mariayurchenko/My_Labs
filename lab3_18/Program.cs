using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit koordunatu poliv chahmatnoi doski (1-8):");
            int x1;
            do
            {
                Console.Write("x1 = ");
                x1 = Convert.ToInt32(Console.ReadLine());
                if (x1 <= 0 || x1 > 8)
                    Console.WriteLine("Error!");
            } while (x1 <= 0 || x1 > 8);
            int y1;
            do
            {
                Console.Write("y1 = ");
                y1 = Convert.ToInt32(Console.ReadLine());
                if (y1 <= 0 || y1 > 8)
                    Console.WriteLine("Error!");
            } while (y1 <= 0 || y1 > 8);
            int x2;
            do
            {
                Console.Write("x2 = ");
                x2 = Convert.ToInt32(Console.ReadLine());
                if (x2 <= 0 || x2 > 8)
                    Console.WriteLine("Error!");
            } while (x2 <= 0 || x2 > 8);
            int y2;
            do
            {
                Console.Write("y2 = ");
                y2 = Convert.ToInt32(Console.ReadLine());
                if (y2 <= 0 || y2 > 8)
                    Console.WriteLine("Error!");
            } while (y2 <= 0 || y2 > 8);

            bool test = false;
            if (Math.Abs(x1 - x2)< 2 && Math.Abs(y1 - y2) < 2)
                test = true;
            Console.WriteLine(test);
            Console.ReadKey();

        }
    }
}
