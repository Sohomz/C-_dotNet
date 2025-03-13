using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldIDE
{
    class MethodOverloading
    {
        public static int add(int a, int b)
        {
            return (a + b);
        }
        public static int add(int a, int b, int c)
        {
            return (a + b + c);
        }
        public static string add(string a, string b)
        {
            return (a + b);
        }
    }
}
