using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1D array
            //int[] arr1D = new int[5];
            int[] arr1D_1 = {45,77,343,-99,56,0,11,6};
            int min = 999;
            int max = -999;

            Console.Write("1D array is:");
            foreach(int i in arr1D_1)
            {
                Console.Write(i); 
                Console.Write(", ");
                if(i < min)
                {
                    min = i;
                }
                if(i > max) { max = i; }
            }
            Console.WriteLine($"\nMin value is: {min}\nMax value is: {max}");
            Console.WriteLine("\nRreverse Array is:");
            int[] rArr = reverseArray(arr1D_1);
            foreach (int j in rArr)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine("\n");

        }

        public static int[] reverseArray(int[] arr)
        {
            int[] temp = new int[arr.Length];
            Array.Copy(arr,temp,arr.Length);
            Array.Reverse(temp);
            return temp;
        }
    }
}
