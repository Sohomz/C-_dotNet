using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class CheckPosition
    {
        public static int PositionMethod(int number)
        {
            if (number < 50)
            {
                return 0;
            }
            else if (number>=50 && number < 60)
            {
                return 5;
            }
            else if (number >= 60 && number < 70)
            {
                return 4;
            }
            else if (number >= 70 && number < 80)
            {
                return 3;
            }
            else if (number >= 80 && number < 90)
            {
                return 2;
            }
            else if (number >= 90 && number < 100)
            {
                return 1;
            }
            else
            {
                return - 1;
            }
        }
    }
}
