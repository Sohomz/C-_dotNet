using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int rA=calculator.Add(5, 3);
            Console.WriteLine("Add result: " + rA);
            int rS=calculator.Subtract(5, 3);
            Console.WriteLine("Substraction result: " + rS);

            TestAdd();
        }

        public static void TestAdd()
        {
            Calculator calculator = new Calculator();
            Calculator.Operation addDelegateSHM=calculator.Add;

            int result=addDelegateSHM(5,3);
            Console.WriteLine("Unit test-case result: "+ (result==8?"passed":"Failed"));
        }
    }
}
