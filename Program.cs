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

          var result = CalculateFac(3);
            Console.WriteLine(result);
            //PrintSum(1, 5, 0);
            Console.ReadLine();

            // PrintNumber(1);
            //Console.ReadLine();
        }

        private static void PrintNumber(int i)
        {
            if (i <= 5)
            {
                Console.WriteLine($"the i value is: {i}");
                PrintNumber(i + 1);
            }
            return;
        }

        private static void SumOfNaturalNumbers(int n)
        {
            if (n == 0)
            {
                return;
            }
            var result = (n * (n + 1)) / 2;
            Console.WriteLine(result);
            SumOfNaturalNumbers(n - 1);
        }

        private static void PrintSum(int i, int n, int sum)
        {
            if (i == n)
            {
                sum += i;
                Console.WriteLine(sum);
                return;
            }
            sum += i;
            PrintSum(i + 1, n, sum);
        }

        private static int CalculateFac(int n)
        {
              if(n==1||n==0)
            {
                return 1;
            }
            var facn1 = CalculateFac(n - 1);
            var facN = n * facn1;
            return facN;
        }
    }
}
