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
            SumOfNaturalNumbers(10);
            Console.ReadLine();

           // PrintNumber(1);
           //Console.ReadLine();
        }

        private static void PrintNumber(int i)
        {
            if (i <= 5)
            {
                Console.WriteLine($"the i value is: {i}");
                PrintNumber(i+1);
            }
            return;
        }

        private static void SumOfNaturalNumbers(int n)
        {
            if(n==0)
            {
                return;
            }
            var result = (n * (n + 1)) / 2;
            Console.WriteLine(result);
            SumOfNaturalNumbers(n-1);
        }
    }
}
