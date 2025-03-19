using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SppechCompetetion
{
    class Program
    {
        static int participantCount = 0;
        static void EnterSpeechCompetition(object participantId)
        {
            Monitor.Enter(typeof(Program)); //LOCK for person to enterinto the competetion

            try
            {
                participantCount++;
                Console.WriteLine($"Participant {participantId} entered. " + "Total participants: " 
                    + participantCount);
            }
            finally
            {
                Monitor.Exit(typeof(Program)); // Release the Lock
            }

            Thread.Sleep(1000); // after 1 sec, everyone will leave the competetion

            Monitor.Enter(typeof(Program));// Another lock so that when one man is speaking,no other man comes

            try
            {
                participantCount--;
                Console.WriteLine($"Participant {participantId} finished. " + "Total participants: "
                    + participantCount);
            }
            finally
            {
                Monitor.Exit(typeof(Program)); // Release the Lock
            }
        }
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Thread t=new Thread(EnterSpeechCompetition);
                t.Start(i); // i = participantId object
            }
        }
    }
}
