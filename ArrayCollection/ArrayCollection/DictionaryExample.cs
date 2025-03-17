using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class DictionaryExample
    {
        public static void Main (string[] args)
        {
            Dictionary <int,string> myDict = new Dictionary<int,string> ();
            myDict.Add(1, "Sohom");
            myDict.Add(2, "John");
            Console.WriteLine (myDict);
            Console.WriteLine(myDict[1]);
            Console.WriteLine(myDict.ContainsKey(1));
            Console.WriteLine(myDict.ContainsValue("John"));
        }
    }
}
