using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AreaCalculator:Circle
    {
        protected double area;

        public void CalculateArea() //set
        {
            area = Math.PI * radius * radius;
        }
        public double GetArea() { return area; } //get
    }
}
