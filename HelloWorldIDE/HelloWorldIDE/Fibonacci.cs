using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class Fibonacci
    {
        public static int FibonacciSeries(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciSeries(num - 1) + FibonacciSeries(num - 2);
            }
        }
        public static void PrintFibonacciSeries(int terms)
        {
            Console.WriteLine($"Fibonacci Series up to {terms} terms:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(FibonacciSeries(i) + " ");
            }
        }
    }
}
