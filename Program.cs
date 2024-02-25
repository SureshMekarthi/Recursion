using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumber(5);
           Console.ReadLine();
        }

        private static void PrintNumber(int i)
        {
            if (i > 0)
            {
                Console.WriteLine($"the i value is: {i}");
                PrintNumber(i-1);
            }
            return;
        }
    }
}
