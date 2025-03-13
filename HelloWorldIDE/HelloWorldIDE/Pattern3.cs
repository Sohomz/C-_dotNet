using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class Pattern3
    {
        public static void pattern3(int lengthP)
        {
            for (int i = 0; i < lengthP; i++)
            {

                for (int j = 0; j < lengthP - i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2*i+1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
