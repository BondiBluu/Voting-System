using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yesCounter = 0;
            int noCounter = 0;

            Console.WriteLine("Welcome to the voting system- Vote yes (y) or no (n).");
            string vote = Console.ReadLine();

            if(vote == "y")
            {
                yesCounter++;
            }
            else if (vote == "n")
            {
                noCounter++;
            }
            else
            {
                Console.WriteLine("Invalid vote.");
            }

            Console.WriteLine();

            Console.WriteLine("The results are in: ");
            Console.WriteLine("Yes: " + yesCounter);
            Console.WriteLine("No: " + noCounter);

            Console.WriteLine();

            VotingResults(yesCounter, noCounter);

            Console.ReadLine();
        }

        static void VotingResults(int yesCounter, int noCounter)
        {
            int total = yesCounter + noCounter;
            int yesPercent = yesCounter / total * 100;
            int noPercent = noCounter / total * 100;

            Console.WriteLine("Yes: " + yesPercent + "%");
            Console.WriteLine("No: " + noPercent + "%");

            if (yesCounter > noCounter)
            {
                Console.WriteLine("The majority voted yes.");
            }
            else if (yesCounter < noCounter)
            {
                Console.WriteLine("The majority voted no.");
            }
            else
            {
                Console.WriteLine("Draw.");
            }
        }
    }
}
