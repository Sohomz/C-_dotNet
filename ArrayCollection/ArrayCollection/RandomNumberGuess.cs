using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class RandomNumberGuess
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game!!");
            Random r = new Random();
            int rNum = r.Next(1, 101);

            Queue<int> q = new Queue<int>();

            while (true)
            {
                Console.Write("Guess a number b/w 1 to 100: ");
                int input = int.Parse(Console.ReadLine());

                if (input == rNum)
                {
                    Console.WriteLine("You guessed correct number: "+input);
                    q.Enqueue(input);
                    break;
                }
                else
                {
                    q.Enqueue(input);
                    checkNum(input,rNum);
                }
            }
            Console.Write("Your choices were: ");
            foreach (int item in q) { 
                Console.Write(item+" ");
            }
        }

        public static void checkNum(int inputNum, int rNum) { 
            int diff=inputNum - rNum;
            if(diff>0)
            {
                Console.WriteLine("You choosed greater than random number");
                if (diff < 10)
                {
                    Console.WriteLine("Very close, less than 10 diff");
                }
                else if (diff < 20)
                {
                    Console.WriteLine("Close, less than 20 diff");
                }
                else
                {
                    Console.WriteLine("Far, greater than 30 diff");
                }
            }
            else
            {
                Console.WriteLine("You choosed Lesser than random number");
                if (Math.Abs(diff) < 10)
                {
                    Console.WriteLine("Very close, less than 10 diff");
                }
                else if (Math.Abs(diff) < 20)
                {
                    Console.WriteLine("Close, less than 20 diff");
                }
                else
                {
                    Console.WriteLine("Far, greater than 30 diff");
                }
            }
        }
    }
}
