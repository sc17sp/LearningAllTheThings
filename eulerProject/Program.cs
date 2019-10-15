using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int sum = test.fibonacciFormula(1, 2, 2);
            Console.WriteLine(sum);
        }

        public int fibonacciFormula(int first, int second, int sum)
        {
            int next = first + second;

            

            if (next > 89)
            {
                return sum;
            }

            if (next % 2 == 0)
            {
                sum = sum + next;

                sum = fibonacciFormula(second, next, sum);
            }
            else
            {
                sum = fibonacciFormula(second, next, sum);
            }

            return sum;
        }
    }
}
