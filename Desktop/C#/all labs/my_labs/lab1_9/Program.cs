using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the distanse that the sprinter ran for a certain time, if it moves with known acceleration.");
            Console.WriteLine("Please enter sprinter details (T - time in second, V - speed m/s , A - acceleration):");
            Console.Write("T = ");
            int T = Convert.ToInt32(Console.ReadLine());
            Console.Write("V = ");
            double V = Convert.ToDouble(Console.ReadLine());
            Console.Write("A = ");
            double A = Convert.ToDouble(Console.ReadLine());
            double S = A * T * T / 2 + V * T;
            Console.WriteLine($"Distanse: {S} meters");
            Console.ReadKey();
 
        }
    }
}
