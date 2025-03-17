using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStructureLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            //Console.WriteLine(computer);
            //computer.startUp();
            computer.Color = "Crimson White";
            computer.DisplayInfo();
        }
    }
}
