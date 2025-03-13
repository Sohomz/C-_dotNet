using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class TryCatch
    {
        public static double TryCatchMethod(int n, int d)
        {
            double result = 0.0;
            try
            {
                result = n / d;
                return result;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Denominator cant be 0");
                return result;
            }
        }
    }
}
