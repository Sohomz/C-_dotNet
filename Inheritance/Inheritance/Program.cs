using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c=new Cylinder();
            c.SetRadius(6); //cylinder getting this from Circle.cs
            Console.WriteLine("Radius is: "+c.GetRadius());
            c.CalculateArea(); // from AreaCalculator.cs
            Console.WriteLine("Area of circle is: " + c.GetArea());
            c.SetHeight(10); //From Cylinder.cs
            c.CalculateVolume();
            Console.WriteLine("Volume is: "+c.GetVolume());
        }
    }
}
