using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStructureLearn
{
    class Computer
    {
        public Computer()
        {
            Console.WriteLine("Computer constructor is called");
        }
        private string _color;
        public string Color
        {
            set{
                if (!string.IsNullOrEmpty(value)) 
                {
                    _color = value;
                }
                else 
                {
                    Console.WriteLine("Color cant be null or empty");
                }
            }
            get { return _color; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"color: {Color}");
        }

        public void startUp()
        {
            Console.WriteLine("Computer is powering up");
        }
    }
}
