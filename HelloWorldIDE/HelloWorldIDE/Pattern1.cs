using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class Pattern1
    {
        public  static void pattern1(int lengthP)
        {
            for (int i=0;i<lengthP;i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
