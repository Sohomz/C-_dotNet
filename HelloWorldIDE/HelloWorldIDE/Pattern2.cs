using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class Pattern2
    {
        public static void pattern2(int lengthP)
        {
            for (int i = 0; i < lengthP; i++)
            {
                for (int j = 0; j < lengthP - i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
