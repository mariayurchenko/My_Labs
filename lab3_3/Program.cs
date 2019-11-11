using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit koordunatu tochku:");
            int x;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            bool test = false;
            if ((x > 0 && y > 0) || (x < 0 && y < 0))
                test = true;
            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
