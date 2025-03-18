using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate double MathOperation(double x, double y); //Delegate or ticket book

        static double Addition(double a,double b)
        {
            return a + b;
        }
        static double Substraction (double a, double b)
        {
            return a - b;
        }
        static double Multiplication (double a,double b)
        {
            return a * b;
        }
        static double Division (double a, double b)
        {
            return a / b;
        }
        static double Operation (double a, double b,MathOperation operation)
        {
            return operation(a,b);
        }
        static void Main(string[] args)
        {
            double a = Operation(1, 4, Addition);
            Console.WriteLine(a);
        }
    }
}
