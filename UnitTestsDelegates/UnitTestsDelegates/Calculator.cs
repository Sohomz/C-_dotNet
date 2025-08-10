using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsDelegates
{
    class Calculator
    {
        public delegate int Operation (int x, int y);
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y) { return x - y; }
    }
}
