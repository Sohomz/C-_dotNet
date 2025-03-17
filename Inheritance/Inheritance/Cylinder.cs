using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cylinder:AreaCalculator
    {
        protected double height;
        protected double volume;

        public void SetHeight(double h) //set
        {
            height = h;
        }
        public double GetHeight() //get
        {
            return height;
        }
        public void CalculateVolume() //set
        {
            volume = area * height;
        }
        public double GetVolume() //get
        {
            return volume;
        }
    }
}
