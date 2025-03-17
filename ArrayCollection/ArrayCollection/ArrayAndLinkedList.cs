using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class ArrayAndLinkedList
    {
        public static void Main(string[] args)
        {
            List<int> arrayList = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
                linkedList.AddLast(i);
            }

            long startTime=DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond;
            int elementAL = arrayList[500000];
            long endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationAL=endTime - startTime;

            long startTimeLL = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementLL = linkedList.ElementAt(500000);
            long endTimeLL = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationLL = endTimeLL - startTimeLL;

            Console.WriteLine("AL time: " + durationAL);
            Console.WriteLine("LL time: " + durationLL);
        }
    }
}
